using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder.Model
{
    class Vehicle
    {
        public string color;
        public int year;

        public Vehicle()
        {
                
        }
        public Vehicle(string color)
        {
            this.color = color;
        }
        public Vehicle(string color,int year)
        {
            this.color = color;
            this.year = year;
        }

    }
}
