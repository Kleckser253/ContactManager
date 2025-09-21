using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ContactManager
{
    public partial class Editor : Form
    {
        private Form1 mainForm;

        private Person personToEdit;

        public Editor(Person person, Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            //InitDropdowns(); // z. B. ComboBox initialisieren
            this.personToEdit = person; ;
            personType.Items.Add("Customer");
            personType.Items.Add("Employee");
            personType.Items.Add("Trainee");
            personType.DropDownStyle = ComboBoxStyle.DropDownList;

            genderBox.Items.Add("Männlich");
            genderBox.Items.Add("Weiblich");
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;

            FillFormWithPersonData(person);
        }


        public Editor(Form1 form1)
        {

            mainForm = form1;
            //Initialisierung aller komponenten
            InitializeComponent();
            personType.Items.Add("Customer");
            personType.Items.Add("Employee");
            personType.Items.Add("Trainee");
            personType.Text = "Customer";
            personType.DropDownStyle = ComboBoxStyle.DropDownList;

            genderBox.Items.Add("Männlich");
            genderBox.Items.Add("Weiblich");
            genderBox.Text = "Männlich";
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!EmailIsValid(emailBox.Text))
            {
                MessageBox.Show("Diese Email-Adresse ist ungültig", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsPhoneNumber(privatePhoneBox.Text))
            {
                MessageBox.Show("Diese private Telefonnummer ist ungültig", "Telefonnummer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsPhoneNumber(mobilePhoneBox.Text))
            {
                MessageBox.Show("Diese mobile Telefonnummer ist ungültig", "Telefonnummer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsPhoneNumber(businessPhoneBox.Text))
            {
                MessageBox.Show("Diese geschäfts Telefonnummer ist ungültig", "Telefonnummer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isZipCode(zipCodeBox.Text))
            {
                MessageBox.Show("Diese Postleitzahl ist ungültig", "PLZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!isValidBirthday(birthdayBox.Value))
            {
                MessageBox.Show("Dieses Geburtsdatum ist ungültig", "Geburtsdatum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            if (personToEdit != null)
            {
                FillPersonFromForm(personToEdit);
                PersonManager.UpdatePerson(personToEdit);
            }
            else
            {
                Person newPerson;

                switch (personType.Text)
                {
                    case "Customer":
                        newPerson = new Customer();
                        break;
                    case "Employee":

                        if (!areValidDates(startDateBox.Value, endDateBox.Value))
                        {
                            MessageBox.Show("Das Startdatum muss vor dem Enddatum liegen", "Start bis Enddatum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        newPerson = new Employee();
                        break;
                    case "Trainee":
                        if (!areValidDates(startDateBox.Value, endDateBox.Value))
                        {
                            MessageBox.Show("Das Startdatum muss vor dem Enddatum liegen", "Start bis Enddatum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        newPerson = new Trainee();
                        break;
                    default:
                        MessageBox.Show("Ungültiger Typ ausgewählt.");
                        return;
                }

                FillPersonFromForm(newPerson);
                PersonManager.AddPerson(newPerson);
            }

            mainForm.Reload();
            this.Close();
        }
        public static bool IsPhoneNumber(string number)
        {
            if( number =="")
                return true;
            else
                return Regex.IsMatch(number, @"^\+?[0-9\s\-()]{7,15}$");
        }

        public static bool isValidBirthday(DateTime birthday)
        {
            int yeardata = DateTime.Compare(birthday, DateTime.Now.Date);
            if (yeardata >= 0)
            { return false; }
            else return true;
        }

        public static bool areValidDates(DateTime startDate, DateTime endDate)
        {
            int yeardata = DateTime.Compare(startDate, endDate);
            if (yeardata >= 0)
            { return false; }
            else return true;
        }

        public static bool isZipCode(string zipcode)
        {
            try
            {
                 int PLZ =  Int32.Parse(zipcode);
                if (999 < PLZ && PLZ < 10000)
                    return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void FillPersonFromForm(Person p)
        {
            p.status = statusBox.Checked;
            p.salutation = salutationBox.Text;
            p.title = titleBox.Text;
            p.gender = genderBox.Text == "Männlich";
            p.firstName = firstNameBox.Text;
            p.lastName = lastNameBox.Text;
            p.nationality = nationalityBox.Text;
            p.socialSecurityNumber = socialSecurityBox.Text;
            p.birthday = birthdayBox.Value;
            p.street = streetBox.Text;
            p.streetNumber = streetNumberBox.Text;
            p.zipCode = int.TryParse(zipCodeBox.Text, out int zip) ? zip : 0;
            p.place = placeBox.Text;
            p.email = emailBox.Text;
            p.phoneNumberBusiness = businessPhoneBox.Text;
            p.phoneNumberPrivat = privatePhoneBox.Text;
            p.phoneNumberMobile = mobilePhoneBox.Text;

            if (p is Customer c)
            {
                personType.Text = "Customer";
                c.companyName = companyNameBox.Text;
                c.companyContact = ContactBox.Text;
                c.customerType = customerTypeBox.Text.Length > 0 ? customerTypeBox.Text[0] : ' ';
            }
            else if (p is Employee e)
            {
                personType.Text = "Employee";
                e.employeeNumber = Guid.TryParse(employeeNumberBox.Text, out var guid) ? guid : Guid.NewGuid();
                e.department = departmentBox.Text;
                e.role = roleBox.Text;
                e.startDate = startDateBox.Value;
                e.endDate = endDateBox.Value;
                e.employment = int.TryParse(employmentBox.Text, out int emp) ? emp : 0;
                e.cadreLevel = int.TryParse(cadreLevelBox.Text, out int level) ? level : 0;
            }

            if (p is Trainee t)
            {
                personType.Text = "Trainee";
                t.traineeYears = int.TryParse(traineeYearsBox.Text, out int ty) ? ty : 0;
                t.actualTraineeYear = int.TryParse(actualTraineeYearBox.Text, out int aty) ? aty : 0;
            }
            dropbox_SelectedIndexChanged(personType, EventArgs.Empty);
        }



        private void CreatePersonForm_Load(object sender, EventArgs e)
        {
            EmployeeGroup.Visible = false;
            CustomerGroup.Visible = true;
            TraineeGroup.Visible = false;
        }


        private void dropbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personType.Text == "Customer")
            {
                EmployeeGroup.Visible = false;
                CustomerGroup.Visible = true;
                TraineeGroup.Visible = false;
            }
            else if (personType.Text == "Employee")
            {

                employeeNumberBox.Text = Guid.NewGuid().ToString();
                EmployeeGroup.Visible = true;
                CustomerGroup.Visible = false;
                TraineeGroup.Visible = false;
            }
            else if (personType.Text == "Trainee")
            {

                employeeNumberBox.Text = Guid.NewGuid().ToString();
                EmployeeGroup.Visible = true;
                CustomerGroup.Visible = false;
                TraineeGroup.Visible = true;
            }
        }


        private void FillFormWithPersonData(Person p)
        {
            // Allgemeine Personendaten
            statusBox.Checked = p.status;
            salutationBox.Text = p.salutation;
            titleBox.Text = p.title;
            genderBox.Text = p.gender ? "Männlich" : "Weiblich";
            firstNameBox.Text = p.firstName;
            lastNameBox.Text = p.lastName;
            nationalityBox.Text = p.nationality;
            birthdayBox.Value = p.birthday;
            streetBox.Text = p.street;
            streetNumberBox.Text = p.streetNumber;
            zipCodeBox.Text = p.zipCode.ToString();
            placeBox.Text = p.place;
            emailBox.Text = p.email;
            businessPhoneBox.Text = p.phoneNumberBusiness;
            privatePhoneBox.Text = p.phoneNumberPrivat;
            mobilePhoneBox.Text = p.phoneNumberMobile;

            // Unterscheiden nach Typ
            if (p is Customer c)
            {
                personType.Text = "Customer";
                CustomerGroup.Visible = true;
                EmployeeGroup.Visible = false;
                TraineeGroup.Visible = false;

                companyNameBox.Text = c.companyName;
                customerTypeBox.Text = c.customerType.ToString();
                ContactBox.Text = c.companyContact;
            }
            else if (p is Trainee t)
            {
                personType.Text = "Trainee";
                CustomerGroup.Visible = false;
                EmployeeGroup.Visible = true;
                TraineeGroup.Visible = true;

                // Mitarbeiterdaten
                employeeNumberBox.Text = t.employeeNumber.ToString();
                departmentBox.Text = t.department;
                roleBox.Text = t.role;
                startDateBox.Value = t.startDate;
                endDateBox.Value = t.endDate;
                employmentBox.Text = t.employment.ToString();
                cadreLevelBox.Text = t.cadreLevel.ToString();

                // Lehrlingsdaten
                traineeYearsBox.Text = t.traineeYears.ToString();
                actualTraineeYearBox.Text = t.actualTraineeYear.ToString();
            }
            else if (p is Employee e)
            {
                personType.Text = "Employee";
                CustomerGroup.Visible = false;
                EmployeeGroup.Visible = true;
                TraineeGroup.Visible = false;

                // Mitarbeiterdaten
                employeeNumberBox.Text = e.employeeNumber.ToString();
                departmentBox.Text = e.department;
                roleBox.Text = e.role;
                startDateBox.Value = e.startDate;
                endDateBox.Value = e.endDate;
                employmentBox.Text = e.employment.ToString();
                cadreLevelBox.Text = e.cadreLevel.ToString();
            }
            dropbox_SelectedIndexChanged(personType, EventArgs.Empty);

        }




        private static bool EmailIsValid(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
    

        private void dropbox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void companyNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
