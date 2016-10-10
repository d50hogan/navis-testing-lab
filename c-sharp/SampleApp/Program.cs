using System;

namespace SampleApp
{

    public class Program
    {
        static void Main()
        {
            var baseValue = new SqlRepository();
            var worker = new Worker(baseValue);
            Console.WriteLine("Please enter a value...");
            var inputValue = Console.ReadLine(); 
            try
            {
                if (inputValue == null)
                {
                    throw new Exception("You didn't supply a value.");
                }
                var value = int.Parse(inputValue);
                var result = worker.AddValueAndOne(value);
                Console.WriteLine($"The result is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid Input. {ex}");
            }

            Console.ReadLine();

        }
    }
}
