namespace UserProject.Views
{
    partial class UserTimeTableForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidleaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sickleaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.paidleaveDataGridViewTextBoxColumn,
            this.sickleaveDataGridViewTextBoxColumn,
            this.updateatDataGridViewTextBoxColumn,
            this.userdataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataSource = typeof(UserProject.Models.time_table);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Visible = false;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // paidleaveDataGridViewTextBoxColumn
            // 
            this.paidleaveDataGridViewTextBoxColumn.DataPropertyName = "paid_leave";
            this.paidleaveDataGridViewTextBoxColumn.HeaderText = "paid_leave";
            this.paidleaveDataGridViewTextBoxColumn.Name = "paidleaveDataGridViewTextBoxColumn";
            // 
            // sickleaveDataGridViewTextBoxColumn
            // 
            this.sickleaveDataGridViewTextBoxColumn.DataPropertyName = "sick_leave";
            this.sickleaveDataGridViewTextBoxColumn.HeaderText = "sick_leave";
            this.sickleaveDataGridViewTextBoxColumn.Name = "sickleaveDataGridViewTextBoxColumn";
            // 
            // updateatDataGridViewTextBoxColumn
            // 
            this.updateatDataGridViewTextBoxColumn.DataPropertyName = "update_at";
            this.updateatDataGridViewTextBoxColumn.HeaderText = "update_at";
            this.updateatDataGridViewTextBoxColumn.Name = "updateatDataGridViewTextBoxColumn";
            // 
            // userdataDataGridViewTextBoxColumn
            // 
            this.userdataDataGridViewTextBoxColumn.DataPropertyName = "user_data";
            this.userdataDataGridViewTextBoxColumn.HeaderText = "user_data";
            this.userdataDataGridViewTextBoxColumn.Name = "userdataDataGridViewTextBoxColumn";
            this.userdataDataGridViewTextBoxColumn.Visible = false;
            // 
            // UserTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserTimeTableForm";
            this.Text = "UserTimeTable";
            this.Load += new System.EventHandler(this.UserTimeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidleaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickleaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timetableBindingSource;
    }
}