namespace DrugsRegister
{
    partial class Drugs
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
            this.btnIvFluids = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIVInjections = new System.Windows.Forms.Button();
            this.LocalPurchases = new System.Windows.Forms.Button();
            this.btnspecialIssues = new System.Windows.Forms.Button();
            this.btnOralIssues = new System.Windows.Forms.Button();
            this.btnWeeklyIssues = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.weeklyIssues1 = new DrugsRegister.WeeklyIssues();
            this.specialIssues1 = new DrugsRegister.SpecialIssues();
            this.localPurchases1 = new DrugsRegister.LocalPurchases();
            this.ivInjection1 = new DrugsRegister.IVInjection();
            this.ivFluids1 = new DrugsRegister.IVFluids();
            this.oralIssues1 = new DrugsRegister.OralIssues();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnIvFluids);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIVInjections);
            this.panel1.Controls.Add(this.LocalPurchases);
            this.panel1.Controls.Add(this.btnspecialIssues);
            this.panel1.Controls.Add(this.btnOralIssues);
            this.panel1.Controls.Add(this.btnWeeklyIssues);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 768);
            this.panel1.TabIndex = 1;
            // 
            // btnIvFluids
            // 
            this.btnIvFluids.FlatAppearance.BorderSize = 0;
            this.btnIvFluids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIvFluids.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIvFluids.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIvFluids.Image = global::DrugsRegister.Properties.Resources.iconfinder_18___Harry_Potter___Outline___Potion_Bottle_2730130;
            this.btnIvFluids.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIvFluids.Location = new System.Drawing.Point(0, 376);
            this.btnIvFluids.Name = "btnIvFluids";
            this.btnIvFluids.Size = new System.Drawing.Size(236, 46);
            this.btnIvFluids.TabIndex = 7;
            this.btnIvFluids.Text = "IV Fluid";
            this.btnIvFluids.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIvFluids.UseVisualStyleBackColor = true;
            this.btnIvFluids.Click += new System.EventHandler(this.btnIvFluids_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category";
            // 
            // btnIVInjections
            // 
            this.btnIVInjections.FlatAppearance.BorderSize = 0;
            this.btnIVInjections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIVInjections.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIVInjections.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIVInjections.Image = global::DrugsRegister.Properties.Resources.syringe__2_;
            this.btnIVInjections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIVInjections.Location = new System.Drawing.Point(0, 333);
            this.btnIVInjections.Name = "btnIVInjections";
            this.btnIVInjections.Size = new System.Drawing.Size(236, 46);
            this.btnIVInjections.TabIndex = 5;
            this.btnIVInjections.Text = "IV Injection";
            this.btnIVInjections.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIVInjections.UseVisualStyleBackColor = true;
            this.btnIVInjections.Click += new System.EventHandler(this.btnIVInjections_Click);
            // 
            // LocalPurchases
            // 
            this.LocalPurchases.FlatAppearance.BorderSize = 0;
            this.LocalPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocalPurchases.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalPurchases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LocalPurchases.Image = global::DrugsRegister.Properties.Resources.ambulance;
            this.LocalPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocalPurchases.Location = new System.Drawing.Point(0, 287);
            this.LocalPurchases.Name = "LocalPurchases";
            this.LocalPurchases.Size = new System.Drawing.Size(236, 46);
            this.LocalPurchases.TabIndex = 4;
            this.LocalPurchases.Text = "Local Purchases";
            this.LocalPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LocalPurchases.UseVisualStyleBackColor = true;
            this.LocalPurchases.Click += new System.EventHandler(this.LocalPurchases_Click);
            // 
            // btnspecialIssues
            // 
            this.btnspecialIssues.FlatAppearance.BorderSize = 0;
            this.btnspecialIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnspecialIssues.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspecialIssues.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnspecialIssues.Image = global::DrugsRegister.Properties.Resources.iconfinder_Hand_1021018;
            this.btnspecialIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspecialIssues.Location = new System.Drawing.Point(0, 241);
            this.btnspecialIssues.Name = "btnspecialIssues";
            this.btnspecialIssues.Size = new System.Drawing.Size(236, 46);
            this.btnspecialIssues.TabIndex = 3;
            this.btnspecialIssues.Text = "Special Issues";
            this.btnspecialIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnspecialIssues.UseVisualStyleBackColor = true;
            this.btnspecialIssues.Click += new System.EventHandler(this.btnspecialIssues_Click);
            // 
            // btnOralIssues
            // 
            this.btnOralIssues.FlatAppearance.BorderSize = 0;
            this.btnOralIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOralIssues.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOralIssues.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOralIssues.Image = global::DrugsRegister.Properties.Resources.iconfinder_16___Harry_Potter___Outline___Potion_Bottle_2730128;
            this.btnOralIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOralIssues.Location = new System.Drawing.Point(0, 195);
            this.btnOralIssues.Name = "btnOralIssues";
            this.btnOralIssues.Size = new System.Drawing.Size(236, 46);
            this.btnOralIssues.TabIndex = 2;
            this.btnOralIssues.Text = "Oral Issues";
            this.btnOralIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOralIssues.UseVisualStyleBackColor = true;
            this.btnOralIssues.Click += new System.EventHandler(this.btnOralIssues_Click);
            // 
            // btnWeeklyIssues
            // 
            this.btnWeeklyIssues.FlatAppearance.BorderSize = 0;
            this.btnWeeklyIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeeklyIssues.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyIssues.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWeeklyIssues.Image = global::DrugsRegister.Properties.Resources.triangular_bandage;
            this.btnWeeklyIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeeklyIssues.Location = new System.Drawing.Point(0, 149);
            this.btnWeeklyIssues.Name = "btnWeeklyIssues";
            this.btnWeeklyIssues.Size = new System.Drawing.Size(236, 46);
            this.btnWeeklyIssues.TabIndex = 1;
            this.btnWeeklyIssues.Text = "Weekly Issues";
            this.btnWeeklyIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWeeklyIssues.UseVisualStyleBackColor = true;
            this.btnWeeklyIssues.Click += new System.EventHandler(this.btnWeeklyIssues_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::DrugsRegister.Properties.Resources.home_page1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(236, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(236, 721);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 47);
            this.panel3.TabIndex = 3;
            // 
            // weeklyIssues1
            // 
            this.weeklyIssues1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.weeklyIssues1.Location = new System.Drawing.Point(235, 0);
            this.weeklyIssues1.Name = "weeklyIssues1";
            this.weeklyIssues1.Size = new System.Drawing.Size(1131, 722);
            this.weeklyIssues1.TabIndex = 9;
            this.weeklyIssues1.Load += new System.EventHandler(this.weeklyIssues1_Load);
            // 
            // specialIssues1
            // 
            this.specialIssues1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.specialIssues1.Location = new System.Drawing.Point(235, 0);
            this.specialIssues1.Name = "specialIssues1";
            this.specialIssues1.Size = new System.Drawing.Size(1131, 722);
            this.specialIssues1.TabIndex = 8;
            // 
            // localPurchases1
            // 
            this.localPurchases1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.localPurchases1.Location = new System.Drawing.Point(235, 0);
            this.localPurchases1.Name = "localPurchases1";
            this.localPurchases1.Size = new System.Drawing.Size(1131, 722);
            this.localPurchases1.TabIndex = 7;
            // 
            // ivInjection1
            // 
            this.ivInjection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ivInjection1.Location = new System.Drawing.Point(235, 0);
            this.ivInjection1.Name = "ivInjection1";
            this.ivInjection1.Size = new System.Drawing.Size(1131, 722);
            this.ivInjection1.TabIndex = 6;
            // 
            // ivFluids1
            // 
            this.ivFluids1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ivFluids1.Location = new System.Drawing.Point(236, 0);
            this.ivFluids1.Name = "ivFluids1";
            this.ivFluids1.Size = new System.Drawing.Size(1131, 722);
            this.ivFluids1.TabIndex = 5;
            // 
            // oralIssues1
            // 
            this.oralIssues1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oralIssues1.Location = new System.Drawing.Point(236, 0);
            this.oralIssues1.Name = "oralIssues1";
            this.oralIssues1.Size = new System.Drawing.Size(1131, 722);
            this.oralIssues1.TabIndex = 4;
            // 
            // Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.weeklyIssues1);
            this.Controls.Add(this.specialIssues1);
            this.Controls.Add(this.localPurchases1);
            this.Controls.Add(this.ivInjection1);
            this.Controls.Add(this.ivFluids1);
            this.Controls.Add(this.oralIssues1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drugs";
            this.Text = "Drugs";
            this.Load += new System.EventHandler(this.Drugs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIVInjections;
        private System.Windows.Forms.Button LocalPurchases;
        private System.Windows.Forms.Button btnspecialIssues;
        private System.Windows.Forms.Button btnOralIssues;
        private System.Windows.Forms.Button btnWeeklyIssues;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnIvFluids;
        private System.Windows.Forms.Panel panel3;
        private OralIssues oralIssues1;
        private IVFluids ivFluids1;
        private IVInjection ivInjection1;
        private LocalPurchases localPurchases1;
        private SpecialIssues specialIssues1;
        private WeeklyIssues weeklyIssues1;
    }
}