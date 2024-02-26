# Итоговая контрольная работа по основному блоку
## **Условия задачи**

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на __GitHub__
2. Нарисовать блок-схему алгоритма _(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)_
3. Снабдить репозиторий оформленным текстовым описанием решения _(файл __README.md__)_
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом _(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)_

**Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
***
## Блок-схема:
![blok-shema.jpg](https://github.com/R0MAN56/Final_control_work/blob/main/blok-shema.jpg)

## Описание решения:
1. Создание репозитория на __GitHub__.
2. Создание локального репозитория в программе __VSCode__.
3. Cоздание блок-схемы в __drawio__.
4. Создание программы в __VSCode__.

Код программы:
```cs
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
```
6. Заполнение файла __README.md__.
7. Связывание локального и удаленнлого репозиториев.
