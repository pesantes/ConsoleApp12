/*
Author: Fernando Pesantes
Date: 1/31/2019
Description: Methods Class Project for ISM 4300

 */

using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            try
            {
                string input = Console.ReadLine();
                Console.WriteLine("Hello " + input);               
                Console.ReadKey(true);

            } // End of try
            catch
            {

            } // End of catch
        } // End of main

        private string ShowName(string get_name)
        {
            string display_name = get_name;
            return get_name;
           
            
            
        }

    }
}
