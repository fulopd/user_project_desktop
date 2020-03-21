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
            this.Text = "User Project - " + CurrentUser.user.user_name;
            buttonUserList.PerformClick();
            backgroundWorker1.RunWorkerAsync();

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

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Form PositionsForm = new PositionsForm();
            OpenFormInPanel(PositionsForm);
        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            Form UserDetailsListForm = new UserDetailsListForm();
            OpenFormInPanel(UserDetailsListForm);
        }

        private void buttonGlobalTimeTable_Click(object sender, EventArgs e)
        {
            Form GlobalTimeTable = new GlobalTimeTableForm();
            GlobalTimeTable.ShowDialog();
        }

        #region Header move mouse
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool connect = true;
            using (userProjectDBContext db = new userProjectDBContext())
            {
                while (connect)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (!db.Database.Exists())
                    {
                        connect = false;
                    }                    
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var LoginForm = new LoginForm();
            MessageBox.Show("Kapcsolat nem elérhető!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Hide();            
            LoginForm.ShowDialog();           
            Close();
        }
    }
}
