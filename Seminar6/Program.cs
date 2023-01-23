// Домашняя работа по 6 семинару.

/*
Задача 1
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

/*

int GetAmountPositiveNumber(int howManyNumbers)
{
    int result = 0;

    for(int count = 0; count < howManyNumbers; count++)
    {
        Console.Write("Пожалуйста, введите число: ");
        if(Convert.ToInt32(Console.ReadLine()) > 0) result++;
    }

    return result;
}

Console.WriteLine("Данная программа подсчитывает количество положительных чисел.");

Console.Write("Пожалуйста, укажите сколько чисел вы собираетесь ввести: ");
int howManyNumbers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество положительных чисел: {GetAmountPositiveNumber(howManyNumbers)}.");

*/

/*
Задача 2
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

/*

double[]  GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] intersectionPoints = new double[2];

    intersectionPoints[0] = (b2 - b1) / (k1 - k2);
    intersectionPoints[1] = k2 * intersectionPoints[0] + b2;

    return intersectionPoints;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }
}

Console.WriteLine("Данная программа находит точки пересечения двух прямых заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");

Console.Write("Введите, пожалуйста b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите, пожалуйста k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите, пожалуйста b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите, пожалуйста k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 != k2) ShowArray(GetIntersectionPoint(b1, k1, b2, k2));
else if(b1 != b2) Console.WriteLine("Прямые параллельны.");
else Console.WriteLine("Две прямые совпадают.");

*/
