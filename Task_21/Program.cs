 // Напишите программу, которая принимает на вход координаты двух точек 
 // и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

    Console.WriteLine("Расстояние в пространстве ");

    int aX, aY, aZ, bX, bY, bZ;
    try
    {
      Console.WriteLine("Введите координаты точки A");
      Console.Write("X: ");
      aX = Convert.ToInt32(Console.ReadLine());
      Console.Write("Y: ");
      aY = Convert.ToInt32(Console.ReadLine());
      Console.Write("Z: ");
      aZ = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Введите координаты точки B");
      Console.Write("X: ");
      bX = Convert.ToInt32(Console.ReadLine());
      Console.Write("Y: ");
      bY = Convert.ToInt32(Console.ReadLine());
      Console.Write("Z: ");
      bZ = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    double distance = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2));

    Console.WriteLine("Расстояние в пространстве = " + Math.Round(distance, 2));