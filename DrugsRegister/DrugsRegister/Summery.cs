using System;
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
    public partial class Summery : Form
    {
        public Summery()
        {
            InitializeComponent();
        }

        private void Summery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalFinalDataSet3.WeeklyIssues' table. You can move, or remove it, as needed.
            this.weeklyIssuesTableAdapter1.Fill(this.hospitalFinalDataSet3.WeeklyIssues);
            // TODO: This line of code loads data into the 'hospitalFinalDataSet1.WeeklyIssues' table. You can move, or remove it, as needed.
            this.weeklyIssuesTableAdapter.Fill(this.hospitalFinalDataSet1.WeeklyIssues);
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
