 /*
 Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 N = 5. -> "5, 4, 3, 2, 1"
 N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
 

using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int number = Convert.ToInt32(ReadLine());
int count = 1;
ResultNamber(number, count);


void ResultNamber(int num, int count)
{
    if (count > num)
    {
        return;
    }
    else
    {
        ResultNamber(num, count + 1);
        Write(count + " ");
    }
}