using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите цолое число. X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое числою Y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine($"{"1",6} - сложение");
                Console.WriteLine($"{"2", 6} - вычитание");
                Console.WriteLine($"{"3",6} - произведение");
                Console.WriteLine($"{"4",6} - частное");
                Console.Write("Ваш выбор: ");
                int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        int otvet = x + y;
                        Console.WriteLine("Результат = {0}", otvet);

                    }
                    if (i == 2)
                    {
                        int otvet = x - y;
                        Console.WriteLine("Результат = {0}", otvet);

                    }
                    if (i == 3)
                    {
                        int otvet = x * y;
                        Console.WriteLine("Результат = {0}", otvet);

                    }
                    if (i == 4)
                    {
                        int otvet = x / y;
                        Console.WriteLine("Результат = {0}", otvet);
                    }
                    if ((i>4) | (i<1))
                    {
                        Console.WriteLine("Нет операции с указанным номером");
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}