//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);
int sum = A;
Console.WriteLine($"{A} , {B} -> {SumNamber(sum)} ");

    int SumNamber(int sum){
    for (int i = 1; i < B; i++)
    {
        sum =sum * A;  
    }
    return sum;
    }*/
    
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел {SumNamber(A)}");
int SumNamber( int A){
    int sum = 0;
    do
    {
        sum = sum + A % 10;
        A = A / 10;
    } while (A >= 1);
    return sum; 
    }*/

    //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinaryArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0 , 40);
    }
    return result;
}*/