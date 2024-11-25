namespace Healtcare_Patient_Application
{
    partial class PatientDemographicsForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(-4, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(333, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(-4, 101);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(333, 26);
            this.txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(-4, 157);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(333, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(-4, 329);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(333, 26);
            this.txtSSN.TabIndex = 3;
            this.txtSSN.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(871, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(871, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(115, 769);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 54);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1563, 769);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Demographics";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(1, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 18);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(-4, 78);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(103, 18);
            this.lblMiddleName.TabIndex = 13;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(-4, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 18);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(0, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 18);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not to Answer"});
            this.comboBox1.Location = new System.Drawing.Point(0, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(-4, 249);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(102, 18);
            this.lblDateOfBirth.TabIndex = 17;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-4, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(-4, 306);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(38, 18);
            this.lblSSN.TabIndex = 19;
            this.lblSSN.Text = "SSN";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(-1, 362);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(115, 18);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(-4, 386);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(333, 26);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(-4, 419);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(110, 18);
            this.lblEmailAddress.TabIndex = 22;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(-4, 443);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(333, 26);
            this.txtEmailAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(-4, 476);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 18);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(-4, 500);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(333, 26);
            this.txtAddress.TabIndex = 25;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(-4, 533);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 18);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(-4, 557);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(333, 26);
            this.txtCity.TabIndex = 27;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(-4, 590);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 18);
            this.lblState.TabIndex = 28;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(-4, 647);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(70, 18);
            this.lblZipCode.TabIndex = 30;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(-4, 671);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(333, 26);
            this.txtZipCode.TabIndex = 31;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "Alabama",
            "",
            "Alaska",
            "",
            "Arizona",
            "",
            "Arkansas",
            "",
            "California",
            "",
            "Colorado",
            "",
            "Connecticut",
            "",
            "Delaware",
            "",
            "Florida",
            "",
            "Georgia",
            "",
            "Hawaii",
            "",
            "Idaho",
            "",
            "Illinois",
            "",
            "Indiana",
            "",
            "Iowa",
            "",
            "Kansas",
            "",
            "Kentucky",
            "",
            "Louisiana",
            "",
            "Maine",
            "",
            "Maryland",
            "",
            "Massachusetts",
            "",
            "Michigan",
            "",
            "Minnesota",
            "",
            "Mississippi",
            "",
            "Missouri",
            "",
            "Montana",
            "",
            "Nebraska",
            "",
            "Nevada",
            "",
            "New Hampshire",
            "",
            "New Jersey",
            "",
            "New Mexico",
            "",
            "New York",
            "",
            "North Carolina",
            "",
            "North Dakota",
            "",
            "Ohio",
            "",
            "Oklahoma",
            "",
            "Oregon",
            "",
            "Pennsylvania",
            "",
            "Rhode Island",
            "",
            "South Carolina",
            "",
            "South Dakota",
            "",
            "Tennessee",
            "",
            "Texas",
            "",
            "Utah",
            "",
            "Vermont",
            "",
            "Virginia",
            "",
            "Washington",
            "",
            "West Virginia",
            "",
            "Wisconsin",
            "",
            "Wyoming"});
            this.cboState.Location = new System.Drawing.Point(0, 612);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(329, 28);
            this.cboState.TabIndex = 32;
            // 
            // PatientDemographicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1802, 920);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "PatientDemographicsForm";
            this.Text = "PatientDemographicsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.ComboBox cboState;
    }
}