namespace UserProject.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPosition = new System.Windows.Forms.Button();
            this.buttonUserList = new System.Windows.Forms.Button();
            this.buttonGlobalTimeTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPosition
            // 
            this.buttonPosition.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition.FlatAppearance.BorderSize = 0;
            this.buttonPosition.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonPosition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPosition.ForeColor = System.Drawing.Color.White;
            this.buttonPosition.Location = new System.Drawing.Point(135, 1);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Size = new System.Drawing.Size(124, 54);
            this.buttonPosition.TabIndex = 3;
            this.buttonPosition.Text = "Munkakör kezelő";
            this.buttonPosition.UseVisualStyleBackColor = false;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonUserList
            // 
            this.buttonUserList.BackColor = System.Drawing.Color.Transparent;
            this.buttonUserList.FlatAppearance.BorderSize = 0;
            this.buttonUserList.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUserList.ForeColor = System.Drawing.Color.White;
            this.buttonUserList.Location = new System.Drawing.Point(1, 1);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(132, 54);
            this.buttonUserList.TabIndex = 3;
            this.buttonUserList.Text = "Felhasználó kezelő";
            this.buttonUserList.UseVisualStyleBackColor = false;
            this.buttonUserList.Click += new System.EventHandler(this.buttonUserList_Click);
            // 
            // buttonGlobalTimeTable
            // 
            this.buttonGlobalTimeTable.BackColor = System.Drawing.Color.Transparent;
            this.buttonGlobalTimeTable.FlatAppearance.BorderSize = 0;
            this.buttonGlobalTimeTable.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonGlobalTimeTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonGlobalTimeTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.buttonGlobalTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGlobalTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGlobalTimeTable.ForeColor = System.Drawing.Color.White;
            this.buttonGlobalTimeTable.Location = new System.Drawing.Point(261, 1);
            this.buttonGlobalTimeTable.Name = "buttonGlobalTimeTable";
            this.buttonGlobalTimeTable.Size = new System.Drawing.Size(123, 54);
            this.buttonGlobalTimeTable.TabIndex = 3;
            this.buttonGlobalTimeTable.Text = "Beosztás kezelő";
            this.buttonGlobalTimeTable.UseVisualStyleBackColor = false;
            this.buttonGlobalTimeTable.Click += new System.EventHandler(this.buttonGlobalTimeTable_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 503);
            this.panel1.TabIndex = 4;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(927, 1);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(19, 18);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimize.ForeColor = System.Drawing.Color.White;
            this.labelMinimize.Location = new System.Drawing.Point(906, -3);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(19, 20);
            this.labelMinimize.TabIndex = 5;
            this.labelMinimize.Text = "_";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.labelMinimize);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.buttonGlobalTimeTable);
            this.Controls.Add(this.buttonPosition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 560);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPosition;
        private System.Windows.Forms.Button buttonUserList;
        private System.Windows.Forms.Button buttonGlobalTimeTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelMinimize;
    }
}