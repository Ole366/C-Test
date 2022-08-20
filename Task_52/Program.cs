/*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    */
    Console.WriteLine("Задание 52. Среднее арифметическое в столбцах");

    int[,] numbers = createArray2Dimensional();
    ShowArray(numbers);
    Console.WriteLine();
    double[] results = CalculateArithmeticMean(numbers);

    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < results.Length; i++)
    {
      if (i == results.Length - 1)
      {
        Console.Write(results[i] + ".");
        return;
      }
      Console.Write(results[i] + "; ");
    }

    double[] CalculateArithmeticMean(int[,] arrayNumbers)
    {
      double[] results = new double[numbers.GetLength(1)];

      for (int i = 0; i < numbers.GetLength(1); i++)
      {
        int currentSum = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
          currentSum += numbers[j, i];
        }
        results[i] = Math.Round(currentSum / Convert.ToDouble(numbers.GetLength(0)), 1);
      }

      return results;
    }
  

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
