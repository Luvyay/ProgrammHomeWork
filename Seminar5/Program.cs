// Домашняя работа по 5 семинару.


int[] CreateIntRandArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}


/*
Задача 1
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

/*

int NumberOfEven(int[] array)
{
    int amount = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) amount++;
    }

    return amount;
}

Console.WriteLine("Данная программа создает массив со случайными положительными трехзначными числами.");
Console.WriteLine("И выводит количество четных чисел в массиве.");

Console.Write("Пожалуйста, введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = 100;
int maxValue = 999;

int[] newArray = CreateIntRandArray(size, minValue, maxValue);

ShowIntArray(newArray);
Console.WriteLine($"Количество четных элементов в массиве: {NumberOfEven(newArray)}.");

*/

/*
Задача 2
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

/*

int GetSumByPosition(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2) sum += array[i];

    return sum;
}

Console.WriteLine("Данная программа создает массив и находит сумму элементов,");
Console.WriteLine("стоящих на нечетных позициях.");

Console.Write("Пожалуйста, введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = -200;
int maxValue = 200;

int[] newArray = CreateIntRandArray(size, minValue, maxValue);

ShowIntArray(newArray);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна: {GetSumByPosition(newArray)}.");

*/

/*
Задача 3
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

/*

double[] CreateDoubleRandArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    int[] tempArray = CreateIntRandArray(size, minValue, maxValue);

    for(int i = 0; i < size; i++)
    {
        // Проверяем что случайная целая часть числа не является нашим пределом
        if(tempArray[i] != maxValue) array[i] = tempArray[i] + Math.Round(new Random().NextDouble(), 3);
        else array[i] = tempArray[i];
    }

    return array;
}

double DifferenceMaxMin(double[] array)
{
    double maxValue = array[0];
    double minValue = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxValue) maxValue = array[i];
        else if(array[i] < minValue) minValue = array[i];
    }

    return maxValue - minValue;
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Данная программа создает массив вещественных чисел");
Console.WriteLine("и находит разность максимального и минимального значения.");

Console.Write("Пожалуйста, введите число элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = -200;
int maxValue = 200;

double[] newArray = CreateDoubleRandArray(size, minValue, maxValue);

ShowDoubleArray(newArray);
Console.WriteLine($"Разность максимального и минимального значения равна: {DifferenceMaxMin(newArray)}.");

*/
