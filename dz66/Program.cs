/*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
using System;
using static System.Console;
Clear();

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void ResultSum(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма равна: {sum}");
        return;
    }
    sum = sum + (M++);
    ResultSum(M, N, sum);
}
ResultSum(M, N, 0);
