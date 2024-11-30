namespace Healtcare_Patient_Application
{
    partial class PatientSelectionForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGoToDemographics = new System.Windows.Forms.Button();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnExitToLogin = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.btnSelectPatient = new System.Windows.Forms.Button();
            this.GoToAllergyFormBT = new System.Windows.Forms.Button();
            this.GoToGMHBT = new System.Windows.Forms.Button();
            this.GoToFamilyHistoryBT = new System.Windows.Forms.Button();
            this.PatientSummaryBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PatientID",
            "PtLastName",
            "HospitalMR#",
            "PtHomePhone"});
            this.comboBox1.Location = new System.Drawing.Point(599, 131);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnGoToDemographics
            // 
            this.btnGoToDemographics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDemographics.Location = new System.Drawing.Point(993, 537);
            this.btnGoToDemographics.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToDemographics.Name = "btnGoToDemographics";
            this.btnGoToDemographics.Size = new System.Drawing.Size(185, 43);
            this.btnGoToDemographics.TabIndex = 1;
            this.btnGoToDemographics.Text = "Go To Demographics";
            this.btnGoToDemographics.UseVisualStyleBackColor = true;
            this.btnGoToDemographics.Click += new System.EventHandler(this.btnGoToDemographics_Click);
            // 
            // txtFromName
            // 
            this.txtFromName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFromName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromName.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtFromName.Location = new System.Drawing.Point(415, 20);
            this.txtFromName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.Size = new System.Drawing.Size(431, 25);
            this.txtFromName.TabIndex = 5;
            this.txtFromName.Text = "Patient Selection";
            this.txtFromName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(218, 129);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 19);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Search Patients:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExitToLogin
            // 
            this.btnExitToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitToLogin.Location = new System.Drawing.Point(49, 537);
            this.btnExitToLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitToLogin.Name = "btnExitToLogin";
            this.btnExitToLogin.Size = new System.Drawing.Size(104, 43);
            this.btnExitToLogin.TabIndex = 9;
            this.btnExitToLogin.Text = "Exit to Login";
            this.btnExitToLogin.UseVisualStyleBackColor = true;
            this.btnExitToLogin.Click += new System.EventHandler(this.btnExitToLogin_Click);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.Location = new System.Drawing.Point(829, 131);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(95, 21);
            this.btnSearchPatient.TabIndex = 10;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(370, 131);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(227, 20);
            this.txtSearchPatient.TabIndex = 11;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(381, 171);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersWidth = 62;
            this.dataGridViewPatients.RowTemplate.Height = 28;
            this.dataGridViewPatients.Size = new System.Drawing.Size(543, 289);
            this.dataGridViewPatients.TabIndex = 12;
            this.dataGridViewPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellContentClick);
            // 
            // btnSelectPatient
            // 
            this.btnSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPatient.Location = new System.Drawing.Point(576, 464);
            this.btnSelectPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectPatient.Name = "btnSelectPatient";
            this.btnSelectPatient.Size = new System.Drawing.Size(136, 30);
            this.btnSelectPatient.TabIndex = 13;
            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.UseVisualStyleBackColor = true;
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);
            // 
            // GoToAllergyFormBT
            // 
            this.GoToAllergyFormBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToAllergyFormBT.Location = new System.Drawing.Point(49, 367);
            this.GoToAllergyFormBT.Margin = new System.Windows.Forms.Padding(2);
            this.GoToAllergyFormBT.Name = "GoToAllergyFormBT";
            this.GoToAllergyFormBT.Size = new System.Drawing.Size(104, 43);
            this.GoToAllergyFormBT.TabIndex = 14;
            this.GoToAllergyFormBT.Text = "Allergy Records";
            this.GoToAllergyFormBT.UseVisualStyleBackColor = true;
            this.GoToAllergyFormBT.Click += new System.EventHandler(this.GoToAllergyFormBT_Click);
            // 
            // GoToGMHBT
            // 
            this.GoToGMHBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToGMHBT.Location = new System.Drawing.Point(49, 293);
            this.GoToGMHBT.Margin = new System.Windows.Forms.Padding(2);
            this.GoToGMHBT.Name = "GoToGMHBT";
            this.GoToGMHBT.Size = new System.Drawing.Size(104, 43);
            this.GoToGMHBT.TabIndex = 15;
            this.GoToGMHBT.Text = "General Medical History";
            this.GoToGMHBT.UseVisualStyleBackColor = true;
            this.GoToGMHBT.Click += new System.EventHandler(this.GoToGMHBT_Click);
            // 
            // GoToFamilyHistoryBT
            // 
            this.GoToFamilyHistoryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToFamilyHistoryBT.Location = new System.Drawing.Point(49, 229);
            this.GoToFamilyHistoryBT.Margin = new System.Windows.Forms.Padding(2);
            this.GoToFamilyHistoryBT.Name = "GoToFamilyHistoryBT";
            this.GoToFamilyHistoryBT.Size = new System.Drawing.Size(104, 43);
            this.GoToFamilyHistoryBT.TabIndex = 16;
            this.GoToFamilyHistoryBT.Text = "Family History";
            this.GoToFamilyHistoryBT.UseVisualStyleBackColor = true;
            this.GoToFamilyHistoryBT.Click += new System.EventHandler(this.GoToFamilyHistoryBT_Click);
            // 
            // PatientSummaryBT
            // 
            this.PatientSummaryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientSummaryBT.Location = new System.Drawing.Point(993, 475);
            this.PatientSummaryBT.Margin = new System.Windows.Forms.Padding(2);
            this.PatientSummaryBT.Name = "PatientSummaryBT";
            this.PatientSummaryBT.Size = new System.Drawing.Size(185, 43);
            this.PatientSummaryBT.TabIndex = 17;
            this.PatientSummaryBT.Text = "Patient Summary";
            this.PatientSummaryBT.UseVisualStyleBackColor = true;
            this.PatientSummaryBT.Click += new System.EventHandler(this.PatientSummaryBT_Click);
            // 
            // PatientSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 593);
            this.Controls.Add(this.PatientSummaryBT);
            this.Controls.Add(this.GoToFamilyHistoryBT);
            this.Controls.Add(this.GoToGMHBT);
            this.Controls.Add(this.GoToAllergyFormBT);
            this.Controls.Add(this.btnSelectPatient);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.btnExitToLogin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtFromName);
            this.Controls.Add(this.btnGoToDemographics);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientSelectionForm";
            this.Text = "PatientSelectionForm";
            this.Load += new System.EventHandler(this.PatientSelectionForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGoToDemographics;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnExitToLogin;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button btnSelectPatient;
        private System.Windows.Forms.Button GoToAllergyFormBT;
        private System.Windows.Forms.Button GoToGMHBT;
        private System.Windows.Forms.Button GoToFamilyHistoryBT;
        private System.Windows.Forms.Button PatientSummaryBT;
    }
}