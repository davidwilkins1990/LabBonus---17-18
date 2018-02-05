using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17
{
    class UsedCar : Car
    {
        double mileage = 0.0;


        public UsedCar(String make, String model, int year, double price, double mileage)
        {
            SetMake(make);
            SetModel(model);
            SetYear(year);
            SetPrice(price);
            SetMileage(mileage);
        }

        public double GetMileage()
        {
            return mileage;
        }

        public void SetMileage(double mileage)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            string carString = "";
            carString = ("Make: " + GetMake() + "\tModel: " + GetModel() + "\tYear: " + GetYear() + "\tPrice: " + formatPrice(GetPrice())
                + "\tMileage: " + GetMileage() + "\t(USED VEHICLE)");
            return carString;
        }

    }
}
