using System;
using BabySitterPayCalculator.Domain;

namespace BabySitterPayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pay Calculator!");
            Console.Write("Please Enter Starting Hour: ");
            var startingHour = Console.ReadLine();
            Console.Write("Please Enter Ending Hour: ");
            var endingHour = Console.ReadLine();

            var calculator = new PayCalculator(int.Parse(startingHour), int.Parse(endingHour));

            var payAmount = calculator.CalculatePay();
            
            Console.WriteLine($"This babysitter is owed: ${payAmount}.00");
        }
        
        
    }
}