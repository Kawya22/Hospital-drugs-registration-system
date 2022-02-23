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
    public partial class Consumable : Form
    {
        public Consumable()
        {
            InitializeComponent();
        }

        private void Consumable_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dressing1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            surgical_Consumable1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            surgical_Gloves1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dispensary1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ether_Spirit1.BringToFront();
        }
    }
}
