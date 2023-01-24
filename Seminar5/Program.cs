// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [- 9, 9]. 
// Найдите сумму отрицательных и положительных эелементов массива.
// Например, в массиве [3, 9, -8, 1,0, -7,2-1,8,-3, -1,6] сумма положительный чисел равна 29, сумма отрицательных равна -20.


// int[] array = GetArray(-9, 9, 12);
// int positiveSum = GetSumPositiveNumbers(array);
// int negativeSum = GetSumNegativeNumbers(array);
// PrintArray(array);


// int[] GetArray(int min, int max, int length)
// {
//     Random random = new Random();
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// int GetSumPositiveNumbers(int[] array)
// {
//     int sumPositive = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0)
//         {
//             sumPositive += array[i];
//         }
//     }
//     return sumPositive;
// }


// int GetSumNegativeNumbers(int[] array)
// {
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sumNegative += array[i];
//         }
//     }
//     return sumNegative;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     string message = string.Join(",", array);          // метод который позволяет печатать буквы и цифры в одной строке.
//     Console.WriteLine(message);                        // заводим под него отдельную перпеменную message.
// }

// Console.WriteLine($"Сумма положительный чисел равна {positiveSum}, сумма отрицательных равна {negativeSum}");





// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] array = GetNewArray(-5, 5, 7);
// int [] replacement = ReplacePositiveAndNegativeElements(array);
// PrintArray1(replacement);
// PrintArray2(array);


// int[] GetNewArray(int min, int max, int size)
// {
//     Random random = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// int [] ReplacePositiveAndNegativeElements(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = - array[i];
//     }
//     return newArray;
// }

// void PrintArray1(int[] newArray)
// {
//     Console.WriteLine(string.Join(", ", newArray ));
// }

// void PrintArray2(int[] array)
// {
//     Console.WriteLine(string.Join(", ", array ));
// }





// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да


// Console.Write("Задайте число, которое необходимо найти в массиве: ");
// int number = int.Parse(Console.ReadLine());
// int[] array = GetNewArray(-12, 12, 7);
// PrintArray(array);

// if(FindNumber(array, number ))
// {
//     Console.WriteLine($"Число {number}, содержится в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {number} нет в массиве");
// }


// bool FindNumber(int[] array, int number )
// {
//     bool result = false;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number)
//         {
//             result = false;
//             break;
//         }   
//     }
//     return result;
// }

// int[] GetNewArray(int min, int max, int size)
// {
//     Random random = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     string message = string.Join(",", array);          
//     Console.WriteLine(message);                        
// }






// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] array = GetNewArray(-100, 100, 123);
// int result = FindArrayElements(array, 10, 99);
// PrintArray(array);
// Console.WriteLine($" {array} -> {result}");


// int[] GetNewArray(int min, int max, int size)
// {
//     Random random = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// int FindArrayElements(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i] <= max)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(string.Join(",", array));         //красивая печать массива
//     }                  
// }






// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = GetArray(-9, 9, 10);
void PrintArray(array);


int[] GetArray(int min, int max, int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(string.Join(",", array));
    }                  
}

int 