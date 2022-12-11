// Задача 18: Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int numberOfQuarter = int.Parse(Console.ReadLine());

int possibleCoordinates = RangeOfPossibleCoordinates(numberOfQuarter);


int RangeOfPossibleCoordinates( int numberOfQuarter)
{
    if (numberOfQuarter == 1)
    {
        Console.WriteLine(" x > 0 && y > 0 ");
    }

    if (numberOfQuarter == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }

    if (numberOfQuarter == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
    }

    if (numberOfQuarter == 4)
    {
        Console.WriteLine("x > 0 && y < 0");
    }
    return -1;
}

