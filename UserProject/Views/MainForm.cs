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
using UserProject.Services;

namespace UserProject.Views
{
    public partial class MainForm : Form
    {
        //<package id="EntityFramework" version="6.4.0" targetFramework="net452" />
        //<package id = "EntityFramework" version="6.1.3" targetFramework="net452" />
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "User Project - "+ CurrentUser.user.user_name;
                                                  
        }

        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            Form userInfoForm = new UsersInfoForm();
            userInfoForm.ShowDialog();
        }

        private void buttonUserTimeTable_Click(object sender, EventArgs e)
        {
            Form userTimeTableForm = new UserTimeTableForm();
            userTimeTableForm.ShowDialog();
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Form PositionsForm = new PositionsForm();
            PositionsForm.ShowDialog();
        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            Form UserListForm = new UserListForm();
            UserListForm.ShowDialog();
        }

        private void buttonGlobalTimeTable_Click(object sender, EventArgs e)
        {
            Form GlobalTimeTable = new GlobalTimeTableForm();
            GlobalTimeTable.ShowDialog();
        }
    }
}
