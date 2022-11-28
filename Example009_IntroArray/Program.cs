// Найти максимальное число сначала из первых трех чисел, потом максимальное из вторых трех чисел и из третьих трех чисел.
// Далле найти маскимальное сило из получившизся трех максимальных.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {15, 24, 35, 47, 58, 69, 73, 82, 96};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);