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
using UserProject.Models;
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
            customizeDGV();
            
        }

        private void customizeDGV()
        {
            SetDoubleBuffered(dataGridView1, true);
            //Oszlopszélesség
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 35;
            }
            //Sor szín
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                
                if (row.Cells[dataGridView1.Columns.Count-1].Value.ToString()=="")
                {                    
                    row.DefaultCellStyle.BackColor = Color.Coral;
                }
            }
            //Rendezés tiltása
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                
    }
}
