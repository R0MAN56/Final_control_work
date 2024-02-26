using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите размер массива: ");
            int sym = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[sym];
            Console.WriteLine($"Введёный массив: {string.Join(",\t ", CrtArr())}");
            Console.WriteLine($"Новый массив: {string.Join(",\t", NewArr(array))}");
            string[] CrtArr()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите элемент массива {i}: ");
                    array[i] = Console.ReadLine();
                }
                return array;
            }
            int ChkArr(string[] array)
            {
                int cnt = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        cnt++;
                    }
                }
                return cnt;
            }
            string[] NewArr(string[] array)
            {
                string[] newArr = new string[ChkArr(array)];
                int n = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        newArr[n] = array[i];
                        n++;
                    }
                }
                return newArr;
            }
        }
    }
}