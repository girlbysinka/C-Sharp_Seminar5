/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();

int[] array = new int[8];
GetRandomArray (array);
Console.WriteLine();

int count = 0;

for (int i = 0; i < array.Length; i++)
        {
            int remainder = array[i]%2;
            if (remainder == 0)
                {
                  count = count + 1; 
                }
        }

Console.WriteLine($"Количество чётных чисел в массиве составляет {count}");

void GetRandomArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100,999);
            Console.Write($"{array[i]} ");
        }
    } 