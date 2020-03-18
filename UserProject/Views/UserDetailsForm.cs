using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Models;
using UserProject.Presenters;
using UserProject.Services;
using UserProject.ViewInterfaces;
using UserProject.ViewModels;

namespace UserProject.Views
{
    public partial class UserDetailsForm : Form, IUserDetailsView
    {
        private int personalId;
        private int userId;
        private UserDetailsPresenter presenter;
        private string localFileFullPath = "";

        public UserDetailsForm()
        {
            InitializeComponent();
            presenter = new UserDetailsPresenter(this);
            presenter.GetAllPositions();
        }

        public UserDetailsViewModel udvm
        {
            get
            {
                var position = (position)comboBoxPositions.SelectedItem;
                UserDetailsViewModel udvmTemp = new UserDetailsViewModel(
                    user.id,
                    user.user_name,
                    personal.id,
                    personal.first_name,
                    personal.last_name,
                    personal.mother,
                    personal.birth_date,
                    personal.location,
                    personal.email,
                    personal.phone,
                    personal.picture,
                    user.position_id,
                    position.position_name
                    );
                return udvmTemp;
            }
            set
            {
                presenter.GetPersonalData(value.personalDataId);
                presenter.GetUserData(value.userDataId);
            }
        }
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
                    textBoxPicture.Text == string.Empty ? "profile.jpg" : textBoxPicture.Text
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
            }
        }
        public user_data user
        {
            get
            {
                DateTime? LastDay = null;
                if (checkBoxLastDay.Checked)
                {
                    LastDay = dateTimePickerLastWorkingDay.Value;
                }
                var position = (position)comboBoxPositions.SelectedItem;
                var positionId = position.id;
                var user_data = new user_data(
                        textBoxUserName.Text,
                        textBoxPassword.Text,
                        dateTimePickerFirstWorkingDay.Value,
                        LastDay,
                        positionId
                    );
                if (userId > 0)
                {
                    user_data.id = userId;
                }
                return user_data;
            }
            set
            {
                textBoxUserName.Text = value.user_name;
                textBoxPassword.Text = value.password;
                dateTimePickerFirstWorkingDay.Value = value.first_working_day.Value;
                if (value.last_working_day != null)
                {
                    dateTimePickerLastWorkingDay.Value = value.last_working_day.Value;
                    checkBoxLastDay.Checked = true;
                }
                else
                {
                    checkBoxLastDay.Checked = false;
                }
                comboBoxPositions.SelectedValue = value.position_id;
                userId = value.id;
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
            //TODO: Ellenőrzés
            int perosnalId = presenter.SavePersonalData(personal);
            presenter.SaveUserData(user, perosnalId);

            if (localFileFullPath!="")
            {
                string newFileName = perosnalId + ".jpg";
                FTP.upload(localFileFullPath, newFileName);
                presenter.UpdatePictur(perosnalId, newFileName);
            }
            
            this.DialogResult = DialogResult.OK;
        }

        private void checkBoxLastDay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerLastWorkingDay.Enabled = checkBoxLastDay.Checked;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "Image files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                localFileFullPath = openFileDialog1.FileName;
                textBoxPicture.Text = localFileFullPath;
            }
        }
    }
}
