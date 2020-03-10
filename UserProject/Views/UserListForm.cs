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
    public partial class UserListForm : Form, IUserListView
    {
        private UserListPresenter presenter;
        private int pageCount;
        private int colIndex;
        public UserListForm()
        {
            InitializeComponent();
            presenter = new UserListPresenter(this);
            Init();
        }

        private void Init()
        {
            pageNumber = 1;
            itemsPerPage = 30;
            sortBy = "id";
            ascending = true;
            colIndex = 0;
    }

        public BindingList<personal_data> userBindingList { 
            get => (BindingList<personal_data>)dataGridViewUserList.DataSource;
            set => dataGridViewUserList.DataSource = value; 
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
                // Összes oldal száma
                pageCount = (value - 1) / itemsPerPage + 1;
                // Jelenlegi oldal / Összes oldal szám
                labelPage.Text = pageNumber.ToString() + "/" + pageCount.ToString();
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            presenter.loadData();
        }

        #region navButtons
        
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.loadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //page = page - 1;
            if (pageNumber >= 2) // page != 1
            {
                pageNumber--;
                presenter.loadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < pageCount)
            {
                pageNumber++;
                presenter.loadData();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.loadData();
        }
        #endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Init();
            presenter.loadData();
        }

        private void dataGridViewUserList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (colIndex == e.ColumnIndex)
            {
                // Ellentétre vált az értéke
                ascending = !ascending;
            }

            // Oszlop száma szerint módosítja a sortBy értékét
            switch (e.ColumnIndex)
            {
                case 0:
                    sortBy = "id";
                    break;
                case 1:
                    sortBy = "first_name";
                    break;
                case 3:
                    sortBy = "last_name";
                    break;
                case 4:
                    sortBy = "location";
                    break;                
                default:
                    break;
            }

            colIndex = e.ColumnIndex;

            presenter.loadData();
        }

        private void EditDGRow(int index)
        {
            var personal = (personal_data)dataGridViewUserList.Rows[index].DataBoundItem;

            if (personal != null)
            {
                using (var modForm = new UserForm())
                {
                    modForm.personal = personal;
                    DialogResult dr = modForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        //presenter.modify(modForm.personal);                        
                        modForm.Close();                       
                    }
                    
                }
            }
        }

        private void NewDGRow()
        {
            using (var szerkForm = new UserForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    //presenter.add(szerkForm.personal);
                    szerkForm.Close(); 
                }
            }
        }


        private void DelDGRow()
        {
            while (dataGridViewUserList.SelectedRows.Count > 0)
            {
                presenter.remove(dataGridViewUserList.SelectedRows[0].Index);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUserList.SelectedRows != null)
            {
                var sorIndex = dataGridViewUserList.SelectedCells[0].RowIndex;
                dataGridViewUserList.ClearSelection();
                dataGridViewUserList.Rows[sorIndex].Selected = true;
            }
            EditDGRow(dataGridViewUserList.SelectedRows[0].Index);
            presenter.loadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewDGRow();
            presenter.loadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }
    }
}
