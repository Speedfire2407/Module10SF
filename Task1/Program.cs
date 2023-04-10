using System.Globalization;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            CalculateSum sum = new CalculateSum();
            string number;
            bool isANumb;
            while (true)
            {
                try
                {
                    ((ILogger)sum).Event("Введите число а");                   
                    number = Console.ReadLine();
                    isANumb = double.TryParse(number, out var a);
                    if (isANumb == false) throw new Exception();
                    ((ILogger)sum).Event("Введите число b");
                    number = Console.ReadLine();
                    isANumb = double.TryParse(number, out var b);
                    if (isANumb == false) throw new Exception();
                    double result = ((ISum)sum).Sum(a, b);
                    ((ILogger)sum).Event("Ответ " + result);
                    break;
                }
                catch 
                {
                    ((ILogger)sum).Error("Введены некоректные данные");
                    Console.WriteLine();
                }
            }
        }
    }
}