using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus17
{
    public static class InputValidator
    {
       

        public static void validateCount (string input)
        {
            if (int.TryParse(input, out int trash) == false)
            {
                Console.WriteLine("\n\n***ERROR: Invalid input.");
                
            }
        }


    }
}
