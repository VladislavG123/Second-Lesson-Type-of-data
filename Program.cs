using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первое.
            Console.WriteLine("Enter number x ");
            int x = Convert.ToInt32(Console.ReadLine());

            var y = 7 * (x * x) - 3 * x + 4;
            Console.WriteLine("Y = " + y);
           
            // Второе.
            Console.WriteLine("Enter value of radius");
            double radius = Convert.ToInt32(Console.ReadLine());

            double diametr = 2 * radius;
            double length = Math.PI * diametr; 
            Console.WriteLine("Lenght = " + length);

            double square = Math.PI * diametr * diametr;
            Console.WriteLine("Square = " + length);

            // Третье.
            Console.WriteLine("Enter distance in centimeters");
            int centimeters = Convert.ToInt32(Console.ReadLine());
            int oneMeterInCentimeters = 100;
            int meters = centimeters / oneMeterInCentimeters;
            Console.WriteLine("Meters = " + meters);

            // Четвертое.
            int amountDays = 234;
            int amountDaysInWeek = 7;
            int amountWeeks = amountDays / amountDaysInWeek;
            Console.WriteLine("Amount weeks in " + amountDays + "\nDays = " + amountWeeks);

            // Пятое.
            Console.WriteLine("Enter two - digit number");
            int twoDigitNumber = Convert.ToInt32(Console.ReadLine());
            int one = twoDigitNumber % 10; // Чтобы получить единицы нужно получить остаток от деления на 10.
            int tens = twoDigitNumber % 100; // Чтобы получить десятки нужно получить остаток от деления на 100.
            int sum = one + tens;
            Console.WriteLine("Amount tens - " + tens);
            Console.WriteLine("Amount ones - " + one);
            Console.WriteLine("The sum = " + sum);

            // Шестое.
            Console.WriteLine("Enter four-digit number");
            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());

            const int ONE = 1;
            const int NULL = 0;

            // Задаем начальные значения.
            int composition = ONE; 
            sum = NULL;
            const int AMOUNT_NUMBERS_IN_FOUR_DIGIT_NUBMER = 4;

            for (int i = 0, elementOfNumber = 10; i < AMOUNT_NUMBERS_IN_FOUR_DIGIT_NUBMER; i++, elementOfNumber+=10)
            {
                composition *= fourDigitNumber % elementOfNumber;
                sum += fourDigitNumber % elementOfNumber;
            }

            Console.WriteLine("Compositition = " + composition);
            Console.WriteLine("The sum = " + sum);

            // Седьмое.
            int threeDigitNumber = 456;
            int secondNumeral = threeDigitNumber % 10;
            threeDigitNumber /= 10;

            secondNumeral *= 
            Console.Read();
        }
    }
}
