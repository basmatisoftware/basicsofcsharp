using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeXX101
{
    public static class Storing
    {

        public static void Initialize()
        {
            Console.WriteLine("Storing Class Initialized.");
            Console.Title = "Initializer";
        }

        private static void SetTitles(string title)
        {
            Console.Title = title;
            Console.WriteLine(title + "\n-------------------------\n");
        }

        public static void DemoVariables()
        {
            SetTitles("Demo Variables");
            //Variable types: 
            //int, uint, char, float, double, decimal, bool, string

            int number = -1;
            uint positiveNumber = 2;
            char letter = 'Z';
            float body = 98.6f;

            
        
        }

        public static void ReadingInput()
        {
            //How to read input from the console
            SetTitles("Reading Input");

            //Using Convert.To___

        }

        public static void UsingArrays()
        {
            //How to read input from the console
            SetTitles( "Using Arrays");

            //Simple 1D arrays

            //2D arrays

            //Casting Data Types

        }

        public static void ConstantsEnumsStructs()
        {
            SetTitles( "Constants, Enums, and Structs");

            //How to use an enum


            //How to use a constant

            
            //How to use a struct
            
         

        }

    }
}
