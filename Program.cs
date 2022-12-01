using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstValue,SecondValue;

            Console.WriteLine("Введите первое число");
            
            FirstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            SecondValue = int.Parse(Console.ReadLine());

            int result = FirstValue + SecondValue;

            Console.WriteLine(("Сумма чисел ровна: ") + result);

            
        }
    }
}
