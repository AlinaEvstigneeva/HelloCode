// Выбрать самый первый элемент и в оставшейся части, с учётом нашей текущей позиции определить минимальный. 
// После того как он найден,нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, 
// это 6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.
// Было: 6 8 3 2 1 4 5 7
// Стало: 1 8 3 2 6 4 5 7


int[] array = { 6, 4, 8, 7, 3, 2, 1, 4, 5, 7 };

void PrintArray(int[] array)              // метод для печати массива на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)            // метод, который будет упорядочивать наш массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;                   // вводим переменную для минимального значения

        for (int j = i + 1; j < array.Length; j++)
        {                                                           // данный блок кода ищет минимальное значение
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];                       // в данном блоке мы меняем местами миннимальный элемент с текущим
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}



PrintArray(array);            //вызов метода для пеечати массива на экран
SelectionSort(array);         //вызов метода для упорядочивания массива

PrintArray(array);
