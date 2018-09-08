using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQdemo
{
    class Team
    {
        private static sbyte counter = 0;
        public sbyte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Team(string name, string description)
        {
            Id = ++counter;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("{0}. {1}\n{2}", Id, Name, Description);
        }
    }
}
