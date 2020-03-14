using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Repositories;
using UserProject.ViewInterfaces;

namespace UserProject.Presenters
{
    class GlobalTimeTablePresenter
    {
        IGlobalTimeTableView view;

        private static userProjectDBContext db = new userProjectDBContext();
        TimeTableRepository repoTimeTable = new TimeTableRepository(db);
        PositionsRepository repoPositions = new PositionsRepository();

        DateTime selectedDate = new DateTime(2020, 03, 02);


        public GlobalTimeTablePresenter(IGlobalTimeTableView param)
        {
            view = param;
        }


        public void GetGlobalTimeTable()
        {
            int selectedYear = selectedDate.Year;
            int selectedMonth = selectedDate.Month;
            DataTable dt = new DataTable();
            int lastDayOfMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

            //Oszlopok kialakítása
            dt.Columns.Add(new DataColumn(("Név"), typeof(string)));
            for (int i = 1; i <= lastDayOfMonth; i++)
            {
                dt.Columns.Add(new DataColumn(("" + i), typeof(string)));
            }
            dt.Columns.Add(new DataColumn(("Id"), typeof(int)));


            BindingList<position> posList = repoPositions.getAllPositions();

            //Sorok kialakítása
            foreach (var positionItem in posList)
            {
                dt.Rows.Add(positionItem.position_name);
                foreach (var item in positionItem.user_data)
                {
                    //Első oszlopban név kiíratása
                    dt.Rows.Add(item.personal_data.first_name + " " + item.personal_data.last_name);
                    //Utolsó oszlopba Névhez tartozó user_data ID kiíratása
                    dt.Rows[dt.Rows.Count - 1][dt.Columns.Count - 1] = item.id;
                    //Adott userhez tartozó beosztás lekérés (kiválasztott időszakra)
                    List<time_table> userTimeTable = new List<time_table>();
                    userTimeTable = item.time_table.Where(x => x.start_date.Year == selectedYear && x.start_date.Month == selectedMonth).ToList();
                    //Ha van a kiválasztott időszakra beosztása a neki létrehozott sorba kiíratás
                    if (userTimeTable.Count > 0)
                    {
                        //Oszlop index megfelel dátumnak(nap) (1 es oszlop indexbe kell hogy kerüljön elseje...)
                        for (int i = 1; i <= dt.Columns.Count - 2; i++)
                        {
                            string cell = "";
                            if (userTimeTable.Any(x => x.start_date.Day == i))
                            {
                                time_table dayTime = userTimeTable.SingleOrDefault(x => x.start_date.Day == i);
                                if ((bool)dayTime.paid_leave)
                                {
                                    cell = "FSZ";
                                }
                                else if ((bool)dayTime.sick_leave)
                                {
                                    cell = "B";
                                }
                                else
                                {
                                    int startTime = dayTime.start_date.Hour;
                                    DateTime stopTime = (DateTime)dayTime.end_date;
                                    cell = startTime + "-" + stopTime.Hour;
                                }
                                
                            }

                            dt.Rows[dt.Rows.Count - 1][i] = cell;
                        }
                    }

                }
            }
            view.globalTimeTable = dt;
        }

        public void Save()
        {
            List<time_table> kiolvasottTimeTableElemek = new List<time_table>();
            List<time_table> torolniTimeTableElemek = new List<time_table>();

            int selectedYear = selectedDate.Year;
            int selectedMonth = selectedDate.Month;

            foreach (DataRow row in view.globalTimeTable.Rows)
            {

                if (!string.IsNullOrEmpty(row.ItemArray[view.globalTimeTable.Columns.Count - 1].ToString()))
                {
                    for (int i = 1; i < row.ItemArray.Length - 1; i++)
                    {
                        int userId = (int)row.ItemArray[view.globalTimeTable.Columns.Count - 1];
                        string cellValue = row.ItemArray[i].ToString();
                        int selectedDay = i;
                        DateTime startDate = new DateTime(selectedYear, selectedMonth, selectedDay);
                        DateTime endDate = startDate;
                        bool betegSzabi = false;
                        bool fizetettSzabi = false;

                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            switch (cellValue)
                            {
                                case "B":
                                    betegSzabi = true;
                                    break;
                                case "FSZ":
                                    fizetettSzabi = true;
                                    break;
                                default:
                                    if (cellValue.Contains('-'))
                                    {
                                        string[] kezdVeg = cellValue.Split('-');
                                        int startH = Convert.ToInt32(kezdVeg[0]);
                                        int endH = Convert.ToInt32(kezdVeg[1]);
                                        if (endH < startH)
                                        {
                                            endDate = endDate.AddDays(1);
                                        }
                                        TimeSpan startTime = new TimeSpan(startH, 0, 0);
                                        TimeSpan endTime = new TimeSpan(endH, 0, 0);
                                        startDate = startDate.Date + startTime;
                                        endDate = endDate.Date + endTime;
                                    }
                                    break;

                            }
                            kiolvasottTimeTableElemek.Add(new time_table(userId, startDate, endDate, fizetettSzabi, betegSzabi, DateTime.Now));
                        }
                        else
                        {
                            torolniTimeTableElemek.Add(new time_table(userId, startDate, endDate, fizetettSzabi, betegSzabi, DateTime.Now));
                        }
                    }
                }
            }
            foreach (time_table item in kiolvasottTimeTableElemek)
            {                
                if (repoTimeTable.Exists(item))
                {
                    try
                    {
                        repoTimeTable.Update(item);                        
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        repoTimeTable.Insert(item);
                        Debug.Write("insert");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }

                Debug.WriteLine(" - "+item.user_id + ": " + item.start_date + " - " + item.end_date);
                repoTimeTable.Save();
            }

            foreach (time_table item in torolniTimeTableElemek)
            {
                if (repoTimeTable.Exists(item))
                {
                    repoTimeTable.Delete(item);
                    Debug.WriteLine("törölve");
                }
                repoTimeTable.Save();
            }
            
        }


    }
}
