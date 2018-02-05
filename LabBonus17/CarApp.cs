using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17
{
    class CarApp
    {
        int input = 0;

        public void SetInput(int input)
        {
            this.input =  input;
        }

        public void runApp()
        {
            userInput();
        }

        public void userInput()
        {
            Console.Write("How many cars do you want to make?: ");
            try
            {
              //  InputValidator.validateCount(Console.ReadLine());
                SetInput(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Error: must be a number.");
                userInput();
            }
            createCar();
        }

        public void createCar()
        {
            for (int i = 0; i < input; i++)
            {
                Car car = new Car();
                try
                {
                    Console.Write("\nEnter the Make: ");
                    car.SetMake(Console.ReadLine());
                    Console.Write("Enter the Model: ");
                    car.SetModel(Console.ReadLine());
                    Console.Write("Enter the Year: ");
                    car.SetYear(int.Parse(Console.ReadLine()));
                    Console.Write("Enter the price: ");
                    car.SetPrice(double.Parse(Console.ReadLine()));

                    CarList.carList.Add(car);
                }
                catch 
                {
                    Console.WriteLine("Invalid year or price, please try again.");
                    createCar();
                    
                }


                
            }

            displayInfo();
        }

        public void displayInfo()
        {
            Console.WriteLine("***Car Inventory ***\n");
            foreach (Car c in CarList.carList)
            {
                Console.WriteLine(c.ToString() + "\n");
            }
        }
    }
}
