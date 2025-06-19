using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ll
{
    public partial class Form2 : Form
    {

        string appDate;
        public delegate void DelegateOneString(string info);

        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Step 1.A.2.c
            buttonNew.Enabled = false;
            labelDetails.Enabled = false;
        }

        public void PrintName(string info)
        {
            labelDetails.Text = info;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            string owner = textBoxOwner.Text;
            string cat = textBoxCat.Text;
            string breed = comboBoxBreed.Text;

            string info = $"Owner: {owner}\nCat: {cat}\nBreed: {breed}\nDate: {appDate}";

            DelegateOneString Print = new DelegateOneString(PrintName);
            Print(info);

            labelDetails.Enabled = true;
            buttonNew.Enabled = true;
            buttonAppointment.Enabled = false;
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            buttonAppointment.Enabled = true;
            buttonNew.Enabled = false;
            labelDetails.Enabled = false;

            textBoxOwner.Clear();
            textBoxCat.Clear();
            labelDetails.Text = "Appointment Details";
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {

            DelegateOneString Print = PrintName; // Step 1.B.3.a
            Print("Owner : " + textBoxOwner.Text); // Step 1.B.3.b
            Print("Cat : " + textBoxCat.Text); // Step 1.B.3.b
            Print("Breed : " + comboBoxBreed.SelectedItem); // Step 1.B.3.b
            Print("Appointment Date : " + appDate); // Step 1.B.3.b
            labelDetails.Enabled = true; // Step 1.B.3.c
            buttonNew.Enabled = true; // Step 1.B.3.c
            buttonAppointment.Enabled = false; // Step 1.B.3.d
        }
    }
}

