namespace ContactManager
{
    partial class Reader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.DataGridView notesGrid;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            statusBox = new CheckBox();
            label1 = new Label();
            genderBox = new TextBox();
            nationalityBox = new TextBox();
            socialSecurityBox = new TextBox();
            lastNameBox = new TextBox();
            birthdayBox = new DateTimePicker();
            firstNameBox = new TextBox();
            salutationBox = new TextBox();
            titleBox = new TextBox();
            groupBox3 = new GroupBox();
            zipCodeBox = new TextBox();
            streetNumberBox = new TextBox();
            placeBox = new TextBox();
            streetBox = new TextBox();
            groupBox4 = new GroupBox();
            privatePhoneBox = new TextBox();
            mobilePhoneBox = new TextBox();
            businessPhoneBox = new TextBox();
            emailBox = new TextBox();
            EmployeeGroup = new GroupBox();
            cadreLevelBox = new TextBox();
            employmentBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            endDateBox = new DateTimePicker();
            startDateBox = new DateTimePicker();
            roleBox = new TextBox();
            employeeNumberBox = new TextBox();
            departmentBox = new TextBox();
            TraineeGroup = new GroupBox();
            actualTraineeYearBox = new TextBox();
            traineeYearsBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            CustomerGroup = new GroupBox();
            customerTypeBox = new TextBox();
            ContactBox = new TextBox();
            companyNameBox = new TextBox();
            noteAddBtn = new Button();
            noteBox = new TextBox();
            notesLabel = new Label();
            notesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            EmployeeGroup.SuspendLayout();
            TraineeGroup.SuspendLayout();
            CustomerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notesGrid).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox4);
            splitContainer1.Panel1.Controls.Add(EmployeeGroup);
            splitContainer1.Panel1.Controls.Add(TraineeGroup);
            splitContainer1.Panel1.Controls.Add(CustomerGroup);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Panel2.Controls.Add(noteAddBtn);
            splitContainer1.Panel2.Controls.Add(noteBox);
            splitContainer1.Panel2.Controls.Add(notesLabel);
            splitContainer1.Panel2.Controls.Add(notesGrid);
            splitContainer1.Size = new Size(1582, 853);
            splitContainer1.SplitterDistance = 791;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(statusBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(genderBox);
            groupBox2.Controls.Add(nationalityBox);
            groupBox2.Controls.Add(socialSecurityBox);
            groupBox2.Controls.Add(lastNameBox);
            groupBox2.Controls.Add(birthdayBox);
            groupBox2.Controls.Add(firstNameBox);
            groupBox2.Controls.Add(salutationBox);
            groupBox2.Controls.Add(titleBox);
            groupBox2.Location = new Point(31, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(718, 247);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Persönliche Daten";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // statusBox
            // 
            statusBox.AutoSize = true;
            statusBox.Checked = true;
            statusBox.CheckState = CheckState.Checked;
            statusBox.Location = new Point(605, 30);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(53, 19);
            statusBox.TabIndex = 39;
            statusBox.Text = "Aktiv";
            statusBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 167);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 36;
            label1.Text = "Geburtsdatum:";
            // 
            // genderBox
            // 
            genderBox.Location = new Point(368, 28);
            genderBox.Margin = new Padding(3, 4, 3, 4);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(114, 23);
            genderBox.TabIndex = 38;
            // 
            // nationalityBox
            // 
            nationalityBox.Location = new Point(10, 120);
            nationalityBox.Margin = new Padding(3, 4, 3, 4);
            nationalityBox.Name = "nationalityBox";
            nationalityBox.Size = new Size(114, 23);
            nationalityBox.TabIndex = 35;
            nationalityBox.Text = "Nationalität";
            nationalityBox.TextChanged += nationalityBox_TextChanged;
            // 
            // socialSecurityBox
            // 
            socialSecurityBox.Location = new Point(211, 120);
            socialSecurityBox.Margin = new Padding(3, 4, 3, 4);
            socialSecurityBox.Name = "socialSecurityBox";
            socialSecurityBox.Size = new Size(114, 23);
            socialSecurityBox.TabIndex = 26;
            socialSecurityBox.Text = "AHV-Nummer";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(211, 71);
            lastNameBox.Margin = new Padding(3, 4, 3, 4);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(114, 23);
            lastNameBox.TabIndex = 33;
            lastNameBox.Text = "Nachname";
            // 
            // birthdayBox
            // 
            birthdayBox.Location = new Point(10, 191);
            birthdayBox.Margin = new Padding(3, 4, 3, 4);
            birthdayBox.Name = "birthdayBox";
            birthdayBox.Size = new Size(228, 23);
            birthdayBox.TabIndex = 18;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(10, 71);
            firstNameBox.Margin = new Padding(3, 4, 3, 4);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(114, 23);
            firstNameBox.TabIndex = 32;
            firstNameBox.Text = "Vorname";
            // 
            // salutationBox
            // 
            salutationBox.Location = new Point(10, 27);
            salutationBox.Margin = new Padding(3, 4, 3, 4);
            salutationBox.Name = "salutationBox";
            salutationBox.Size = new Size(114, 23);
            salutationBox.TabIndex = 5;
            salutationBox.Text = "Anrede";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(211, 27);
            titleBox.Margin = new Padding(3, 4, 3, 4);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(114, 23);
            titleBox.TabIndex = 7;
            titleBox.Text = "Titel";
            titleBox.TextChanged += titleBox_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(zipCodeBox);
            groupBox3.Controls.Add(streetNumberBox);
            groupBox3.Controls.Add(placeBox);
            groupBox3.Controls.Add(streetBox);
            groupBox3.Location = new Point(399, 281);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(359, 162);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Adresse";
            // 
            // zipCodeBox
            // 
            zipCodeBox.Location = new Point(10, 84);
            zipCodeBox.Margin = new Padding(3, 4, 3, 4);
            zipCodeBox.Name = "zipCodeBox";
            zipCodeBox.Size = new Size(114, 23);
            zipCodeBox.TabIndex = 17;
            zipCodeBox.Text = "Postleitzahl";
            // 
            // streetNumberBox
            // 
            streetNumberBox.Location = new Point(208, 29);
            streetNumberBox.Margin = new Padding(3, 4, 3, 4);
            streetNumberBox.Name = "streetNumberBox";
            streetNumberBox.Size = new Size(114, 23);
            streetNumberBox.TabIndex = 15;
            streetNumberBox.Text = "Hausnummer";
            // 
            // placeBox
            // 
            placeBox.Location = new Point(208, 84);
            placeBox.Margin = new Padding(3, 4, 3, 4);
            placeBox.Name = "placeBox";
            placeBox.Size = new Size(114, 23);
            placeBox.TabIndex = 16;
            placeBox.Text = "Ort";
            // 
            // streetBox
            // 
            streetBox.Location = new Point(10, 29);
            streetBox.Margin = new Padding(3, 4, 3, 4);
            streetBox.Name = "streetBox";
            streetBox.Size = new Size(114, 23);
            streetBox.TabIndex = 14;
            streetBox.Text = "Strasse";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(privatePhoneBox);
            groupBox4.Controls.Add(mobilePhoneBox);
            groupBox4.Controls.Add(businessPhoneBox);
            groupBox4.Controls.Add(emailBox);
            groupBox4.Location = new Point(31, 268);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(359, 176);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kontakt";
            // 
            // privatePhoneBox
            // 
            privatePhoneBox.Location = new Point(10, 148);
            privatePhoneBox.Margin = new Padding(3, 4, 3, 4);
            privatePhoneBox.Name = "privatePhoneBox";
            privatePhoneBox.Size = new Size(173, 23);
            privatePhoneBox.TabIndex = 12;
            privatePhoneBox.Text = "Telefonnummer Privat";
            // 
            // mobilePhoneBox
            // 
            mobilePhoneBox.Location = new Point(10, 109);
            mobilePhoneBox.Margin = new Padding(3, 4, 3, 4);
            mobilePhoneBox.Name = "mobilePhoneBox";
            mobilePhoneBox.Size = new Size(173, 23);
            mobilePhoneBox.TabIndex = 8;
            mobilePhoneBox.Text = "Mobiltelefonnummer";
            // 
            // businessPhoneBox
            // 
            businessPhoneBox.Location = new Point(10, 71);
            businessPhoneBox.Margin = new Padding(3, 4, 3, 4);
            businessPhoneBox.Name = "businessPhoneBox";
            businessPhoneBox.Size = new Size(173, 23);
            businessPhoneBox.TabIndex = 9;
            businessPhoneBox.Text = "Telefon (Geschäft)";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(10, 29);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(173, 23);
            emailBox.TabIndex = 10;
            emailBox.Text = "E-Mail";
            // 
            // EmployeeGroup
            // 
            EmployeeGroup.Controls.Add(cadreLevelBox);
            EmployeeGroup.Controls.Add(employmentBox);
            EmployeeGroup.Controls.Add(label8);
            EmployeeGroup.Controls.Add(label9);
            EmployeeGroup.Controls.Add(label10);
            EmployeeGroup.Controls.Add(label11);
            EmployeeGroup.Controls.Add(endDateBox);
            EmployeeGroup.Controls.Add(startDateBox);
            EmployeeGroup.Controls.Add(roleBox);
            EmployeeGroup.Controls.Add(employeeNumberBox);
            EmployeeGroup.Controls.Add(departmentBox);
            EmployeeGroup.Location = new Point(12, 475);
            EmployeeGroup.Margin = new Padding(3, 4, 3, 4);
            EmployeeGroup.Name = "EmployeeGroup";
            EmployeeGroup.Padding = new Padding(3, 4, 3, 4);
            EmployeeGroup.Size = new Size(501, 237);
            EmployeeGroup.TabIndex = 27;
            EmployeeGroup.TabStop = false;
            EmployeeGroup.Text = "Mitarbeiterdaten";
            // 
            // cadreLevelBox
            // 
            cadreLevelBox.Location = new Point(153, 185);
            cadreLevelBox.Margin = new Padding(3, 4, 3, 4);
            cadreLevelBox.Name = "cadreLevelBox";
            cadreLevelBox.Size = new Size(114, 23);
            cadreLevelBox.TabIndex = 30;
            cadreLevelBox.Text = "0";
            // 
            // employmentBox
            // 
            employmentBox.Location = new Point(153, 150);
            employmentBox.Margin = new Padding(3, 4, 3, 4);
            employmentBox.Name = "employmentBox";
            employmentBox.Size = new Size(114, 23);
            employmentBox.TabIndex = 29;
            employmentBox.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 184);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 28;
            label8.Text = "Kaderebene:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 151);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 27;
            label9.Text = "Anstellung:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 110);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 24;
            label10.Text = "Enddatum:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 75);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 23;
            label11.Text = "Startdatum:";
            // 
            // endDateBox
            // 
            endDateBox.Location = new Point(153, 109);
            endDateBox.Margin = new Padding(3, 4, 3, 4);
            endDateBox.Name = "endDateBox";
            endDateBox.Size = new Size(271, 23);
            endDateBox.TabIndex = 22;
            // 
            // startDateBox
            // 
            startDateBox.Location = new Point(153, 74);
            startDateBox.Margin = new Padding(3, 4, 3, 4);
            startDateBox.Name = "startDateBox";
            startDateBox.Size = new Size(271, 23);
            startDateBox.TabIndex = 19;
            // 
            // roleBox
            // 
            roleBox.Location = new Point(368, 28);
            roleBox.Margin = new Padding(3, 4, 3, 4);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(114, 23);
            roleBox.TabIndex = 21;
            roleBox.Text = "Funktion";
            // 
            // employeeNumberBox
            // 
            employeeNumberBox.Location = new Point(19, 28);
            employeeNumberBox.Margin = new Padding(3, 4, 3, 4);
            employeeNumberBox.Name = "employeeNumberBox";
            employeeNumberBox.ReadOnly = true;
            employeeNumberBox.Size = new Size(205, 23);
            employeeNumberBox.TabIndex = 20;
            employeeNumberBox.Text = "Mitarbeiternummer";
            // 
            // departmentBox
            // 
            departmentBox.Location = new Point(230, 28);
            departmentBox.Margin = new Padding(3, 4, 3, 4);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(114, 23);
            departmentBox.TabIndex = 19;
            departmentBox.Text = "Abteilung";
            // 
            // TraineeGroup
            // 
            TraineeGroup.Controls.Add(actualTraineeYearBox);
            TraineeGroup.Controls.Add(traineeYearsBox);
            TraineeGroup.Controls.Add(label12);
            TraineeGroup.Controls.Add(label13);
            TraineeGroup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TraineeGroup.Location = new Point(3, 730);
            TraineeGroup.Margin = new Padding(3, 4, 3, 4);
            TraineeGroup.Name = "TraineeGroup";
            TraineeGroup.Padding = new Padding(3, 4, 3, 4);
            TraineeGroup.Size = new Size(310, 110);
            TraineeGroup.TabIndex = 28;
            TraineeGroup.TabStop = false;
            TraineeGroup.Text = "Lehrlingsdaten";
            TraineeGroup.Visible = false;
            // 
            // actualTraineeYearBox
            // 
            actualTraineeYearBox.Location = new Point(169, 68);
            actualTraineeYearBox.Margin = new Padding(3, 4, 3, 4);
            actualTraineeYearBox.Name = "actualTraineeYearBox";
            actualTraineeYearBox.Size = new Size(114, 23);
            actualTraineeYearBox.TabIndex = 32;
            actualTraineeYearBox.Text = "0";
            // 
            // traineeYearsBox
            // 
            traineeYearsBox.Location = new Point(19, 68);
            traineeYearsBox.Margin = new Padding(3, 4, 3, 4);
            traineeYearsBox.Name = "traineeYearsBox";
            traineeYearsBox.Size = new Size(114, 23);
            traineeYearsBox.TabIndex = 31;
            traineeYearsBox.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(169, 41);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 21;
            label12.Text = "Lehrlingsjahr:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 41);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 20;
            label13.Text = "Lehrlingsjahre:";
            // 
            // CustomerGroup
            // 
            CustomerGroup.Controls.Add(customerTypeBox);
            CustomerGroup.Controls.Add(ContactBox);
            CustomerGroup.Controls.Add(companyNameBox);
            CustomerGroup.Location = new Point(519, 676);
            CustomerGroup.Margin = new Padding(3, 4, 3, 4);
            CustomerGroup.Name = "CustomerGroup";
            CustomerGroup.Padding = new Padding(3, 4, 3, 4);
            CustomerGroup.Size = new Size(253, 149);
            CustomerGroup.TabIndex = 26;
            CustomerGroup.TabStop = false;
            CustomerGroup.Text = "Kundendaten";
            // 
            // customerTypeBox
            // 
            customerTypeBox.Location = new Point(19, 98);
            customerTypeBox.Margin = new Padding(3, 4, 3, 4);
            customerTypeBox.Name = "customerTypeBox";
            customerTypeBox.ReadOnly = true;
            customerTypeBox.Size = new Size(211, 23);
            customerTypeBox.TabIndex = 21;
            customerTypeBox.Text = "Kundentyp";
            // 
            // ContactBox
            // 
            ContactBox.Location = new Point(19, 63);
            ContactBox.Margin = new Padding(3, 4, 3, 4);
            ContactBox.Name = "ContactBox";
            ContactBox.ReadOnly = true;
            ContactBox.Size = new Size(211, 23);
            ContactBox.TabIndex = 20;
            ContactBox.Text = "Ansprechperson";
            // 
            // companyNameBox
            // 
            companyNameBox.Location = new Point(19, 28);
            companyNameBox.Margin = new Padding(3, 4, 3, 4);
            companyNameBox.Name = "companyNameBox";
            companyNameBox.ReadOnly = true;
            companyNameBox.Size = new Size(211, 23);
            companyNameBox.TabIndex = 19;
            companyNameBox.Text = "Firmenname";
            // 
            // noteAddBtn
            // 
            noteAddBtn.Location = new Point(501, 704);
            noteAddBtn.Name = "noteAddBtn";
            noteAddBtn.Size = new Size(120, 27);
            noteAddBtn.TabIndex = 19;
            noteAddBtn.Text = "Hinzufügen";
            noteAddBtn.UseVisualStyleBackColor = true;
            noteAddBtn.Click += button1_Click;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(10, 704);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(485, 145);
            noteBox.TabIndex = 18;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(10, 10);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(51, 15);
            notesLabel.TabIndex = 0;
            notesLabel.Text = "Notizen:";
            // 
            // notesGrid
            // 
            notesGrid.AllowUserToAddRows = false;
            notesGrid.AllowUserToDeleteRows = false;
            notesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesGrid.ColumnHeadersHeight = 29;
            notesGrid.Location = new Point(10, 40);
            notesGrid.Name = "notesGrid";
            notesGrid.ReadOnly = true;
            notesGrid.RowHeadersWidth = 51;
            notesGrid.Size = new Size(761, 647);
            notesGrid.TabIndex = 1;
            // 
            // Reader
            // 
            ClientSize = new Size(1582, 853);
            Controls.Add(splitContainer1);
            Name = "Reader";
            Text = "Person anzeigen";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            EmployeeGroup.ResumeLayout(false);
            EmployeeGroup.PerformLayout();
            TraineeGroup.ResumeLayout(false);
            TraineeGroup.PerformLayout();
            CustomerGroup.ResumeLayout(false);
            CustomerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)notesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button noteAddBtn;
        private TextBox noteBox;
        private GroupBox EmployeeGroup;
        private TextBox cadreLevelBox;
        private TextBox employmentBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker endDateBox;
        private DateTimePicker startDateBox;
        private TextBox roleBox;
        private TextBox employeeNumberBox;
        private TextBox departmentBox;
        private GroupBox TraineeGroup;
        private TextBox actualTraineeYearBox;
        private TextBox traineeYearsBox;
        private Label label12;
        private Label label13;
        private GroupBox CustomerGroup;
        private TextBox customerTypeBox;
        private TextBox ContactBox;
        private TextBox companyNameBox;
        private GroupBox groupBox3;
        private TextBox zipCodeBox;
        private TextBox streetNumberBox;
        private TextBox placeBox;
        private TextBox streetBox;
        private GroupBox groupBox4;
        private TextBox privatePhoneBox;
        private TextBox mobilePhoneBox;
        private TextBox businessPhoneBox;
        private TextBox emailBox;
        private Label label1;
        private TextBox nationalityBox;
        private TextBox lastNameBox;
        private TextBox firstNameBox;
        private GroupBox groupBox2;
        private TextBox socialSecurityBox;
        private DateTimePicker birthdayBox;
        private TextBox salutationBox;
        private TextBox titleBox;
        private TextBox genderBox;
        private CheckBox statusBox;
    }
}
