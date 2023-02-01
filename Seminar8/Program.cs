int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}


/*
Задача 1
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

/*

void Sort2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sizeRows = array.GetLength(1);
        while(sizeRows > 0)
        {
            int minValue = 0;
            for(int j = 1; j < sizeRows; j++)
            {
                if(array[i,j] < array[i,minValue]) minValue = j;
            }

            int temp = array[i,sizeRows-1];
            array[i,sizeRows-1] = array[i,minValue];
            array[i,minValue] = temp;

            sizeRows--;
        }
    }
}

Console.WriteLine("This program sort array.");
int[,] newArray = CreateRandom2dArray();
Console.WriteLine();
Console.WriteLine("Unsorted array:");
Show2dArray(newArray);

Sort2dArray(newArray);
Console.WriteLine("Sorted array:");
Show2dArray(newArray);

*/

/*
Задача 2
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

/*

int GetMinValueInArray(int[] array)
{
    int minIndex = 0;

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < array[minIndex]) minIndex = i;
    }

    return minIndex;
}

int GetRowsWithMinSum(int[,] array)
{
    int[] lineSum = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            lineSum[i] += array[i,j];
        }
    }

    return GetMinValueInArray(lineSum) + 1;
}

Console.WriteLine("This program find row with min sum.");
Console.WriteLine();
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.WriteLine($"Number of row with min sum is: {GetRowsWithMinSum(newArray)}.");

*/

/*
Задача 3
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

/*

int[,] MultiplyArray(int[,] arrayA, int[,] arrayB)
{
    int[,] resultArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for(int i = 0; i < resultArray.GetLength(0); i++)
    {
        for(int j = 0; j < resultArray.GetLength(1); j++)
        {
            for(int k = 0; k < arrayB.GetLength(0); k++)
            {
                resultArray[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }

    return resultArray;
}

Console.WriteLine("This program calculate matrix product.");

Console.WriteLine("Create matrix A.");
int[,] newArrayA = CreateRandom2dArray();
Console.WriteLine("Create matrix B.");
int[,] newArrayB = CreateRandom2dArray();
Console.WriteLine("Show matrix A and matrix B.");
Show2dArray(newArrayA);
Show2dArray(newArrayB);

// Нужно сделать проверку "чтобы матрицу K можно было умножить на матрицу L нужно, чтобы число столбцов матрицы K равнялось числу строк матрицы L"
if(newArrayA.GetLength(1) == newArrayB.GetLength(0))
{
    int[,] multiArray = MultiplyArray(newArrayA, newArrayB);
    Console.WriteLine("Matrix product is:");
    Show2dArray(multiArray);
}
else Console.WriteLine("Numbers of matrix columns A not equal number of matrix rows B!");

*/

/*
Задача 4
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

/*

int TakeUniqueValueFromBufferArray(int[] array)
{
    int randomIndex = new Random().Next(0, array.Length);
    while(array[randomIndex] == 0) randomIndex = new Random().Next(0, array.Length);

    int result = array[randomIndex];
    array[randomIndex] = 0;
    
    return result;
}

int[,,] CreateRandom3dArray(int layers, int rows, int columns)
{
    int[,,] array = new int[layers, rows, columns];
    int amountNumbers = 90;
    int[] bufferArray = new int[amountNumbers];
    int startBufferArray = 10;

    for(int i = 0; i < bufferArray.Length; i++) bufferArray[i] = startBufferArray + i;

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                array[i,j,k] = TakeUniqueValueFromBufferArray(bufferArray);

    return array;
}

void Show3dArrray(int[,,] array)
{
    for(int layers = 0; layers < array.GetLength(0); layers++)
    {
        for(int rows = 0; rows < array.GetLength(1); rows++)
        {
            for(int columns = 0; columns < array.GetLength(2); columns++)
                Console.Write($"{array[layers,rows,columns]} ({rows};{columns};{layers}) | ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Input a numbero of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of layers: ");
int layers = Convert.ToInt32(Console.ReadLine());

if(rows * columns * layers <= 90)
{
    int[,,] newArray = CreateRandom3dArray(layers, rows, columns);
    Show3dArrray(newArray);
}
else 
{
    Console.WriteLine("Sorry your value is over 91. Calculate the value use the formula: rows * columns * layers.");
    Console.WriteLine($"Your value is {rows * columns * layers}.");
}

*/

/*
Задача 5
Напишите программу, которая заполнит спирально массив 4 на 4.
*/

/*

int[,] CreateSpiralArray()
{
    //Данная функция генерирует матрицу любых размеров и заполняет ее значениями по спирали.
    //1       2       3       4
    //14      15      16      5
    //13      20      17      6
    //12      19      18      7
    //11      10      9       8

    //Блок запроса информации для создания матрицы.
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int startValue = 1;
    int[,] array = new int[rows, columns];

    //Блок определения количества операций в главном цикле (двигаемся буквой "г" и 
    //число итераций равно меньшему значению столбца или строки).
    int size;

    if(rows >= columns) size = columns;
    else size = rows;

    //Блок инициализации вспомогательных счетчиков.
    int count = 0;
    int amountWriteInRowsColumnsEven = 0; //счетчик заполненных строк и столбцов правой "г".
    int amountWriteInRowsColumnsOdd = 0; //счетчик заполненных строк и столбцов левой "г".

    while(count < size)
    {
        //Если четное значение, то двигаемся по правой "г".
        if(count % 2 == 0)
        {
            for(int j = amountWriteInRowsColumnsOdd; j < columns - amountWriteInRowsColumnsEven; j++)
            {
                array[amountWriteInRowsColumnsEven,j] = startValue;
                startValue++;
            }
            //"int i = amountWriteInRowsColumnsEven + 1" - смещение на 1 строчку вниз.
            for(int i = amountWriteInRowsColumnsEven + 1; i < rows - amountWriteInRowsColumnsOdd; i++)
            {
                array[i,columns-amountWriteInRowsColumnsEven-1] = startValue;
                startValue++;
            }
            amountWriteInRowsColumnsEven++;
        }
        //Иначе по левой "г".
        else
        {
            for(int j = columns - amountWriteInRowsColumnsEven - 1; j >= amountWriteInRowsColumnsOdd; j--)
            {
                array[rows-amountWriteInRowsColumnsOdd-1,j] = startValue;
                startValue++;
            }
            //"int i = rows - amountWriteInRowsColumnsOdd - 2" - "-2" т.к. нужно сместить на 1 строчку вверх и подогнать
            //наше значение под пределы индексов.
            for(int i = rows - amountWriteInRowsColumnsOdd - 2; i >= amountWriteInRowsColumnsEven; i--)
            {
                array[i,amountWriteInRowsColumnsOdd] = startValue;
                startValue++;
            }
            amountWriteInRowsColumnsOdd++;
        }
        count++;
    }

    return array;

}

int[,] newArray = CreateSpiralArray();
Show2dArray(newArray);

*/
