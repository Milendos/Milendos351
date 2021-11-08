using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive28090
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Массив
            backData:
            Console.WriteLine("Введите границы массива:");
            int BorderArray = int.Parse(Console.ReadLine());

            string[] ArrayText = new string[BorderArray]; //5
            for (int step = 0; step < ArrayText.Length; step++)
            {
                Console.Write($"Значение для {step}-индекса: ");
                Console.WriteLine();
                ArrayText[step] = Console.ReadLine();
            }
            Console.WriteLine("Ввод данных закончен! Ура! :3");

            Console.WriteLine("Введеный ранее вами массив:");
            foreach (string item in ArrayText)
            {
                Console.WriteLine(item);
            }
            goto backData;
            #endregion
            Console.ReadKey();
        }
    }
}
