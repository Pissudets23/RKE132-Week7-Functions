using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine("Please choose the type of temperature you want to convert (1 for Celsius, 2 for Fahrenheit):");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the temperature in Celsius:");
                double celsius = Double.Parse(Console.ReadLine());
                ConvertToCelsius(celsius);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the temperature in Fahrenheit:");
                double fahrenheit = Double.Parse(Console.ReadLine());
                ConvertToFahrenheit(fahrenheit);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void ConvertToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0:F2} degrees Fahrenheit is {1:F2} degrees Celsius.", fahrenheit, celsius);
        }

        static void ConvertToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("{0:F2} degrees Celsius is {1:F2} degrees Fahrenheit.", celsius, fahrenheit);
        }
    }
}