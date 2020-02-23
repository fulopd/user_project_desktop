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

        public List<time_table> userTimeTableList { set => dataGridView1.DataSource = value; }

        private void UserTimeTable_Load(object sender, EventArgs e)
        {
            presenter.getUserTimeTable();
        }
    }
}
