﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int NaturalNumber (int N)
{
    if (N == 1) return N;
    Console.Write($"{N}, ");
    return NaturalNumber(N-1); 
}
Console.WriteLine(NaturalNumber(N));


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
//от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumber(int M, int N2)
{
    if (M == N2) return N2;
    return  M + SumNaturalNumber(M+1, N2);
}
Console.WriteLine(SumNaturalNumber(M, N2));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите минимальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
System.Console.WriteLine(Ackermann(m, n));



