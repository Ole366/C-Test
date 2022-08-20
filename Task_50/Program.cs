
    /*
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    1, 7 -> такого числа в массиве нет
    */
    Console.WriteLine("Задание 50. Значение элемента в двумерном массиве");

    int[,] numbers = createArray2Dimensional();
    ShowArray(numbers);

    Console.WriteLine();

    Console.Write("Введите позицию элемента 'n,m' (через пробел, запятую или точку): ");
    int[] arrayElement = new int[2];

    char[] delimiterChars = { ' ', ',', '.', '\t' };
    try
    {
      string[] userAnswer = Console.ReadLine().Split(delimiterChars);
      arrayElement = Array.ConvertAll(userAnswer, s => int.Parse(s));
    }
    catch
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    if (arrayElement[0] > numbers.GetLength(0) || arrayElement[0] < 0)
    {
      Console.WriteLine("Такого числа в массиве нет");
      return;
    }
    if (arrayElement[1] > numbers.GetLength(1) || arrayElement[1] < 0)
    {
      Console.WriteLine("Такого числа в массиве нет");
      return;
    }

    Console.WriteLine($"({arrayElement[0]}, {arrayElement[1]}) -> {numbers[arrayElement[0], arrayElement[1]]}");

  static int[,] createArray2Dimensional()
  {
    Random rnd = new Random();
    int countRow = rnd.Next(2, 10);
    int countCol = rnd.Next(2, 10);
    int[,] numbers = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
      for (int j = 0; j < countCol; j++)
      {
        numbers[i, j] = rnd.Next(0, 10);
      }
    }
    return numbers;
  }
  static void ShowArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i, j]} ");
      }
    }
  }
