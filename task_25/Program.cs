// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

using System;

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getPow(int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;

}

int A = getUserData("Введите число А");
int B = getUserData("Введите число В");
int result = getPow(A, B);
Console.WriteLine($"Результат равен {result}");


