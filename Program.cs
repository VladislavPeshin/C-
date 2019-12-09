using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1 Вывести на экран число p с точностью до сотых.
            Console.WriteLine(3.14);

            //1.2 Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine(2.7);

            //1.3 Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение "Вы ввели число".
            Console.Write("");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {number1}");

            //1.4 Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение " - вот какое число Выввели"
            Console.Write("");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number2} - вот какое число Вы ввели");


        }
    }
}
