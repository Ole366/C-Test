// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
 
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
 
Console.WriteLine("Поиск максимального числа");
    Console.Write("Введите три числа через пробел: ");
    int[] numbers = new int[3];
    try
    {
      string[] userAnswer = Console.ReadLine().Split(" ");

      // Is it really has no method to push element into arrays in C#?
      for (int i = 0; i < 3; i++)
        numbers[i] = Convert.ToInt32(userAnswer[i]);
    }
    catch
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
      if (numbers[i] > max)
        max = numbers[i];
    }

    Console.WriteLine("max = " + max);

