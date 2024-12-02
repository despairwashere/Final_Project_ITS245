namespace Healtcare_Patient_Application
{
    partial class AllergyHistoryForm
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
            this.txtAllergyEndDate = new System.Windows.Forms.TextBox();
            this.AllergyEndDateLB = new System.Windows.Forms.Label();
            this.AllergyStartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.deletedCB = new System.Windows.Forms.CheckBox();
            this.RecDeletedLB = new System.Windows.Forms.Label();
            this.txtAllergyDescription_Text = new System.Windows.Forms.TextBox();
            this.MajorDisordersLB = new System.Windows.Forms.Label();
            this.AllergyStartDateLB = new System.Windows.Forms.Label();
            this.txtAllergen_Text = new System.Windows.Forms.TextBox();
            this.FamilyNameLB = new System.Windows.Forms.Label();
            this.PatientNameLB = new System.Windows.Forms.Label();
            this.PatientAgeLB = new System.Windows.Forms.Label();
            this.allergydatagridview = new System.Windows.Forms.DataGridView();
            this.AllergyAddBT = new System.Windows.Forms.Button();
            this.ModifyAllergyRecordBT = new System.Windows.Forms.Button();
            this.SaveAllergyRecordBT = new System.Windows.Forms.Button();
            this.AllergyUndoBT = new System.Windows.Forms.Button();
            this.DeleteAllergyRecordBT = new System.Windows.Forms.Button();
            this.BackToPatientSelectionBT = new System.Windows.Forms.Button();
            this.btnPatientDemographics = new System.Windows.Forms.Button();
            this.btnGeneralMedicalHistory = new System.Windows.Forms.Button();
            this.btnFamilyHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allergydatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAllergyEndDate);
            this.panel1.Controls.Add(this.AllergyEndDateLB);
            this.panel1.Controls.Add(this.AllergyStartDateDTP);
            this.panel1.Controls.Add(this.deletedCB);
            this.panel1.Controls.Add(this.RecDeletedLB);
            this.panel1.Controls.Add(this.txtAllergyDescription_Text);
            this.panel1.Controls.Add(this.MajorDisordersLB);
            this.panel1.Controls.Add(this.AllergyStartDateLB);
            this.panel1.Controls.Add(this.txtAllergen_Text);
            this.panel1.Controls.Add(this.FamilyNameLB);
            this.panel1.Location = new System.Drawing.Point(324, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 568);
            this.panel1.TabIndex = 2;
            // 
            // txtAllergyEndDate
            // 
            this.txtAllergyEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergyEndDate.Location = new System.Drawing.Point(207, 210);
            this.txtAllergyEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAllergyEndDate.Name = "txtAllergyEndDate";
            this.txtAllergyEndDate.Size = new System.Drawing.Size(268, 31);
            this.txtAllergyEndDate.TabIndex = 22;
            // 
            // AllergyEndDateLB
            // 
            this.AllergyEndDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyEndDateLB.Location = new System.Drawing.Point(4, 202);
            this.AllergyEndDateLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllergyEndDateLB.Name = "AllergyEndDateLB";
            this.AllergyEndDateLB.Size = new System.Drawing.Size(224, 35);
            this.AllergyEndDateLB.TabIndex = 21;
            this.AllergyEndDateLB.Text = "Allergy End Date";
            this.AllergyEndDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllergyEndDateLB.Click += new System.EventHandler(this.AllergyEndDateLB_Click);
            // 
            // AllergyStartDateDTP
            // 
            this.AllergyStartDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyStartDateDTP.Location = new System.Drawing.Point(237, 149);
            this.AllergyStartDateDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllergyStartDateDTP.Name = "AllergyStartDateDTP";
            this.AllergyStartDateDTP.Size = new System.Drawing.Size(367, 30);
            this.AllergyStartDateDTP.TabIndex = 20;
            // 
            // deletedCB
            // 
            this.deletedCB.AutoSize = true;
            this.deletedCB.Location = new System.Drawing.Point(219, 418);
            this.deletedCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletedCB.Name = "deletedCB";
            this.deletedCB.Size = new System.Drawing.Size(22, 21);
            this.deletedCB.TabIndex = 19;
            this.deletedCB.UseVisualStyleBackColor = true;
            // 
            // RecDeletedLB
            // 
            this.RecDeletedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecDeletedLB.Location = new System.Drawing.Point(15, 411);
            this.RecDeletedLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecDeletedLB.Name = "RecDeletedLB";
            this.RecDeletedLB.Size = new System.Drawing.Size(195, 35);
            this.RecDeletedLB.TabIndex = 16;
            this.RecDeletedLB.Text = "Record Deleted";
            this.RecDeletedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAllergyDescription_Text
            // 
            this.txtAllergyDescription_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergyDescription_Text.Location = new System.Drawing.Point(9, 298);
            this.txtAllergyDescription_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAllergyDescription_Text.Multiline = true;
            this.txtAllergyDescription_Text.Name = "txtAllergyDescription_Text";
            this.txtAllergyDescription_Text.Size = new System.Drawing.Size(790, 82);
            this.txtAllergyDescription_Text.TabIndex = 13;
            // 
            // MajorDisordersLB
            // 
            this.MajorDisordersLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorDisordersLB.Location = new System.Drawing.Point(15, 258);
            this.MajorDisordersLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MajorDisordersLB.Name = "MajorDisordersLB";
            this.MajorDisordersLB.Size = new System.Drawing.Size(238, 35);
            this.MajorDisordersLB.TabIndex = 12;
            this.MajorDisordersLB.Text = "Allergy Description ";
            this.MajorDisordersLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllergyStartDateLB
            // 
            this.AllergyStartDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyStartDateLB.Location = new System.Drawing.Point(4, 149);
            this.AllergyStartDateLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllergyStartDateLB.Name = "AllergyStartDateLB";
            this.AllergyStartDateLB.Size = new System.Drawing.Size(224, 35);
            this.AllergyStartDateLB.TabIndex = 6;
            this.AllergyStartDateLB.Text = "Allergy Start Date";
            this.AllergyStartDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAllergen_Text
            // 
            this.txtAllergen_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergen_Text.Location = new System.Drawing.Point(123, 18);
            this.txtAllergen_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAllergen_Text.Multiline = true;
            this.txtAllergen_Text.Name = "txtAllergen_Text";
            this.txtAllergen_Text.Size = new System.Drawing.Size(676, 92);
            this.txtAllergen_Text.TabIndex = 5;
            this.txtAllergen_Text.TextChanged += new System.EventHandler(this.txtAllergen_Text_TextChanged);
            // 
            // FamilyNameLB
            // 
            this.FamilyNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameLB.Location = new System.Drawing.Point(15, 18);
            this.FamilyNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FamilyNameLB.Name = "FamilyNameLB";
            this.FamilyNameLB.Size = new System.Drawing.Size(99, 35);
            this.FamilyNameLB.TabIndex = 4;
            this.FamilyNameLB.Text = "Allergen";
            this.FamilyNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientNameLB
            // 
            this.PatientNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLB.Location = new System.Drawing.Point(514, 54);
            this.PatientNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLB.Name = "PatientNameLB";
            this.PatientNameLB.Size = new System.Drawing.Size(672, 69);
            this.PatientNameLB.TabIndex = 3;
            this.PatientNameLB.Text = "Patient Name";
            this.PatientNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAgeLB
            // 
            this.PatientAgeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLB.Location = new System.Drawing.Point(1196, 48);
            this.PatientAgeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientAgeLB.Name = "PatientAgeLB";
            this.PatientAgeLB.Size = new System.Drawing.Size(254, 75);
            this.PatientAgeLB.TabIndex = 11;
            this.PatientAgeLB.Text = "Patient\'s Age";
            this.PatientAgeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allergydatagridview
            // 
            this.allergydatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allergydatagridview.Location = new System.Drawing.Point(1444, 155);
            this.allergydatagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allergydatagridview.Name = "allergydatagridview";
            this.allergydatagridview.RowHeadersWidth = 62;
            this.allergydatagridview.Size = new System.Drawing.Size(360, 568);
            this.allergydatagridview.TabIndex = 12;
            this.allergydatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AllergyAddBT
            // 
            this.AllergyAddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyAddBT.Location = new System.Drawing.Point(324, 780);
            this.AllergyAddBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllergyAddBT.Name = "AllergyAddBT";
            this.AllergyAddBT.Size = new System.Drawing.Size(196, 78);
            this.AllergyAddBT.TabIndex = 13;
            this.AllergyAddBT.Text = "Add Allergy Record";
            this.AllergyAddBT.UseVisualStyleBackColor = true;
            this.AllergyAddBT.Click += new System.EventHandler(this.AllergyAddBT_Click);
            // 
            // ModifyAllergyRecordBT
            // 
            this.ModifyAllergyRecordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAllergyRecordBT.Location = new System.Drawing.Point(561, 780);
            this.ModifyAllergyRecordBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifyAllergyRecordBT.Name = "ModifyAllergyRecordBT";
            this.ModifyAllergyRecordBT.Size = new System.Drawing.Size(196, 78);
            this.ModifyAllergyRecordBT.TabIndex = 14;
            this.ModifyAllergyRecordBT.Text = "Modify Allergy Record";
            this.ModifyAllergyRecordBT.UseVisualStyleBackColor = true;
            this.ModifyAllergyRecordBT.Click += new System.EventHandler(this.ModifyAllergyRecordBT_Click);
            // 
            // SaveAllergyRecordBT
            // 
            this.SaveAllergyRecordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAllergyRecordBT.Location = new System.Drawing.Point(798, 780);
            this.SaveAllergyRecordBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveAllergyRecordBT.Name = "SaveAllergyRecordBT";
            this.SaveAllergyRecordBT.Size = new System.Drawing.Size(196, 78);
            this.SaveAllergyRecordBT.TabIndex = 16;
            this.SaveAllergyRecordBT.Text = "Save Allergy Record";
            this.SaveAllergyRecordBT.UseVisualStyleBackColor = true;
            this.SaveAllergyRecordBT.Click += new System.EventHandler(this.SaveAllergyRecordBT_Click);
            // 
            // AllergyUndoBT
            // 
            this.AllergyUndoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyUndoBT.Location = new System.Drawing.Point(1036, 780);
            this.AllergyUndoBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllergyUndoBT.Name = "AllergyUndoBT";
            this.AllergyUndoBT.Size = new System.Drawing.Size(168, 78);
            this.AllergyUndoBT.TabIndex = 17;
            this.AllergyUndoBT.Text = "Undo Allergy Changes";
            this.AllergyUndoBT.UseVisualStyleBackColor = true;
            this.AllergyUndoBT.Click += new System.EventHandler(this.AllergyUndoBT_Click);
            // 
            // DeleteAllergyRecordBT
            // 
            this.DeleteAllergyRecordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllergyRecordBT.Location = new System.Drawing.Point(1234, 780);
            this.DeleteAllergyRecordBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteAllergyRecordBT.Name = "DeleteAllergyRecordBT";
            this.DeleteAllergyRecordBT.Size = new System.Drawing.Size(214, 78);
            this.DeleteAllergyRecordBT.TabIndex = 18;
            this.DeleteAllergyRecordBT.Text = "Delete Allergy Record";
            this.DeleteAllergyRecordBT.UseVisualStyleBackColor = true;
            this.DeleteAllergyRecordBT.Click += new System.EventHandler(this.DeleteAllergyRecordBT_Click);
            // 
            // BackToPatientSelectionBT
            // 
            this.BackToPatientSelectionBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToPatientSelectionBT.Location = new System.Drawing.Point(13, 54);
            this.BackToPatientSelectionBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackToPatientSelectionBT.Name = "BackToPatientSelectionBT";
            this.BackToPatientSelectionBT.Size = new System.Drawing.Size(196, 78);
            this.BackToPatientSelectionBT.TabIndex = 19;
            this.BackToPatientSelectionBT.Text = "Patient Selection";
            this.BackToPatientSelectionBT.UseVisualStyleBackColor = true;
            this.BackToPatientSelectionBT.Click += new System.EventHandler(this.BackToPatientSelectionBT_Click);
            // 
            // btnPatientDemographics
            // 
            this.btnPatientDemographics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDemographics.Location = new System.Drawing.Point(13, 155);
            this.btnPatientDemographics.Name = "btnPatientDemographics";
            this.btnPatientDemographics.Size = new System.Drawing.Size(196, 78);
            this.btnPatientDemographics.TabIndex = 20;
            this.btnPatientDemographics.Text = "Patient Demographics";
            this.btnPatientDemographics.UseVisualStyleBackColor = true;
            this.btnPatientDemographics.Click += new System.EventHandler(this.btnPatientDemographics_Click);
            // 
            // btnGeneralMedicalHistory
            // 
            this.btnGeneralMedicalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralMedicalHistory.Location = new System.Drawing.Point(13, 256);
            this.btnGeneralMedicalHistory.Name = "btnGeneralMedicalHistory";
            this.btnGeneralMedicalHistory.Size = new System.Drawing.Size(196, 78);
            this.btnGeneralMedicalHistory.TabIndex = 21;
            this.btnGeneralMedicalHistory.Text = "General Medical History";
            this.btnGeneralMedicalHistory.UseVisualStyleBackColor = true;
            this.btnGeneralMedicalHistory.Click += new System.EventHandler(this.btnGeneralMedicalHistory_Click);
            // 
            // btnFamilyHistory
            // 
            this.btnFamilyHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilyHistory.Location = new System.Drawing.Point(13, 371);
            this.btnFamilyHistory.Name = "btnFamilyHistory";
            this.btnFamilyHistory.Size = new System.Drawing.Size(196, 77);
            this.btnFamilyHistory.TabIndex = 22;
            this.btnFamilyHistory.Text = "Family History";
            this.btnFamilyHistory.UseVisualStyleBackColor = true;
            this.btnFamilyHistory.Click += new System.EventHandler(this.btnFamilyHistory_Click);
            // 
            // AllergyHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1856, 915);
            this.Controls.Add(this.btnFamilyHistory);
            this.Controls.Add(this.btnGeneralMedicalHistory);
            this.Controls.Add(this.btnPatientDemographics);
            this.Controls.Add(this.BackToPatientSelectionBT);
            this.Controls.Add(this.DeleteAllergyRecordBT);
            this.Controls.Add(this.AllergyUndoBT);
            this.Controls.Add(this.SaveAllergyRecordBT);
            this.Controls.Add(this.ModifyAllergyRecordBT);
            this.Controls.Add(this.AllergyAddBT);
            this.Controls.Add(this.allergydatagridview);
            this.Controls.Add(this.PatientAgeLB);
            this.Controls.Add(this.PatientNameLB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllergyHistoryForm";
            this.Text = "AllergyHistoryForm";
            this.Load += new System.EventHandler(this.AllergyHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allergydatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox deletedCB;
        private System.Windows.Forms.Label RecDeletedLB;
        private System.Windows.Forms.TextBox txtAllergyDescription_Text;
        private System.Windows.Forms.Label MajorDisordersLB;
        private System.Windows.Forms.Label AllergyStartDateLB;
        private System.Windows.Forms.TextBox txtAllergen_Text;
        private System.Windows.Forms.Label FamilyNameLB;
        private System.Windows.Forms.DateTimePicker AllergyStartDateDTP;
        private System.Windows.Forms.Label AllergyEndDateLB;
        private System.Windows.Forms.Label PatientNameLB;
        private System.Windows.Forms.Label PatientAgeLB;
        private System.Windows.Forms.DataGridView allergydatagridview;
        private System.Windows.Forms.Button AllergyAddBT;
        private System.Windows.Forms.Button ModifyAllergyRecordBT;
        private System.Windows.Forms.Button SaveAllergyRecordBT;
        private System.Windows.Forms.Button AllergyUndoBT;
        private System.Windows.Forms.Button DeleteAllergyRecordBT;
        private System.Windows.Forms.Button BackToPatientSelectionBT;
        private System.Windows.Forms.TextBox txtAllergyEndDate;
        private System.Windows.Forms.Button btnPatientDemographics;
        private System.Windows.Forms.Button btnGeneralMedicalHistory;
        private System.Windows.Forms.Button btnFamilyHistory;
    }
}