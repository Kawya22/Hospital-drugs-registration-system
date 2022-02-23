using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DrugsRegister
{
    public partial class OralIssues : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=HospitalFinal;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;

        public OralIssues()
        {
            InitializeComponent();
        }

        private void OralIssues_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadData();
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand sc = new SqlCommand("select * from OralIssueItems where itemname='" + cmbItemName.Text + "'", con);
            SqlDataReader dataReader;

            dataReader = sc.ExecuteReader();
            while (dataReader.Read())
            {
                txtItemNo.Text = dataReader.GetValue(1).ToString(); 
            }
        }
        protected void FillCombobox()
        {

            con.Open();
            SqlCommand sc = new SqlCommand("select itemname,itemno from OralIssueItems", con);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("itemname", typeof(string));

            dt.Load(reader);

            cmbItemName.ValueMember = "itemname";
            cmbItemName.DisplayMember = "itemname";
            cmbItemName.DataSource = dt;

            con.Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int issue, rdp;

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            if (rdsIssue.Checked == true)
            {
                issue = Convert.ToInt32(txtAmount.Text);
                rdp = 0;
                SqlCommand cmd1 = new SqlCommand("select currentbalance from OralIssueItems where itemname='" + cmbItemName.Text + "'", con);
                cmd1.ExecuteNonQuery();

                SqlDataReader r = cmd1.ExecuteReader();
                int curbal = 0;

                while (r.Read())
                {
                    curbal = Convert.ToInt32(r.GetValue(0).ToString());
                }
                r.Close();

                curbal = curbal + rdp - issue;

                //update query
                SqlCommand cmd = new SqlCommand("insert into OralIssues (itemno,itemname,date,bht,issue,currentbalance) values('" + txtItemNo.Text + "','" + cmbItemName.Text + "','" + txtDate.Text + "','" + txtBht.Text + "','" + txtAmount.Text + "','" + Convert.ToString(curbal) + "')", con);


                cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                cmd.Parameters.AddWithValue("@date", txtDate.Text);
                cmd.Parameters.AddWithValue("@bht", txtBht.Text);
                cmd.Parameters.AddWithValue("@issue", txtAmount.Text);
                cmd.Parameters.AddWithValue("@currentbalance", curbal.ToString());
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update OralIssueItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);

                cmd2.ExecuteNonQuery();
                //done
            }
            else if (rdsRdp.Checked == true)
            {
                issue = 0;
                rdp = Convert.ToInt32(txtAmount.Text); ;
                SqlCommand cmd1 = new SqlCommand("select currentbalance from OralIssueItems where itemname='" + cmbItemName.Text + "'", con);
                cmd1.ExecuteNonQuery();

                SqlDataReader r = cmd1.ExecuteReader();
                int curbal = 0;

                while (r.Read())
                {
                    curbal = Convert.ToInt32(r.GetValue(0).ToString());
                }
                r.Close();

                curbal = curbal + rdp - issue;

                SqlCommand cmd = new SqlCommand("insert into OralIssues (itemno,itemname,date,bht,rdp,currentbalance) values('" + txtItemNo.Text + "','" + cmbItemName.Text + "','" + txtDate.Text + "','" + txtBht.Text + "','" + txtAmount.Text + "','" + Convert.ToString(curbal) + "')", con);
                SqlCommand cmd2 = new SqlCommand("update OralIssueItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);
                cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                cmd.Parameters.AddWithValue("@date", txtDate.Text);
                cmd.Parameters.AddWithValue("@bht", txtBht.Text);
                cmd.Parameters.AddWithValue("@rdp", txtAmount.Text);
                cmd.Parameters.AddWithValue("@currentbalance", curbal.ToString());

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please Select");
            }



            con.Close();

            //


            Clear();
            LoadData();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtItemNo.Text = "";
            txtBht.Text = "";
            txtAmount.Text = "";
            lblNo.Text = "";
            txtDate.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectData();
            LoadData();
        }

        public void LoadData()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            dt = new DataTable();
            adpt = new SqlDataAdapter("Select * from OralIssues", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                
                dataGridView1.Rows.RemoveAt(item.Index);
                delete(); 
            }

        }
        void delete()
        {
            int issue, rdp, bhtt;

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from OralIssues where no='" + lblNo.Text + "'", con);//items walin select kala
            cmd3.ExecuteNonQuery();

            bhtt = Convert.ToInt32(txtBht.Text);//bht eka varibale ekata initialze kala
            if (bhtt == 0)
            {
                rdp = Convert.ToInt32(txtAmount.Text);

                SqlCommand cmd1 = new SqlCommand("select currentbalance from OralIssueItems where itemname='" + cmbItemName.Text + "'", con);
                cmd1.ExecuteNonQuery();

                SqlDataReader r = cmd1.ExecuteReader();
                int curbal = 0;

                while (r.Read())
                {
                    curbal = Convert.ToInt32(r.GetValue(0).ToString());
                }
                r.Close();

                curbal = curbal - rdp;

                //update query
                SqlCommand cmd = new SqlCommand("Delete * from OralIssues where no='" + lblNo.Text + "'", con);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update OralIssueItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);

                cmd2.ExecuteNonQuery();
                //done
            }
            else if (bhtt != 0)
            {
                issue = Convert.ToInt32(txtAmount.Text);

                SqlCommand cmd1 = new SqlCommand("select currentbalance from OralIssueItems where itemname='" + cmbItemName.Text + "'", con);
                cmd1.ExecuteNonQuery();

                SqlDataReader r = cmd1.ExecuteReader();
                int curbal = 0;

                while (r.Read())
                {
                    curbal = Convert.ToInt32(r.GetValue(0).ToString());
                }
                r.Close();

                curbal = curbal + issue;

                //update query
                SqlCommand cmd = new SqlCommand("Delete * from OralIssues where no='" + lblNo.Text + "'", con);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update OralIssueItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);

                cmd2.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please Select");
            }
            dataGridView1.Refresh();

            con.Close();
            Clear();
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectData();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectData();
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectData();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            selectData();
        }

        private void rdsRdp_CheckedChanged(object sender, EventArgs e)
        {
            txtBht.Enabled = !rdsRdp.Checked;
        }
        private void selectData()
        {
            lblNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cmbItemName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtItemNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtBht.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (txtBht.Text == "")
            {
                txtAmount.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                txtAmount.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
    }
}
