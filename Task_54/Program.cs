/*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по ?убыванию? (возрастанию?) элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    1 2 4 7
    2 3 5 9
    2 4 4 8
    */
    Console.WriteLine("Запущено задание 54. Элементы по возрастанию в каждой строке двумерного массива");

    // CreateArray();
    /*
    int[,] numbers = new int[3, 4]{
      {1, 4, 7, 2},
      {5, 9, 2, 3},
      {8, 4, 2, 4}};
    */

    int[,] numbers = createArray2Dimensional();
    ShowArray2D(numbers);
    Console.WriteLine("");
    Console.Write("----------------");
    BubbleSort(numbers);
    ShowArray2D(numbers);

    static int[,] createArray2Dimensional()
    {
      Random rnd = new Random();
      int countRow = rnd.Next(3, 10);
      int countCol = rnd.Next(4, 10);
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

    static void BubbleSort(int[,] array)
    {
      int countRows = array.GetLength(0);
      int countColumns = array.GetLength(1);

      for (int n = 0; n < countRows; n++)
      {
        for (int i = 0; i < countColumns; i++)
        {
          for (int j = 0; j < countColumns - 1 - i; j++)
          {
            if (array[n, j] > array[n, j + 1])
            {
              int temp = array[n, j];
              array[n, j] = array[n, j + 1];
              array[n, j + 1] = temp;
            }
          }
        }
      }
    }
  
  