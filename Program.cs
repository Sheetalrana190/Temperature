using System;
namespace Test
{
    class ExampleClass
    {
        static void Main()
        {
            int f = 0, c = 0;
            Console.WriteLine("Enter temperature in Fahrenheit");
            f = Convert.ToDouble(Console.ReadLine());
            
            c = (f - 32) * 5 / 9; 
            Console.WriteLine("\nTemperature in Celsius " + c);
            Console.WriteLine("\nEnter temperature in Celsius");
            c = Convert.ToDouble(Console.ReadLine());
            f = (c * 9) / 5 + 32; 
            Console.WriteLine("\nTemperature in Fahrenheit  " + f);
        }
    }
}
