namespace ContactManager
{
    partial class Editor
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
            save_btn = new Button();
            personType = new ComboBox();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            salutationBox = new TextBox();
            genderBox = new ComboBox();
            titleBox = new TextBox();
            mobilePhoneBox = new TextBox();
            businessPhoneBox = new TextBox();
            emailBox = new TextBox();
            privatePhoneBox = new TextBox();
            nationalityBox = new TextBox();
            streetBox = new TextBox();
            streetNumberBox = new TextBox();
            placeBox = new TextBox();
            zipCodeBox = new TextBox();
            birthdayBox = new DateTimePicker();
            label1 = new Label();
            groupBox1 = new GroupBox();
            statusBox = new CheckBox();
            groupBox2 = new GroupBox();
            socialSecurityBox = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            CustomerGroup = new GroupBox();
            customerTypeBox = new TextBox();
            ContactBox = new TextBox();
            companyNameBox = new TextBox();
            EmployeeGroup = new GroupBox();
            cadreLevelBox = new TextBox();
            employmentBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            endDateBox = new DateTimePicker();
            startDateBox = new DateTimePicker();
            roleBox = new TextBox();
            employeeNumberBox = new TextBox();
            departmentBox = new TextBox();
            TraineeGroup = new GroupBox();
            actualTraineeYearBox = new TextBox();
            traineeYearsBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            CustomerGroup.SuspendLayout();
            EmployeeGroup.SuspendLayout();
            TraineeGroup.SuspendLayout();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.Location = new Point(859, 547);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(77, 23);
            save_btn.TabIndex = 0;
            save_btn.Text = "Speichern";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // personType
            // 
            personType.FormattingEnabled = true;
            personType.Location = new Point(44, 43);
            personType.Name = "personType";
            personType.Size = new Size(100, 23);
            personType.TabIndex = 1;
            personType.Text = "Auswahl";
            personType.SelectedIndexChanged += dropbox_SelectedIndexChanged;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(44, 182);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(100, 23);
            firstNameBox.TabIndex = 2;
            firstNameBox.Text = "Vorname";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(217, 182);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(100, 23);
            lastNameBox.TabIndex = 3;
            lastNameBox.Text = "Nachname";
            lastNameBox.TextChanged += textBox2_TextChanged;
            // 
            // salutationBox
            // 
            salutationBox.Location = new Point(9, 20);
            salutationBox.Name = "salutationBox";
            salutationBox.Size = new Size(100, 23);
            salutationBox.TabIndex = 5;
            salutationBox.Text = "Anrede";
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Location = new Point(44, 144);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(100, 23);
            genderBox.TabIndex = 6;
            genderBox.Text = "Geschlecht";
            genderBox.SelectedIndexChanged += dropbox_gender_SelectedIndexChanged;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(182, 20);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(100, 23);
            titleBox.TabIndex = 7;
            titleBox.Text = "Titel";
            // 
            // mobilePhoneBox
            // 
            mobilePhoneBox.Location = new Point(158, 76);
            mobilePhoneBox.Name = "mobilePhoneBox";
            mobilePhoneBox.Size = new Size(152, 23);
            mobilePhoneBox.TabIndex = 8;
            // 
            // businessPhoneBox
            // 
            businessPhoneBox.Location = new Point(158, 52);
            businessPhoneBox.Name = "businessPhoneBox";
            businessPhoneBox.Size = new Size(152, 23);
            businessPhoneBox.TabIndex = 9;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(9, 22);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(152, 23);
            emailBox.TabIndex = 10;
            emailBox.Text = "E-Mail";
            // 
            // privatePhoneBox
            // 
            privatePhoneBox.Location = new Point(158, 102);
            privatePhoneBox.Name = "privatePhoneBox";
            privatePhoneBox.Size = new Size(152, 23);
            privatePhoneBox.TabIndex = 12;
            // 
            // nationalityBox
            // 
            nationalityBox.Location = new Point(44, 224);
            nationalityBox.Name = "nationalityBox";
            nationalityBox.Size = new Size(100, 23);
            nationalityBox.TabIndex = 13;
            nationalityBox.Text = "Nationalität";
            // 
            // streetBox
            // 
            streetBox.Location = new Point(9, 22);
            streetBox.Name = "streetBox";
            streetBox.Size = new Size(100, 23);
            streetBox.TabIndex = 14;
            streetBox.Text = "Strasse";
            // 
            // streetNumberBox
            // 
            streetNumberBox.Location = new Point(182, 22);
            streetNumberBox.Name = "streetNumberBox";
            streetNumberBox.Size = new Size(100, 23);
            streetNumberBox.TabIndex = 15;
            streetNumberBox.Text = "Hausnummer";
            // 
            // placeBox
            // 
            placeBox.Location = new Point(182, 63);
            placeBox.Name = "placeBox";
            placeBox.Size = new Size(100, 23);
            placeBox.TabIndex = 16;
            placeBox.Text = "Ort";
            // 
            // zipCodeBox
            // 
            zipCodeBox.Location = new Point(9, 63);
            zipCodeBox.Name = "zipCodeBox";
            zipCodeBox.Size = new Size(100, 23);
            zipCodeBox.TabIndex = 17;
            zipCodeBox.Text = "Postleitzahl";
            zipCodeBox.TextChanged += textBox12_TextChanged;
            // 
            // birthdayBox
            // 
            birthdayBox.Location = new Point(9, 186);
            birthdayBox.Name = "birthdayBox";
            birthdayBox.Size = new Size(229, 23);
            birthdayBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 263);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 19;
            label1.Text = "Geburtsdatum:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(statusBox);
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 77);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategorie";
            // 
            // statusBox
            // 
            statusBox.AutoSize = true;
            statusBox.Checked = true;
            statusBox.CheckState = CheckState.Checked;
            statusBox.Location = new Point(193, 32);
            statusBox.Margin = new Padding(3, 2, 3, 2);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(53, 19);
            statusBox.TabIndex = 29;
            statusBox.Text = "Aktiv";
            statusBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(socialSecurityBox);
            groupBox2.Controls.Add(birthdayBox);
            groupBox2.Controls.Add(salutationBox);
            groupBox2.Controls.Add(titleBox);
            groupBox2.Location = new Point(35, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 231);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Persönliche Daten";
            // 
            // socialSecurityBox
            // 
            socialSecurityBox.Location = new Point(182, 130);
            socialSecurityBox.Name = "socialSecurityBox";
            socialSecurityBox.Size = new Size(100, 23);
            socialSecurityBox.TabIndex = 26;
            socialSecurityBox.Text = "AHV-Nummer";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zipCodeBox);
            groupBox3.Controls.Add(streetNumberBox);
            groupBox3.Controls.Add(placeBox);
            groupBox3.Controls.Add(streetBox);
            groupBox3.Location = new Point(35, 332);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 92);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Adresse";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(privatePhoneBox);
            groupBox4.Controls.Add(mobilePhoneBox);
            groupBox4.Controls.Add(businessPhoneBox);
            groupBox4.Controls.Add(emailBox);
            groupBox4.Location = new Point(35, 430);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(314, 140);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kontakt";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 102);
            label10.Name = "label10";
            label10.Size = new Size(128, 15);
            label10.TabIndex = 22;
            label10.Text = "Telefonnummer Privat:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 76);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 21;
            label9.Text = "Mobiltelefonnummer:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 54);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 20;
            label8.Text = "Telefon (Geschäft):";
            // 
            // CustomerGroup
            // 
            CustomerGroup.Controls.Add(customerTypeBox);
            CustomerGroup.Controls.Add(ContactBox);
            CustomerGroup.Controls.Add(companyNameBox);
            CustomerGroup.Location = new Point(381, 12);
            CustomerGroup.Name = "CustomerGroup";
            CustomerGroup.Size = new Size(427, 60);
            CustomerGroup.TabIndex = 23;
            CustomerGroup.TabStop = false;
            CustomerGroup.Text = "Kundendaten";
            CustomerGroup.Enter += groupBox5_Enter;
            // 
            // customerTypeBox
            // 
            customerTypeBox.Location = new Point(227, 21);
            customerTypeBox.Name = "customerTypeBox";
            customerTypeBox.Size = new Size(100, 23);
            customerTypeBox.TabIndex = 21;
            customerTypeBox.Text = "Kundentyp";
            customerTypeBox.TextChanged += textBox15_TextChanged;
            // 
            // ContactBox
            // 
            ContactBox.Location = new Point(122, 21);
            ContactBox.Name = "ContactBox";
            ContactBox.Size = new Size(100, 23);
            ContactBox.TabIndex = 20;
            ContactBox.Text = "Ansprechperson";
            // 
            // companyNameBox
            // 
            companyNameBox.Location = new Point(17, 21);
            companyNameBox.Name = "companyNameBox";
            companyNameBox.Size = new Size(100, 23);
            companyNameBox.TabIndex = 19;
            companyNameBox.Text = "Firmenname";
            companyNameBox.TextChanged += companyNameBox_TextChanged;
            // 
            // EmployeeGroup
            // 
            EmployeeGroup.Controls.Add(cadreLevelBox);
            EmployeeGroup.Controls.Add(employmentBox);
            EmployeeGroup.Controls.Add(label5);
            EmployeeGroup.Controls.Add(label4);
            EmployeeGroup.Controls.Add(label3);
            EmployeeGroup.Controls.Add(label2);
            EmployeeGroup.Controls.Add(endDateBox);
            EmployeeGroup.Controls.Add(startDateBox);
            EmployeeGroup.Controls.Add(roleBox);
            EmployeeGroup.Controls.Add(employeeNumberBox);
            EmployeeGroup.Controls.Add(departmentBox);
            EmployeeGroup.Location = new Point(381, 88);
            EmployeeGroup.Name = "EmployeeGroup";
            EmployeeGroup.Size = new Size(427, 176);
            EmployeeGroup.TabIndex = 24;
            EmployeeGroup.TabStop = false;
            EmployeeGroup.Text = "Mitarbeiterdaten";
            EmployeeGroup.Enter += groupBox5_Enter_1;
            // 
            // cadreLevelBox
            // 
            cadreLevelBox.Location = new Point(134, 139);
            cadreLevelBox.Name = "cadreLevelBox";
            cadreLevelBox.Size = new Size(100, 23);
            cadreLevelBox.TabIndex = 30;
            cadreLevelBox.Text = "0";
            // 
            // employmentBox
            // 
            employmentBox.Location = new Point(134, 112);
            employmentBox.Name = "employmentBox";
            employmentBox.Size = new Size(100, 23);
            employmentBox.TabIndex = 29;
            employmentBox.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 137);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 28;
            label5.Text = "Kaderebene:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 112);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 27;
            label4.Text = "Anstellung:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 82);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 24;
            label3.Text = "Enddatum:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 56);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 23;
            label2.Text = "Startdatum:";
            label2.Click += label2_Click;
            // 
            // endDateBox
            // 
            endDateBox.Location = new Point(134, 82);
            endDateBox.Name = "endDateBox";
            endDateBox.Size = new Size(235, 23);
            endDateBox.TabIndex = 22;
            // 
            // startDateBox
            // 
            startDateBox.Location = new Point(134, 56);
            startDateBox.Name = "startDateBox";
            startDateBox.Size = new Size(235, 23);
            startDateBox.TabIndex = 19;
            // 
            // roleBox
            // 
            roleBox.Location = new Point(322, 21);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(100, 23);
            roleBox.TabIndex = 21;
            roleBox.Text = "Funktion";
            // 
            // employeeNumberBox
            // 
            employeeNumberBox.Location = new Point(17, 21);
            employeeNumberBox.Name = "employeeNumberBox";
            employeeNumberBox.ReadOnly = true;
            employeeNumberBox.Size = new Size(153, 23);
            employeeNumberBox.TabIndex = 20;
            employeeNumberBox.Text = "Mitarbeiternummer";
            employeeNumberBox.TextChanged += employeeNumberBox_TextChanged;
            // 
            // departmentBox
            // 
            departmentBox.Location = new Point(201, 21);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(100, 23);
            departmentBox.TabIndex = 19;
            departmentBox.Text = "Abteilung";
            // 
            // TraineeGroup
            // 
            TraineeGroup.Controls.Add(actualTraineeYearBox);
            TraineeGroup.Controls.Add(traineeYearsBox);
            TraineeGroup.Controls.Add(label7);
            TraineeGroup.Controls.Add(label6);
            TraineeGroup.Font = new Font("Segoe UI", 9F);
            TraineeGroup.Location = new Point(381, 281);
            TraineeGroup.Name = "TraineeGroup";
            TraineeGroup.Size = new Size(427, 107);
            TraineeGroup.TabIndex = 25;
            TraineeGroup.TabStop = false;
            TraineeGroup.Text = "Lehrlingsdaten";
            TraineeGroup.Visible = false;
            // 
            // actualTraineeYearBox
            // 
            actualTraineeYearBox.Location = new Point(148, 51);
            actualTraineeYearBox.Name = "actualTraineeYearBox";
            actualTraineeYearBox.Size = new Size(100, 23);
            actualTraineeYearBox.TabIndex = 32;
            actualTraineeYearBox.Text = "0";
            // 
            // traineeYearsBox
            // 
            traineeYearsBox.Location = new Point(17, 51);
            traineeYearsBox.Name = "traineeYearsBox";
            traineeYearsBox.Size = new Size(100, 23);
            traineeYearsBox.TabIndex = 31;
            traineeYearsBox.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 30);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 21;
            label7.Text = "Lehrlingsjahr:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 30);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 20;
            label6.Text = "Lehrlingsjahre:";
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(948, 582);
            Controls.Add(EmployeeGroup);
            Controls.Add(TraineeGroup);
            Controls.Add(CustomerGroup);
            Controls.Add(label1);
            Controls.Add(nationalityBox);
            Controls.Add(genderBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(personType);
            Controls.Add(save_btn);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Name = "Editor";
            Text = "Editor";
            Load += Editor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            CustomerGroup.ResumeLayout(false);
            CustomerGroup.PerformLayout();
            EmployeeGroup.ResumeLayout(false);
            EmployeeGroup.PerformLayout();
            TraineeGroup.ResumeLayout(false);
            TraineeGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_btn;
        private ComboBox personType;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox salutationBox;
        private ComboBox genderBox;
        private TextBox titleBox;
        private TextBox mobilePhoneBox;
        private TextBox businessPhoneBox;
        private TextBox emailBox;
        private TextBox privatePhoneBox;
        private TextBox nationalityBox;
        private TextBox streetBox;
        private TextBox streetNumberBox;
        private TextBox placeBox;
        private TextBox zipCodeBox;
        private DateTimePicker birthdayBox;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox CustomerGroup;
        private TextBox ContactBox;
        private TextBox companyNameBox;
        private TextBox customerTypeBox;
        private GroupBox EmployeeGroup;
        private TextBox roleBox;
        private TextBox employeeNumberBox;
        private TextBox departmentBox;
        private Label label2;
        private DateTimePicker endDateBox;
        private DateTimePicker startDateBox;
        private Label label3;
        private Label label5;
        private Label label4;
        private GroupBox TraineeGroup;
        private Label label7;
        private Label label6;
        private CheckBox statusBox;
        private TextBox cadreLevelBox;
        private TextBox employmentBox;
        private TextBox actualTraineeYearBox;
        private TextBox traineeYearsBox;
        private TextBox socialSecurityBox;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}