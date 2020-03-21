using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int colIndex;        

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
            itemsPerPage = 17;
            sortBy = "Id";            
            ascending = true;
            active = true;
        }
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => textBoxSearchText.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public bool active { get; set; }
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
        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            active = !active;
            Debug.WriteLine(active);
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
        
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (colIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                default:
                    sortBy = "id";
                    break;
                case 0:
                    sortBy = "position";                    
                    break;
                case 1:
                    sortBy = "firstname";
                    break;
                case 2:
                    sortBy = "lastname";
                    break;
                case 3:
                    sortBy = "location";
                    break;
                case 4:
                    sortBy = "email";
                    break;
                case 5:
                    sortBy = "phone";
                    break;
                case 6:
                    sortBy = "birth";
                    break;
                case 7:
                    sortBy = "mother";
                    break;
                case 8:
                    sortBy = "user";
                    break;

            }

            colIndex = e.ColumnIndex;
            presenter.LoadData();
        }
    }
}
