using System;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode;
            float temperature;

            Console.Write("1: convert F to C\n2: convert C to F\n");
            Console.Write("Enter 1 or 2: ");
            int.TryParse(Console.ReadLine(), out mode);

            Console.Write("Enter temperature to be converted: ");
            float.TryParse(Console.ReadLine(), out temperature);

            if (mode == 1)
            {
                float c = (temperature - 32) * (5.0f / 9.0f);
                Console.WriteLine("Converted {0} Fahrenheit degree to {1} Celsius degree", temperature, c);
            }
            else if (mode == 2)
            {
                float f = temperature * 1.8f + 32;
                Console.WriteLine("Converted {0} Celsius degree to {1} Fahrenheit degree", temperature, f);
            }
            else
            {
                Console.WriteLine("You've entered wrong mode.");
            }
        }
    }
}
    

