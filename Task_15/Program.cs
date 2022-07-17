// Напишите программу, которая принимает на вход цифру, обозначающую день недели 
// и проверяет, является ли этот день выходным.
    // 6 -> да
    // 7 -> да
    // 1 -> нет

    Console.WriteLine("Проверка выходного дня");
    Console.Write("Введите день недели: ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());

    if (userAnswer > 7 || userAnswer < 1)
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    if (userAnswer == 6 || userAnswer == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");