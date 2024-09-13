using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEstudiantes.Models
{
    internal class GeneralGrade
    {
        private int[] grades = new int[1000]; //Nos permite almacenar hasta 1000 notas
        public void AddElement(int grade, int pos) //Agrega un elemento al arreglo
        {
            grades[pos] = grade; //Agrega la nota en la posición indicada
        }
        public int[] GetElements()
        {
            return grades;
        }
    }
}
