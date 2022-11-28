/*Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9);

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int g = j+1; g < array.GetLength(1); g++)
            {
                if (array[i,g] > array[i,j])
                {
                    int max = array[i,j];
                    array[i,j] = array[i,g];
                    array[i,g] = max;
                }
            }
        }
    }
}


Console.WriteLine();
Console.WriteLine("Первоначальный массив");
PrintArray(array);

SortArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив");

PrintArray(array);



// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

int max1 = 0;
int max = 1000;
int row = 0;

void MaxRow(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           max1 = array[i,j] + max1;
        }
        if (max1 < max)
        {
            max = max1;
            max1 = 0;
            row = i;
        }
        else
        {
            max1 = 0;
        }
    }
}

MaxRow(array);
Console.WriteLine();
Console.WriteLine($"{row + 1} строка");

//Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] A = GetArray(rows, columns, 0, 9);
int[,] B = GetArray(rows, columns, 0, 9);
int[,] C = GetArray(rows, columns, 0, 9);

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           C[i,j] = 0;
           for (int f = 0; f < rows; f++)
           {
                C[i,j] = C[i,j] + A[i,f] * B[f,j];
           }
        }
    }

Console.WriteLine();
Console.WriteLine("Матрица А");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Матрица В");
PrintArray(B);
Console.WriteLine();
Console.WriteLine("Результирующая матрица С");
PrintArray(C);
Console.WriteLine();
*/

Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z");
int z = int.Parse(Console.ReadLine()!);

int[,,] array3 = GetArray3(x, y, z, 10, 99);
PrintArray3(array3);


int[,,] GetArray3(int m, int n, int p, int min, int max)
{
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                int element = new Random().Next(min, max + 1);
                Check(result, element);
                result[i, j, k] = element;
            }
        }
    }
    return result;
}


int Check(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == element)
                {
                    element = new Random().Next(10, 99);
                }
            }
        }
    }
    return element;
}

void PrintArray3(int[,,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}
