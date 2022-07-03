using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            try
            {
                Console.WriteLine("Введите первое число");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберете операцию над числами:");
                Console.WriteLine(" 1 - сложение");
                Console.WriteLine(" 2 - вычитание");
                Console.WriteLine(" 3 - произведение");
                Console.WriteLine(" 4 - частное");
                byte operation = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", operation);
                if (operation == 1)
                    Console.WriteLine(firstNumber + secondNumber);
                if (operation == 2)
                    Console.WriteLine(firstNumber - secondNumber);
                if (operation == 3)
                    Console.WriteLine(firstNumber * secondNumber);
                if (operation == 4)
                    try
                    {
                        Console.WriteLine(firstNumber / secondNumber);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                // Есть или нет try/catch/finally, результат одинаковый. Это может быть связано с разницей в версиях и библиотеках Visual Studio и .NET соответственно? Например в новой версии встроенный try/catch/finally. Спасибо
                if (operation > 4 || operation < 1)
                    Console.WriteLine("Неверный код операции");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
    
}
