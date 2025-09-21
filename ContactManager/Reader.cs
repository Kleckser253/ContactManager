using System;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Reader : Form
    {
        private Person person;

        public Reader(Person person)
        {
            InitializeComponent();
            this.person = person;


            if (person is Customer c)
            {
                EmployeeGroup.Visible = false;
                CustomerGroup.Visible = true;
                TraineeGroup.Visible = false;
                notesGrid.DataSource = null;
                notesGrid.DataSource = c.Notes;
            }
            else if (person is Trainee t)
            {
                EmployeeGroup.Visible = true;
                CustomerGroup.Visible = false;
                TraineeGroup.Visible = true;
                notesGrid.DataSource = null;
                notesGrid.DataSource = t.Notes;
            }
            else if (person is Employee e)
            {
                EmployeeGroup.Visible = true;
                CustomerGroup.Visible = false;
                TraineeGroup.Visible = false;
                notesGrid.DataSource = null;
                notesGrid.DataSource = e.Notes;
            }
            FillFormWithPersonData(person);
            MakeControlsReadOnly();
        }

        private void FillFormWithPersonData(Person p)
        {
            //firstNameBox.Text = p.firstName;
            //lastNameBox.Text = p.lastName;
            //emailBox.Text = p.email;
            //birthdayBox.Value = p.birthday;
            //statusBox.Checked = p.status;


            statusBox.Checked = p.status;
            salutationBox.Text = p.salutation;
            titleBox.Text = p.title;
            genderBox.Text = p.gender ? "Männlich" : "Weiblich";
            firstNameBox.Text = p.firstName;
            lastNameBox.Text = p.lastName;
            nationalityBox.Text = p.nationality;
            socialSecurityBox.Text = p.socialSecurityNumber;
            birthdayBox.Value = p.birthday;
            streetBox.Text = p.street;
            streetNumberBox.Text = p.streetNumber;
            zipCodeBox.Text = p.zipCode.ToString();
            placeBox.Text = p.place;
            emailBox.Text = p.email;
            businessPhoneBox.Text = p.phoneNumberBusiness;
            privatePhoneBox.Text = p.phoneNumberPrivat;
            mobilePhoneBox.Text = p.phoneNumberMobile;


            if (p is Customer c)
            {
                companyNameBox.Text = c.companyName;
                ContactBox.Text = c.companyContact;
                customerTypeBox.Text = c.customerType != ' ' ? c.customerType.ToString() : "";
            }
            else if (p is Employee e)
            {
                employeeNumberBox.Text = e.employeeNumber.ToString();
                departmentBox.Text = e.department;
                roleBox.Text = e.role;
                startDateBox.Value = e.startDate;
                endDateBox.Value = e.endDate;
                employmentBox.Text = e.employment.ToString();
                cadreLevelBox.Text = e.cadreLevel.ToString();
            }

            if (p is Trainee t)
            {
                traineeYearsBox.Text = t.traineeYears.ToString();
                actualTraineeYearBox.Text = t.actualTraineeYear.ToString();
            }

        }

        private void MakeControlsReadOnly(Control parent = null)
        {
            if (parent == null) parent = this;

            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb && tb != noteBox) tb.ReadOnly = true;
                if (ctrl is ComboBox cb) cb.Enabled = false;
                if (ctrl is DateTimePicker dp) dp.Enabled = false;
                if (ctrl is CheckBox ch) ch.Enabled = false;

                if (ctrl.HasChildren)
                {
                    MakeControlsReadOnly(ctrl);
                }
            }
        }


        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactNote newNote = new ContactNote();
            newNote.Date = DateTime.Now;
            newNote.Note = noteBox.Text;
            person.Notes.Add(newNote);
            noteBox.Text = "";


            notesGrid.DataSource = null;
            notesGrid.DataSource = person.Notes;
            Form1.SaveToFile();
        }

        private void nationalityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

