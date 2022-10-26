//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
/*Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue){
    double [,] result = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}


void PrintArray(double[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            Console.Write($"{Array[i,j]: 0.0} ");
        }
        Console.WriteLine();
    }
}*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
 //что такого элемента нет.
/*Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue){
    double [,] result = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}


void PrintArray(double[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            Console.Write($"{Array[i,j]: 0.0} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите i");
int i1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите j");
int j1 = int.Parse(Console.ReadLine()!);

if ((i1 > rows - 1) || (j1 > columns - 1))
{
    Console.WriteLine("Нет такого элемента");
}
else
{
    Console.WriteLine($"Ваш элемент: {array[i1, j1]: 0.0}");
}*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum = sum + array[i,j];
    }
    sum = sum / rows;
    Console.WriteLine($"Среднее арифметическое столбца {j} - {sum: 0.0}");
}*/