// Домашняя работа по 4 семинару

/*
Задача 1
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

/*

int MyMathPow(int number, int power)
{
    int result = 1;

    while(power > 0)
    {
        result *= number;
        power--;
    }

    return result;
}

Console.WriteLine("Данная программа принимает 2 целых числа и возводит первое число");
Console.WriteLine("в натуральную степень второго числа.");

Console.Write("Введите, пожалуйста, первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите, пожалуйста, второе число: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат возведения числа {number} в степь {pow} равно: {MyMathPow(number, pow)}.");

*/

/*
Задача 2
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

/*

int GetSumDigit(int number)
{
    if(number < 0) number *= -1;

    int sum = 0;

    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.WriteLine("Данная программа принимает число и выдает сумму цифр в числе.");
Console.Write("Введите, пожалуйста, число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма разрядов числа {num} равна: {GetSumDigit(num)}.");

*/

/*
Задача 3
Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
*/

/*

int[] CreateArray(int amountOfElements)
{
    int[] array = new int[amountOfElements];
    
    for(int i = 0; i < amountOfElements; i++)
    {
        Console.Write("Введите, пожалуйста, значение: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Данная программа позволяет создать и вывести массив.");
Console.WriteLine("Для этого необходимо указать количество элементов и");
Console.WriteLine("указать последовательно значение для каждого элемента.");
Console.WriteLine();

Console.Write("Введите, пожалуйста, количество элементов в массиве: ");
int amount = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(amount));

*/