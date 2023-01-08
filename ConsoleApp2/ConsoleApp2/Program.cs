using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(DateTime.Now);*/
            /*DateTime i =DateTime.Now;
            Console.WriteLine("yeaer is: {0}",i.Year);
            Console.WriteLine("month is: {0}", i.Month);
            Console.WriteLine("day is: {0}", i.Day);
            Console.WriteLine("day of week is: {0}", i.DayOfWeek);
            Console.WriteLine("day of year is: {0}", i.DayOfYear);
            Console.WriteLine("time of day is: {0}", i.TimeOfDay);*/
            /*double num = 39.6;
            Console.WriteLine("floor({0}): {1}",num,Math.Floor(num));
            Console.WriteLine("ceiling({0}): {1}", num, Math.Ceiling(num));*/
            /*for(int i = 0; i <= 10; i++) 
            {
                Console.WriteLine("2^{0} = {1}",i,Math.Pow(2,i));
            }*/
            /*Console.WriteLine("jazr : {0}",Math.Sqrt(25));*/
            Random ger = new Random();
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(ger.Next());
            }
            Console.ReadKey();

        }
    }
}