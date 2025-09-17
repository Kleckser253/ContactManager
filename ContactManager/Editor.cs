using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            dropbox.Items.Add("Customer");
            dropbox.Items.Add("Employee");
            dropbox.Items.Add("Trainee");
            dropbox.Text = "Customer";
            dropbox.DropDownStyle = ComboBoxStyle.DropDownList;

            dropbox_gender.Items.Add("Männlich");
            dropbox_gender.Items.Add("Weiblich");
            dropbox_gender.Text = "Männlich";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dropbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropbox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
