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
    public partial class AddItem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=HospitalFinal;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter adpt;
        DataTable dt;
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbItemName.Text != "")
            {
                if (rdsConsumable.Checked == true)
                {
                    cmd = new SqlCommand("insert into SurgicalConsumableItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsDispesary.Checked == true)
                {
                    cmd = new SqlCommand("insert into DispenseryItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsDressing.Checked == true)
                {
                    cmd = new SqlCommand("insert into DressingItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsEather.Checked == true)
                {
                    cmd = new SqlCommand("insert into EatherSpiritItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (RdsFluids.Checked == true)
                {
                    cmd = new SqlCommand("insert into IVFluidItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsGloves.Checked == true)
                {
                    cmd = new SqlCommand("insert into SurgicalGlovesItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsInjection.Checked == true)
                {
                    cmd = new SqlCommand("insert into IVInjectionItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsLocal.Checked == true)
                {
                    cmd = new SqlCommand("insert into LocalPurchaseItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsOral.Checked == true)
                {
                    cmd = new SqlCommand("insert into OralIssueItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsSpecial.Checked == true)
                {
                    cmd = new SqlCommand("insert into SpecialIssueItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else if (rdsWeekly.Checked == true)
                {
                    cmd = new SqlCommand("insert into WeeklyIssueItems (itemname,regdate) values(@itemname,@regdate)", con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
                    cmd.Parameters.AddWithValue("@itemno", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@regdate", txtDate.Text);
                    cmd.ExecuteNonQuery();


                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Please Select a category");
                }

            }
            else
            {
                MessageBox.Show("Please Select a category");
            }
            LoadData();
            Clear();

        }

        public void LoadData()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            dt = new DataTable();
            if (rdsWeekly.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from WeeklyIssueItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsConsumable.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from SurgicalConsumableItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsDispesary.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from DispenseryItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsDressing.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from DressingItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsEather.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from EatherSpiritItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (RdsFluids.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from IVFluidItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsGloves.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from SurgicalGlovesItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsInjection.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from IVInjectionItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsLocal.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from LocalPurchaseItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsOral.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from OralIssueItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }
            else if (rdsSpecial.Checked == true)
            {
                adpt = new SqlDataAdapter("Select itemname from SpecialIssueItems", con);
                adpt.Fill(dt);
                cmbItemName.DataSource = dt;
                FillCombobox();
            }

            con.Close();

        }
        private void AddItem_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cmbItemName;
            FillCombobox();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete * from AddItem where itemname=@itemname)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@itemname", cmbItemName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        
        protected void FillCombobox()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            
            if (rdsWeekly.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from WeeklyIssueItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";

            }
            else if (rdsConsumable.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from SurgicalConsumableItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsDispesary.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from DispenseryItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsDressing.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from DressingItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsEather.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from EatherSpiritItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (RdsFluids.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from IVFluidItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsGloves.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from SurgicalGlovesItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsInjection.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from IVInjectionItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsLocal.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from LocalPurchaseItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsOral.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from OralIssueItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }
            else if (rdsSpecial.Checked == true)
            {
                SqlCommand sc = new SqlCommand("select itemname,itemno from SpecialIssueItems", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("itemname", typeof(string));

                dt.Load(reader);

                cmbItemName.ValueMember = "itemname";

                cmbItemName.DisplayMember = "itemname";
            }


            cmbItemName.DataSource = dt;
           /* if (txtItemNo == null)
            {
                txtItemNo.Enabled = true;
            }*/
            con.Close();
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdsSpecial.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
                
            }
            else if (rdsConsumable.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SurgicalConsumableItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsDispesary.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from DispenseryItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsDressing.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsEather.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (RdsFluids.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsGloves.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsInjection.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsLocal.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsOral.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }
            else if (rdsWeekly.Checked == true)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand sc = new SqlCommand("select * from SpecialIssueItems where itemname='" + cmbItemName.Text + "'", con);
                //SqlDataReader dataReader;

                if (dataReader != null) dataReader.Close();
                dataReader = sc.ExecuteReader();
                while (dataReader.Read())
                {
                    txtItemNo.Text = dataReader.GetValue(1).ToString();
                    txtDate.Text = dataReader.GetValue(3).ToString();
                }
            }

            FillCombobox();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            cmbItemName.Text = "";
            txtDate.Value = DateTime.Now;
        }

    }
}
