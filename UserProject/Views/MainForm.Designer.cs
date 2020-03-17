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
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonUserTimeTable = new System.Windows.Forms.Button();
            this.buttonPosition = new System.Windows.Forms.Button();
            this.buttonUserList = new System.Windows.Forms.Button();
            this.buttonGlobalTimeTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Location = new System.Drawing.Point(12, 12);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonUserInfo.TabIndex = 2;
            this.buttonUserInfo.Text = "UserInfo";
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonUserInfo_Click);
            // 
            // buttonUserTimeTable
            // 
            this.buttonUserTimeTable.Location = new System.Drawing.Point(93, 12);
            this.buttonUserTimeTable.Name = "buttonUserTimeTable";
            this.buttonUserTimeTable.Size = new System.Drawing.Size(98, 23);
            this.buttonUserTimeTable.TabIndex = 3;
            this.buttonUserTimeTable.Text = "Saját beosztás";
            this.buttonUserTimeTable.UseVisualStyleBackColor = true;
            this.buttonUserTimeTable.Click += new System.EventHandler(this.buttonUserTimeTable_Click);
            // 
            // buttonPosition
            // 
            this.buttonPosition.Location = new System.Drawing.Point(197, 12);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Size = new System.Drawing.Size(98, 23);
            this.buttonPosition.TabIndex = 3;
            this.buttonPosition.Text = "Pozíciók";
            this.buttonPosition.UseVisualStyleBackColor = true;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // buttonUserList
            // 
            this.buttonUserList.Location = new System.Drawing.Point(301, 12);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(132, 23);
            this.buttonUserList.TabIndex = 3;
            this.buttonUserList.Text = "Felhasználó kezelés";
            this.buttonUserList.UseVisualStyleBackColor = true;
            this.buttonUserList.Click += new System.EventHandler(this.buttonUserList_Click);
            // 
            // buttonGlobalTimeTable
            // 
            this.buttonGlobalTimeTable.Location = new System.Drawing.Point(439, 12);
            this.buttonGlobalTimeTable.Name = "buttonGlobalTimeTable";
            this.buttonGlobalTimeTable.Size = new System.Drawing.Size(132, 23);
            this.buttonGlobalTimeTable.TabIndex = 3;
            this.buttonGlobalTimeTable.Text = "Teljes beosztás";
            this.buttonGlobalTimeTable.UseVisualStyleBackColor = true;
            this.buttonGlobalTimeTable.Click += new System.EventHandler(this.buttonGlobalTimeTable_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 494);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGlobalTimeTable);
            this.Controls.Add(this.buttonUserList);
            this.Controls.Add(this.buttonPosition);
            this.Controls.Add(this.buttonUserTimeTable);
            this.Controls.Add(this.buttonUserInfo);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonUserTimeTable;
        private System.Windows.Forms.Button buttonPosition;
        private System.Windows.Forms.Button buttonUserList;
        private System.Windows.Forms.Button buttonGlobalTimeTable;
        private System.Windows.Forms.Panel panel1;
    }
}