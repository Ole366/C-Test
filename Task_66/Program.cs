﻿/*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
    */
    Console.WriteLine("Задание 66. Сумма натуральных элементов");

    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp = m;

    if (m > n)
    {
      m = n;
      n = temp;
    }

    PrintSumm(m, n, temp = 0);

    void PrintSumm(int m, int n, int sum)
    {
      sum += n;
      if (n <= m)
      {
        Console.Write($"Сумма элементов = {sum}");
        return;
      }
      PrintSumm(m, n - 1, sum);
    }
  