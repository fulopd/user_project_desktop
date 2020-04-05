namespace UserProject.Views
{
    partial class PositionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionsForm));
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonNewPosition = new System.Windows.Forms.Button();
            this.buttonPositionDelete = new System.Windows.Forms.Button();
            this.buttonPositionUp = new System.Windows.Forms.Button();
            this.buttonPositionDown = new System.Windows.Forms.Button();
            this.buttonPermisionAdd = new System.Windows.Forms.Button();
            this.buttonPermisionRemove = new System.Windows.Forms.Button();
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workschedulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAvailablePermissions = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewPositionPermissions = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailablePermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositionPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(349, 22);
            this.textBoxDescription.MaxLength = 1000;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(534, 151);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.Leave += new System.EventHandler(this.textBoxDescription_Leave);
            // 
            // buttonNewPosition
            // 
            this.buttonNewPosition.Location = new System.Drawing.Point(49, 180);
            this.buttonNewPosition.Name = "buttonNewPosition";
            this.buttonNewPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPosition.TabIndex = 2;
            this.buttonNewPosition.Text = "Új munkakör";
            this.buttonNewPosition.UseVisualStyleBackColor = true;
            this.buttonNewPosition.Click += new System.EventHandler(this.buttonNewPosition_Click);
            // 
            // buttonPositionDelete
            // 
            this.buttonPositionDelete.Location = new System.Drawing.Point(195, 180);
            this.buttonPositionDelete.Name = "buttonPositionDelete";
            this.buttonPositionDelete.Size = new System.Drawing.Size(44, 23);
            this.buttonPositionDelete.TabIndex = 3;
            this.buttonPositionDelete.Text = "Törlés";
            this.buttonPositionDelete.UseVisualStyleBackColor = true;
            this.buttonPositionDelete.Click += new System.EventHandler(this.buttonPositionDelete_Click);
            // 
            // buttonPositionUp
            // 
            this.buttonPositionUp.Location = new System.Drawing.Point(238, 180);
            this.buttonPositionUp.Name = "buttonPositionUp";
            this.buttonPositionUp.Size = new System.Drawing.Size(37, 23);
            this.buttonPositionUp.TabIndex = 4;
            this.buttonPositionUp.Text = "Fel";
            this.buttonPositionUp.UseVisualStyleBackColor = true;
            this.buttonPositionUp.Click += new System.EventHandler(this.buttonPositionUp_Click);
            // 
            // buttonPositionDown
            // 
            this.buttonPositionDown.Location = new System.Drawing.Point(274, 180);
            this.buttonPositionDown.Name = "buttonPositionDown";
            this.buttonPositionDown.Size = new System.Drawing.Size(37, 23);
            this.buttonPositionDown.TabIndex = 5;
            this.buttonPositionDown.Text = "Le";
            this.buttonPositionDown.UseVisualStyleBackColor = true;
            this.buttonPositionDown.Click += new System.EventHandler(this.buttonPositionDown_Click);
            // 
            // buttonPermisionAdd
            // 
            this.buttonPermisionAdd.Location = new System.Drawing.Point(451, 330);
            this.buttonPermisionAdd.Name = "buttonPermisionAdd";
            this.buttonPermisionAdd.Size = new System.Drawing.Size(31, 23);
            this.buttonPermisionAdd.TabIndex = 8;
            this.buttonPermisionAdd.Text = ">";
            this.buttonPermisionAdd.UseVisualStyleBackColor = true;
            this.buttonPermisionAdd.Click += new System.EventHandler(this.buttonPermisionAdd_Click);
            // 
            // buttonPermisionRemove
            // 
            this.buttonPermisionRemove.Location = new System.Drawing.Point(451, 371);
            this.buttonPermisionRemove.Name = "buttonPermisionRemove";
            this.buttonPermisionRemove.Size = new System.Drawing.Size(31, 23);
            this.buttonPermisionRemove.TabIndex = 9;
            this.buttonPermisionRemove.Text = "<";
            this.buttonPermisionRemove.UseVisualStyleBackColor = true;
            this.buttonPermisionRemove.Click += new System.EventHandler(this.buttonPermisionRemove_Click);
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AllowUserToAddRows = false;
            this.dataGridViewPositions.AllowUserToDeleteRows = false;
            this.dataGridViewPositions.AllowUserToOrderColumns = true;
            this.dataGridViewPositions.AllowUserToResizeRows = false;
            this.dataGridViewPositions.AutoGenerateColumns = false;
            this.dataGridViewPositions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priorityDataGridViewTextBoxColumn,
            this.positionnameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.permissionidsDataGridViewTextBoxColumn,
            this.workschedulesDataGridViewTextBoxColumn,
            this.userdataDataGridViewTextBoxColumn});
            this.dataGridViewPositions.DataSource = this.positionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPositions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPositions.Location = new System.Drawing.Point(48, 22);
            this.dataGridViewPositions.MultiSelect = false;
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            this.dataGridViewPositions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPositions.RowHeadersVisible = false;
            this.dataGridViewPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPositions.Size = new System.Drawing.Size(264, 151);
            this.dataGridViewPositions.StandardTab = true;
            this.dataGridViewPositions.TabIndex = 1;
            this.dataGridViewPositions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPositions_CellClick);
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Prioritás";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityDataGridViewTextBoxColumn.Width = 69;
            // 
            // positionnameDataGridViewTextBoxColumn
            // 
            this.positionnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionnameDataGridViewTextBoxColumn.DataPropertyName = "position_name";
            this.positionnameDataGridViewTextBoxColumn.HeaderText = "Munkakör megnevezés";
            this.positionnameDataGridViewTextBoxColumn.Name = "positionnameDataGridViewTextBoxColumn";
            this.positionnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // permissionidsDataGridViewTextBoxColumn
            // 
            this.permissionidsDataGridViewTextBoxColumn.DataPropertyName = "permission_ids";
            this.permissionidsDataGridViewTextBoxColumn.HeaderText = "permission_ids";
            this.permissionidsDataGridViewTextBoxColumn.Name = "permissionidsDataGridViewTextBoxColumn";
            this.permissionidsDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionidsDataGridViewTextBoxColumn.Visible = false;
            // 
            // workschedulesDataGridViewTextBoxColumn
            // 
            this.workschedulesDataGridViewTextBoxColumn.DataPropertyName = "work_schedules";
            this.workschedulesDataGridViewTextBoxColumn.HeaderText = "work_schedules";
            this.workschedulesDataGridViewTextBoxColumn.Name = "workschedulesDataGridViewTextBoxColumn";
            this.workschedulesDataGridViewTextBoxColumn.ReadOnly = true;
            this.workschedulesDataGridViewTextBoxColumn.Visible = false;
            // 
            // userdataDataGridViewTextBoxColumn
            // 
            this.userdataDataGridViewTextBoxColumn.DataPropertyName = "user_data";
            this.userdataDataGridViewTextBoxColumn.HeaderText = "user_data";
            this.userdataDataGridViewTextBoxColumn.Name = "userdataDataGridViewTextBoxColumn";
            this.userdataDataGridViewTextBoxColumn.ReadOnly = true;
            this.userdataDataGridViewTextBoxColumn.Visible = false;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(UserProject.Models.position);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(847, 453);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elérhető jogosultságok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kiosztott jogosultságok";
            // 
            // dataGridViewAvailablePermissions
            // 
            this.dataGridViewAvailablePermissions.AllowUserToAddRows = false;
            this.dataGridViewAvailablePermissions.AllowUserToDeleteRows = false;
            this.dataGridViewAvailablePermissions.AllowUserToResizeRows = false;
            this.dataGridViewAvailablePermissions.AutoGenerateColumns = false;
            this.dataGridViewAvailablePermissions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAvailablePermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailablePermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.permissionnameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridViewAvailablePermissions.DataSource = this.permissionBindingSource;
            this.dataGridViewAvailablePermissions.Location = new System.Drawing.Point(48, 252);
            this.dataGridViewAvailablePermissions.MultiSelect = false;
            this.dataGridViewAvailablePermissions.Name = "dataGridViewAvailablePermissions";
            this.dataGridViewAvailablePermissions.ReadOnly = true;
            this.dataGridViewAvailablePermissions.RowHeadersVisible = false;
            this.dataGridViewAvailablePermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailablePermissions.Size = new System.Drawing.Size(360, 190);
            this.dataGridViewAvailablePermissions.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // permissionnameDataGridViewTextBoxColumn
            // 
            this.permissionnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.permissionnameDataGridViewTextBoxColumn.DataPropertyName = "permission_name";
            this.permissionnameDataGridViewTextBoxColumn.HeaderText = "Jogosultság ";
            this.permissionnameDataGridViewTextBoxColumn.Name = "permissionnameDataGridViewTextBoxColumn";
            this.permissionnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.permissionnameDataGridViewTextBoxColumn.Width = 91;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Leírás";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // permissionBindingSource
            // 
            this.permissionBindingSource.DataSource = typeof(UserProject.Models.permission);
            // 
            // dataGridViewPositionPermissions
            // 
            this.dataGridViewPositionPermissions.AllowUserToAddRows = false;
            this.dataGridViewPositionPermissions.AllowUserToDeleteRows = false;
            this.dataGridViewPositionPermissions.AllowUserToResizeRows = false;
            this.dataGridViewPositionPermissions.AutoGenerateColumns = false;
            this.dataGridViewPositionPermissions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPositionPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositionPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.permissionnameDataGridViewTextBoxColumn1,
            this.description});
            this.dataGridViewPositionPermissions.DataSource = this.permissionBindingSource;
            this.dataGridViewPositionPermissions.Location = new System.Drawing.Point(523, 252);
            this.dataGridViewPositionPermissions.MultiSelect = false;
            this.dataGridViewPositionPermissions.Name = "dataGridViewPositionPermissions";
            this.dataGridViewPositionPermissions.ReadOnly = true;
            this.dataGridViewPositionPermissions.RowHeadersVisible = false;
            this.dataGridViewPositionPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPositionPermissions.Size = new System.Drawing.Size(360, 190);
            this.dataGridViewPositionPermissions.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 40;
            // 
            // permissionnameDataGridViewTextBoxColumn1
            // 
            this.permissionnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.permissionnameDataGridViewTextBoxColumn1.DataPropertyName = "permission_name";
            this.permissionnameDataGridViewTextBoxColumn1.HeaderText = "Jogosultság ";
            this.permissionnameDataGridViewTextBoxColumn1.Name = "permissionnameDataGridViewTextBoxColumn1";
            this.permissionnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.permissionnameDataGridViewTextBoxColumn1.Width = 91;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Leírás";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Munkakörök listája";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Munkakör leírása";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(123, 180);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(73, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Szerkesztés";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 488);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewPositionPermissions);
            this.Controls.Add(this.dataGridViewAvailablePermissions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewPositions);
            this.Controls.Add(this.buttonPositionDown);
            this.Controls.Add(this.buttonPermisionRemove);
            this.Controls.Add(this.buttonPermisionAdd);
            this.Controls.Add(this.buttonPositionUp);
            this.Controls.Add(this.buttonPositionDelete);
            this.Controls.Add(this.buttonNewPosition);
            this.Controls.Add(this.textBoxDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PositionsForm";
            this.RightToLeftLayout = true;
            this.Text = "PositionsForm";
            this.Load += new System.EventHandler(this.PositionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailablePermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositionPermissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonNewPosition;
        private System.Windows.Forms.Button buttonPositionDelete;
        private System.Windows.Forms.Button buttonPositionUp;
        private System.Windows.Forms.Button buttonPositionDown;
        private System.Windows.Forms.Button buttonPermisionAdd;
        private System.Windows.Forms.Button buttonPermisionRemove;
        private System.Windows.Forms.DataGridView dataGridViewPositions;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAvailablePermissions;
        private System.Windows.Forms.BindingSource permissionBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPositionPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workschedulesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdit;
    }
}