namespace UserProject.Views
{
    partial class GlobalTimeTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalTimeTableForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxTimeIntervall = new System.Windows.Forms.TextBox();
            this.buttonFillSelectedCell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1150, 524);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(1079, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 31);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(158, 51);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 31);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Betöltés";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonth.Location = new System.Drawing.Point(6, 51);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(96, 29);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "Aktuális";
            // 
            // textBoxTimeIntervall
            // 
            this.textBoxTimeIntervall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTimeIntervall.Location = new System.Drawing.Point(9, 19);
            this.textBoxTimeIntervall.Name = "textBoxTimeIntervall";
            this.textBoxTimeIntervall.Size = new System.Drawing.Size(160, 20);
            this.textBoxTimeIntervall.TabIndex = 6;
            // 
            // buttonFillSelectedCell
            // 
            this.buttonFillSelectedCell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFillSelectedCell.Location = new System.Drawing.Point(9, 50);
            this.buttonFillSelectedCell.Name = "buttonFillSelectedCell";
            this.buttonFillSelectedCell.Size = new System.Drawing.Size(160, 31);
            this.buttonFillSelectedCell.TabIndex = 7;
            this.buttonFillSelectedCell.Text = "Minta másolása";
            this.buttonFillSelectedCell.UseVisualStyleBackColor = true;
            this.buttonFillSelectedCell.Click += new System.EventHandler(this.buttonFillSelectedCell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFillSelectedCell);
            this.groupBox1.Controls.Add(this.textBoxTimeIntervall);
            this.groupBox1.Location = new System.Drawing.Point(257, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitöltési minta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.labelMonth);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 91);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dátum";
            // 
            // GlobalTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlobalTimeTableForm";
            this.Text = "Beosztás kezelő";
            this.Load += new System.EventHandler(this.GlobalTimeTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxTimeIntervall;
        private System.Windows.Forms.Button buttonFillSelectedCell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}