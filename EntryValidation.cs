using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class EntryValidation
    {
        public void ValidateFirstName()
        {
            {
               
                string patternFirstName = @"^[A-Z]{1}([a-zA-Z]+){2,}";
                Regex regex = new Regex(patternFirstName);
              
                Console.WriteLine("Enter the first name of user");
                string firstName = Console.ReadLine();
               
                if (regex.IsMatch(firstName))
                {
                    Console.WriteLine("The entry for first name is valid");
                   
                }
               
                else
                {
                    Console.WriteLine("Invalid entry. Enter atleast 3 characters and first letter should be capital");
                  
                }
            }
        }
    }
}
