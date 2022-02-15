using System;

namespace StringInterpolation
{
    internal class Program
    {
        private const double Pi = Math.PI;
        private static readonly DateTime Date = DateTime.Now;

        public static void Main(string[] args)
        {
            Number1();
            Number2();
            Number3();
            Number4();
            Number5();
            Number6();
            Number7();
            Number8();
            Number9();
            Number10();
        }

        private static void Number1()
        {
            var date = $"{Date,40:MMMM dd, yyyy}";
            Console.WriteLine(date);
        }

        private static void Number2()
        {
            var date = $"{Date:yyyy}.{Date:MM}.{Date:dd}";
            Console.WriteLine(date);
        }

        private static void Number3()
        {
            var date = $"Day {Date:dd} of {Date:MMMM}, {Date:yyyy}";
            Console.WriteLine(date);
        }

        private static void Number4()
        {
            var date = $"Year: {Date:yyyy}, Month: {Date:MM}, Day: {Date:dd}";
            Console.WriteLine(date);
        }

        private static void Number5()
        {
            var date = $"{Date,10:dddd}";
            Console.WriteLine(date);
        }

        private static void Number6()
        {
            var date = $"{Date:hh}:{Date:mm} {Date:tt}";
            var addition = $"{date,10}";
            var final = addition + $"{Date,10:dddd}";
            Console.WriteLine(final);
        }

        private static void Number7()
        {
            var date = $"h:{Date:hh}, m:{Date:mm}, s:{Date:ss}";
            Console.WriteLine(date);
        }

        private static void Number8()
        {
            var date = $"{Date:yyyy}.{Date:MM}.{Date:dd}.{Date:hh}.{Date:mm}.{Date:ss}";
            Console.WriteLine(date);
        }

        private static void Number9()
        {
            var output = $"{Pi:C}";
            Console.WriteLine(output);
        }

        private static void Number10()
        {
            var output = $"{Pi,10:n3}";
            Console.WriteLine(output);
        }
    }
}