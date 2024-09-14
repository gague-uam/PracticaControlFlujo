using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.clases
{
    internal class Persona
    {
        public Persona() { }

        private string[] Names = new string[100];
        private string[] LastNames = new string[100];
        private DateTime[] BirthDates = new DateTime[100];

        public void AddName(string name, int pos)
        {
            Names[pos] = name;
        }
        public void AddlastName(string lastName, int pos)
        {
            LastNames[pos] = lastName;
        }
        public void AddBirthDate(DateTime birthDate, int pos)
        {
            BirthDates[pos] = birthDate;
        }
        public string[] GetNames()
        {
            return Names;
        }
        public string[] GetlastNames()
        {
            return LastNames;
        }
        public DateTime[] GetBirthDates()
        {
            return BirthDates;
        }

        public int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
