

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17
{
    public static class UsedCarMenu

    {


        public static void runUsed()
        {

            Console.WriteLine("***New/Used Car Inventory***");

            Car car1 = new Car("Chevy","Corvette",2017, 59999.99);
            Car car2 = new Car("Ford", "Mustang", 2018, 48999.99);
            Car car3 = new Car("Lambo", "Gallard", 2016, 999999.99);

            UsedCar usedCar1 = new UsedCar("Chevy", "Camaro", 2002, 4999.99, 223456);
            UsedCar usedCar2 = new UsedCar("Ford", "F-150", 2005, 8999.99, 123456);
            UsedCar usedCar3 = new UsedCar("Subaru", "Impreza", 2014, 20999.99, 23996);

            CarList.usedCarList.Add(car1);
            CarList.usedCarList.Add(car2);
            CarList.usedCarList.Add(car3);
            CarList.usedCarList.Add(usedCar1);
            CarList.usedCarList.Add(usedCar2);
            CarList.usedCarList.Add(usedCar3);

            showInventory();
            

        }


        public static void showInventory()
        {

            Console.WriteLine("\n\n***Car inventory is listed below by number***");
            int count = 0;

            if (CarList.usedCarList.Count == 0)
            {
                Console.WriteLine("You have purchase all available vehicles. Goodbye.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            foreach (Car c in CarList.usedCarList)
            {
                Console.WriteLine(count +": " + c.ToString());
                count++;
            }

            userInput();
        }

        public static void userInput()
        {
            Console.Write("\nEnter a number to purchase a car: ");
            string input = Console.ReadLine();
            int carSelect = 0;
            try
            {
                carSelect = int.Parse(input);
                if (carSelect > CarList.usedCarList.Count)
                {
                    Console.WriteLine("Invalid selection. Try Again.");
                    userInput();
                }
            }
            catch
            {
                Console.WriteLine("ERROR: You must enter a number.");
                userInput();
            }
            confirm(carSelect);
        }

        public static void confirm(int input)
        {
            Console.WriteLine("You have selected: \n" + CarList.usedCarList[input].ToString());
            Console.WriteLine("\nPress 'p' to purchase this car, 'x' to exit, or any other key to view the inventory.");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            if (choice == "p")
            {
                removeCar(input);
            }
            else if (choice == "x")
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                showInventory();
            }
        }

        public static void removeCar(int input)
        {
            Console.WriteLine(input + ": " + CarList.usedCarList[input].GetModel() + " purchased.\n");
            CarList.usedCarList.RemoveAt(input);
            showInventory();
        }

    }
}
