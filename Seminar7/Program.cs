int constMinValue = 1;
int constMaxValue = 200;
int constRows = 4;
int constColumns = 5;

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }

}

double[,] CreateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    int[,] tempArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(tempArray[i,j] != maxValue) array[i,j] = tempArray[i,j] + Math.Round(new Random().NextDouble(), 3);
            else array[i,j] = tempArray[i,j];
    
    return array;
}

void ShowDouble2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }

}


/*
Задача 1
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

/*

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] newArray = CreateRandomDouble2dArray(rows, columns, constMinValue, constMaxValue);
ShowDouble2dArray(newArray);

*/

/*
Задача 2
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

/*

bool CheckExistence(int[,] array, int rows, int columns)
{
    if((rows <= array.GetLength(0) - 1) && (columns <= array.GetLength(1) - 1)) return true;
    else return false;
}

int GetValueFromArray(int[,] array, int rows, int columns)
{
    return array[rows, columns];
}

int[,] newArray = CreateRandom2dArray(constRows, constColumns, constMinValue, constMaxValue);
Show2dArray(newArray);

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(CheckExistence(newArray, rows, columns)) Console.WriteLine(GetValueFromArray(newArray, rows, columns));
else Console.WriteLine($"{rows} {columns} -> элемента с такими индексами в массиве нет.");

*/

/*
Задача 3
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

/*

double[] GetAverageColumns(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];

    for(int columns = 0; columns < array.GetLength(1); columns++)
    {
        for(int rows = 0; rows < array.GetLength(0); rows++)
        {
            averageArray[columns] += array[rows,columns];
        }
    }

    for(int i = 0; i < averageArray.Length; i++)
        averageArray[i] = Math.Round(averageArray[i] / array.GetLength(0), 3);

    return averageArray;
}

void ShowArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray(constRows, constColumns, constMinValue, constMaxValue);
Show2dArray(newArray);

double[] newAverageArray = GetAverageColumns(newArray);
ShowArray(newAverageArray);

*/