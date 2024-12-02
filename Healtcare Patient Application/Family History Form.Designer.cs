namespace Healtcare_Patient_Application
{
    partial class Family_History_Form
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
            this.LivesWithPatientCB = new System.Windows.Forms.CheckBox();
            this.deletedCB = new System.Windows.Forms.CheckBox();
            this.AliveCB = new System.Windows.Forms.CheckBox();
            this.RecDeletedLB = new System.Windows.Forms.Label();
            this.SpecificDisorderTypeTB = new System.Windows.Forms.TextBox();
            this.SpecificTypeDisorderLB = new System.Windows.Forms.Label();
            this.MajorDisordersTB = new System.Windows.Forms.TextBox();
            this.MajorDisordersLB = new System.Windows.Forms.Label();
            this.LiveswithpatientLB = new System.Windows.Forms.Label();
            this.AliveLB = new System.Windows.Forms.Label();
            this.FamilyRelationTB = new System.Windows.Forms.TextBox();
            this.RelationLB = new System.Windows.Forms.Label();
            this.FamilyNameTB = new System.Windows.Forms.TextBox();
            this.FamilyNameLB = new System.Windows.Forms.Label();
            this.PatientNameLB = new System.Windows.Forms.Label();
            this.FamHisAddBT = new System.Windows.Forms.Button();
            this.FamHisModifyBT = new System.Windows.Forms.Button();
            this.FamHisSaveBT = new System.Windows.Forms.Button();
            this.FamHisUndoBT = new System.Windows.Forms.Button();
            this.FamHisDeleteBT = new System.Windows.Forms.Button();
            this.GoToGenMedicalHistoryBT = new System.Windows.Forms.Button();
            this.PatientAgeLB = new System.Windows.Forms.Label();
            this.GoToPatientSelectionBTN = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Allergy_HistoryBTN = new System.Windows.Forms.Button();
            this.BTNPatientDemographics = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LivesWithPatientCB);
            this.panel1.Controls.Add(this.deletedCB);
            this.panel1.Controls.Add(this.AliveCB);
            this.panel1.Controls.Add(this.RecDeletedLB);
            this.panel1.Controls.Add(this.SpecificDisorderTypeTB);
            this.panel1.Controls.Add(this.SpecificTypeDisorderLB);
            this.panel1.Controls.Add(this.MajorDisordersTB);
            this.panel1.Controls.Add(this.MajorDisordersLB);
            this.panel1.Controls.Add(this.LiveswithpatientLB);
            this.panel1.Controls.Add(this.AliveLB);
            this.panel1.Controls.Add(this.FamilyRelationTB);
            this.panel1.Controls.Add(this.RelationLB);
            this.panel1.Controls.Add(this.FamilyNameTB);
            this.panel1.Controls.Add(this.FamilyNameLB);
            this.panel1.Location = new System.Drawing.Point(281, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 454);
            this.panel1.TabIndex = 1;
            // 
            // LivesWithPatientCB
            // 
            this.LivesWithPatientCB.AutoSize = true;
            this.LivesWithPatientCB.Location = new System.Drawing.Point(185, 95);
            this.LivesWithPatientCB.Margin = new System.Windows.Forms.Padding(4);
            this.LivesWithPatientCB.Name = "LivesWithPatientCB";
            this.LivesWithPatientCB.Size = new System.Drawing.Size(18, 17);
            this.LivesWithPatientCB.TabIndex = 20;
            this.LivesWithPatientCB.UseVisualStyleBackColor = true;
            // 
            // deletedCB
            // 
            this.deletedCB.AutoSize = true;
            this.deletedCB.Location = new System.Drawing.Point(185, 330);
            this.deletedCB.Margin = new System.Windows.Forms.Padding(4);
            this.deletedCB.Name = "deletedCB";
            this.deletedCB.Size = new System.Drawing.Size(18, 17);
            this.deletedCB.TabIndex = 19;
            this.deletedCB.UseVisualStyleBackColor = true;
            // 
            // AliveCB
            // 
            this.AliveCB.AutoSize = true;
            this.AliveCB.Location = new System.Drawing.Point(487, 62);
            this.AliveCB.Margin = new System.Windows.Forms.Padding(4);
            this.AliveCB.Name = "AliveCB";
            this.AliveCB.Size = new System.Drawing.Size(18, 17);
            this.AliveCB.TabIndex = 18;
            this.AliveCB.UseVisualStyleBackColor = true;
            // 
            // RecDeletedLB
            // 
            this.RecDeletedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecDeletedLB.Location = new System.Drawing.Point(4, 324);
            this.RecDeletedLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecDeletedLB.Name = "RecDeletedLB";
            this.RecDeletedLB.Size = new System.Drawing.Size(173, 28);
            this.RecDeletedLB.TabIndex = 16;
            this.RecDeletedLB.Text = "Record Deleted";
            this.RecDeletedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecificDisorderTypeTB
            // 
            this.SpecificDisorderTypeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificDisorderTypeTB.Location = new System.Drawing.Point(8, 250);
            this.SpecificDisorderTypeTB.Margin = new System.Windows.Forms.Padding(4);
            this.SpecificDisorderTypeTB.Multiline = true;
            this.SpecificDisorderTypeTB.Name = "SpecificDisorderTypeTB";
            this.SpecificDisorderTypeTB.Size = new System.Drawing.Size(703, 66);
            this.SpecificDisorderTypeTB.TabIndex = 15;
            // 
            // SpecificTypeDisorderLB
            // 
            this.SpecificTypeDisorderLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificTypeDisorderLB.Location = new System.Drawing.Point(4, 218);
            this.SpecificTypeDisorderLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpecificTypeDisorderLB.Name = "SpecificTypeDisorderLB";
            this.SpecificTypeDisorderLB.Size = new System.Drawing.Size(241, 28);
            this.SpecificTypeDisorderLB.TabIndex = 14;
            this.SpecificTypeDisorderLB.Text = "Specific Disorder Types";
            this.SpecificTypeDisorderLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MajorDisordersTB
            // 
            this.MajorDisordersTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorDisordersTB.Location = new System.Drawing.Point(8, 148);
            this.MajorDisordersTB.Margin = new System.Windows.Forms.Padding(4);
            this.MajorDisordersTB.Multiline = true;
            this.MajorDisordersTB.Name = "MajorDisordersTB";
            this.MajorDisordersTB.Size = new System.Drawing.Size(703, 66);
            this.MajorDisordersTB.TabIndex = 13;
            this.MajorDisordersTB.TextChanged += new System.EventHandler(this.MajorDisordersTB_TextChanged);
            // 
            // MajorDisordersLB
            // 
            this.MajorDisordersLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorDisordersLB.Location = new System.Drawing.Point(4, 116);
            this.MajorDisordersLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MajorDisordersLB.Name = "MajorDisordersLB";
            this.MajorDisordersLB.Size = new System.Drawing.Size(173, 28);
            this.MajorDisordersLB.TabIndex = 12;
            this.MajorDisordersLB.Text = "Major Disorders";
            this.MajorDisordersLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LiveswithpatientLB
            // 
            this.LiveswithpatientLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveswithpatientLB.Location = new System.Drawing.Point(4, 87);
            this.LiveswithpatientLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LiveswithpatientLB.Name = "LiveswithpatientLB";
            this.LiveswithpatientLB.Size = new System.Drawing.Size(173, 28);
            this.LiveswithpatientLB.TabIndex = 10;
            this.LiveswithpatientLB.Text = "Lives with Patient";
            this.LiveswithpatientLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AliveLB
            // 
            this.AliveLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliveLB.Location = new System.Drawing.Point(408, 55);
            this.AliveLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AliveLB.Name = "AliveLB";
            this.AliveLB.Size = new System.Drawing.Size(69, 28);
            this.AliveLB.TabIndex = 8;
            this.AliveLB.Text = "Alive";
            this.AliveLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FamilyRelationTB
            // 
            this.FamilyRelationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyRelationTB.Location = new System.Drawing.Point(109, 57);
            this.FamilyRelationTB.Margin = new System.Windows.Forms.Padding(4);
            this.FamilyRelationTB.Name = "FamilyRelationTB";
            this.FamilyRelationTB.Size = new System.Drawing.Size(285, 26);
            this.FamilyRelationTB.TabIndex = 7;
            // 
            // RelationLB
            // 
            this.RelationLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationLB.Location = new System.Drawing.Point(1, 55);
            this.RelationLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RelationLB.Name = "RelationLB";
            this.RelationLB.Size = new System.Drawing.Size(112, 28);
            this.RelationLB.TabIndex = 6;
            this.RelationLB.Text = "Relation";
            this.RelationLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FamilyNameTB
            // 
            this.FamilyNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameTB.Location = new System.Drawing.Point(109, 15);
            this.FamilyNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.FamilyNameTB.Name = "FamilyNameTB";
            this.FamilyNameTB.Size = new System.Drawing.Size(285, 26);
            this.FamilyNameTB.TabIndex = 5;
            // 
            // FamilyNameLB
            // 
            this.FamilyNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyNameLB.Location = new System.Drawing.Point(25, 14);
            this.FamilyNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FamilyNameLB.Name = "FamilyNameLB";
            this.FamilyNameLB.Size = new System.Drawing.Size(88, 28);
            this.FamilyNameLB.TabIndex = 4;
            this.FamilyNameLB.Text = "Name";
            this.FamilyNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientNameLB
            // 
            this.PatientNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLB.Location = new System.Drawing.Point(629, 37);
            this.PatientNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLB.Name = "PatientNameLB";
            this.PatientNameLB.Size = new System.Drawing.Size(597, 55);
            this.PatientNameLB.TabIndex = 2;
            this.PatientNameLB.Text = "Patient Name";
            this.PatientNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PatientNameLB.Click += new System.EventHandler(this.PatientName_Click);
            // 
            // FamHisAddBT
            // 
            this.FamHisAddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisAddBT.Location = new System.Drawing.Point(281, 593);
            this.FamHisAddBT.Margin = new System.Windows.Forms.Padding(4);
            this.FamHisAddBT.Name = "FamHisAddBT";
            this.FamHisAddBT.Size = new System.Drawing.Size(175, 63);
            this.FamHisAddBT.TabIndex = 3;
            this.FamHisAddBT.Text = "Add Family History Record";
            this.FamHisAddBT.UseVisualStyleBackColor = true;
            this.FamHisAddBT.Click += new System.EventHandler(this.FamHisAddBT_Click);
            // 
            // FamHisModifyBT
            // 
            this.FamHisModifyBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisModifyBT.Location = new System.Drawing.Point(496, 593);
            this.FamHisModifyBT.Margin = new System.Windows.Forms.Padding(4);
            this.FamHisModifyBT.Name = "FamHisModifyBT";
            this.FamHisModifyBT.Size = new System.Drawing.Size(181, 63);
            this.FamHisModifyBT.TabIndex = 4;
            this.FamHisModifyBT.Text = "Modify Family History Record";
            this.FamHisModifyBT.UseVisualStyleBackColor = true;
            this.FamHisModifyBT.Click += new System.EventHandler(this.FamHisModifyBT_Click);
            // 
            // FamHisSaveBT
            // 
            this.FamHisSaveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisSaveBT.Location = new System.Drawing.Point(711, 593);
            this.FamHisSaveBT.Margin = new System.Windows.Forms.Padding(4);
            this.FamHisSaveBT.Name = "FamHisSaveBT";
            this.FamHisSaveBT.Size = new System.Drawing.Size(189, 63);
            this.FamHisSaveBT.TabIndex = 5;
            this.FamHisSaveBT.Text = "Save Family History Record";
            this.FamHisSaveBT.UseVisualStyleBackColor = true;
            this.FamHisSaveBT.Click += new System.EventHandler(this.FamHisSaveBT_Click);
            // 
            // FamHisUndoBT
            // 
            this.FamHisUndoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisUndoBT.Location = new System.Drawing.Point(941, 593);
            this.FamHisUndoBT.Margin = new System.Windows.Forms.Padding(4);
            this.FamHisUndoBT.Name = "FamHisUndoBT";
            this.FamHisUndoBT.Size = new System.Drawing.Size(149, 63);
            this.FamHisUndoBT.TabIndex = 6;
            this.FamHisUndoBT.Text = "Undo Family Changes";
            this.FamHisUndoBT.UseVisualStyleBackColor = true;
            this.FamHisUndoBT.Click += new System.EventHandler(this.FamHisUndoBT_Click);
            // 
            // FamHisDeleteBT
            // 
            this.FamHisDeleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamHisDeleteBT.Location = new System.Drawing.Point(1112, 593);
            this.FamHisDeleteBT.Margin = new System.Windows.Forms.Padding(4);
            this.FamHisDeleteBT.Name = "FamHisDeleteBT";
            this.FamHisDeleteBT.Size = new System.Drawing.Size(191, 63);
            this.FamHisDeleteBT.TabIndex = 7;
            this.FamHisDeleteBT.Text = "Delete Family History Record";
            this.FamHisDeleteBT.UseVisualStyleBackColor = true;
            this.FamHisDeleteBT.Click += new System.EventHandler(this.FamHisDeleteBT_Click);
            // 
            // GoToGenMedicalHistoryBT
            // 
            this.GoToGenMedicalHistoryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToGenMedicalHistoryBT.Location = new System.Drawing.Point(32, 244);
            this.GoToGenMedicalHistoryBT.Margin = new System.Windows.Forms.Padding(4);
            this.GoToGenMedicalHistoryBT.Name = "GoToGenMedicalHistoryBT";
            this.GoToGenMedicalHistoryBT.Size = new System.Drawing.Size(168, 54);
            this.GoToGenMedicalHistoryBT.TabIndex = 9;
            this.GoToGenMedicalHistoryBT.Text = "General Medical History";
            this.GoToGenMedicalHistoryBT.UseVisualStyleBackColor = true;
            this.GoToGenMedicalHistoryBT.Click += new System.EventHandler(this.GoToGenMedicalHistoryBT_Click);
            // 
            // PatientAgeLB
            // 
            this.PatientAgeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLB.Location = new System.Drawing.Point(1235, 32);
            this.PatientAgeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientAgeLB.Name = "PatientAgeLB";
            this.PatientAgeLB.Size = new System.Drawing.Size(225, 60);
            this.PatientAgeLB.TabIndex = 10;
            this.PatientAgeLB.Text = "Patient\'s Age";
            this.PatientAgeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToPatientSelectionBTN
            // 
            this.GoToPatientSelectionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPatientSelectionBTN.Location = new System.Drawing.Point(32, 172);
            this.GoToPatientSelectionBTN.Margin = new System.Windows.Forms.Padding(4);
            this.GoToPatientSelectionBTN.Name = "GoToPatientSelectionBTN";
            this.GoToPatientSelectionBTN.Size = new System.Drawing.Size(168, 54);
            this.GoToPatientSelectionBTN.TabIndex = 13;
            this.GoToPatientSelectionBTN.Text = "Patient Selection";
            this.GoToPatientSelectionBTN.UseVisualStyleBackColor = true;
            this.GoToPatientSelectionBTN.Click += new System.EventHandler(this.GoToLoginPageBT_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1296, 123);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(320, 434);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Allergy_HistoryBTN
            // 
            this.Allergy_HistoryBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allergy_HistoryBTN.Location = new System.Drawing.Point(32, 328);
            this.Allergy_HistoryBTN.Margin = new System.Windows.Forms.Padding(4);
            this.Allergy_HistoryBTN.Name = "Allergy_HistoryBTN";
            this.Allergy_HistoryBTN.Size = new System.Drawing.Size(168, 54);
            this.Allergy_HistoryBTN.TabIndex = 17;
            this.Allergy_HistoryBTN.Text = "Allergy History";
            this.Allergy_HistoryBTN.UseVisualStyleBackColor = true;
            this.Allergy_HistoryBTN.Click += new System.EventHandler(this.Allergy_HistoryBTN_Click);
            // 
            // BTNPatientDemographics
            // 
            this.BTNPatientDemographics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPatientDemographics.Location = new System.Drawing.Point(32, 419);
            this.BTNPatientDemographics.Margin = new System.Windows.Forms.Padding(4);
            this.BTNPatientDemographics.Name = "BTNPatientDemographics";
            this.BTNPatientDemographics.Size = new System.Drawing.Size(168, 54);
            this.BTNPatientDemographics.TabIndex = 18;
            this.BTNPatientDemographics.Text = "Patient Demographics";
            this.BTNPatientDemographics.UseVisualStyleBackColor = true;
            this.BTNPatientDemographics.Click += new System.EventHandler(this.BTNPatientDemographics_Click);
            // 
            // Family_History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1704, 735);
            this.Controls.Add(this.BTNPatientDemographics);
            this.Controls.Add(this.Allergy_HistoryBTN);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.GoToPatientSelectionBTN);
            this.Controls.Add(this.PatientAgeLB);
            this.Controls.Add(this.GoToGenMedicalHistoryBT);
            this.Controls.Add(this.FamHisDeleteBT);
            this.Controls.Add(this.FamHisUndoBT);
            this.Controls.Add(this.FamHisSaveBT);
            this.Controls.Add(this.FamHisModifyBT);
            this.Controls.Add(this.FamHisAddBT);
            this.Controls.Add(this.PatientNameLB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Family_History_Form";
            this.Text = "Family History Form";
            this.Load += new System.EventHandler(this.Family_History_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PatientNameLB;
        private System.Windows.Forms.TextBox FamilyNameTB;
        private System.Windows.Forms.Label FamilyNameLB;
        private System.Windows.Forms.Label RelationLB;
        private System.Windows.Forms.Label LiveswithpatientLB;
        private System.Windows.Forms.Label AliveLB;
        private System.Windows.Forms.TextBox FamilyRelationTB;
        private System.Windows.Forms.TextBox MajorDisordersTB;
        private System.Windows.Forms.Label MajorDisordersLB;
        private System.Windows.Forms.Label RecDeletedLB;
        private System.Windows.Forms.TextBox SpecificDisorderTypeTB;
        private System.Windows.Forms.Label SpecificTypeDisorderLB;
        private System.Windows.Forms.Button FamHisAddBT;
        private System.Windows.Forms.Button FamHisModifyBT;
        private System.Windows.Forms.Button FamHisSaveBT;
        private System.Windows.Forms.Button FamHisUndoBT;
        private System.Windows.Forms.Button FamHisDeleteBT;
        private System.Windows.Forms.Button GoToGenMedicalHistoryBT;
        private System.Windows.Forms.Label PatientAgeLB;
        private System.Windows.Forms.Button GoToPatientSelectionBTN;
        private System.Windows.Forms.CheckBox AliveCB;
        private System.Windows.Forms.CheckBox deletedCB;
        private System.Windows.Forms.CheckBox LivesWithPatientCB;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Allergy_HistoryBTN;
        private System.Windows.Forms.Button BTNPatientDemographics;
    }
}