using System.Reflection;
using System.Text.Json;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonViewer.RowPrePaint += PersonViewer_RowPrePaint_1;
            TypeSearchBox.Items.Add("Customer");
            TypeSearchBox.Items.Add("Employee");
            TypeSearchBox.Text = "Customer"; // Default-Suchtyp

        }
        private void read_btn_Click(object sender, EventArgs e)
        {
            if (PersonViewer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte eine Person auswählen.");
                return;
            }

            var selectedDisplay = PersonViewer.SelectedRows[0].DataBoundItem as PersonDisplay;
            var selectedPerson = selectedDisplay?.PersonObject;

            if (selectedPerson == null)
            {
                MessageBox.Show("Ungültige Auswahl.");
                return;
            }


            // Editor im Bearbeitungsmodus öffnen
            Reader reader = new Reader(selectedPerson);
            reader.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (PersonViewer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte eine Person auswählen.");
                return;
            }

            var selectedDisplay = PersonViewer.SelectedRows[0].DataBoundItem as PersonDisplay;
            var selectedPerson = selectedDisplay?.PersonObject;

            if (selectedPerson == null)
            {
                MessageBox.Show("Ungültige Auswahl.");
                return;
            }


            // Editor im Bearbeitungsmodus öffnen
            Editor editor = new Editor(selectedPerson, this);
            editor.Show();
        }
        // Löscht die aktuell ausgewählte Person aus dem Datenbestand
        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (PersonViewer.SelectedRows.Count > 0)
            {
                var selectedDisplay = PersonViewer.SelectedRows[0].DataBoundItem as PersonDisplay;
                var selectedPerson = selectedDisplay?.PersonObject;


                if (selectedPerson != null)
                {
                    PersonManager.RemovePerson(selectedPerson);
                    MessageBox.Show("Person erfolgreich gelöscht!", "Person Deleted", MessageBoxButtons.OK);

                    LoadPersonsIntoGrid();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Person aus.", "Löschen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void suchen_btn_Click(object sender, EventArgs e)
        {
            searchSort();
        }

        // Zentrale Such-/Filterlogik für Vorname, Nachname, Geburtstag, Typ
        private void searchSort()
        {

            string firstNameSearch = FirstNameBox.Text.ToLower().Trim();
            string lastNameSearch = LastNameBox.Text.ToLower().Trim();

            DateTime? birthdaySearch = BirthdayBox.Checked ? BirthdayBox.Value.Date : (DateTime?)null;

            string typeSearch = TypeSearchBox.SelectedItem != null
                ? TypeSearchBox.SelectedItem.ToString().ToLower()
                : "";


            var allPersons = PersonManager.GetAllPersons();

            if (FirstNameCheck.Checked)
            {
                allPersons = allPersons.Where(p =>
                    (string.IsNullOrEmpty(firstNameSearch) || p.firstName.ToLower().Contains(firstNameSearch))
                ).ToList();
            }


            if (LastNameCheck.Checked)
            {
                allPersons = allPersons.Where(p =>
                    (string.IsNullOrEmpty(lastNameSearch) || p.lastName.ToLower().Contains(lastNameSearch))
                ).ToList();
            }


            if (BirthdayCheck.Checked)
            {
                allPersons = allPersons.Where(p => 
                (!birthdaySearch.HasValue || p.birthday.Date == birthdaySearch.Value)
                ).ToList();
            }


            if (TypeCheck.Checked)
            {
                allPersons = allPersons.Where(p =>
                    (string.IsNullOrEmpty(typeSearch) ||
                        (typeSearch == "employee" && p is Employee) ||
                        (typeSearch == "customer" && p is Customer)
                    )
                ).ToList();
            }

            var displayList = allPersons.Select(p => new
            {
                PersonObject = p,
                Anrede = p.salutation,
                Vorname = p.firstName,
                Nachname = p.lastName,
                Titel = p.title,
                Sozialversicherungsnummer = p.socialSecurityNumber,
                Privattelefon = p.phoneNumberPrivat,
                Mobiltelefon = p.phoneNumberMobile,
                Geschäftstelefon = p.phoneNumberBusiness,
                EMail = p.email,
                Nationalität = p.nationality,
                Straße = p.street,
                Hausnummer = p.streetNumber,
                PLZ = p.zipCode,
                Ort = p.place,
                Geschlecht = p.gender ? "Männlich" : "Weiblich",
                Status = p.status ? "Aktiv" : "Inaktiv"
            }).ToList();
            PersonViewer.DataSource = null;
            PersonViewer.DataSource = displayList;
            PersonViewer.Columns["PersonObject"].Visible = false;

            PersonViewer.AutoResizeColumns();
        }



        private void PersonViewer_CellContentClick(object sender, EventArgs e)
        {

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor(this);
            ed.Show();

        }
        private void PersonListForm_Load(object sender, EventArgs e)
        {
            LoadPersonsIntoGrid();
        }
        public void Reload()
        {
            LoadPersonsIntoGrid();
            SaveToFile();
        }

        // Lädt alle Personen und baut eine List für die Grid-Anzeige
        public void LoadPersonsIntoGrid()
        {
            var personen = PersonManager.GetAllPersons();

            var displayList = personen.Select(p => new PersonDisplay
            {
                PersonObject = p, 
                Anrede = p.salutation,
                Vorname = p.firstName,
                Nachname = p.lastName,
                Titel = p.title,
                Sozialversicherungsnummer = p.socialSecurityNumber,
                Privattelefon = p.phoneNumberPrivat,
                Mobiltelefon = p.phoneNumberMobile,
                Geschäftstelefon = p.phoneNumberBusiness,
                EMail = p.email,
                Nationalität = p.nationality,
                Straße = p.street,
                Hausnummer = p.streetNumber,
                PLZ = p.zipCode,
                Ort = p.place,
                Geschlecht = p.gender ? "Männlich" : "Weiblich",
                Status = p.status ? "Aktiv" : "Inaktiv"
            }).ToList();

            PersonViewer.DataSource = null;
            PersonViewer.DataSource = displayList;

            PersonViewer.Columns["PersonObject"].Visible = false;

            PersonViewer.AutoResizeColumns();
        }




        private void PersonViewer_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = PersonViewer.Rows[e.RowIndex];
            Person person = row.DataBoundItem as Person;
            if (person != null)
            {
                if (person.status)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void PersonViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        public static void SaveToFile()
        {            
            string path = Path.Combine(Directory.GetCurrentDirectory(), "test.json");
            var json = JsonSerializer.Serialize(PersonManager.GetAllPersons());
            File.WriteAllText(path, json);
        }

        private void TypeSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Optionaler Lader für JSON -> Liste (bewusst auskommentiert)
        //public static void LoadFromFile(string path)
        //{
        //    if (File.Exists(path))
        //    {
        //        var json = File.ReadAllText(path);
        //        persons = JsonSerializer.Deserialize<List<Person>>(json);
        //    }
        //}

    }
}
