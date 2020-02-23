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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidleaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sickleaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.start_date,
            this.dataGridViewTextBoxColumn1,
            this.end_date,
            this.paidleaveDataGridViewTextBoxColumn,
            this.sickleaveDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.timetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(162, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(464, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // start_date
            // 
            this.start_date.DataPropertyName = "start_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.start_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.start_date.HeaderText = "Dátum";
            this.start_date.Name = "start_date";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "start_date";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Kezdés";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.end_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.end_date.HeaderText = "Vége";
            this.end_date.Name = "end_date";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Munkaidő";
            this.Column1.Name = "Column1";
            // 
            // paidleaveDataGridViewTextBoxColumn
            // 
            this.paidleaveDataGridViewTextBoxColumn.DataPropertyName = "paid_leave";
            this.paidleaveDataGridViewTextBoxColumn.HeaderText = "paid_leave";
            this.paidleaveDataGridViewTextBoxColumn.Name = "paidleaveDataGridViewTextBoxColumn";
            this.paidleaveDataGridViewTextBoxColumn.Visible = false;
            // 
            // sickleaveDataGridViewTextBoxColumn
            // 
            this.sickleaveDataGridViewTextBoxColumn.DataPropertyName = "sick_leave";
            this.sickleaveDataGridViewTextBoxColumn.HeaderText = "sick_leave";
            this.sickleaveDataGridViewTextBoxColumn.Name = "sickleaveDataGridViewTextBoxColumn";
            this.sickleaveDataGridViewTextBoxColumn.Visible = false;
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataSource = typeof(UserProject.Models.time_table);
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
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidleaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickleaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}