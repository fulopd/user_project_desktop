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
    public partial class UserForm : Form, IUserView
    {
        private int personalId;
        private int userId;
        private UserPresenter presenter;
        public UserForm()
        {
            InitializeComponent();
            presenter = new UserPresenter(this);
            presenter.LoadData();
        }

        //https://github.com/borosbence/JarmuKolcsonzo/blob/master/JarmuKolcsonzo/Views/JarmuForm.cs
        public personal_data personal
        {
            get
            {
                var personal_data = new personal_data(
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxMother.Text,
                    dateTimePickerBirthDate.Value,
                    textBoxLocation.Text,
                    textBoxEmail.Text,
                    textBoxPhone.Text,
                    textBoxPicture.Text
                    );
                if (personalId > 0)
                {
                    personal_data.id = personalId;
                }
                return personal_data;
            }
            set
            {
                personalId = value.id;
                textBoxFirstName.Text = value.first_name;
                textBoxLastName.Text = value.last_name;
                textBoxMother.Text = value.mother;
                dateTimePickerBirthDate.Value = value.birth_date;
                textBoxLocation.Text = value.location;
                textBoxEmail.Text = value.email;
                textBoxPhone.Text = value.phone;
                textBoxPicture.Text = value.picture;

                var user_data = value.user_data.SingleOrDefault(x => x.personal_data_id == value.id);

                textBoxUserName.Text = user_data.user_name;
                textBoxPassword.Text = user_data.password;
                dateTimePickerFirstWorkingDay.Value = user_data.first_working_day.Value;
                
                if (user_data.last_working_day != null)
                {
                    dateTimePickerLastWorkingDay.Value = user_data.last_working_day.Value;
                }
                comboBoxPositions.SelectedValue = user_data.position_id;
                userId = user_data.id;
            }
        }
        public user_data user
        {
            get                
            {
                var position = (position)comboBoxPositions.SelectedItem;
                var positionId = position.id;
                var user_data = new user_data(
                        textBoxUserName.Text,
                        textBoxPassword.Text,
                        dateTimePickerFirstWorkingDay.Value,
                        dateTimePickerLastWorkingDay.Value,
                        positionId
                    );
                if (userId > 0)
                {
                    user_data.id = userId;
                }
                return user_data;
            }            
        }
        public BindingList<position> positionList
        {
            get => (BindingList<position>)comboBoxPositions.DataSource;
            set
            {
                comboBoxPositions.DataSource = value;
                comboBoxPositions.DisplayMember = "position_name";
                comboBoxPositions.Name = "id";
                comboBoxPositions.ValueMember = "id";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.SavePersonalDataAndUserData(this.personal, this.user);
            this.DialogResult = DialogResult.OK;

        }
    }
}
