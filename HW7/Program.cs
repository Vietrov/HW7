using System;
using System.Text;

namespace Lesson
{
     class Program
    {
         static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = new int[30]; // создаем массив
            Random rand = new Random(); // создаем рандомный набор
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101); // Генерация чисел от 1 до 100
            }
            for (int j = 0; j < array.Length; j++) // создаем цикл
            {
                for (int n = 0; n < array.Length - j - 1; n++)
                {

                    if (array[n] > array[n + 1])
                    {
                        int k = array[n];
                        array[n] = array[n + 1]; // сравнение элементов массива
                        array[n + 1] = k;
                    }
                } 

            }

            for(int i = 0;i < array.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {array[i]}");
            }


        }
    }
}