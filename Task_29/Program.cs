// Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
    // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

    Console.WriteLine("Массив случайных чисел из 8 эл.");

    int[] array = new int[8];
    Random rnd = new Random();
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
      array[i] = rnd.Next(0, 101);
      Console.Write($"{array[i]}");
      if (i != array.Length - 1)
        Console.Write(", ");
    }
    Console.WriteLine("]");
