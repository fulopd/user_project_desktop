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
    public partial class PositionAddForm : Form, IPositionAddView
    {
        PositionAddPresenter presenter;

        public PositionAddForm()
        {
            InitializeComponent();
            presenter = new PositionAddPresenter(this);
        }

        public position newPosition { 
            get 
            {
                var newPos = new position(textBox1.Text);
                return newPos;
            } 
        }
        public string errorMessage 
        {
            get => errorProvider1.GetError(textBox1);
            set => errorProvider1.SetError(textBox1, value);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            presenter.ErroCheck(this.newPosition);
            if (string.IsNullOrEmpty(errorMessage))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
