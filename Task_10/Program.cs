// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
    // 456 -> 5
    // 782 -> 8
    // 918 -> 1

    Console.WriteLine("Вывод второй цифры трехзначного числа");
    Console.Write("Введите трехзначное число: ");
    int userAnswer = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (userAnswer <= 99 || userAnswer >= 1000)
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    Console.WriteLine(userAnswer / 10 % 10);