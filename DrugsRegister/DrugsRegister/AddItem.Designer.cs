namespace DrugsRegister
{
    partial class AddItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdsEather = new System.Windows.Forms.RadioButton();
            this.rdsLocal = new System.Windows.Forms.RadioButton();
            this.rdsDressing = new System.Windows.Forms.RadioButton();
            this.rdsConsumable = new System.Windows.Forms.RadioButton();
            this.rdsGloves = new System.Windows.Forms.RadioButton();
            this.rdsDispesary = new System.Windows.Forms.RadioButton();
            this.RdsFluids = new System.Windows.Forms.RadioButton();
            this.rdsInjection = new System.Windows.Forms.RadioButton();
            this.rdsSpecial = new System.Windows.Forms.RadioButton();
            this.rdsOral = new System.Windows.Forms.RadioButton();
            this.rdsWeekly = new System.Windows.Forms.RadioButton();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtItemNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbItemName);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 319);
            this.panel1.TabIndex = 0;
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(138, 269);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(152, 20);
            this.txtItemNo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item No";
            // 
            // rdsEather
            // 
            this.rdsEather.AutoSize = true;
            this.rdsEather.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsEather.Location = new System.Drawing.Point(6, 111);
            this.rdsEather.Name = "rdsEather";
            this.rdsEather.Size = new System.Drawing.Size(88, 17);
            this.rdsEather.TabIndex = 18;
            this.rdsEather.TabStop = true;
            this.rdsEather.Text = "Ether Spirit";
            this.rdsEather.UseVisualStyleBackColor = true;
            // 
            // rdsLocal
            // 
            this.rdsLocal.AutoSize = true;
            this.rdsLocal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsLocal.Location = new System.Drawing.Point(6, 135);
            this.rdsLocal.Name = "rdsLocal";
            this.rdsLocal.Size = new System.Drawing.Size(119, 17);
            this.rdsLocal.TabIndex = 17;
            this.rdsLocal.TabStop = true;
            this.rdsLocal.Text = "Local Purchases";
            this.rdsLocal.UseVisualStyleBackColor = true;
            this.rdsLocal.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rdsDressing
            // 
            this.rdsDressing.AutoSize = true;
            this.rdsDressing.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsDressing.Location = new System.Drawing.Point(6, 19);
            this.rdsDressing.Name = "rdsDressing";
            this.rdsDressing.Size = new System.Drawing.Size(78, 17);
            this.rdsDressing.TabIndex = 16;
            this.rdsDressing.TabStop = true;
            this.rdsDressing.Text = "Dressing ";
            this.rdsDressing.UseVisualStyleBackColor = true;
            this.rdsDressing.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rdsConsumable
            // 
            this.rdsConsumable.AutoSize = true;
            this.rdsConsumable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsConsumable.Location = new System.Drawing.Point(6, 42);
            this.rdsConsumable.Name = "rdsConsumable";
            this.rdsConsumable.Size = new System.Drawing.Size(143, 17);
            this.rdsConsumable.TabIndex = 15;
            this.rdsConsumable.TabStop = true;
            this.rdsConsumable.Text = "Surgical Consumable";
            this.rdsConsumable.UseVisualStyleBackColor = true;
            this.rdsConsumable.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // rdsGloves
            // 
            this.rdsGloves.AutoSize = true;
            this.rdsGloves.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsGloves.Location = new System.Drawing.Point(6, 65);
            this.rdsGloves.Name = "rdsGloves";
            this.rdsGloves.Size = new System.Drawing.Size(114, 17);
            this.rdsGloves.TabIndex = 14;
            this.rdsGloves.TabStop = true;
            this.rdsGloves.Text = "Surgical Gloves";
            this.rdsGloves.UseVisualStyleBackColor = true;
            this.rdsGloves.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // rdsDispesary
            // 
            this.rdsDispesary.AutoSize = true;
            this.rdsDispesary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsDispesary.Location = new System.Drawing.Point(6, 88);
            this.rdsDispesary.Name = "rdsDispesary";
            this.rdsDispesary.Size = new System.Drawing.Size(87, 17);
            this.rdsDispesary.TabIndex = 13;
            this.rdsDispesary.TabStop = true;
            this.rdsDispesary.Text = "Dispensary";
            this.rdsDispesary.UseVisualStyleBackColor = true;
            this.rdsDispesary.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // RdsFluids
            // 
            this.RdsFluids.AutoSize = true;
            this.RdsFluids.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RdsFluids.Location = new System.Drawing.Point(6, 112);
            this.RdsFluids.Name = "RdsFluids";
            this.RdsFluids.Size = new System.Drawing.Size(74, 17);
            this.RdsFluids.TabIndex = 12;
            this.RdsFluids.TabStop = true;
            this.RdsFluids.Text = "IV Fluids";
            this.RdsFluids.UseVisualStyleBackColor = true;
            // 
            // rdsInjection
            // 
            this.rdsInjection.AutoSize = true;
            this.rdsInjection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsInjection.Location = new System.Drawing.Point(6, 89);
            this.rdsInjection.Name = "rdsInjection";
            this.rdsInjection.Size = new System.Drawing.Size(90, 17);
            this.rdsInjection.TabIndex = 11;
            this.rdsInjection.TabStop = true;
            this.rdsInjection.Text = "IV Injection";
            this.rdsInjection.UseVisualStyleBackColor = true;
            // 
            // rdsSpecial
            // 
            this.rdsSpecial.AutoSize = true;
            this.rdsSpecial.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsSpecial.Location = new System.Drawing.Point(6, 66);
            this.rdsSpecial.Name = "rdsSpecial";
            this.rdsSpecial.Size = new System.Drawing.Size(101, 17);
            this.rdsSpecial.TabIndex = 10;
            this.rdsSpecial.TabStop = true;
            this.rdsSpecial.Text = "Special Issue";
            this.rdsSpecial.UseVisualStyleBackColor = true;
            // 
            // rdsOral
            // 
            this.rdsOral.AutoSize = true;
            this.rdsOral.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsOral.Location = new System.Drawing.Point(6, 43);
            this.rdsOral.Name = "rdsOral";
            this.rdsOral.Size = new System.Drawing.Size(82, 17);
            this.rdsOral.TabIndex = 9;
            this.rdsOral.TabStop = true;
            this.rdsOral.Text = "Oral Issue";
            this.rdsOral.UseVisualStyleBackColor = true;
            // 
            // rdsWeekly
            // 
            this.rdsWeekly.AutoSize = true;
            this.rdsWeekly.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rdsWeekly.Location = new System.Drawing.Point(6, 19);
            this.rdsWeekly.Name = "rdsWeekly";
            this.rdsWeekly.Size = new System.Drawing.Size(107, 17);
            this.rdsWeekly.TabIndex = 8;
            this.rdsWeekly.TabStop = true;
            this.rdsWeekly.Text = "Weekly Issues";
            this.rdsWeekly.UseVisualStyleBackColor = true;
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(138, 207);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(232, 21);
            this.cmbItemName.TabIndex = 7;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(138, 238);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(111, 20);
            this.txtDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Register Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdsOral);
            this.groupBox1.Controls.Add(this.rdsSpecial);
            this.groupBox1.Controls.Add(this.rdsInjection);
            this.groupBox1.Controls.Add(this.rdsLocal);
            this.groupBox1.Controls.Add(this.RdsFluids);
            this.groupBox1.Controls.Add(this.rdsWeekly);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 173);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drugs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdsDressing);
            this.groupBox2.Controls.Add(this.rdsDispesary);
            this.groupBox2.Controls.Add(this.rdsEather);
            this.groupBox2.Controls.Add(this.rdsGloves);
            this.groupBox2.Controls.Add(this.rdsConsumable);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(227, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 173);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consumable";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(342, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(261, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(180, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(445, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.RadioButton rdsLocal;
        private System.Windows.Forms.RadioButton rdsDressing;
        private System.Windows.Forms.RadioButton rdsConsumable;
        private System.Windows.Forms.RadioButton rdsGloves;
        private System.Windows.Forms.RadioButton rdsDispesary;
        private System.Windows.Forms.RadioButton RdsFluids;
        private System.Windows.Forms.RadioButton rdsInjection;
        private System.Windows.Forms.RadioButton rdsSpecial;
        private System.Windows.Forms.RadioButton rdsOral;
        private System.Windows.Forms.RadioButton rdsWeekly;
        private System.Windows.Forms.RadioButton rdsEather;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
    }
}