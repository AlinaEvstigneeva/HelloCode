// Напишиет программу, которая принимает на вход координаты точки ( X, Y), причем X не равен 0 и Y не равен 0 и выдает номер четверти
// плоскости, в которой находится эта точка.

bool CoorX = int.TryParse(Console.ReadLine(), out int x);

bool CoorY = int.TryParse(Console.ReadLine(), out int y);

if (!CoorX || !CoorY || x == 0 || y == 0)                       // ! - знак отрицания условия
                                                                // если было TRUE - программа переделывает на FALSE
{
    Console.WriteLine("Координаты ввели некорректно");
    return;
}

int quarterNumber = GetQuarterNumberByCoordinates(x, y);         // Чтобы код выполнился, необходимо вызвать метод.
                                                                // Написать его название и ввести параметры.
                                                                // int quarterNumber - название с типом данных
                                                                // GetQuarterNumberByCoordinates(x, y) - его параметры и переменные

if(quarterNumber == -1)
{
    Console.WriteLine("Ошибка");
    return;
}

Console.WriteLine(quarterNumber);

// возвращаемый_тип_данных НазваниеМетода()
// {
//     тело метода;
//     return;          оператор return возвращает из метода значение и останавливает его.
// }

int GetQuarterNumberByCoordinates(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }
    return -1;
}