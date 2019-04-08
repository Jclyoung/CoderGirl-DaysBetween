using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("Please enter your first Date in mm/dd/yyyy format:");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second Date in mm/dd/yyyy format:");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DaysBetween(firstDate, secondDate));
            Console.ReadLine();
        }

        public static double DaysBetween (DateTime firstDate, DateTime secondDate)
        {           
            return Math.Abs(secondDate.Subtract(firstDate).TotalDays);
        }

        // TODO: Create that has a method that counts the number of days between two different dates.
    }
}
