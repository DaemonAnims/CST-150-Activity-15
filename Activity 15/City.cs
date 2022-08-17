using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_15
{
    public class City
    {

        public string Name { get; set; }
        public int Value { get; set; }

        public City(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
