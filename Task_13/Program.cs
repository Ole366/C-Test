// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
    // 645 -> 5
    // 78 -> третьей цифры нет
    // 32679 -> 6

    Console.WriteLine("Вывод третьей цифры числа");
    Console.Write("Введите число: ");
    int userAnswer = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (userAnswer < 100)
    {
      Console.WriteLine("Третьей цифры нет");
      return;
    }

    while (userAnswer / 10 >= 100) userAnswer /= 10;
    Console.WriteLine(userAnswer % 10);