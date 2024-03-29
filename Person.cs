using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorbitTask
{
    public class Person
    {
        private double weight;
        private double height;
        public Person(double weight, double height) {
            this.weight = weight;
            this.height = height;
        }

        public double Weight
        {
            get { return weight; }
        }

        public double Height
        {
            get { return height; }
        }
    }
}
