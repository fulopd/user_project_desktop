using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Models;
using UserProject.Presenters;
using UserProject.ViewInterfaces;

namespace UserProject.Views
{
    public partial class GlobalTimeTableForm : Form, IGlobalTimeTableView
    {
        GlobalTimeTablePresenter presenter;
        private userProjectDBContext db = new userProjectDBContext();

        public GlobalTimeTableForm()
        {
            InitializeComponent();
            presenter = new GlobalTimeTablePresenter(this);
        }

        public List<user_data> userDataList {
            get => (List<user_data>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        DateTime selectedDate = new DateTime(2020, 02, 02);
        int selectedYear;
        int selectedMonth;
        List<time_table> timeList = new List<time_table>();
        private void GetSelectedMonthTimeTable() 
        {
            timeList = db.time_table.Where(x => x.start_date.Year == selectedYear && x.start_date.Month == selectedMonth).ToList();
        }
        
        private void GlobalTimeTableForm_Load(object sender, EventArgs e)
        {
            selectedYear = selectedDate.Year;
            selectedMonth = selectedDate.Month;
            GetSelectedMonthTimeTable();
            DataTable dt = new DataTable();
            int lastDayOfMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

            dt.Columns.Add(new DataColumn(("Név"), typeof(string)));
            for (int i = 1; i <= lastDayOfMonth; i++)
            {
                dt.Columns.Add(new DataColumn((""+i), typeof(string)));
            }
            dt.Columns.Add(new DataColumn(("Id"), typeof(int)));

            using (userProjectDBContext db = new userProjectDBContext())
            {                
                List<position> posList = new List<position>();
                foreach (var positionItem in db.position)
                {
                    posList.Add(positionItem);                  

                }

                foreach (var positionItem in posList)
                {
                    dt.Rows.Add(positionItem.position_name).CancelEdit();
                    foreach (var item in positionItem.user_data)
                    {
                        dt.Rows.Add(item.personal_data.first_name + " " + item.personal_data.last_name);
                        dt.Rows[dt.Rows.Count-1][dt.Columns.Count-1] = item.id;
                        List<time_table> userTimeTable = new List<time_table>();
                        userTimeTable = item.time_table.Where(x => x.start_date.Year == selectedYear && x.start_date.Month == selectedMonth).ToList();
                        if (userTimeTable.Count > 0)
                        {
                            for (int i = 1; i <= dt.Columns.Count - 2; i++)
                            {
                                string cell = "";
                                if (userTimeTable.Any(x => x.start_date.Day == i))
                                {
                                    time_table dayTime= userTimeTable.SingleOrDefault(x => x.start_date.Day == i);
                                    int startTime = dayTime.start_date.Hour;
                                    DateTime stopTime = (DateTime)dayTime.end_date;
                                    cell = startTime + "-" + stopTime.Hour;
                                }
                               
                                dt.Rows[dt.Rows.Count - 1][i] = cell;
                            }
                        }

                    }
                }
            }          


            dataGridView1.DataSource = dt;
        }


        DataTable dtFromGrid = new DataTable();
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            
            dtFromGrid = (dataGridView1.DataSource as DataTable).Copy();
            dataGridView2.DataSource = dtFromGrid;
            saveDataToDBFromDataTable();



        }
       
        private void saveDataToDBFromDataTable() 
        {
            List<time_table> kiolvasottTimeTableElemek = new List<time_table>();
            
           
            foreach (DataRow row in dtFromGrid.Rows)
            {

                if (!string.IsNullOrEmpty(row.ItemArray[dtFromGrid.Columns.Count-1].ToString()))
                {
                    for (int i = 1; i < row.ItemArray.Length-1; i++)
                    {
                        int userId = (int)row.ItemArray[dtFromGrid.Columns.Count - 1];
                        string cellValue = row.ItemArray[i].ToString();

                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            string returnValue = "";                            
                            int selectedDay = i;
                            DateTime startDate = new DateTime(selectedYear, selectedMonth, selectedDay);
                            DateTime endDate = startDate;
                            bool betegSzabi = false;
                            bool fizetettSzabi = false;

                            switch (cellValue)
                            {
                                case "B":
                                    returnValue = "beteg szabi";
                                    betegSzabi = true;                                    
                                    break;
                                case "FSZ":
                                    returnValue = "fizetett szabi";
                                    fizetettSzabi = true;
                                    break;
                                default:
                                    returnValue = row.ItemArray[i].ToString();
                                    if (cellValue.Contains('-'))
                                    {
                                        string[] kezdVeg = cellValue.Split('-');
                                        int startH = Convert.ToInt32(kezdVeg[0]);
                                        int endH = Convert.ToInt32(kezdVeg[1]);
                                        if (endH<startH)
                                        {
                                            endDate = endDate.AddDays(1);
                                        }
                                        TimeSpan startTime = new TimeSpan(startH,0,0);
                                        TimeSpan endTime = new TimeSpan(endH, 0, 0);
                                        startDate = startDate.Date + startTime;
                                        endDate = endDate.Date + endTime;
                                    }

                                    break;

                            }

                            kiolvasottTimeTableElemek.Add(new time_table(userId,startDate,endDate,fizetettSzabi,betegSzabi));

                            // Debug.WriteLine(userId + " " + startDate + " " + cellValue);
                            //Debug.WriteLine(userId + " " + startDate + " " + endDate +" "+ returnValue);
                        }
                    } 
                }
            }
            foreach (time_table item in kiolvasottTimeTableElemek)
            {
                Debug.WriteLine(item.user_id + ": " + item.start_date + " - " + item.end_date);
            }
        }
    }
}
