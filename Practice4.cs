using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose = 3;
            string name = null;
            int pro = 0;
            Console.WriteLine("Добро пожаловать на Олимпийские игры!");

            Console.WriteLine("Чтобы вывести данные, нажмите 1");
            Console.WriteLine("Чтобы зарегистрировать спортсменов, нажмите 2");
            Console.WriteLine("Чтобы начать стрельбу, нажмите 3");

            Console.Write("Выберите ваше действие- ");

            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:

                    Console.WriteLine("Расстояние дистанции 18, 30 или 50 метров.");
                    Console.WriteLine("Виды луков - классический и блочный.");

                    break;
                case 2:
                    Console.WriteLine("Регистрация спортсменов");
                    Console.Write("Какое количество спортсменов будет выступать? -");

                    name = null.Parse(Console.ReadLine());





                    break;
                    







            }


        }
    }
}
