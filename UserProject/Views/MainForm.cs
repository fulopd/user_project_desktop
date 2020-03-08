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
            label1.Text = CurrentUser.user.user_name;
            label2.Text = CurrentUser.user.position.permission_ids;                            
        }

        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            Form userInfoForm = new UserInfoForm();
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
    }
}
