// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

using System;

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int sumOfDigits(int N)
{   int result = 0;
    while(N > 0)
    {
        int B = N % 10;
        result = result + B;
        N = N / 10;
    }
    return result;

}
int N = getUserData("Введите число: ");
int M = sumOfDigits(N);
Console.WriteLine($"Сумма цифр числа равна: {M}");





