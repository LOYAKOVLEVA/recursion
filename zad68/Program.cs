﻿//Задача 68: Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());
        int result = AckermannFunction(m, n);
        Console.WriteLine("Результат функции Аккермана для m={0} и n={1} равен {2}", m, n, result);
        Console.ReadKey();
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
