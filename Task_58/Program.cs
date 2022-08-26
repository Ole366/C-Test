/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, заданы 2 массива:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    и
    1 5 8 5
    4 9 4 2
    7 2 2 6
    2 3 4 7
    Их произведение будет равно следующему массиву:
    1 20 56 10
    20 81 8 6
    56 8 4 24
    10 6 24 49
    */
    Console.WriteLine("Запущено задание 58. Произведение матриц");

    int[,] firstMatrix = createRectangularMatrix();
    int[,] secondMatrix = createRectangularMatrix();

    /*
    int[,] firstMatrix = {
      {1, 4, 7, 2},
      {5, 9, 2, 3},
      {8, 4, 2, 4},
      {5, 2, 6, 7}};
    int[,] secondMatrix = {
      {1, 5, 8, 5},
      {4, 9, 4, 2},
      {7, 2, 2, 6},
      {2, 3, 4, 7}};
    */

    Console.WriteLine("Первая матрица: ");
    ShowArray2D(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("\nВторая матрица: ");
    ShowArray2D(secondMatrix);

    int[,] result = MultiplyMatrix(firstMatrix, secondMatrix);

    Console.WriteLine();
    Console.WriteLine("\nПроизведение матриц:");
    ShowArray2D(result);

    int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
      int countRowsFirst = firstMatrix.GetLength(0);
      int countColumnsFirst = firstMatrix.GetLength(1);
      int countRowsSecond = secondMatrix.GetLength(0);
      int countColumnsSecond = secondMatrix.GetLength(1);

      if (countColumnsFirst != countRowsSecond)
      {
        Console.WriteLine("Умножение невозможно");
        return null;
      }
      else
      {
        int[,] resultMatrix = new int[countRowsFirst, countColumnsSecond];
        for (int i = 0; i < countRowsFirst; i++)
        {
          for (int j = 0; j < countColumnsSecond; j++)
          {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < countColumnsFirst; k++)
            {
              resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
          }
        }

        return resultMatrix;
      }
    }
    static int[,] createRectangularMatrix()
    {
      Random rnd = new Random();
      int countEl = rnd.Next(3, 4);
      int[,] matrix = new int[countEl, countEl];

      for (int i = 0; i < countEl; i++)
      {
        for (int j = 0; j < countEl; j++)
        {
          matrix[i, j] = rnd.Next(0, 10);
        }
      }
      return matrix;
    }
    
   static void ShowArray2D(int[,] array)
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