/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();

int[] array = new int[8];
GetRandomArray (array);
Console.WriteLine();

int sum = 0;

for (int i = 0; i < array.Length; i++)
        {
            int remainder = i%2;
            if (remainder != 0)
                {
                  sum = sum + array[i]; 
                }
        }

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, составляет {sum}");

void GetRandomArray (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0,10);
            Console.Write($"{array[i]} ");
        }
    } 