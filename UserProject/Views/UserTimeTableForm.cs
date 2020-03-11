using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class UserTimeTableForm : Form, IUserTimeTableView
    {
        private UserTimeTablePresenter presenter;
        public UserTimeTableForm()
        {
            InitializeComponent();
            presenter = new UserTimeTablePresenter(this);
        }

        public List<time_table> userTimeTableList { 
            set => dataGridView1.DataSource = value;        
        }
        
        private void UserTimeTable_Load(object sender, EventArgs e)
        {
            presenter.GetUserTimeTable();
            workTimeCalc();
        }

        private void workTimeCalc() 
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[3].Value)
                {
                    item.Cells[5].Value = "Fizetett szabadság";
                }
                if ((bool)item.Cells[4].Value)
                {
                    item.Cells[5].Value = "Beteg szabadság";
                }

                if (!(bool)item.Cells[3].Value && !(bool)item.Cells[4].Value)
                {
                    DateTime start = (DateTime)item.Cells[1].Value;
                    DateTime end = (DateTime)item.Cells[2].Value;
                    TimeSpan time = end - start;                    
                    item.Cells[5].Value = time.ToString(@"hh");
                   
                }

                
            }
        }
    }
}
