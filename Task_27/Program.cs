/*  =====> Задача 27: 
Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.   */

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int number) // выдаёт сумму цифр в числе
{
    int count = number;
    int digit = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        digit = number % 10;
        result = result + digit;
        number = number / 10;
    }
    return result;
}

int sum = DigitSum(number);
Console.WriteLine($"Сумма цифр в числе: {number} -> {sum}");
