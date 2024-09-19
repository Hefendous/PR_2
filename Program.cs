//***********************************************************
//* Практическая работа №2                                  *
//* Выполнил : Васильев Р.А., группа 2-ИСП                  *
//* Задание : составить программу работы линейного алгоритма*
//***********************************************************
using System;


namespace Практическая_работа_2
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу
        {
            Console.Title = "Практическая работа 2"; // заголовок консоли
            Console.BackgroundColor = ConsoleColor.Blue;

            int x, y; // объявление переменных 
            Console.Write("Введите значение x: "); // ввод данных
            x = Convert.ToInt32(Console.ReadLine()); // явное привидение к типу int
            Console.Write("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0) // если x>0 и y>0, то
            { Console.WriteLine("Точка находится в первой четверти.");
            } else // иначе
                  if (x < 0 && y > 0) // если x<0 и y>0, то
              { Console.WriteLine("Точка находится во второй четверти."); 
              }     else // иначе
                        if (x < 0 && y < 0)// если x<0 и y<0, то
                    { Console.WriteLine("Точка находится в третьей четверти."); 
                    }    else // иначе
                             if (x > 0 && y < 0)// если x>0 и y<0, то
                        { Console.WriteLine("Точка находится в четвертой четверти."); 
                        }  else // иначе
                               if (x==0 && y!=0)// если x==0 и y!=0, то
                           { Console.WriteLine("Точка находится на оси Y.");   
                           } else // иначе
                                 if (x!=0 && y == 0)// если x!=0 и y==0, то
                           { Console.WriteLine("Точка находится на оси X.");
                           } else // иначе
                                  { Console.WriteLine("Точка находится в начале координат.");
                                  }

                           Console.ReadKey();

        }
    }
}
