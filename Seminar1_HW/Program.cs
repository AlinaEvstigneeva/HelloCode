// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine("a > b");
//  }
// if(a == b)
//  {
//      Console.WriteLine("a = b");
//  }
// else
// {
//     Console.WriteLine("b > a");
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// int maxNum = 0;

// if(a > b)
// {
//     maxNum = a;
// }
// else
// {
//     maxNum = b;
// }
// if(maxNum > c)
// {
//     Console.WriteLine(b);
// }
// else
// {
//     Console.WriteLine(c);
// }




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// int number = int.Parse(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine("Четное");
// }
// else
// {
//     Console.WriteLine("Нечетное");
// }




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N = int.Parse(Console.ReadLine());

int i = 1, k = 1;            
while (i <= N)
{
	if (i % 2 == 0)
	{
		Console.WriteLine(i);
		k++;
	}
	if (k > N)
	{
		break;
	}
	i++;
}
