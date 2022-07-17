
    // Напишите программу, которая на вход принимает число (N), 
    // а на выходе показывает все чётные числа от 1 до N.
    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8
    
    Console.WriteLine("Вывод четных чисел от 1 до N");
    Console.Write("Введите число N > 1): ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n >= 2)
    {
      for (int i = 2; i <= n; i += 2)
      {
        Console.Write(i + " ");
      }
    }
    else
    {
      Console.WriteLine("Некорректный ввод");
    }
