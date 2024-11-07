using System;
using System.Windows.Forms;

namespace Healtcare_Patient_Application
{
    partial class GMH 
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
            this.DrugDurationTB = new System.Windows.Forms.TextBox();
            this.DrugDurationLB = new System.Windows.Forms.Label();
            this.RHTB = new System.Windows.Forms.TextBox();
            this.BloodTypeTB = new System.Windows.Forms.TextBox();
            this.DrugTypeTB = new System.Windows.Forms.TextBox();
            this.DrugTB = new System.Windows.Forms.TextBox();
            this.LMPTB = new System.Windows.Forms.TextBox();
            this.AlcoholDurTB = new System.Windows.Forms.TextBox();
            this.AlcoholQuanTB = new System.Windows.Forms.TextBox();
            this.DrinkAlcoholTB = new System.Windows.Forms.TextBox();
            this.LMPStatusLB = new System.Windows.Forms.Label();
            this.TobaccoDurationTB = new System.Windows.Forms.TextBox();
            this.TobaccoQuanTB = new System.Windows.Forms.TextBox();
            this.TobaccoTB = new System.Windows.Forms.TextBox();
            this.RHLB = new System.Windows.Forms.Label();
            this.BloodTypeLB = new System.Windows.Forms.Label();
            this.DrugTypeLB = new System.Windows.Forms.Label();
            this.DrugLB = new System.Windows.Forms.Label();
            this.AlcoholDurationLB = new System.Windows.Forms.Label();
            this.AlcoholQuanLB = new System.Windows.Forms.Label();
            this.AlcoholLB = new System.Windows.Forms.Label();
            this.TobaccoDurationLB = new System.Windows.Forms.Label();
            this.TobaccoQuantityLB = new System.Windows.Forms.Label();
            this.TobaccoLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MensesMonthlyNochoice = new System.Windows.Forms.CheckBox();
            this.MensesNoLB = new System.Windows.Forms.Label();
            this.MensesMonthlyYeschoice = new System.Windows.Forms.CheckBox();
            this.DeletedCB = new System.Windows.Forms.CheckBox();
            this.DeletedLB = new System.Windows.Forms.Label();
            this.MensesFreqTB = new System.Windows.Forms.TextBox();
            this.MensesFreqLB = new System.Windows.Forms.Label();
            this.MedHistoryTB = new System.Windows.Forms.TextBox();
            this.MedHistoryLB = new System.Windows.Forms.Label();
            this.HXTB = new System.Windows.Forms.TextBox();
            this.HXLB = new System.Windows.Forms.Label();
            this.MenNoLB = new System.Windows.Forms.Label();
            this.BehavioralHistoryTB = new System.Windows.Forms.TextBox();
            this.BehavioralTB = new System.Windows.Forms.Label();
            this.DietaryTB = new System.Windows.Forms.TextBox();
            this.EducationLevelTB = new System.Windows.Forms.TextBox();
            this.NumChildrenTB = new System.Windows.Forms.TextBox();
            this.MaritalStatusTB = new System.Windows.Forms.TextBox();
            this.Dieta = new System.Windows.Forms.Label();
            this.NumChildrenLB = new System.Windows.Forms.Label();
            this.EducationLB = new System.Windows.Forms.Label();
            this.MaritalStatusLB = new System.Windows.Forms.Label();
            this.Patient_Name = new System.Windows.Forms.Label();
            this.AddBT = new System.Windows.Forms.Button();
            this.ModifyBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.UndoBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.GoToFamilyHistoryBT = new System.Windows.Forms.Button();
            this.PatientAgeLB = new System.Windows.Forms.Label();
            this.GoToLoginPageBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DrugDurationTB);
            this.panel1.Controls.Add(this.DrugDurationLB);
            this.panel1.Controls.Add(this.RHTB);
            this.panel1.Controls.Add(this.BloodTypeTB);
            this.panel1.Controls.Add(this.DrugTypeTB);
            this.panel1.Controls.Add(this.DrugTB);
            this.panel1.Controls.Add(this.LMPTB);
            this.panel1.Controls.Add(this.AlcoholDurTB);
            this.panel1.Controls.Add(this.AlcoholQuanTB);
            this.panel1.Controls.Add(this.DrinkAlcoholTB);
            this.panel1.Controls.Add(this.LMPStatusLB);
            this.panel1.Controls.Add(this.TobaccoDurationTB);
            this.panel1.Controls.Add(this.TobaccoQuanTB);
            this.panel1.Controls.Add(this.TobaccoTB);
            this.panel1.Controls.Add(this.RHLB);
            this.panel1.Controls.Add(this.BloodTypeLB);
            this.panel1.Controls.Add(this.DrugTypeLB);
            this.panel1.Controls.Add(this.DrugLB);
            this.panel1.Controls.Add(this.AlcoholDurationLB);
            this.panel1.Controls.Add(this.AlcoholQuanLB);
            this.panel1.Controls.Add(this.AlcoholLB);
            this.panel1.Controls.Add(this.TobaccoDurationLB);
            this.panel1.Controls.Add(this.TobaccoQuantityLB);
            this.panel1.Controls.Add(this.TobaccoLB);
            this.panel1.Location = new System.Drawing.Point(193, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 535);
            this.panel1.TabIndex = 0;
            // 
            // DrugDurationTB
            // 
            this.DrugDurationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugDurationTB.Location = new System.Drawing.Point(118, 344);
            this.DrugDurationTB.Multiline = true;
            this.DrugDurationTB.Name = "DrugDurationTB";
            this.DrugDurationTB.Size = new System.Drawing.Size(448, 41);
            this.DrugDurationTB.TabIndex = 32;
            // 
            // DrugDurationLB
            // 
            this.DrugDurationLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugDurationLB.Location = new System.Drawing.Point(12, 344);
            this.DrugDurationLB.Name = "DrugDurationLB";
            this.DrugDurationLB.Size = new System.Drawing.Size(100, 23);
            this.DrugDurationLB.TabIndex = 31;
            this.DrugDurationLB.Text = "Drug Duration";
            this.DrugDurationLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RHTB
            // 
            this.RHTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RHTB.Location = new System.Drawing.Point(118, 436);
            this.RHTB.Name = "RHTB";
            this.RHTB.Size = new System.Drawing.Size(368, 22);
            this.RHTB.TabIndex = 20;
            // 
            // BloodTypeTB
            // 
            this.BloodTypeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodTypeTB.Location = new System.Drawing.Point(118, 397);
            this.BloodTypeTB.Name = "BloodTypeTB";
            this.BloodTypeTB.Size = new System.Drawing.Size(368, 22);
            this.BloodTypeTB.TabIndex = 19;
            // 
            // DrugTypeTB
            // 
            this.DrugTypeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugTypeTB.Location = new System.Drawing.Point(118, 240);
            this.DrugTypeTB.Multiline = true;
            this.DrugTypeTB.Name = "DrugTypeTB";
            this.DrugTypeTB.Size = new System.Drawing.Size(433, 83);
            this.DrugTypeTB.TabIndex = 18;
            // 
            // DrugTB
            // 
            this.DrugTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugTB.Location = new System.Drawing.Point(118, 212);
            this.DrugTB.Name = "DrugTB";
            this.DrugTB.Size = new System.Drawing.Size(368, 22);
            this.DrugTB.TabIndex = 17;
            // 
            // LMPTB
            // 
            this.LMPTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMPTB.Location = new System.Drawing.Point(118, 464);
            this.LMPTB.Multiline = true;
            this.LMPTB.Name = "LMPTB";
            this.LMPTB.Size = new System.Drawing.Size(448, 41);
            this.LMPTB.TabIndex = 30;
            // 
            // AlcoholDurTB
            // 
            this.AlcoholDurTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoholDurTB.Location = new System.Drawing.Point(118, 184);
            this.AlcoholDurTB.Name = "AlcoholDurTB";
            this.AlcoholDurTB.Size = new System.Drawing.Size(433, 22);
            this.AlcoholDurTB.TabIndex = 16;
            // 
            // AlcoholQuanTB
            // 
            this.AlcoholQuanTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoholQuanTB.Location = new System.Drawing.Point(118, 156);
            this.AlcoholQuanTB.Name = "AlcoholQuanTB";
            this.AlcoholQuanTB.Size = new System.Drawing.Size(433, 22);
            this.AlcoholQuanTB.TabIndex = 15;
            // 
            // DrinkAlcoholTB
            // 
            this.DrinkAlcoholTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkAlcoholTB.Location = new System.Drawing.Point(118, 128);
            this.DrinkAlcoholTB.Name = "DrinkAlcoholTB";
            this.DrinkAlcoholTB.Size = new System.Drawing.Size(433, 22);
            this.DrinkAlcoholTB.TabIndex = 14;
            // 
            // LMPStatusLB
            // 
            this.LMPStatusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMPStatusLB.Location = new System.Drawing.Point(7, 464);
            this.LMPStatusLB.Name = "LMPStatusLB";
            this.LMPStatusLB.Size = new System.Drawing.Size(114, 23);
            this.LMPStatusLB.TabIndex = 27;
            this.LMPStatusLB.Text = "LMPStatus";
            this.LMPStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TobaccoDurationTB
            // 
            this.TobaccoDurationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TobaccoDurationTB.Location = new System.Drawing.Point(118, 100);
            this.TobaccoDurationTB.Name = "TobaccoDurationTB";
            this.TobaccoDurationTB.Size = new System.Drawing.Size(433, 22);
            this.TobaccoDurationTB.TabIndex = 13;
            // 
            // TobaccoQuanTB
            // 
            this.TobaccoQuanTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TobaccoQuanTB.Location = new System.Drawing.Point(118, 72);
            this.TobaccoQuanTB.Name = "TobaccoQuanTB";
            this.TobaccoQuanTB.Size = new System.Drawing.Size(433, 22);
            this.TobaccoQuanTB.TabIndex = 12;
            // 
            // TobaccoTB
            // 
            this.TobaccoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TobaccoTB.Location = new System.Drawing.Point(118, 47);
            this.TobaccoTB.Name = "TobaccoTB";
            this.TobaccoTB.Size = new System.Drawing.Size(433, 22);
            this.TobaccoTB.TabIndex = 11;
            // 
            // RHLB
            // 
            this.RHLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RHLB.Location = new System.Drawing.Point(21, 435);
            this.RHLB.Name = "RHLB";
            this.RHLB.Size = new System.Drawing.Size(100, 23);
            this.RHLB.TabIndex = 10;
            this.RHLB.Text = "RH";
            this.RHLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BloodTypeLB
            // 
            this.BloodTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodTypeLB.Location = new System.Drawing.Point(21, 396);
            this.BloodTypeLB.Name = "BloodTypeLB";
            this.BloodTypeLB.Size = new System.Drawing.Size(100, 23);
            this.BloodTypeLB.TabIndex = 9;
            this.BloodTypeLB.Text = "BloodType";
            this.BloodTypeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrugTypeLB
            // 
            this.DrugTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugTypeLB.Location = new System.Drawing.Point(23, 240);
            this.DrugTypeLB.Name = "DrugTypeLB";
            this.DrugTypeLB.Size = new System.Drawing.Size(100, 23);
            this.DrugTypeLB.TabIndex = 7;
            this.DrugTypeLB.Text = "Drug Type";
            this.DrugTypeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrugLB
            // 
            this.DrugLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugLB.Location = new System.Drawing.Point(23, 214);
            this.DrugLB.Name = "DrugLB";
            this.DrugLB.Size = new System.Drawing.Size(100, 23);
            this.DrugLB.TabIndex = 6;
            this.DrugLB.Text = "Drug";
            this.DrugLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlcoholDurationLB
            // 
            this.AlcoholDurationLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoholDurationLB.Location = new System.Drawing.Point(-6, 183);
            this.AlcoholDurationLB.Name = "AlcoholDurationLB";
            this.AlcoholDurationLB.Size = new System.Drawing.Size(118, 23);
            this.AlcoholDurationLB.TabIndex = 5;
            this.AlcoholDurationLB.Text = "Alcohol Duration";
            this.AlcoholDurationLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlcoholQuanLB
            // 
            this.AlcoholQuanLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoholQuanLB.Location = new System.Drawing.Point(5, 160);
            this.AlcoholQuanLB.Name = "AlcoholQuanLB";
            this.AlcoholQuanLB.Size = new System.Drawing.Size(100, 23);
            this.AlcoholQuanLB.TabIndex = 4;
            this.AlcoholQuanLB.Text = "Alcohol Quantity ";
            this.AlcoholQuanLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlcoholLB
            // 
            this.AlcoholLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoholLB.Location = new System.Drawing.Point(12, 131);
            this.AlcoholLB.Name = "AlcoholLB";
            this.AlcoholLB.Size = new System.Drawing.Size(100, 23);
            this.AlcoholLB.TabIndex = 3;
            this.AlcoholLB.Text = "Drink Alcohol";
            this.AlcoholLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TobaccoDurationLB
            // 
            this.TobaccoDurationLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TobaccoDurationLB.Location = new System.Drawing.Point(3, 102);
            this.TobaccoDurationLB.Name = "TobaccoDurationLB";
            this.TobaccoDurationLB.Size = new System.Drawing.Size(118, 23);
            this.TobaccoDurationLB.TabIndex = 2;
            this.TobaccoDurationLB.Text = "Tobacco Duration ";
            this.TobaccoDurationLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TobaccoQuantityLB
            // 
            this.TobaccoQuantityLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TobaccoQuantityLB.Location = new System.Drawing.Point(-3, 69);
            this.TobaccoQuantityLB.Name = "TobaccoQuantityLB";
            this.TobaccoQuantityLB.Size = new System.Drawing.Size(129, 28);
            this.TobaccoQuantityLB.TabIndex = 1;
            this.TobaccoQuantityLB.Text = "Tobacco Quantity";
            this.TobaccoQuantityLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TobaccoLB
            // 
            this.TobaccoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TobaccoLB.Location = new System.Drawing.Point(12, 46);
            this.TobaccoLB.Name = "TobaccoLB";
            this.TobaccoLB.Size = new System.Drawing.Size(100, 23);
            this.TobaccoLB.TabIndex = 0;
            this.TobaccoLB.Text = "Use Tobacco";
            this.TobaccoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MensesMonthlyNochoice);
            this.panel2.Controls.Add(this.MensesNoLB);
            this.panel2.Controls.Add(this.MensesMonthlyYeschoice);
            this.panel2.Controls.Add(this.DeletedCB);
            this.panel2.Controls.Add(this.DeletedLB);
            this.panel2.Controls.Add(this.MensesFreqTB);
            this.panel2.Controls.Add(this.MensesFreqLB);
            this.panel2.Controls.Add(this.MedHistoryTB);
            this.panel2.Controls.Add(this.MedHistoryLB);
            this.panel2.Controls.Add(this.HXTB);
            this.panel2.Controls.Add(this.HXLB);
            this.panel2.Controls.Add(this.MenNoLB);
            this.panel2.Controls.Add(this.BehavioralHistoryTB);
            this.panel2.Controls.Add(this.BehavioralTB);
            this.panel2.Controls.Add(this.DietaryTB);
            this.panel2.Controls.Add(this.EducationLevelTB);
            this.panel2.Controls.Add(this.NumChildrenTB);
            this.panel2.Controls.Add(this.MaritalStatusTB);
            this.panel2.Controls.Add(this.Dieta);
            this.panel2.Controls.Add(this.NumChildrenLB);
            this.panel2.Controls.Add(this.EducationLB);
            this.panel2.Controls.Add(this.MaritalStatusLB);
            this.panel2.Location = new System.Drawing.Point(778, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 535);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MensesMonthlyNochoice
            // 
            this.MensesMonthlyNochoice.AutoSize = true;
            this.MensesMonthlyNochoice.Location = new System.Drawing.Point(222, 276);
            this.MensesMonthlyNochoice.Name = "MensesMonthlyNochoice";
            this.MensesMonthlyNochoice.Size = new System.Drawing.Size(15, 14);
            this.MensesMonthlyNochoice.TabIndex = 43;
            this.MensesMonthlyNochoice.UseVisualStyleBackColor = true;
            // 
            // MensesNoLB
            // 
            this.MensesNoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensesNoLB.Location = new System.Drawing.Point(183, 271);
            this.MensesNoLB.Name = "MensesNoLB";
            this.MensesNoLB.Size = new System.Drawing.Size(41, 23);
            this.MensesNoLB.TabIndex = 42;
            this.MensesNoLB.Text = "No";
            this.MensesNoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MensesMonthlyYeschoice
            // 
            this.MensesMonthlyYeschoice.AutoSize = true;
            this.MensesMonthlyYeschoice.Location = new System.Drawing.Point(162, 276);
            this.MensesMonthlyYeschoice.Name = "MensesMonthlyYeschoice";
            this.MensesMonthlyYeschoice.Size = new System.Drawing.Size(15, 14);
            this.MensesMonthlyYeschoice.TabIndex = 41;
            this.MensesMonthlyYeschoice.UseVisualStyleBackColor = true;
            // 
            // DeletedCB
            // 
            this.DeletedCB.AutoSize = true;
            this.DeletedCB.Location = new System.Drawing.Point(569, 397);
            this.DeletedCB.Name = "DeletedCB";
            this.DeletedCB.Size = new System.Drawing.Size(15, 14);
            this.DeletedCB.TabIndex = 40;
            this.DeletedCB.UseVisualStyleBackColor = true;
            // 
            // DeletedLB
            // 
            this.DeletedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletedLB.Location = new System.Drawing.Point(531, 372);
            this.DeletedLB.Name = "DeletedLB";
            this.DeletedLB.Size = new System.Drawing.Size(100, 23);
            this.DeletedLB.TabIndex = 31;
            this.DeletedLB.Text = "Deleted ";
            this.DeletedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MensesFreqTB
            // 
            this.MensesFreqTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensesFreqTB.Location = new System.Drawing.Point(153, 301);
            this.MensesFreqTB.Name = "MensesFreqTB";
            this.MensesFreqTB.Size = new System.Drawing.Size(433, 22);
            this.MensesFreqTB.TabIndex = 38;
            // 
            // MensesFreqLB
            // 
            this.MensesFreqLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensesFreqLB.Location = new System.Drawing.Point(24, 300);
            this.MensesFreqLB.Name = "MensesFreqLB";
            this.MensesFreqLB.Size = new System.Drawing.Size(123, 23);
            this.MensesFreqLB.TabIndex = 37;
            this.MensesFreqLB.Text = "Menses Frequently";
            this.MensesFreqLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedHistoryTB
            // 
            this.MedHistoryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedHistoryTB.Location = new System.Drawing.Point(24, 383);
            this.MedHistoryTB.Multiline = true;
            this.MedHistoryTB.Name = "MedHistoryTB";
            this.MedHistoryTB.Size = new System.Drawing.Size(479, 65);
            this.MedHistoryTB.TabIndex = 36;
            // 
            // MedHistoryLB
            // 
            this.MedHistoryLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedHistoryLB.Location = new System.Drawing.Point(21, 357);
            this.MedHistoryLB.Name = "MedHistoryLB";
            this.MedHistoryLB.Size = new System.Drawing.Size(135, 23);
            this.MedHistoryLB.TabIndex = 35;
            this.MedHistoryLB.Text = "Medical History Notes";
            this.MedHistoryLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HXTB
            // 
            this.HXTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HXTB.Location = new System.Drawing.Point(130, 335);
            this.HXTB.Name = "HXTB";
            this.HXTB.Size = new System.Drawing.Size(433, 22);
            this.HXTB.TabIndex = 34;
            // 
            // HXLB
            // 
            this.HXLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HXLB.Location = new System.Drawing.Point(21, 334);
            this.HXLB.Name = "HXLB";
            this.HXLB.Size = new System.Drawing.Size(114, 23);
            this.HXLB.TabIndex = 33;
            this.HXLB.Text = "HXObtainedBy";
            this.HXLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenNoLB
            // 
            this.MenNoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenNoLB.Location = new System.Drawing.Point(29, 271);
            this.MenNoLB.Name = "MenNoLB";
            this.MenNoLB.Size = new System.Drawing.Size(135, 23);
            this.MenNoLB.TabIndex = 29;
            this.MenNoLB.Text = "Menses Monthly Yes";
            this.MenNoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BehavioralHistoryTB
            // 
            this.BehavioralHistoryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehavioralHistoryTB.Location = new System.Drawing.Point(130, 198);
            this.BehavioralHistoryTB.Multiline = true;
            this.BehavioralHistoryTB.Name = "BehavioralHistoryTB";
            this.BehavioralHistoryTB.Size = new System.Drawing.Size(479, 65);
            this.BehavioralHistoryTB.TabIndex = 26;
            // 
            // BehavioralTB
            // 
            this.BehavioralTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehavioralTB.Location = new System.Drawing.Point(10, 198);
            this.BehavioralTB.Name = "BehavioralTB";
            this.BehavioralTB.Size = new System.Drawing.Size(114, 23);
            this.BehavioralTB.TabIndex = 25;
            this.BehavioralTB.Text = "Behavioral History";
            this.BehavioralTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DietaryTB
            // 
            this.DietaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DietaryTB.Location = new System.Drawing.Point(130, 118);
            this.DietaryTB.Multiline = true;
            this.DietaryTB.Name = "DietaryTB";
            this.DietaryTB.Size = new System.Drawing.Size(479, 65);
            this.DietaryTB.TabIndex = 24;
            // 
            // EducationLevelTB
            // 
            this.EducationLevelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationLevelTB.Location = new System.Drawing.Point(130, 88);
            this.EducationLevelTB.Name = "EducationLevelTB";
            this.EducationLevelTB.Size = new System.Drawing.Size(433, 22);
            this.EducationLevelTB.TabIndex = 23;
            // 
            // NumChildrenTB
            // 
            this.NumChildrenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumChildrenTB.Location = new System.Drawing.Point(130, 60);
            this.NumChildrenTB.Name = "NumChildrenTB";
            this.NumChildrenTB.Size = new System.Drawing.Size(78, 22);
            this.NumChildrenTB.TabIndex = 22;
            // 
            // MaritalStatusTB
            // 
            this.MaritalStatusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaritalStatusTB.Location = new System.Drawing.Point(130, 32);
            this.MaritalStatusTB.Name = "MaritalStatusTB";
            this.MaritalStatusTB.Size = new System.Drawing.Size(433, 22);
            this.MaritalStatusTB.TabIndex = 21;
            // 
            // Dieta
            // 
            this.Dieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dieta.Location = new System.Drawing.Point(-4, 118);
            this.Dieta.Name = "Dieta";
            this.Dieta.Size = new System.Drawing.Size(135, 23);
            this.Dieta.TabIndex = 12;
            this.Dieta.Text = "Dietary Information";
            this.Dieta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumChildrenLB
            // 
            this.NumChildrenLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumChildrenLB.Location = new System.Drawing.Point(6, 59);
            this.NumChildrenLB.Name = "NumChildrenLB";
            this.NumChildrenLB.Size = new System.Drawing.Size(118, 23);
            this.NumChildrenLB.TabIndex = 11;
            this.NumChildrenLB.Text = "Number of Children";
            this.NumChildrenLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EducationLB
            // 
            this.EducationLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducationLB.Location = new System.Drawing.Point(24, 88);
            this.EducationLB.Name = "EducationLB";
            this.EducationLB.Size = new System.Drawing.Size(100, 23);
            this.EducationLB.TabIndex = 9;
            this.EducationLB.Text = "Educaton Level";
            this.EducationLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaritalStatusLB
            // 
            this.MaritalStatusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaritalStatusLB.Location = new System.Drawing.Point(24, 32);
            this.MaritalStatusLB.Name = "MaritalStatusLB";
            this.MaritalStatusLB.Size = new System.Drawing.Size(100, 23);
            this.MaritalStatusLB.TabIndex = 8;
            this.MaritalStatusLB.Text = "Marital Status";
            this.MaritalStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Patient_Name
            // 
            this.Patient_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Name.Location = new System.Drawing.Point(480, 18);
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.Size = new System.Drawing.Size(476, 51);
            this.Patient_Name.TabIndex = 2;
            this.Patient_Name.Text = "Patient Name";
            this.Patient_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBT
            // 
            this.AddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBT.Location = new System.Drawing.Point(326, 663);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(151, 32);
            this.AddBT.TabIndex = 3;
            this.AddBT.Text = "Add New Record";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // ModifyBT
            // 
            this.ModifyBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBT.Location = new System.Drawing.Point(559, 663);
            this.ModifyBT.Name = "ModifyBT";
            this.ModifyBT.Size = new System.Drawing.Size(151, 32);
            this.ModifyBT.TabIndex = 4;
            this.ModifyBT.Text = "Modify Record";
            this.ModifyBT.UseVisualStyleBackColor = true;
            this.ModifyBT.Click += new System.EventHandler(this.ModifyBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBT.Location = new System.Drawing.Point(792, 663);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(151, 32);
            this.SaveBT.TabIndex = 5;
            this.SaveBT.Text = "Save Record";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // UndoBT
            // 
            this.UndoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoBT.Location = new System.Drawing.Point(1001, 663);
            this.UndoBT.Name = "UndoBT";
            this.UndoBT.Size = new System.Drawing.Size(151, 32);
            this.UndoBT.TabIndex = 6;
            this.UndoBT.Text = "Undo Changes";
            this.UndoBT.UseVisualStyleBackColor = true;
            this.UndoBT.Click += new System.EventHandler(this.UndoBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBT.Location = new System.Drawing.Point(1225, 663);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(151, 32);
            this.DeleteBT.TabIndex = 7;
            this.DeleteBT.Text = "Delete Record";
            this.DeleteBT.UseVisualStyleBackColor = true;
            // 
            // GoToFamilyHistoryBT
            // 
            this.GoToFamilyHistoryBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToFamilyHistoryBT.Location = new System.Drawing.Point(32, 109);
            this.GoToFamilyHistoryBT.Name = "GoToFamilyHistoryBT";
            this.GoToFamilyHistoryBT.Size = new System.Drawing.Size(126, 44);
            this.GoToFamilyHistoryBT.TabIndex = 8;
            this.GoToFamilyHistoryBT.Text = "Go To Family History";
            this.GoToFamilyHistoryBT.UseVisualStyleBackColor = true;
            this.GoToFamilyHistoryBT.Click += new System.EventHandler(this.GoToFamilyHistoryBT_Click);
            // 
            // PatientAgeLB
            // 
            this.PatientAgeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLB.Location = new System.Drawing.Point(962, 18);
            this.PatientAgeLB.Name = "PatientAgeLB";
            this.PatientAgeLB.Size = new System.Drawing.Size(169, 49);
            this.PatientAgeLB.TabIndex = 11;
            this.PatientAgeLB.Text = "Patient\'s Age";
            this.PatientAgeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToLoginPageBT
            // 
            this.GoToLoginPageBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToLoginPageBT.Location = new System.Drawing.Point(32, 177);
            this.GoToLoginPageBT.Name = "GoToLoginPageBT";
            this.GoToLoginPageBT.Size = new System.Drawing.Size(126, 44);
            this.GoToLoginPageBT.TabIndex = 12;
            this.GoToLoginPageBT.Text = "Go To Login Page";
            this.GoToLoginPageBT.UseVisualStyleBackColor = true;
            this.GoToLoginPageBT.Click += new System.EventHandler(this.GoToLoginPageBT_Click);
            // 
            // GMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1689, 719);
            this.Controls.Add(this.GoToLoginPageBT);
            this.Controls.Add(this.PatientAgeLB);
            this.Controls.Add(this.GoToFamilyHistoryBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.UndoBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.ModifyBT);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.Patient_Name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GMH";
            this.Text = "General Medical History";
            this.Load += new System.EventHandler(this.GMH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Patient_Name;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button ModifyBT;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button UndoBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Label TobaccoLB;
        private System.Windows.Forms.Label TobaccoQuantityLB;
        private System.Windows.Forms.Label AlcoholLB;
        private System.Windows.Forms.Label TobaccoDurationLB;
        private System.Windows.Forms.Label AlcoholDurationLB;
        private System.Windows.Forms.Label AlcoholQuanLB;
        private System.Windows.Forms.Label MaritalStatusLB;
        private System.Windows.Forms.Label DrugTypeLB;
        private System.Windows.Forms.Label DrugLB;
        private System.Windows.Forms.Label RHLB;
        private System.Windows.Forms.Label BloodTypeLB;
        private System.Windows.Forms.TextBox TobaccoTB;
        private System.Windows.Forms.TextBox AlcoholDurTB;
        private System.Windows.Forms.TextBox AlcoholQuanTB;
        private System.Windows.Forms.TextBox DrinkAlcoholTB;
        private System.Windows.Forms.TextBox TobaccoDurationTB;
        private System.Windows.Forms.TextBox TobaccoQuanTB;
        private System.Windows.Forms.TextBox DrugTB;
        private System.Windows.Forms.TextBox DrugTypeTB;
        private System.Windows.Forms.TextBox BloodTypeTB;
        private System.Windows.Forms.TextBox RHTB;
        private System.Windows.Forms.Label NumChildrenLB;
        private System.Windows.Forms.Label EducationLB;
        private System.Windows.Forms.Label Dieta;
        private System.Windows.Forms.TextBox EducationLevelTB;
        private System.Windows.Forms.TextBox NumChildrenTB;
        private System.Windows.Forms.TextBox MaritalStatusTB;
        private System.Windows.Forms.TextBox DietaryTB;
        private System.Windows.Forms.Label BehavioralTB;
        private System.Windows.Forms.TextBox BehavioralHistoryTB;
        private System.Windows.Forms.Label LMPStatusLB;
        private System.Windows.Forms.TextBox LMPTB;
        private System.Windows.Forms.Label HXLB;
        private System.Windows.Forms.TextBox HXTB;
        private System.Windows.Forms.Label MedHistoryLB;
        private System.Windows.Forms.TextBox MedHistoryTB;
        
        private Button GoToFamilyHistoryBT;
        private Label PatientAgeLB;
        private Button GoToLoginPageBT;
        private TextBox MensesFreqTB;
        private Label MensesFreqLB;
        private Label DeletedLB;
        private TextBox DrugDurationTB;
        private Label DrugDurationLB;
        private Label MenNoLB;
        private CheckBox DeletedCB;
        private CheckBox MensesMonthlyYeschoice;
        private CheckBox MensesMonthlyNochoice;
        private Label MensesNoLB;
    }
}

