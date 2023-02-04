/*
Задача 1.
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/

/*

void ShowNumsFromN(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNumsFromN(num - 1);
}

Console.Write("Input a number N greater than or equal to 1: ");
int numN = Convert.ToInt32(Console.ReadLine());

while(numN <= 0)
{
    Console.WriteLine("Wrong number entered. Your number N less than 1.");
    Console.Write("Input a number N greater than or equal to 1: ");
    numN = Convert.ToInt32(Console.ReadLine());
}

ShowNumsFromN(numN);

*/

/*
Задача 2.
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/

/*

int GetSumFromMToN(int numM, int numN)
{
    if(numM < numN)
    {
        if(numM < numN) return numM + GetSumFromMToN(numM + 1, numN);
        return numM;
    }
    else if(numN < numM)
    {
        if(numM > numN) return numM + GetSumFromMToN(numM - 1, numN);
        return numM;
    }
    else return numM;
}

Console.Write("Input a number M greater than or equal to 1: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N greater than or equal to 1: ");
int numN = Convert.ToInt32(Console.ReadLine());

while(numM < 1 || numN < 1)
{
    Console.WriteLine("Wrong number entered. Your number M or number N less than 1.");
    Console.Write("Input a number M greater than or equal to 1: ");
    numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number N greater than or equal to 1: ");
    numN = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Sum of natural numbers from {numM} to {numN} equal {GetSumFromMToN(numM, numN)}.");

*/

/*
Задача 3.
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

/*

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Input a number M greater than or equal to 0: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N greater than or equal to 0: ");
int numN = Convert.ToInt32(Console.ReadLine());

while(numM < 0 || numN < 0)
{
    Console.WriteLine("Wrong number entered. Your number M or number N less than 0.");
    Console.Write("Input a number M greater than or equal to 0: ");
    numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number N greater than or equal to 0: ");
    numN = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Result function Akkerman({numM}, {numN}) is equal to {Akkerman(numM, numN)}.");

*/
