using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Models;
using UserProject.Presenters;
using UserProject.Properties;
using UserProject.ViewInterfaces;

namespace UserProject.Views
{
    public partial class PositionsForm : Form, IPositionsView
    {
        PositionsPresenter presenter;
        position selectedPosition;
        
        public PositionsForm()
        {
            InitializeComponent();
            presenter = new PositionsPresenter(this);
        }
        
        public List<position> statPositionList
        {
            get => (List<position>)dataGridViewPositions.DataSource;
            set => dataGridViewPositions.DataSource = value;
        }
        public string descriptions
        {
            get => textBoxDescription.Text;
        }
        public List<permission> availablePermissionsList
        {
            set => dataGridViewAvailablePermissions.DataSource = value;
        }
        public List<permission> positionPermissionsList
        {
            set => dataGridViewPositionPermissions.DataSource = value;
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            //Kezdő értékek beállítása
            presenter.GetAllPositon();//összes pozició betöltése adatbázisból
            setPriorityBasedOnRowIndex();//prioritások beállítása sor indexnex megfelelően
            init();
        }
        private void init()
        {
            if (dataGridViewPositions.Rows.Count > 0)
            {
                selectedPosition = (position)dataGridViewPositions.Rows[0].DataBoundItem;//kiválasztott elem kezdő érték megadása
                textBoxDescription.Text = selectedPosition.description; //kiválasztott elem leírásának betöltése
                presenter.GetPermissions(selectedPosition); //kiválasztott elemhez adható jogosultságok listája / kiválasztott jogosultságok listája
            }
            else
            {
                selectedPosition = null;
                textBoxDescription.Text = "";
                dataGridViewAvailablePermissions.DataSource = null;
                dataGridViewPositionPermissions.DataSource = null;
            }

        }       
        private void setPriorityBasedOnRowIndex()
        {
            foreach (DataGridViewRow row in dataGridViewPositions.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }
        private void buttonPositionUp_Click(object sender, EventArgs e)
        {
            if (selectedPosition != null)
            {
                int selectedRowIndex = dataGridViewPositions.SelectedRows[0].Index;
                presenter.UpList(selectedPosition);
                setPriorityBasedOnRowIndex();
                dataGridViewPositions.Refresh();
                dataGridViewPositions.Rows[selectedRowIndex - (selectedRowIndex > 0 ? 1 : 0)].Selected = true;
            }

        }
        private void buttonPositionDown_Click(object sender, EventArgs e)
        {
            if (selectedPosition != null)
            {
                int selectedRowIndex = dataGridViewPositions.SelectedRows[0].Index;
                presenter.DownList(selectedPosition);
                setPriorityBasedOnRowIndex();
                dataGridViewPositions.Refresh();
                dataGridViewPositions.Rows[selectedRowIndex + (selectedRowIndex < dataGridViewPositions.RowCount - 1 ? 1 : 0)].Selected = true;
            }
        }
        private void buttonPositionDelete_Click(object sender, EventArgs e)
        {
            if (selectedPosition != null || dataGridViewPositions.Rows.Count > 0)
            {
                presenter.Delete(selectedPosition);
                setPriorityBasedOnRowIndex();
                init();
            }
        }
        private void dataGridViewPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPosition = (position)dataGridViewPositions.SelectedRows[0].DataBoundItem;
            textBoxDescription.Text = selectedPosition.description;
            presenter.GetPermissions(selectedPosition);

        }
        private void textBoxDescription_Leave(object sender, EventArgs e)
        {            
            selectedPosition.description = textBoxDescription.Text;
        }       
        private void buttonPermisionAdd_Click(object sender, EventArgs e)
        {
            if (selectedPosition != null && dataGridViewAvailablePermissions.Rows.Count > 0)
            {   
                var selectedPermision = (permission)dataGridViewAvailablePermissions.SelectedRows[0].DataBoundItem;
                if (selectedPermision != null)
                {
                    if (selectedPosition.permission_ids.Equals(string.Empty))
                    {
                        selectedPosition.permission_ids += selectedPermision.id;//első jogosultság hozzáadása
                    }
                    else
                    {
                        selectedPosition.permission_ids += "," + selectedPermision.id;//további jogosultságok hozáadása
                    }                       
                    presenter.GetPermissions(selectedPosition);
                }
            }
        }
        private void buttonPermisionRemove_Click(object sender, EventArgs e)
        {           
            if (selectedPosition != null && dataGridViewPositionPermissions.Rows.Count > 0)
            {                
                string[] sPermissonons = selectedPosition.permission_ids.Split(',');
                int[] perm = Array.ConvertAll(sPermissonons, s => int.Parse(s));

                var selectedPermision = (permission)dataGridViewPositionPermissions.SelectedRows[0].DataBoundItem;
                Debug.WriteLine(selectedPermision.id);
                int idToRemove = selectedPermision.id;
                perm = perm.Where(val => val != idToRemove).ToArray();
                string newPerm = string.Empty;
                if (perm.Length != 0)
                {
                    foreach (int item in perm)
                    {
                        newPerm += item + ",";
                    }
                    newPerm = newPerm.Substring(0, newPerm.Length - 1);
                }
                selectedPosition.permission_ids = newPerm;
                presenter.GetPermissions(selectedPosition);                                
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(Resources.messageSave,
                                                            "Mentés",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    presenter.Save();
                }
            }
            catch (Exception ed)
            {
                MessageBox.Show("Függőségek miatt a törlést nem lehet végrehajtani!\n" + ed.Message,"Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void buttonNewPosition_Click(object sender, EventArgs e)
        {
            using (var addPositionForm = new PositionAddForm())
            {
                DialogResult dr = addPositionForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.AddPosition(addPositionForm.newPosition);
                    addPositionForm.Close();
                    setPriorityBasedOnRowIndex();

                }
            }
        }
    }
}
