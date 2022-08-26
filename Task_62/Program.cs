/*  Задача 62. Заполните спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    1 2 3 4
    12 13 14 5
    11 16 15 6
    10 9 8 7
    */
    Console.WriteLine("Задание 62. Спиральное заполнение");
    Console.WriteLine();

    int[,] sqareMatrix = new int[4, 4];

    int currentNumber = 1;
    int i = 0;
    int j = 0;

    while (currentNumber <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
      sqareMatrix[i, j] = currentNumber;
      currentNumber++;
      if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
      else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
      else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
      else
        i--;
    }

    ShowArray2D(sqareMatrix);
  
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