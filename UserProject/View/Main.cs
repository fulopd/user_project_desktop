﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Models;

namespace UserProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (userProjectDBContext db = new userProjectDBContext())
            {
                label1.Text = db.user_data.First().personal_data.mother.ToString();
                user_data admin = db.user_data.First();
                var aa = admin.position.permission_ids.ToString();
                label1.Text += aa;
            }
        }
    }
}

