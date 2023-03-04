/* string[,] table = new string[2, 3];       // двумерные массивы задаются по аналогии с одномерными.
                                        // Запятая в кв скобках указывает на размерность массива:
                                        // одна , - 2D массив, две ,, - 3D массив и тд.

int[,] matrix = new int[5, 8];     // 5 - кол-во строк, 8 - кол-во столбцов */

/*string[,] table = new string[2, 5];
table[1, 2] = "слово";      // table[1, 2] - обращаемся к определенному элементу или присвоение значеения элементу.
                            // 1 и 2 - в данном случае это индексы 

// table [0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table [1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
// String.Empty - константа для инициализации строк

for (int rows = 0; rows < 2; rows++)    // rows - строки
{
    for (int columns = 0; columns < 5; columns++)   // columns - столбцы
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */

/* void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // matrix.GetLength(0) - данная конструкция обратится к строкам и выдаст их кол-во
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) - данная конструкция обратится к столбцам и выдаст их кол-во
        {
            Console.Write($"{matrix[i, j]} ");  //Write без Line, чтобы счетчик не перескакивал на след строчку после каждого цикла.
        }
        Console.WriteLine();    //указываем данную команду, чтобы перескочить на следующий столбец.
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); */








// Рекурсия - метод, который вызывает сам себя.

// Факториал
// 5! = 5 * 4 * 3 * 2 * 1

/* int Factorial(int n)
{
    // 1! = 1
    // 0! = 1                                       // int работает с небольшими числами, далее программа тупит
    if (n == 1) return 1;                           // на помощь приходит тип данных double, он рабоате с числами побольше
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5)); //1*2*3 =6 */



// Число Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}