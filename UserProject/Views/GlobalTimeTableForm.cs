using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Presenters;
using UserProject.ViewInterfaces;

namespace UserProject.Views
{
    public partial class GlobalTimeTableForm : Form, IGlobalTimeTableView
    {
        GlobalTimeTablePresenter presenter;

        public GlobalTimeTableForm()
        {
            InitializeComponent();
            presenter = new GlobalTimeTablePresenter(this);
        }


        public DataTable globalTimeTable
        {
            get => (dataGridView1.DataSource as DataTable).Copy();
            set => dataGridView1.DataSource = value;
        }

        private void GlobalTimeTableForm_Load(object sender, EventArgs e)
        {
            presenter.GetGlobalTimeTable();
            CustomizeDGV();
        }

        private void CustomizeDGV()
        {
            SetDoubleBuffered(dataGridView1, true);
            dataGridView1.GridColor = Color.FromArgb(222, 226, 230);
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //Oszlopszélesség
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 35;
            }
            //Sor szín
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[dataGridView1.Columns.Count - 1].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 238, 186);
                }
            }

            //Rendezés tiltása oszlop fejlécre kattintásnál
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                //oszlop szín (hétvége)
                int day;
                if (int.TryParse(column.HeaderText, out day))
                {
                    DateTime temp = new DateTime(2020, 02, day);
                    if (temp.ToString("ddd") == "Szo" || temp.ToString("ddd") == "V")
                    {
                        column.DefaultCellStyle.BackColor = Color.FromArgb(190, 229, 235);
                    }
                }



            }

        }
        private void SetDoubleBuffered(DataGridView dataGridView, bool p)
        {
            Type dgvType = dataGridView.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView, p, null);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
        
        //Cella érték validálás
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            cellValue = cellValue.ToUpper();
            switch (cellValue.Length)
            {
                case 1:
                    if (cellValue != "B")
                    {
                        cellValue = string.Empty;
                    }
                    break;
                case 3:
                    if (cellValue != "FSZ")
                    {
                        cellValue = string.Empty;
                    }
                    break;
                case 4:
                case 5:
                    if (cellValue.Contains('-') && !cellValue.Contains(' '))
                    {
                        string[] data = cellValue.Split('-');
                        if (data.Length == 2)
                        {
                            int numOne;
                            int numTwo;
                            if (int.TryParse(data[0], out numOne) && int.TryParse(data[1], out numTwo))
                            {
                                if (!(numOne >= 0 && numOne < 24 && numTwo >= 0 && numTwo < 24))
                                {
                                    cellValue = string.Empty;
                                }
                            }
                            else
                            {
                                cellValue = string.Empty;
                            }
                        }
                        else
                        {
                            cellValue = string.Empty;
                        }
                    }
                    else
                    {
                        cellValue = string.Empty;
                    }
                    break;                
                default:
                    cellValue = string.Empty;
                    break;
            }

            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellValue;
            Debug.WriteLine(cellValue);
        }
    }
}
