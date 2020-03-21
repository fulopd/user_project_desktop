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
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        public string userName { get => textBoxUserName.Text; }
        public string password { get => textBoxPassword.Text; }
        public string errorMessage { set => errorProvider.SetError(buttonLogin, value); }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter.Authenticate();
            if (presenter.loginSucces)
            {
                var mf = new MainForm();
                Hide();
                mf.ShowDialog();
                Close();

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            presenter.CheckConnection();

        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
