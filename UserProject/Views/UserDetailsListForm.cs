using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Presenters;
using UserProject.ViewInterfaces;
using UserProject.ViewModels;

namespace UserProject.Views
{
    public partial class UserDetailsListForm : Form, IUserDetailsListView
    {
        UserDetailsListPresenter presenter;
        private int pageCount;
        private int sortIndex;

        public UserDetailsListForm()
        {
            InitializeComponent();
            presenter = new UserDetailsListPresenter(this);
            Init();
        }

        public BindingList<UserDetailsViewModel> bindingList
        {
            get => (BindingList<UserDetailsViewModel>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 20;
            sortBy = "Id";
            sortIndex = 0;
            ascending = true;
        }
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => textBoxSearchText.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                label1.Text = pageNumber.ToString() + "/" + pageCount.ToString();                
            }
        }

        private void UserDetailsListForm_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(dataGridView1, true);
            presenter.LoadData();
        }
        private void SetDoubleBuffered(DataGridView dataGridView, bool p)
        {
            Type dgvType = dataGridView.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView, p, null);
        }
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber != 1)
            {
                pageNumber--;
                presenter.LoadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pageNumber != pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;
            }
            EditDGRow(dataGridView1.SelectedRows[0].Index);
        }

        private void EditDGRow(int index)
        {
            var userDetail = (UserDetailsViewModel)dataGridView1.Rows[index].DataBoundItem;

            if (userDetail != null)
            {
                using (var modForm = new UserDetailsForm())
                {
                    modForm.udvm = userDetail;
                    DialogResult dr = modForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(index, modForm.udvm);
                        modForm.Close();
                    }

                }
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewDGRow();
            presenter.LoadData();
        }
        private void NewDGRow()
        {
            using (var szerkForm = new UserDetailsForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(szerkForm.udvm);
                    szerkForm.Close();
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {            
            if (dataGridView1.SelectedRows != null)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;                
            }
            RemoveDGRow(dataGridView1.SelectedRows[0].Index);
            
        }

        private void RemoveDGRow(int index)
        {
            var userDetail = (UserDetailsViewModel)dataGridView1.Rows[index].DataBoundItem;
            if (userDetail != null)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index, userDetail);
            }
            
        }
    }
}
