/*
 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

int[,]point = new int[x1, y1];
void InputNumbers()
{
  for (int i = 0; i < point.GetLength(0); i++)
  {
    Console.Write($"Введите уравнение (y = k * x + b):\n");
    for (int j = 0; j < point.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите число k: ");
      else Console.Write($"Введите число b: ");
      point[i,j] = int.Parse(Console.ReadLine());
    }
  }
}

int[]Point(int[,] point)
{
  Point[0] = (point[1,1] - point[0,1]) / (point[0,0] - point[1,0]);
  Point[1] = Point[0] * point[0,0] + point[0,1];
  return Point;
}

