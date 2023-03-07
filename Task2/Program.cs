// Задача 21: Напишите программу, которая 
// принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)

Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

Console.WriteLine (d);