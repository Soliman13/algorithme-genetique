using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class City
    {
        public String Name { get; }
        public double X { get; }
        public double Y { get; }

        public City(string name, double x, double y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }
    }
}
