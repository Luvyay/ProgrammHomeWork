// Домашняя работа по 3 семинару.

/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
*/

/*

bool IsPalindrome(int number)
{
    //Данная функция получает число и переворачивает его, после чего осуществляет проверку
    //и на выходе возвращает истину или ложь.
    
    int copyNumber = number;
    if(copyNumber > 9)
    {
        int turnOverNumber = 0;

        while(copyNumber > 0)
        {
            turnOverNumber *= 10;
            turnOverNumber += copyNumber % 10;

            copyNumber /= 10;
        }

        if(number == turnOverNumber) return true;
        else return false;
    }
    else return false;
}

Console.WriteLine("Данная программа принимает число и определяет является ли");
Console.WriteLine("данное число палиндромом или нет.");
Console.WriteLine("---------------------------------------------------------");

Console.Write("Введите, пожалуйста, число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(IsPalindrome(num)) Console.WriteLine("Данное число является палиндромом!");
else Console.WriteLine("Данное число не является палиндромом!");
*/

/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
*/

/*

double GetDistance3D(double xPos1, double yPos1, double zPos1, double xPos2, double yPos2, double zPos2)
{
    double xDistance = Math.Pow(xPos2 - xPos1, 2);
    double yDistance = Math.Pow(yPos2 - yPos1, 2);
    double zDistance = Math.Pow(zPos2 - zPos1, 2);

    return Math.Round(Math.Sqrt(xDistance + yDistance + zDistance), 2);
}

Console.WriteLine("Данная программа находит расстояние между 2 точками");
Console.WriteLine("в 3D пространстве.");

Console.Write("Введите, пожалуйста, координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, пожалуйста, координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние равно: {GetDistance3D(x1, y1, z1, x2, y2, z2)}.");
*/

/*
Задача 3
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
*/

/*

void GetAllCub(int number, int initialValue)
{
    int count = initialValue;

    while(count <= number)
    {
        Console.WriteLine($"{count} -> {Math.Pow(count, 3)}.");
        count++;
    }
}

Console.WriteLine("Данная программа принимает любое целое число от 1 и выводит");
Console.WriteLine("таблицу кубов от 1 до указанного числа.");

Console.Write("Введите, пожалуйста, любое целое число от 1: ");
int num = Convert.ToInt32(Console.ReadLine());

int initValue = 1;

while(num < initValue)
{
    Console.WriteLine("Введено не корректное значение!");
    Console.Write("Введите, пожалуйста, любое целое число от 1: ");
    num = Convert.ToInt32(Console.ReadLine());
}

GetAllCub(num, initValue);
*/