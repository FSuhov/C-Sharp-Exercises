using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQdemo
{
    class Gladiatrix
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }        
        public int Resistance { get; set; }
        public int Excitement { get; set; }
        public float Strength { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public float Rating { get; set; }
        public Team Team { get; set; }
        public bool IsQueen { get; set; }

        public Gladiatrix(string name, int res, int exc, float strength)
        {
            Id = ++counter;
            Name = name;
            Resistance = res;
            Excitement = exc;
            Strength = strength;
        }

        public override string ToString()
        {
            string teamName = (Team != null) ? Team.Name : "independent"; 
            return string.Format("{0}. {1} - {2}\n| Resistance: {3} | Excitement: {4} | Strength: {5}\nLosses - {6} | Wins - {7} | Rating - {8}",
                                    Id, Name, ((Team != null) ? Team.Name : "independent"), Resistance, Excitement, Strength, Losses, Wins, Rating);
        }
    }
}
