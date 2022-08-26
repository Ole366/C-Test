 /*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 3, n = 2 -> A(m,n) = 29
    */
    Console.WriteLine("Задание 68. Функция Аккремана");


    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int functionAkkerman = Akkerman(m, n);

    Console.Write(functionAkkerman);

    int Akkerman(int m, int n)
    {
      if (m == 0) return n + 1;
      else if (n == 0) return Akkerman(m - 1, 1);
      else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
  