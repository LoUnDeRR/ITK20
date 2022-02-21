using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Train
    {
        private int number;
        private string name;
        private string type; //p || f
        private int cars;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public Train(int number, string name, string type, int cars)
        {
            Number = number;
            Name = name;
            Type = type;
            Cars = cars;
        }

        public override string ToString() // ToDo
        {
            return null;
        }
    }
}
