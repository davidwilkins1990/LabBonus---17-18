/*
 David Wilkins
 Lab Bonus 17
 02/05/18

 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17
{
    class Program
    {
        static void Main(string[] args)
        {                  
            CarApp carApp = new CarApp();

            carApp.runApp();

            Console.WriteLine("\n\n//...NOW BEGINNING USED CAR APP...//\n\n");

            UsedCarMenu.runUsed();

            Console.ReadLine();
        }
    }
}
