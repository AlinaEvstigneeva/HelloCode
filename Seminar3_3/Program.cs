// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
double pointA1 = Convert.ToDouble(Console.ReadLine());
double pointA2 = Convert.ToDouble(Console.ReadLine());

double x1 = pointA1;
double y1 = pointA2;


Console.WriteLine("Введите координаты второй точки");
double pointB1 = Convert.ToDouble(Console.ReadLine());
double pointB2 = Convert.ToDouble(Console.ReadLine());

double x2 = pointB1;
double y2 = pointB2;


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double result = Math.Round(distance, 2);
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {result}");

