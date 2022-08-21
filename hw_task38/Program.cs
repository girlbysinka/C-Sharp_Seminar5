/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();


double [] array = new double [8];
GetRandomArray (array);
Console.WriteLine();

double max = 0;
double min = 0;
double diff = 0;

for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                {
                    max = array[i];
                }
            else if (array[i] < min)
                {
                    min = array[i];
                }
        }
diff = max - min;
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива составляет {diff}");

void GetRandomArray (double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-10,10);
            Console.Write($"{array[i]} ");
        }
    } 
