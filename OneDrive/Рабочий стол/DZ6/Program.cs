//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

/*Console.WriteLine("Сколько чисел вы хотите ввести?");
int M = int.Parse(Console.ReadLine()!);
int[] a = new int[M];
int sum = 0;
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < M; i++)
{
    a[i] = int.Parse(Console.ReadLine()!);
    if (a[i] > 0)
    {
        sum = sum + 1;
    }
}
Console.Write("Чисел больше нуля: ");
Console.WriteLine(sum);*/

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*Console.WriteLine("Введите точку b1");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку k1");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку b2");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку k2");
double k2 = int.Parse(Console.ReadLine()!);

if ((b1 == b2) && (k1 == k2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x}; {y})");
}*/


/*Console.WriteLine("Введите число от 50 до 100");
int A = int.Parse(Console.ReadLine()!);

int[] res = new int[10];
int sum = 1;
for (int i = 0; i < 10; i++)
{
    res[i] = new Random().Next(50, 100 + 1);
    Console.Write($"{res[i]} ");
    if (A > res[i])
    {
        sum = sum * res[i];
    }
}
Console.WriteLine();
if (sum == 1)
{
    Console.WriteLine($"Нет чисел меньше {A}");
}
else
{
    Console.WriteLine(sum);
}*/

