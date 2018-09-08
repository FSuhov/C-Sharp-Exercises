using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Girl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Resistance { get; set; }
        public int Excitement { get; set; }
        public double Strength { get; set; }

        public Girl() { }

        public Girl(int id, string name, string surname, DateTime birthdate, int res, int exc, double str)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            Resistance = res;
            Excitement = exc;
            Strength = str;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthDate.ToShortDateString() + "\nResistance Rate: " + Resistance + "\nExcitment Rate: " + Excitement + "\nStrength: " + Strength;
        }
    }
}
