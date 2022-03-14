using System;
using ConsoleApp1.NewFolder.Model;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("BMW","X5",100,1,80);
            Car1.color = "Blue";
            Car1.year = 2012;
            Car1.Drive(100);
            Car1.ShowInfo();

        }
    }
}
