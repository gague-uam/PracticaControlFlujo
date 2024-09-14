using Datos.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Datos
{
    public partial class Form1 : Form
    {
        Persona names = new Persona();
        Persona lastNames = new Persona();
        int index = 0;
        int i;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void AddPerson()
        {
            try
            {
                string name = tbNames.Text;
                names.AddName(name, index);
                string lastName = tbLastNames.Text;
                lastNames.AddlastName(lastName, index);
                DateTime birthDate = DateTime.Parse(dtpBirthday.Text);
                names.AddBirthDate(birthDate, index);

                index++;
                ShowData();
                tbNames.Clear();
                tbNames.Focus();
                tbLastNames.Clear();
                tbLastNames.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DateTime Birthday { get; set; }
        private void ShowData()
        {
            try
            {
                lbDatos.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    string fullName = $"{names.GetNames()[i]} {lastNames.GetlastNames()[i]}";
                    DateTime birthDate = names.GetBirthDates()[i];
                    int age = names.GetAge(birthDate);
                    lbDatos.Items.Add($"{fullName}. Edad: {age}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
