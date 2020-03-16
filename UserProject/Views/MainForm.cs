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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "User Project - "+ CurrentUser.user.user_name;
                                                  
        }
        private void OpenFormInPanel(Form param)         
        {
            panel1.Controls.Clear();
            param.TopLevel = false;
            param.AutoScroll = true;
            param.FormBorderStyle = FormBorderStyle.None;
            param.Dock = DockStyle.Fill;
            panel1.Controls.Add(param);            
            param.Show();
        }
        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            //Form userInfoForm = new UsersInfoForm();
            //userInfoForm.ShowDialog();
            Form userInfoForm = new UsersInfoForm();
            OpenFormInPanel(userInfoForm);
            
        }

        private void buttonUserTimeTable_Click(object sender, EventArgs e)
        {
            Form userTimeTableForm = new UserTimeTableForm();
            //userTimeTableForm.ShowDialog();
            OpenFormInPanel(userTimeTableForm);
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Form PositionsForm = new PositionsForm();
            //PositionsForm.ShowDialog();
            OpenFormInPanel(PositionsForm);
        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            Form UserDetailsListForm = new UserDetailsListForm();
            //UserListForm.ShowDialog();
            OpenFormInPanel(UserDetailsListForm);
        }

        private void buttonGlobalTimeTable_Click(object sender, EventArgs e)
        {
            Form GlobalTimeTable = new GlobalTimeTableForm();
            GlobalTimeTable.ShowDialog();
            //OpenFormInPanel(GlobalTimeTable);
        }
    }
}
