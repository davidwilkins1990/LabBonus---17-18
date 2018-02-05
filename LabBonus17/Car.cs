using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17
{
    class Car
    {
        string make = "";
        string model = "";
        int year = 0;
        double price = 0.0;


        public Car()
        {

        }

        public Car(String make, String model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public string formatPrice(double price)
        {
            string formatted = "";
            formatted = string.Format("{0:C2}" , price);
            return formatted;
        }

        public string GetMake()
        {
            return make;
        }

        public void SetMake(string make)
        {
            this.make = make;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return year;
        }
        
        public void SetYear(int year)
        {
            this.year = year;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {           
            this.price = price;
        }

        public override string ToString()
        {
            string carString = "";
            carString = ("Make: " + make + "\tModel: " + model + "\tYear: " + year + "\tPrice: "  + formatPrice(this.price)) ;
            return carString;
        }

    }
}
