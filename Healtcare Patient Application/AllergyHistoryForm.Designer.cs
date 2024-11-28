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
            this.AllergyEndDateDTP = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allergydatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AllergyEndDateDTP);
            this.panel1.Controls.Add(this.AllergyEndDateLB);
            this.panel1.Controls.Add(this.AllergyStartDateDTP);
            this.panel1.Controls.Add(this.deletedCB);
            this.panel1.Controls.Add(this.RecDeletedLB);
            this.panel1.Controls.Add(this.txtAllergyDescription_Text);
            this.panel1.Controls.Add(this.MajorDisordersLB);
            this.panel1.Controls.Add(this.AllergyStartDateLB);
            this.panel1.Controls.Add(this.txtAllergen_Text);
            this.panel1.Controls.Add(this.FamilyNameLB);
            this.panel1.Location = new System.Drawing.Point(216, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 369);
            this.panel1.TabIndex = 2;
            // 
            // AllergyEndDateDTP
            // 
            this.AllergyEndDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyEndDateDTP.Location = new System.Drawing.Point(158, 133);
            this.AllergyEndDateDTP.Name = "AllergyEndDateDTP";
            this.AllergyEndDateDTP.Size = new System.Drawing.Size(246, 22);
            this.AllergyEndDateDTP.TabIndex = 22;
            // 
            // AllergyEndDateLB
            // 
            this.AllergyEndDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyEndDateLB.Location = new System.Drawing.Point(3, 132);
            this.AllergyEndDateLB.Name = "AllergyEndDateLB";
            this.AllergyEndDateLB.Size = new System.Drawing.Size(149, 23);
            this.AllergyEndDateLB.TabIndex = 21;
            this.AllergyEndDateLB.Text = "Allergy End Date";
            this.AllergyEndDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllergyEndDateLB.Click += new System.EventHandler(this.AllergyEndDateLB_Click);
            // 
            // AllergyStartDateDTP
            // 
            this.AllergyStartDateDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyStartDateDTP.Location = new System.Drawing.Point(158, 97);
            this.AllergyStartDateDTP.Name = "AllergyStartDateDTP";
            this.AllergyStartDateDTP.Size = new System.Drawing.Size(246, 22);
            this.AllergyStartDateDTP.TabIndex = 20;
            // 
            // deletedCB
            // 
            this.deletedCB.AutoSize = true;
            this.deletedCB.Location = new System.Drawing.Point(146, 272);
            this.deletedCB.Name = "deletedCB";
            this.deletedCB.Size = new System.Drawing.Size(15, 14);
            this.deletedCB.TabIndex = 19;
            this.deletedCB.UseVisualStyleBackColor = true;
            // 
            // RecDeletedLB
            // 
            this.RecDeletedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecDeletedLB.Location = new System.Drawing.Point(10, 267);
            this.RecDeletedLB.Name = "RecDeletedLB";
            this.RecDeletedLB.Size = new System.Drawing.Size(130, 23);
            this.RecDeletedLB.TabIndex = 16;
            this.RecDeletedLB.Text = "Record Deleted";
            this.RecDeletedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAllergyDescription_Text
            // 
            this.txtAllergyDescription_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergyDescription_Text.Location = new System.Drawing.Point(6, 194);
            this.txtAllergyDescription_Text.Multiline = true;
            this.txtAllergyDescription_Text.Name = "txtAllergyDescription_Text";
            this.txtAllergyDescription_Text.Size = new System.Drawing.Size(528, 54);
            this.txtAllergyDescription_Text.TabIndex = 13;
            // 
            // MajorDisordersLB
            // 
            this.MajorDisordersLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorDisordersLB.Location = new System.Drawing.Point(10, 168);
            this.MajorDisordersLB.Name = "MajorDisordersLB";
            this.MajorDisordersLB.Size = new System.Drawing.Size(159, 23);
            this.MajorDisordersLB.TabIndex = 12;
            this.MajorDisordersLB.Text = "Allergy Description ";
            this.MajorDisordersLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllergyStartDateLB
            // 
            this.AllergyStartDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyStartDateLB.Location = new System.Drawing.Point(3, 97);
            this.AllergyStartDateLB.Name = "AllergyStartDateLB";
            this.AllergyStartDateLB.Size = new System.Drawing.Size(149, 23);
            this.AllergyStartDateLB.TabIndex = 6;
            this.AllergyStartDateLB.Text = "Allergy Start Date";
            this.AllergyStartDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAllergen_Text
            // 
            this.txtAllergen_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergen_Text.Location = new System.Drawing.Point(82, 12);
            this.txtAllergen_Text.Multiline = true;
            this.txtAllergen_Text.Name = "txtAllergen_Text";
            this.txtAllergen_Text.Size = new System.Drawing.Size(452, 61);
            this.txtAllergen_Text.TabIndex = 5;
            // 
            // FamilyNameLB
            // 
            this.FamilyNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameLB.Location = new System.Drawing.Point(10, 12);
            this.FamilyNameLB.Name = "FamilyNameLB";
            this.FamilyNameLB.Size = new System.Drawing.Size(66, 23);
            this.FamilyNameLB.TabIndex = 4;
            this.FamilyNameLB.Text = "Allergen";
            this.FamilyNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientNameLB
            // 
            this.PatientNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLB.Location = new System.Drawing.Point(343, 35);
            this.PatientNameLB.Name = "PatientNameLB";
            this.PatientNameLB.Size = new System.Drawing.Size(448, 45);
            this.PatientNameLB.TabIndex = 3;
            this.PatientNameLB.Text = "Patient Name";
            this.PatientNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAgeLB
            // 
            this.PatientAgeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLB.Location = new System.Drawing.Point(797, 31);
            this.PatientAgeLB.Name = "PatientAgeLB";
            this.PatientAgeLB.Size = new System.Drawing.Size(169, 49);
            this.PatientAgeLB.TabIndex = 11;
            this.PatientAgeLB.Text = "Patient\'s Age";
            this.PatientAgeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allergydatagridview
            // 
            this.allergydatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allergydatagridview.Location = new System.Drawing.Point(963, 101);
            this.allergydatagridview.Name = "allergydatagridview";
            this.allergydatagridview.Size = new System.Drawing.Size(240, 369);
            this.allergydatagridview.TabIndex = 12;
            this.allergydatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AllergyAddBT
            // 
            this.AllergyAddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyAddBT.Location = new System.Drawing.Point(216, 507);
            this.AllergyAddBT.Name = "AllergyAddBT";
            this.AllergyAddBT.Size = new System.Drawing.Size(131, 51);
            this.AllergyAddBT.TabIndex = 13;
            this.AllergyAddBT.Text = "Add Allergy Record";
            this.AllergyAddBT.UseVisualStyleBackColor = true;
            this.AllergyAddBT.Click += new System.EventHandler(this.AllergyAddBT_Click);
            // 
            // ModifyAllergyRecordBT
            // 
            this.ModifyAllergyRecordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAllergyRecordBT.Location = new System.Drawing.Point(374, 507);
            this.ModifyAllergyRecordBT.Name = "ModifyAllergyRecordBT";
            this.ModifyAllergyRecordBT.Size = new System.Drawing.Size(131, 51);
            this.ModifyAllergyRecordBT.TabIndex = 14;
            this.ModifyAllergyRecordBT.Text = "Modify Allergy Record";
            this.ModifyAllergyRecordBT.UseVisualStyleBackColor = true;
            this.ModifyAllergyRecordBT.Click += new System.EventHandler(this.ModifyAllergyRecordBT_Click);
            // 
            // SaveAllergyRecordBT
            // 
            this.SaveAllergyRecordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAllergyRecordBT.Location = new System.Drawing.Point(532, 507);
            this.SaveAllergyRecordBT.Name = "SaveAllergyRecordBT";
            this.SaveAllergyRecordBT.Size = new System.Drawing.Size(131, 51);
            this.SaveAllergyRecordBT.TabIndex = 16;
            this.SaveAllergyRecordBT.Text = "Save Allergy Record";
            this.SaveAllergyRecordBT.UseVisualStyleBackColor = true;
            this.SaveAllergyRecordBT.Click += new System.EventHandler(this.SaveAllergyRecordBT_Click);
            // 
            // AllergyUndoBT
            // 
            this.AllergyUndoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergyUndoBT.Location = new System.Drawing.Point(691, 507);
            this.AllergyUndoBT.Name = "AllergyUndoBT";
            this.AllergyUndoBT.Size = new System.Drawing.Size(112, 51);
            this.AllergyUndoBT.TabIndex = 17;
            this.AllergyUndoBT.Text = "Undo Allergy Changes";
            this.AllergyUndoBT.UseVisualStyleBackColor = true;
            this.AllergyUndoBT.Click += new System.EventHandler(this.AllergyUndoBT_Click);
            // 
            // DeleteAllergyRecordBT
            // 
            this.DeleteAllergyRecordBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllergyRecordBT.Location = new System.Drawing.Point(823, 507);
            this.DeleteAllergyRecordBT.Name = "DeleteAllergyRecordBT";
            this.DeleteAllergyRecordBT.Size = new System.Drawing.Size(143, 51);
            this.DeleteAllergyRecordBT.TabIndex = 18;
            this.DeleteAllergyRecordBT.Text = "Delete Allergy Record";
            this.DeleteAllergyRecordBT.UseVisualStyleBackColor = true;
            this.DeleteAllergyRecordBT.Click += new System.EventHandler(this.DeleteAllergyRecordBT_Click);
            // 
            // BackToPatientSelectionBT
            // 
            this.BackToPatientSelectionBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToPatientSelectionBT.Location = new System.Drawing.Point(1023, 507);
            this.BackToPatientSelectionBT.Name = "BackToPatientSelectionBT";
            this.BackToPatientSelectionBT.Size = new System.Drawing.Size(131, 51);
            this.BackToPatientSelectionBT.TabIndex = 19;
            this.BackToPatientSelectionBT.Text = "Back to Patient Selection";
            this.BackToPatientSelectionBT.UseVisualStyleBackColor = true;
            this.BackToPatientSelectionBT.Click += new System.EventHandler(this.BackToPatientSelectionBT_Click);
            // 
            // AllergyHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1237, 595);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DateTimePicker AllergyEndDateDTP;
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
    }
}