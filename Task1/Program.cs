﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= n)
{
    PrintNaturalNumbers(m, n);
}
else
{
    Console.WriteLine("Значение M должно быть меньше или равно N.");
}

void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNaturalNumbers(m + 1, n);
    }
}
