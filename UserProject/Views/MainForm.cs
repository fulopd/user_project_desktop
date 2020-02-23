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
            using (userProjectDBContext db = new userProjectDBContext())
            {
                label1.Text = db.user_data.First().user_name;
                label2.Text = CurrentUser.user.position.permission_ids;
                
            }
        }
    }
}
