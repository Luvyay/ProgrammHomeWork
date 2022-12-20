// Домашняя работа по 2 семинару.

/*
Задача 1
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
*/

/*

int ShowSecondNumber(int number)
{
    return number / 10 % 10;
}

Console.WriteLine("Данная программа принимает 3-х значное число");
Console.WriteLine("и выводит вторую цифру данного числа.");

Console.Write("Введите, пожалуйста, трех значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;

// Инициализируем цикл на введение корректного значения если оно было не корректным.
while(num < minValue || num > maxValue)
{
    Console.WriteLine("Было введено не корректное число!");
    Console.Write("Введите, пожалуйста, трех значное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int result = ShowSecondNumber(num);

Console.WriteLine($"Вторая цифра от числа {num} равняется {result}");
*/

/*
Задача 2
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
*/

/*

int CountingNumbers(int number)
{
    int copyNumber = number;
    int amountOfNumbers = 0;

    if(copyNumber == 0)
        amountOfNumbers++;
    else
    {
        // Цикл в котором отсекаем последнюю цифру и увеличиваем amountOfNumber (количество цифр).
        while(copyNumber != 0)
        {
            copyNumber /= 10;
            amountOfNumbers++;
        }
    }

    return amountOfNumbers;
}

int ShowThirdNumber(int number, int amount)
{
    // Инициализируем проверку на отрицательные числа и убираем знак минуса.
    if(number < 0) number *= -1;

    int divider = 1;

    // Инициализируем цикл в котором увеличиваем делимое, чтобы в дальнейшем отсечь не нужное от числа.
    while(amount > 0)
    {
        divider *= 10;
        amount--;
    }

    return number / divider % 10;
}

Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("Данная программа принимает любое целове число и выводит третью цифру.");
Console.WriteLine("Если 3-ей цифры нет, то программа сообщает об этом.");
Console.WriteLine("---------------------------------------------------------------------\n");

Console.Write("Введите, пожалуйста, любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int amountOfNum = CountingNumbers(num);
int serialNum = 3; // Переменная, которая указывает какое число будем выводить. Указана здесь, чтобы
// избавиться от магического числа.

// Проверяем есть ли третья цифра в числе и если нет, то выводим сообщение.
if(amountOfNum >= 3)
{
    int result = ShowThirdNumber(num, amountOfNum - serialNum);
    Console.WriteLine($"Третья цифра числа {num} равняется {result}.\n");
}
else
    Console.WriteLine("В заданном числе нет третьей цифры!\n");
*/

/*
Задача 3
Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

/*

bool DetermineDayOff(int day)
{
    if(day == 6 || day == 7) return true;
    else return false;
}

Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine("Данная программа принимает на вход цифру и выводит сообщение");
Console.WriteLine("является ли это выходным или нет.");
Console.WriteLine("---------------------------------------------------------------------\n");

Console.Write("Пожалуйста, введите число: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if(DetermineDayOff(dayOfWeek))
    Console.WriteLine("Данный день является выходным!");
else
    Console.WriteLine("Данный день не является выходным.");
*/