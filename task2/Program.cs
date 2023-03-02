// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите c1");
double c1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите c2");
double c2 = double.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x1 - x2 , 2) + + Math.Pow(y1 - y2 , 2) + Math.Pow(c1 - c2 , 2));
Console.WriteLine($"distance - {distance:f2}");

