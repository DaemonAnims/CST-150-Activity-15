using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_15
{
    public class Country
    {
        private List<City> cityList;
        public string Name { get; set; }
        public int Value { get; set; }

        public Country(string name, int value)
        {
            Name = name;
            Value = value;
            cityList = new List<City>();
        }

        public void AddCity(string name, int value)
        {
            cityList.Add(new City(name, value));
        }

        public List<City> CityList { get { return cityList; } }

        
    }
}
