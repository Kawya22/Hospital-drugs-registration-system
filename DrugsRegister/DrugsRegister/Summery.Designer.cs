namespace DrugsRegister
{
    partial class Summery
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyIssuesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalFinalDataSet3 = new DrugsRegister.HospitalFinalDataSet3();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.weeklyIssuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalFinalDataSet1 = new DrugsRegister.HospitalFinalDataSet1();
            this.btnExit = new System.Windows.Forms.Button();
            this.weeklyIssuesTableAdapter = new DrugsRegister.HospitalFinalDataSet1TableAdapters.WeeklyIssuesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.weeklyIssuesTableAdapter1 = new DrugsRegister.HospitalFinalDataSet3TableAdapters.WeeklyIssuesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyIssuesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFinalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyIssuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(115, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 589);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weekly Issues";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(6, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 186);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.itemnoDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.currentbalanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.weeklyIssuesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemnoDataGridViewTextBoxColumn
            // 
            this.itemnoDataGridViewTextBoxColumn.DataPropertyName = "itemno";
            this.itemnoDataGridViewTextBoxColumn.HeaderText = "itemno";
            this.itemnoDataGridViewTextBoxColumn.Name = "itemnoDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "itemname";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // currentbalanceDataGridViewTextBoxColumn
            // 
            this.currentbalanceDataGridViewTextBoxColumn.DataPropertyName = "currentbalance";
            this.currentbalanceDataGridViewTextBoxColumn.HeaderText = "currentbalance";
            this.currentbalanceDataGridViewTextBoxColumn.Name = "currentbalanceDataGridViewTextBoxColumn";
            // 
            // weeklyIssuesBindingSource1
            // 
            this.weeklyIssuesBindingSource1.DataMember = "WeeklyIssues";
            this.weeklyIssuesBindingSource1.DataSource = this.hospitalFinalDataSet3;
            // 
            // hospitalFinalDataSet3
            // 
            this.hospitalFinalDataSet3.DataSetName = "HospitalFinalDataSet3";
            this.hospitalFinalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oral Issues";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(816, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Special Issues";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(816, 563);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Local Purchases";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(816, 563);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "IV Injections";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(816, 563);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "IV Fluids";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(816, 563);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Dressing";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(816, 563);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Surgical Consumable";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(816, 563);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Surgical Gloves";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(816, 563);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Dispensary";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(816, 563);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Eather Spirit";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // weeklyIssuesBindingSource
            // 
            this.weeklyIssuesBindingSource.DataMember = "WeeklyIssues";
            this.weeklyIssuesBindingSource.DataSource = this.hospitalFinalDataSet1;
            // 
            // hospitalFinalDataSet1
            // 
            this.hospitalFinalDataSet1.DataSetName = "HospitalFinalDataSet1";
            this.hospitalFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(918, 703);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // weeklyIssuesTableAdapter
            // 
            this.weeklyIssuesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(115, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Summery Report";
            // 
            // weeklyIssuesTableAdapter1
            // 
            this.weeklyIssuesTableAdapter1.ClearBeforeFill = true;
            // 
            // Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Summery";
            this.Text = "Summery";
            this.Load += new System.EventHandler(this.Summery_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyIssuesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFinalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyIssuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFinalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalFinalDataSet1 hospitalFinalDataSet1;
        private System.Windows.Forms.BindingSource weeklyIssuesBindingSource;
        private HospitalFinalDataSet1TableAdapters.WeeklyIssuesTableAdapter weeklyIssuesTableAdapter;
        private System.Windows.Forms.Label label1;
        private HospitalFinalDataSet3 hospitalFinalDataSet3;
        private System.Windows.Forms.BindingSource weeklyIssuesBindingSource1;
        private HospitalFinalDataSet3TableAdapters.WeeklyIssuesTableAdapter weeklyIssuesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentbalanceDataGridViewTextBoxColumn;
    }
}