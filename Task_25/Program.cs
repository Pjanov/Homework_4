/*  =====> Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.  */

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
double numA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B: ");
double numB = Convert.ToDouble(Console.ReadLine());

double Numberdegree(double number, in double degree) // возведение числа A, в степень B
{
    double temp = number;
    double count = degree;

    for (int i = 1; i < count; i++)
    {
        temp = temp * number;
    }
    return temp;
}

double res = Numberdegree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {res}");