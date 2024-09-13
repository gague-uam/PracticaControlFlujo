using NotasEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasEstudiantes
{
    public partial class ArregloNotas : Form
    {
        GeneralGrade grades = new GeneralGrade(); 
        int index = 0; //Variable para llevar el control de las notas
        public ArregloNotas()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddElement();
        }

        private void AddElement() //Agrega un elemento al arreglo
        {
            try
            {
                int grade = Convert.ToInt32(tbGrade.Text);
                grades.AddElement(grade, index); //Agrega la nota en la posición indicada
                index++;
                ShowGrades(); //Muestra las notas en el ListBox
                tbGrade.Clear();
                tbGrade.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error); //Muestra un mensaje de error
            }
        }

        private void ShowGrades() //Muestra las notas en el ListBox
        {
            try //Manejo de excepciones
            {
                lbNotas.Items.Clear();
                for (int i = 0; i < index; i++) //Recorre el arreglo de notas
                {
                    lbNotas.Items.Add(grades.GetElements()[(int)i]);
                }
                int max = grades.GetElements().Max(); //Obtiene la nota más alta
                double average = grades.GetElements().Average(); //Obtiene el promedio
                lblHighest.Text = "Mayor nota: " + max; //Muestra la nota más alta
                lblAverage.Text = "Promedio: " + average; //Muestra el promedio
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) //Si se presiona la tecla Enter se agrega la nota
            {
                AddElement();
            }
        }
    }
}
