using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder.Model
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapaCity;
        public double FuelFor1km;
        public double CurrentFuel;

        public Car(String Brand)
        {
            this.Brand = Brand;
        }
        public Car(String Brand,string Model):this(Brand)
        {
            this.Model = Model;
        }
        public Car(String Brand,string Model,int FuelCapaCity):this(Brand,Model)
        {
            this.FuelCapaCity = FuelCapaCity;
        }
        public Car(String Brand, string Model, int FuelCapaCity, double FuelFor1km):this(Brand,Model, FuelCapaCity)
        {
            this.FuelFor1km = FuelFor1km; 
        }
        public Car(String Brand, string Model, int FuelCapaCity, double FuelFor1km,double CurrentFuel):this(Brand, Model, FuelCapaCity, FuelFor1km)
        {
            this.CurrentFuel = CurrentFuel;
        }

        public void ShowInfo()
        {
           // Console.WriteLine(Brand+" "+Model+" "+ FuelCapaCity+" "+ FuelFor1km+ " " + CurrentFuel);
            Console.WriteLine($"1)Brend:{Brand}  2)Model :{Model}   3)Cenin tutdugu hecim:  {FuelCapaCity}  4)1km istifade etdiyi yanacaq: {FuelFor1km}  5)Cende olan benzinin hecmi: {CurrentFuel}" );
        }

        public void Drive(double DriveWay)
        {
            if ((DriveWay * FuelFor1km) > CurrentFuel)
            {
                Console.WriteLine("Yanacaq catmayacaq ");
            }
           else  if (DriveWay > 0)
            {
                double result = 0;
               result =CurrentFuel - (DriveWay * FuelFor1km);
                Console.WriteLine("Yol gedildikden sonraki benzinin hecmi: "+result);
            }
            else
            {
                Console.WriteLine("yol gedilmeyib");
            }
        }
                

    }

}
