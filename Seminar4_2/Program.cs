// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5


// Console.WriteLine("Введите число");

// int number = int.Parse(Console.ReadLine());

// int DetermineHowManyDigits(int number)
// {
//     int count = 0;
//     if (number >= 0)
//     {
//         count = 1;
//         while (number > 9)
//         {
//             number = number / 10;
//             count++;
//         }
//     }
//     return count;
// }

// int result = DetermineHowManyDigits(number);
// Console.WriteLine(result);




// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120


// Console.WriteLine("Введите число: ");

// int number = int.Parse(Console.ReadLine());

// int FindProductOfNumbers(int number)
// {
//     int product = 1;
//     for( int i = 1; i <= number; i++)
//     {
//         product *= i;
//     }
//     return product;
// }

// int result = FindProductOfNumbers(number);
// Console.WriteLine(result);





// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] FillArray()
{
    int [] newArray = new int [8];
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(0, 2); 
    }
    return newArray;
}

int[] randomArray = FillArray();


void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

PrintArray(randomArray);


