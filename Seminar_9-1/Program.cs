﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int num = 1;

string NumbersRec(int num, int N)
{
if (num <= N) return $"{N} "+ NumbersRec(num, N-1);
else return String.Empty;
}

Console.WriteLine(NumbersRec(num, N));
