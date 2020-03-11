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
    public partial class GlobalTimeTableForm : Form, IGlobalTimeTableView
    {
        private GlobalTimeTablePresenter presenter;
        public GlobalTimeTableForm()
        {
            InitializeComponent();
            presenter = new GlobalTimeTablePresenter(this);
        }

        public BindingList<user_data> userDataBindingList
        {
            get => (BindingList<user_data>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        private void GlobalTimeTableForm_Load(object sender, EventArgs e)
        {
            userProjectDBContext db = new userProjectDBContext();

            //dataGridView1.DataSource = db.user_data.;
        }
    }

}



