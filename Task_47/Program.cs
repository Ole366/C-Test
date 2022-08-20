 /*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
    */
    Console.WriteLine("Задание 47. Двумерный массив вещественных чисел");
    Console.WriteLine("Задайте размерность массива");
    Console.Write("Количество строк m: ");
    int countRow = Convert.ToInt16(Console.ReadLine());
    Console.Write("Количество столбцов n: ");
    int countCol = Convert.ToInt16(Console.ReadLine());

    double[,] numbers = new double[countRow, countCol];
    fillArray(numbers, countRow, countCol);

    for (int i = 0; i < countRow; i++)
    {
      Console.WriteLine();
      for (int j = 0; j < countCol; j++)
      {
        Console.Write($"{numbers[i, j]} ");
      }
    }

    void fillArray(double[,] array, int countRow, int countCol)
    {
      Random rnd = new Random();

      for (int i = 0; i < countRow; i++)
      {
        for (int j = 0; j < countCol; j++)
        {
          // random.NextDouble() * (maximum - minimum) + minimum;
          numbers[i, j] = Math.Round((rnd.NextDouble() * (10 + 10) - 10), 1);
        }
      }
    }
  
   