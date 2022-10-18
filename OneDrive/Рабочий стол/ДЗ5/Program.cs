//Рандомный массив

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}




//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


/*int[] array = GetArray(5, 100, 1000);
Console.Write(String.Join(", ", array));
int even = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
    {
     even = even + 1;
    }
}
Console.WriteLine($" Количество {even}");*/



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19


/*int[] array = GetArray(5, 10, 100);
Console.Write(String.Join(", ", array));
int even = 0;


for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) 
    {
     even = even + array[i];
    }
}
Console.WriteLine($" Sum of odd {even}");*/



//Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем).
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*int[] array = GetArray(4, -100, 100);
Console.Write(String.Join(", ", array));
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
int sum = max - min;
Console.WriteLine($" Difference between max and min = {sum}");*/