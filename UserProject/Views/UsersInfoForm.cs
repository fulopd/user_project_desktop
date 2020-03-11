using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Presenters;
using UserProject.ViewInterfaces;

namespace UserProject.Views
{
    public partial class UsersInfoForm : Form, IUserInfoView
    {
        private UserInfoPresenter presenter;

        public UsersInfoForm()
        {
            InitializeComponent();
            presenter = new UserInfoPresenter(this);
        }

        public string firstName { set => labelFullName.Text = value; }
        public string lastName { set => labelFullName.Text += " " + value; }
        public string motherName { set => labelMother.Text = value; }
        public DateTime birthDate { set => labelBirthDate.Text = "" + value; }
        public string location { set => labelLocation.Text = value; }
        public string email { set => labelEmail.Text = value; }
        public string phone { set => labelPhone.Text = value; }
        public string userName { set => labelUserName.Text = value; }
        public string position { set => labelPosition.Text = value; }
        public DateTime firstWorkDay { set => labelFirstWorkDay.Text = "" + value; }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            presenter.GetUserData();
        }
    }
}
