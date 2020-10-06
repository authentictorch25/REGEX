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
        public void ValidateLastName()
        {
            {

                string patternLastName = @"^[A-Z]{1}([a-zA-Z]+){2,}";
                Regex regex = new Regex(patternLastName);

                Console.WriteLine("Enter the first name of user");
                string lastName = Console.ReadLine();

                if (regex.IsMatch(lastName))
                {
                    Console.WriteLine("The entry for last name is valid");

                }

                else
                {
                    Console.WriteLine("Invalid entry. Enter atleast 3 characters and first letter should be capital");

                }
            }
        }
        public void ValidateEmail()
        {
            {

                string patternEmail = @"^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*([@]{1}[a-zA-Z0-9]+)?([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
                Regex regex = new Regex(patternEmail);

                Console.WriteLine("Enter the email of user");
                string email = Console.ReadLine();

                if (regex.IsMatch(email))
                {
                    Console.WriteLine("The entry for email is valid");

                }

                else
                {
                    Console.WriteLine("Invalid entry for email");

                }
            }
        }

        public void ValidatePhoneNumber()
        {
            {
                {

                    string patternPhoneNumber = @"^91[ ][6-9]{1}[0-9]{9}$";
                    Regex regex = new Regex(patternPhoneNumber);

                    Console.WriteLine("Enter the phone number of user");
                    string phoneNumber = Console.ReadLine();

                    if (regex.IsMatch(phoneNumber))
                    {
                        Console.WriteLine("The entry for phont number is valid");

                    }

                    else
                    {
                        Console.WriteLine("Invalid entry for phone number ");

                    }
                }
            }
        }
    }
}
