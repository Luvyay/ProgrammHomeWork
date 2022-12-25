// Домашняя работа по 3 семинару.

/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
*/



bool IsPalindrome(int number)
{
    /*
        Данная функция получает число и переворачивает его, после чего осуществляет проверку
        и на выходе возвращает истину или ложь.
    */
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
