Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(1, N));

string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (end + " " + PrintNumbers(start, end - 1));
}


/*Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine(CalcSum(N, M));

int CalcSum(int start, int end)
{
    if (start == end) return start;
    return start + CalcSum(start +1, end);
}*/


/*Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}*/