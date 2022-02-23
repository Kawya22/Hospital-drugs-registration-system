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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new AddItem().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StartPage().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Consumable().Show();
        }

        private void btnDrugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Drugs().Show();
        }

        private void btnSpecialNote_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Special_Note().Show();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            new Summery().Show();
        }
    }
}
