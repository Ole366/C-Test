/*
    Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    массив размером 2 x 2 x 2
    12(0,0,0) 22(0,0,1)
    45(1,0,0) 53(1,0,1)
    */
    Console.WriteLine("Задание 60. Трехмерный массив");
    Console.WriteLine();

    int[,,] array3D = CreateArray3D();
    ShowArray3D(array3D);

    void ShowArray3D(int[,,] array3D)
    {
      for (int i = 0; i < array3D.GetLength(0); i++)
      {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
          // Console.Write($"X({i}) Y({j}) ");
          for (int k = 0; k < array3D.GetLength(2); k++)
          {
            Console.Write($"{array3D[i, j, k]}({i}, {j}, {k}) ");
          }
          Console.WriteLine();
        }
        Console.WriteLine();
      }
    }

    int[,,] CreateArray3D()
    {
      int[] temp = new int[8];
      int number;
      int[,,] resultArray = new int[2, 2, 2];

      for (int i = 0; i < temp.Length; i++)
      {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
          for (int j = 0; j < i; j++)
          {
            while (temp[i] == temp[j])
            {
              temp[i] = new Random().Next(10, 100);
              j = 0;
              number = temp[i];
            }
            number = temp[i];
          }
        }
      }
      int count = 0;
      for (int x = 0; x < 2; x++)
      {
        for (int y = 0; y < 2; y++)
        {
          for (int z = 0; z < 2; z++)
          {
            resultArray[x, y, z] = temp[count];
            count++;
          }
        }
      }

      return resultArray;
    }

  