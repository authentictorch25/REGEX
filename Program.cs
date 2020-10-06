using System;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Portal");
            EntryValidation validation = new EntryValidation();
            validation.ValidateFirstName();

            validation.ValidateLastName();

            validation.ValidateEmail();



        }
    }
}
