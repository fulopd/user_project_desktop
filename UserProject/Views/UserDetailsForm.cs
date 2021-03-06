﻿using System;
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
            dateTimePickerLastWorkingDay.MinDate = dateTimePickerFirstWorkingDay.Value;
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
                textBoxPasswordSec.Text = value.password;
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
        public string errorFirstName
        {
            get => errorProviderFirstName.GetError(textBoxFirstName);
            set => errorProviderFirstName.SetError(textBoxFirstName, value);
        }
        public string errorLastName
        {
            get => errorProviderLastName.GetError(textBoxLastName);
            set => errorProviderLastName.SetError(textBoxLastName, value);
        }
        public string errorMother
        {
            get => errorProviderMother.GetError(textBoxMother);
            set => errorProviderMother.SetError(textBoxMother, value);
        }
        public string errorPhone
        {
            get => errorProviderPhone.GetError(textBoxPhone);
            set => errorProviderPhone.SetError(textBoxPhone, value);
        }
        public string errorLocation
        {
            get => errorProviderLocation.GetError(textBoxLocation);
            set => errorProviderLocation.SetError(textBoxLocation, value);
        }
        public string errorUserName { 
            get => errorProviderUserName.GetError(textBoxUserName); 
            set => errorProviderUserName.SetError(textBoxUserName,value); 
        }
        public string errorPassword
        {
            get => errorProviderPassword.GetError(textBoxPassword);
            set => errorProviderPassword.SetError(textBoxPassword, value);
        }
        private bool PasswordMatch() 
        {
            bool match = true;
            errorProviderPasswordSec.Clear();
            if (textBoxPassword.Text != textBoxPasswordSec.Text)
            {
                errorProviderPasswordSec.SetError(textBoxPasswordSec, "Jelszavak nem egyeznek meg");
                match = false;
            }
            return match;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {            
            presenter.ValidateData(personal, user);            

            if (PasswordMatch() &&
                string.IsNullOrEmpty(errorFirstName) &&
                string.IsNullOrEmpty(errorLastName) &&
                string.IsNullOrEmpty(errorMother) &&
                string.IsNullOrEmpty(errorPhone) &&
                string.IsNullOrEmpty(errorLocation) &&
                string.IsNullOrEmpty(errorUserName) &&
                string.IsNullOrEmpty(errorPassword)                
                )
            {
                int perosnalId = presenter.SavePersonalData(personal);
                presenter.SaveUserData(user, perosnalId);

                if (localFileFullPath != "")//Csak tallózás után lesz értéke
                {
                    string newFileName = perosnalId + ".jpg";
                    try
                    {
                        FTP.upload(localFileFullPath, newFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("File feltöltése nem lehetséges.","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    presenter.UpdatePictur(perosnalId, newFileName);
                }
                this.DialogResult = DialogResult.OK;
            }
            
        }
        private void checkBoxLastDay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerLastWorkingDay.Enabled = checkBoxLastDay.Checked;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image File",

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

        private void dateTimePickerFirstWorkingDay_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastWorkingDay.MinDate = dateTimePickerFirstWorkingDay.Value;
        }
    }
}
