// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите число");

// int number = int.Parse(Console.ReadLine());

// if( number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if( number == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if( number == 3)
// {
//     Console.WriteLine("Среда");
// }
// if( number == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if( number == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if( number == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if( number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }




// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");

// int number = Math.Abs(int.Parse(Console.ReadLine()));    //Math.Abs(int.Parse(Console.ReadLine())) - оператор, который 
                                                            // любое введенное число делает положительным.

// for (int i = -number; i <= number; i++)
// {
//     Console.Write($"{i} ");         //$"{i} " - интерполяция
// }




// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число");

int number = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine( number % 10);


