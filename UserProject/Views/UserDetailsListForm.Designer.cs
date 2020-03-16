namespace UserProject.Views
{
    partial class UserDetailsListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.positionPositionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataBirthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataMotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalDataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDetailsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionPositionnameDataGridViewTextBoxColumn,
            this.personalDataFirstnameDataGridViewTextBoxColumn,
            this.personalDataLastnameDataGridViewTextBoxColumn,
            this.personalDataLocationDataGridViewTextBoxColumn,
            this.personalDataEmailDataGridViewTextBoxColumn,
            this.personalDataPhoneDataGridViewTextBoxColumn,
            this.personalDataBirthdateDataGridViewTextBoxColumn,
            this.personalDataMotherDataGridViewTextBoxColumn,
            this.userDataUsernameDataGridViewTextBoxColumn,
            this.personalDataPictureDataGridViewTextBoxColumn,
            this.userDataIdDataGridViewTextBoxColumn,
            this.personalDataIdDataGridViewTextBoxColumn,
            this.positionIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDetailsViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonFirst);
            this.flowLayoutPanel1.Controls.Add(this.buttonPrev);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.buttonNext);
            this.flowLayoutPanel1.Controls.Add(this.buttonLast);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(210, 420);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFirst.Location = new System.Drawing.Point(3, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.Location = new System.Drawing.Point(84, 3);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Location = new System.Drawing.Point(206, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLast.Location = new System.Drawing.Point(287, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 4;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.Location = new System.Drawing.Point(12, 33);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(156, 20);
            this.textBoxSearchText.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(174, 31);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Keresés";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(255, 31);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Szerkesztés";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(336, 30);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "Új";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(417, 30);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Törlés";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // positionPositionnameDataGridViewTextBoxColumn
            // 
            this.positionPositionnameDataGridViewTextBoxColumn.DataPropertyName = "positionPosition_name";
            this.positionPositionnameDataGridViewTextBoxColumn.HeaderText = "positionPosition_name";
            this.positionPositionnameDataGridViewTextBoxColumn.Name = "positionPositionnameDataGridViewTextBoxColumn";
            this.positionPositionnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataFirstnameDataGridViewTextBoxColumn
            // 
            this.personalDataFirstnameDataGridViewTextBoxColumn.DataPropertyName = "personalDataFirst_name";
            this.personalDataFirstnameDataGridViewTextBoxColumn.HeaderText = "personalDataFirst_name";
            this.personalDataFirstnameDataGridViewTextBoxColumn.Name = "personalDataFirstnameDataGridViewTextBoxColumn";
            this.personalDataFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataLastnameDataGridViewTextBoxColumn
            // 
            this.personalDataLastnameDataGridViewTextBoxColumn.DataPropertyName = "personalDataLast_name";
            this.personalDataLastnameDataGridViewTextBoxColumn.HeaderText = "personalDataLast_name";
            this.personalDataLastnameDataGridViewTextBoxColumn.Name = "personalDataLastnameDataGridViewTextBoxColumn";
            this.personalDataLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataLocationDataGridViewTextBoxColumn
            // 
            this.personalDataLocationDataGridViewTextBoxColumn.DataPropertyName = "personalDataLocation";
            this.personalDataLocationDataGridViewTextBoxColumn.HeaderText = "personalDataLocation";
            this.personalDataLocationDataGridViewTextBoxColumn.Name = "personalDataLocationDataGridViewTextBoxColumn";
            this.personalDataLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataEmailDataGridViewTextBoxColumn
            // 
            this.personalDataEmailDataGridViewTextBoxColumn.DataPropertyName = "personalDataEmail";
            this.personalDataEmailDataGridViewTextBoxColumn.HeaderText = "personalDataEmail";
            this.personalDataEmailDataGridViewTextBoxColumn.Name = "personalDataEmailDataGridViewTextBoxColumn";
            this.personalDataEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataPhoneDataGridViewTextBoxColumn
            // 
            this.personalDataPhoneDataGridViewTextBoxColumn.DataPropertyName = "personalDataPhone";
            this.personalDataPhoneDataGridViewTextBoxColumn.HeaderText = "personalDataPhone";
            this.personalDataPhoneDataGridViewTextBoxColumn.Name = "personalDataPhoneDataGridViewTextBoxColumn";
            this.personalDataPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataBirthdateDataGridViewTextBoxColumn
            // 
            this.personalDataBirthdateDataGridViewTextBoxColumn.DataPropertyName = "personalDataBirth_date";
            this.personalDataBirthdateDataGridViewTextBoxColumn.HeaderText = "personalDataBirth_date";
            this.personalDataBirthdateDataGridViewTextBoxColumn.Name = "personalDataBirthdateDataGridViewTextBoxColumn";
            this.personalDataBirthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataMotherDataGridViewTextBoxColumn
            // 
            this.personalDataMotherDataGridViewTextBoxColumn.DataPropertyName = "personalDataMother";
            this.personalDataMotherDataGridViewTextBoxColumn.HeaderText = "personalDataMother";
            this.personalDataMotherDataGridViewTextBoxColumn.Name = "personalDataMotherDataGridViewTextBoxColumn";
            this.personalDataMotherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataUsernameDataGridViewTextBoxColumn
            // 
            this.userDataUsernameDataGridViewTextBoxColumn.DataPropertyName = "userDataUser_name";
            this.userDataUsernameDataGridViewTextBoxColumn.HeaderText = "userDataUser_name";
            this.userDataUsernameDataGridViewTextBoxColumn.Name = "userDataUsernameDataGridViewTextBoxColumn";
            this.userDataUsernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalDataPictureDataGridViewTextBoxColumn
            // 
            this.personalDataPictureDataGridViewTextBoxColumn.DataPropertyName = "personalDataPicture";
            this.personalDataPictureDataGridViewTextBoxColumn.HeaderText = "personalDataPicture";
            this.personalDataPictureDataGridViewTextBoxColumn.Name = "personalDataPictureDataGridViewTextBoxColumn";
            this.personalDataPictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataIdDataGridViewTextBoxColumn
            // 
            this.userDataIdDataGridViewTextBoxColumn.DataPropertyName = "userDataId";
            this.userDataIdDataGridViewTextBoxColumn.HeaderText = "userDataId";
            this.userDataIdDataGridViewTextBoxColumn.Name = "userDataIdDataGridViewTextBoxColumn";
            this.userDataIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // personalDataIdDataGridViewTextBoxColumn
            // 
            this.personalDataIdDataGridViewTextBoxColumn.DataPropertyName = "personalDataId";
            this.personalDataIdDataGridViewTextBoxColumn.HeaderText = "personalDataId";
            this.personalDataIdDataGridViewTextBoxColumn.Name = "personalDataIdDataGridViewTextBoxColumn";
            this.personalDataIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personalDataIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // positionIdDataGridViewTextBoxColumn
            // 
            this.positionIdDataGridViewTextBoxColumn.DataPropertyName = "positionId";
            this.positionIdDataGridViewTextBoxColumn.HeaderText = "positionId";
            this.positionIdDataGridViewTextBoxColumn.Name = "positionIdDataGridViewTextBoxColumn";
            this.positionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDetailsViewModelBindingSource
            // 
            this.userDetailsViewModelBindingSource.DataSource = typeof(UserProject.ViewModels.UserDetailsViewModel);
            // 
            // UserDetailsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchText);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserDetailsListForm";
            this.Text = "UserDetailsListForm";
            this.Load += new System.EventHandler(this.UserDetailsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userDetailsViewModelBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionPositionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataBirthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataMotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalDataIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionIdDataGridViewTextBoxColumn;
    }
}