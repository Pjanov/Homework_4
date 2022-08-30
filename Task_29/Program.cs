/* =====> Задача 29: 
Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.  */

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection) // Этот метод заполняет массив случайными числами от 1 до 8
{
    int length = collection.Length; // Команда, узнать кол-во элементов в массиве
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // в аргумент (collection) рандомно ложатся новые случайные числа от 1 до 10.
        index++;
    }
}

void PrintArray(int[] col) // Этот метод выводит по порядку значения массива в терминал  
{
    int count = col.Length;
    int i = 0;
    // Console.Write("Массив: ");
    while (i < count)
    {
        Console.Write($" {col[i]}{(i != count - 1 ? "," : " ")}"); // вывод в терминал
        i++;
    }
}

void Task29() // Выводит результат двух методов
{
    int length = 8;
    int[] array = new int[length];
    FillArray(array);
    PrintArray(array);
    Console.Write($"-> [");
    PrintArray(array);
    Console.Write($"]");
}

Task29();


