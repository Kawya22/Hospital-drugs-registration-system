﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugsRegister
{
    public partial class Drugs : Form
    {
        public Drugs()
        {
            InitializeComponent();
        }

        private void Drugs_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void btnWeeklyIssues_Click(object sender, EventArgs e)
        {
            weeklyIssues1.BringToFront();
        }

        private void btnOralIssues_Click(object sender, EventArgs e)
        {
            oralIssues1.BringToFront();
        }

        private void btnspecialIssues_Click(object sender, EventArgs e)
        {
            specialIssues1.BringToFront();
        }

        private void LocalPurchases_Click(object sender, EventArgs e)
        {
            localPurchases1.BringToFront();
        }

        private void btnIVInjections_Click(object sender, EventArgs e)
        {
           ivInjection1.BringToFront();
        }

        private void btnIvFluids_Click(object sender, EventArgs e)
        {
           ivFluids1.BringToFront();
        }

        private void oralIssues1_Load(object sender, EventArgs e)
        {

        }

        private void weeklyIssues1_Load(object sender, EventArgs e)
        {

        }
    }
}
