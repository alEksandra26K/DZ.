//*Напишите программу, которая принимает на вход пятизначное число 
//*и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

/*Console.WriteLine("Введите 5-ти значное чило: ");
String X = Console.ReadLine()!;
if ((X.Length == 5))
{
    int A = Convert.ToInt32(X[0]);
    int B = Convert.ToInt32(X[1]);
    int C = Convert.ToInt32(X[3]);
    int D = Convert.ToInt32(X[4]);
    if (A == D && B == C)
    {
        Console.WriteLine("Палиндромное число");
    }
    else if (A != D || B != C)
    {
        Console.WriteLine("Не палиндромное число");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}/*

//*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*Console.WriteLine("Введите координату х первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координату у первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координату z первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координату х второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координату у второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите координату z второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow ((x2 - x1), 2) + Math.Pow ((y2 - y1), 2) + Math.Pow ((z2 - z1), 2));
Console.WriteLine($"Расстояние между точками {result:f2}");
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*Console.WriteLine("Введите число N больше 1: ");
int N = int.Parse(Console.ReadLine()!);
int M = 1;

if (N < 1)

{
    Console.WriteLine("Вы ввели некоректное число N");

}
else
{
    while (M <= N)
    {
        Console.WriteLine($"{Math.Pow(M, 3)}, " );
        M = M +1;
    }
    
}*/