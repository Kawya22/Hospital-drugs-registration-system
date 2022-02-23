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

namespace DrugsRegister
{

    public partial class Dressing : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=HospitalFinal;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;

        public Dressing()
        {
            InitializeComponent();
        }

        private void cmbItemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            SqlCommand sc = new SqlCommand("select * from DressingItems where itemname='" + cmbItemName.Text + "'", con);
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
            SqlCommand sc = new SqlCommand("select itemname from DressingItems", con);
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

        private void Dressing_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int issue, rdp;

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();

            if (rdsIssues.Checked == true)
            {
                issue = Convert.ToInt32(txtAmount.Text);
                rdp = 0;
                SqlCommand cmd1 = new SqlCommand("select currentbalance from DressingItems where itemname='" + cmbItemName.Text + "'", con);
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
                SqlCommand cmd = new SqlCommand("insert into Dressing (itemno,itemname,date,issue,currentbalance) values('" + txtItemNo.Text + "','" + cmbItemName.Text + "','" + txtDate.Text + "','" + txtAmount.Text + "','" + Convert.ToString(curbal) + "')", con);


                cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                cmd.Parameters.AddWithValue("@date", txtDate.Text);
                cmd.Parameters.AddWithValue("@issue", txtAmount.Text);
                cmd.Parameters.AddWithValue("@currentbalance", curbal.ToString());
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update DressingItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);

                cmd2.ExecuteNonQuery();
                //done
            }
            else if (rdsRdp.Checked == true)
            {
                issue = 0;
                rdp = Convert.ToInt32(txtAmount.Text); ;
                SqlCommand cmd1 = new SqlCommand("select currentbalance from DressingItems where itemname='" + cmbItemName.Text + "'", con);
                cmd1.ExecuteNonQuery();

                SqlDataReader r = cmd1.ExecuteReader();
                int curbal = 0;

                while (r.Read())
                {
                    curbal = Convert.ToInt32(r.GetValue(0).ToString());
                }
                r.Close();

                curbal = curbal + rdp - issue;

                SqlCommand cmd = new SqlCommand("insert into Dressing (itemno,itemname,date,rdp,currentbalance) values('" + txtItemNo.Text + "','" + cmbItemName.Text + "','" + txtDate.Text + "','" + txtAmount.Text + "','" + Convert.ToString(curbal) + "')", con);
                SqlCommand cmd2 = new SqlCommand("update DressingItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);
                cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                cmd.Parameters.AddWithValue("@date", txtDate.Text);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);
                delete();
            }
        }
        void Clear()
        {
            txtItemNo.Text = "";
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
            adpt = new SqlDataAdapter("Select * from Dressing", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            //ResetId();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectData();
        }

        void delete()
        {

            int issue, rdp;

            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Dressing where no='" + lblNo.Text + "'", con);//items walin select kala
            cmd3.ExecuteNonQuery();

           
            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "")
            {
                rdp = Convert.ToInt32(txtAmount.Text);

                SqlCommand cmd1 = new SqlCommand("select currentbalance from DressingItems where itemname='" + cmbItemName.Text + "'", con);
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
                SqlCommand cmd = new SqlCommand("Delete * from Dressing where no='" + lblNo.Text + "'", con);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update DressingItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);

                cmd2.ExecuteNonQuery();
                //done
            }
            else if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "")
            {
                issue = Convert.ToInt32(txtAmount.Text);

                SqlCommand cmd1 = new SqlCommand("select currentbalance from DressingItems where itemname='" + cmbItemName.Text + "'", con);
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
                SqlCommand cmd = new SqlCommand("Delete * from Dressing where no='" + lblNo.Text + "'", con);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update DressingItems SET currentbalance='" + curbal + "'  WHERE itemname='" + cmbItemName.Text + "'", con);

                cmd2.ExecuteNonQuery();
            }
            else
            {
               // MessageBox.Show("");
            }
            dataGridView1.Refresh();

            con.Close();
            Clear();
            LoadData();

        }
        private void selectData()
        {
            lblNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cmbItemName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtItemNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "")
            {
                txtAmount.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "")
            {
                txtAmount.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
