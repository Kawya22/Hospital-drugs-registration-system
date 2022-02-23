using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugsRegister
{
    public partial class Special_Note : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=HospitalFinal;Integrated Security=True");
        SqlCommand cmd;
       SqlDataAdapter adpt;
        DataTable dt;
        public Special_Note()
        {
            InitializeComponent();
            //ShowData();
        }

        private void Special_Note_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalFinalDataSet.SpecialNote' table. You can move, or remove it, as needed.
            this.specialNoteTableAdapter.Fill(this.hospitalFinalDataSet.SpecialNote);
            LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into SpecialNote (date,note) values(@date,@note)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@date", txtDate.Text);
            cmd.Parameters.AddWithValue("@note", txtNote.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
        void Clear()
        {
            txtDate.Text = "";
            txtNote.Text = "";
        }
        
        public void LoadData()
        {
            
            con.Open();
            dt = new DataTable();
            adpt = new SqlDataAdapter("Select * from SpecialNote",con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        
    }
}
