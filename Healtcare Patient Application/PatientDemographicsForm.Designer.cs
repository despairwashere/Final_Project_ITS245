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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
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
            this.lblEmergencyContactName = new System.Windows.Forms.Label();
            this.txtEmergencyContactName = new System.Windows.Forms.TextBox();
            this.lblEmergencyContactRelationship = new System.Windows.Forms.Label();
            this.txtEmergencyContactRelationship = new System.Windows.Forms.TextBox();
            this.lblEmergencyContactPhone = new System.Windows.Forms.Label();
            this.txtEmergencyContactPhone = new System.Windows.Forms.TextBox();
            this.lblInsuranceProvider = new System.Windows.Forms.Label();
            this.txtInsuranceProvider = new System.Windows.Forms.TextBox();
            this.lblPolicyNumber = new System.Windows.Forms.Label();
            this.txtPolicyNumber = new System.Windows.Forms.TextBox();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.lblKnownAllergies = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblCurrentMedications = new System.Windows.Forms.Label();
            this.txtMedications = new System.Windows.Forms.TextBox();
            this.lblMedicalConditions = new System.Windows.Forms.Label();
            this.txtMedicalConditions = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(-3, 29);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(223, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(-3, 66);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(223, 20);
            this.txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(-3, 102);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(223, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(-3, 214);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(223, 20);
            this.txtSSN.TabIndex = 3;
            this.txtSSN.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 80);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(581, 265);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 162);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(77, 500);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1042, 500);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 34);
            this.button7.TabIndex = 10;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient Demographics";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(1, 14);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 14);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(-3, 51);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(82, 14);
            this.lblMiddleName.TabIndex = 13;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(-3, 87);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 14);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(0, 123);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 14);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not to Answer"});
            this.cboGender.Location = new System.Drawing.Point(0, 139);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(221, 21);
            this.cboGender.TabIndex = 16;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(-3, 162);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(82, 14);
            this.lblDateOfBirth.TabIndex = 17;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(-3, 177);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(223, 20);
            this.dtpDateOfBirth.TabIndex = 18;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(-3, 199);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(30, 14);
            this.lblSSN.TabIndex = 19;
            this.lblSSN.Text = "SSN";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(-1, 235);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(93, 14);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(-3, 251);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(223, 20);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(-3, 272);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(89, 14);
            this.lblEmailAddress.TabIndex = 22;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(-3, 288);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(223, 20);
            this.txtEmailAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(-3, 309);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 14);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(-3, 325);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 20);
            this.txtAddress.TabIndex = 25;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(-3, 346);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 14);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(-3, 362);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(223, 20);
            this.txtCity.TabIndex = 27;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(-3, 384);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 14);
            this.lblState.TabIndex = 28;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(-3, 421);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(55, 14);
            this.lblZipCode.TabIndex = 30;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(-3, 436);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(223, 20);
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
            this.cboState.Location = new System.Drawing.Point(0, 398);
            this.cboState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(221, 21);
            this.cboState.TabIndex = 32;
            // 
            // lblEmergencyContactName
            // 
            this.lblEmergencyContactName.AutoSize = true;
            this.lblEmergencyContactName.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactName.Location = new System.Drawing.Point(986, 14);
            this.lblEmergencyContactName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmergencyContactName.Name = "lblEmergencyContactName";
            this.lblEmergencyContactName.Size = new System.Drawing.Size(158, 14);
            this.lblEmergencyContactName.TabIndex = 33;
            this.lblEmergencyContactName.Text = "Emergency Contact Name";
            // 
            // txtEmergencyContactName
            // 
            this.txtEmergencyContactName.Location = new System.Drawing.Point(989, 29);
            this.txtEmergencyContactName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmergencyContactName.Name = "txtEmergencyContactName";
            this.txtEmergencyContactName.Size = new System.Drawing.Size(213, 20);
            this.txtEmergencyContactName.TabIndex = 34;
            // 
            // lblEmergencyContactRelationship
            // 
            this.lblEmergencyContactRelationship.AutoSize = true;
            this.lblEmergencyContactRelationship.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactRelationship.Location = new System.Drawing.Point(989, 51);
            this.lblEmergencyContactRelationship.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmergencyContactRelationship.Name = "lblEmergencyContactRelationship";
            this.lblEmergencyContactRelationship.Size = new System.Drawing.Size(196, 14);
            this.lblEmergencyContactRelationship.TabIndex = 35;
            this.lblEmergencyContactRelationship.Text = "Emergency Contact Relationship";
            // 
            // txtEmergencyContactRelationship
            // 
            this.txtEmergencyContactRelationship.Location = new System.Drawing.Point(989, 65);
            this.txtEmergencyContactRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmergencyContactRelationship.Name = "txtEmergencyContactRelationship";
            this.txtEmergencyContactRelationship.Size = new System.Drawing.Size(213, 20);
            this.txtEmergencyContactRelationship.TabIndex = 36;
            // 
            // lblEmergencyContactPhone
            // 
            this.lblEmergencyContactPhone.AutoSize = true;
            this.lblEmergencyContactPhone.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactPhone.Location = new System.Drawing.Point(989, 86);
            this.lblEmergencyContactPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmergencyContactPhone.Name = "lblEmergencyContactPhone";
            this.lblEmergencyContactPhone.Size = new System.Drawing.Size(159, 14);
            this.lblEmergencyContactPhone.TabIndex = 37;
            this.lblEmergencyContactPhone.Text = "Emergency Contact Phone";
            // 
            // txtEmergencyContactPhone
            // 
            this.txtEmergencyContactPhone.Location = new System.Drawing.Point(989, 101);
            this.txtEmergencyContactPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
            this.txtEmergencyContactPhone.Size = new System.Drawing.Size(213, 20);
            this.txtEmergencyContactPhone.TabIndex = 38;
            // 
            // lblInsuranceProvider
            // 
            this.lblInsuranceProvider.AutoSize = true;
            this.lblInsuranceProvider.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceProvider.Location = new System.Drawing.Point(989, 123);
            this.lblInsuranceProvider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsuranceProvider.Name = "lblInsuranceProvider";
            this.lblInsuranceProvider.Size = new System.Drawing.Size(118, 14);
            this.lblInsuranceProvider.TabIndex = 39;
            this.lblInsuranceProvider.Text = "Insurance Provider";
            // 
            // txtInsuranceProvider
            // 
            this.txtInsuranceProvider.Location = new System.Drawing.Point(989, 140);
            this.txtInsuranceProvider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInsuranceProvider.Name = "txtInsuranceProvider";
            this.txtInsuranceProvider.Size = new System.Drawing.Size(213, 20);
            this.txtInsuranceProvider.TabIndex = 40;
            // 
            // lblPolicyNumber
            // 
            this.lblPolicyNumber.AutoSize = true;
            this.lblPolicyNumber.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyNumber.Location = new System.Drawing.Point(989, 162);
            this.lblPolicyNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPolicyNumber.Name = "lblPolicyNumber";
            this.lblPolicyNumber.Size = new System.Drawing.Size(93, 14);
            this.lblPolicyNumber.TabIndex = 41;
            this.lblPolicyNumber.Text = "Policy Number";
            // 
            // txtPolicyNumber
            // 
            this.txtPolicyNumber.Location = new System.Drawing.Point(989, 177);
            this.txtPolicyNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPolicyNumber.Name = "txtPolicyNumber";
            this.txtPolicyNumber.Size = new System.Drawing.Size(213, 20);
            this.txtPolicyNumber.TabIndex = 42;
            // 
            // lblGroupNumber
            // 
            this.lblGroupNumber.AutoSize = true;
            this.lblGroupNumber.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNumber.Location = new System.Drawing.Point(989, 199);
            this.lblGroupNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroupNumber.Name = "lblGroupNumber";
            this.lblGroupNumber.Size = new System.Drawing.Size(94, 14);
            this.lblGroupNumber.TabIndex = 43;
            this.lblGroupNumber.Text = "Group Number";
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Location = new System.Drawing.Point(989, 213);
            this.txtGroupNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(213, 20);
            this.txtGroupNumber.TabIndex = 44;
            // 
            // lblKnownAllergies
            // 
            this.lblKnownAllergies.AutoSize = true;
            this.lblKnownAllergies.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnownAllergies.Location = new System.Drawing.Point(989, 235);
            this.lblKnownAllergies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKnownAllergies.Name = "lblKnownAllergies";
            this.lblKnownAllergies.Size = new System.Drawing.Size(101, 14);
            this.lblKnownAllergies.TabIndex = 45;
            this.lblKnownAllergies.Text = "Known Allergies";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(989, 250);
            this.txtAllergies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(213, 20);
            this.txtAllergies.TabIndex = 46;
            // 
            // lblCurrentMedications
            // 
            this.lblCurrentMedications.AutoSize = true;
            this.lblCurrentMedications.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMedications.Location = new System.Drawing.Point(989, 272);
            this.lblCurrentMedications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentMedications.Name = "lblCurrentMedications";
            this.lblCurrentMedications.Size = new System.Drawing.Size(125, 14);
            this.lblCurrentMedications.TabIndex = 47;
            this.lblCurrentMedications.Text = "Current Medications";
            // 
            // txtMedications
            // 
            this.txtMedications.Location = new System.Drawing.Point(989, 287);
            this.txtMedications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.Size = new System.Drawing.Size(213, 20);
            this.txtMedications.TabIndex = 48;
            // 
            // lblMedicalConditions
            // 
            this.lblMedicalConditions.AutoSize = true;
            this.lblMedicalConditions.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalConditions.Location = new System.Drawing.Point(989, 309);
            this.lblMedicalConditions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicalConditions.Name = "lblMedicalConditions";
            this.lblMedicalConditions.Size = new System.Drawing.Size(115, 14);
            this.lblMedicalConditions.TabIndex = 49;
            this.lblMedicalConditions.Text = "Medical Conditions";
            // 
            // txtMedicalConditions
            // 
            this.txtMedicalConditions.Location = new System.Drawing.Point(989, 324);
            this.txtMedicalConditions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMedicalConditions.Name = "txtMedicalConditions";
            this.txtMedicalConditions.Size = new System.Drawing.Size(213, 20);
            this.txtMedicalConditions.TabIndex = 50;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(578, 31);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(61, 14);
            this.lblPatientID.TabIndex = 51;
            this.lblPatientID.Text = "PatientID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(538, 45);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(137, 20);
            this.txtPatientID.TabIndex = 52;
            // 
            // PatientDemographicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 598);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtMedicalConditions);
            this.Controls.Add(this.lblMedicalConditions);
            this.Controls.Add(this.txtMedications);
            this.Controls.Add(this.lblCurrentMedications);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.lblKnownAllergies);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.lblGroupNumber);
            this.Controls.Add(this.txtPolicyNumber);
            this.Controls.Add(this.lblPolicyNumber);
            this.Controls.Add(this.txtInsuranceProvider);
            this.Controls.Add(this.lblInsuranceProvider);
            this.Controls.Add(this.txtEmergencyContactPhone);
            this.Controls.Add(this.lblEmergencyContactPhone);
            this.Controls.Add(this.txtEmergencyContactRelationship);
            this.Controls.Add(this.lblEmergencyContactRelationship);
            this.Controls.Add(this.txtEmergencyContactName);
            this.Controls.Add(this.lblEmergencyContactName);
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
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientDemographicsForm";
            this.Text = "PatientDemographicsForm";
            this.Load += new System.EventHandler(this.PatientDemographicsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
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
        private System.Windows.Forms.Label lblEmergencyContactName;
        private System.Windows.Forms.TextBox txtEmergencyContactName;
        private System.Windows.Forms.Label lblEmergencyContactRelationship;
        private System.Windows.Forms.TextBox txtEmergencyContactRelationship;
        private System.Windows.Forms.Label lblEmergencyContactPhone;
        private System.Windows.Forms.TextBox txtEmergencyContactPhone;
        private System.Windows.Forms.Label lblInsuranceProvider;
        private System.Windows.Forms.TextBox txtInsuranceProvider;
        private System.Windows.Forms.Label lblPolicyNumber;
        private System.Windows.Forms.TextBox txtPolicyNumber;
        private System.Windows.Forms.Label lblGroupNumber;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.Label lblKnownAllergies;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblCurrentMedications;
        private System.Windows.Forms.TextBox txtMedications;
        private System.Windows.Forms.Label lblMedicalConditions;
        private System.Windows.Forms.TextBox txtMedicalConditions;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
    }
}