// Домашняя работа по 1 семинару.

/*
Задача 1.
Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
*/

/*
Console.WriteLine("Данная программа принимает 2 числа и выдает");
Console.WriteLine("какое число большее, а какое меньшее");
Console.Write("Введите, пожалуйста, первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите, пожалуйста, второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2)
{
    Console.WriteLine($"Оба числа равны друг другу.");
}
else if(number1 > number2)
{
    Console.WriteLine($"max: {number1}; min: {number2}");
}
else
{
    Console.WriteLine($"max: {number2}; min: {number1}");
}
*/

/*
Задача 2.
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

/*
Console.WriteLine("Данная программа принимает 3 числа и выдает максимальное");
Console.Write("Введите, пожалуйста, первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите, пожалуйста, второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите, пожалуйста, третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max_value = number1; // Предполагаем, что первое число наибольшее.

if(number2 > max_value) max_value = number2;
if(number3 > max_value) max_value = number3;

if(number1 == number2 && number2 == number3) // Проверяем равны ли все числа или нет.
{
    Console.WriteLine("Все числа равны");
}
else
{
    Console.WriteLine($"Максимальное число = {max_value}");
}
*/

/*
Задача 3.
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

/*
Console.WriteLine("Данная программа принимает число и проверяет четное оно или нет.");
Console.Write("Введите, пожалуйста, число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine($"Число: {number} - является четным.");
}
else
{
    Console.WriteLine($"Число: {number} - не является четным.");
}
*/

/*
Задача 4.
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

/*
int current = 1; // Данная переменная является минимальным значением для цикла.
Console.WriteLine("Данная программа принимает число и выводит");
Console.WriteLine($"все четные числа от {current} до указанного числа (включительно).");
Console.Write("Введите, пожалуйста, число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Если число было меньше минимального значения для цикла
// то переходим в цикл для ввода корректного значения.
while(number < current)
{
    Console.WriteLine("Введено не верное число!");
    Console.Write($"Пожалуйста, укажите число больше {current - 1}: ");
    number = Convert.ToInt32(Console.ReadLine());
}

while(current <= number)
{
    if(current % 2 == 0)
    {
        Console.WriteLine(current);
        current += 1;
    }
    else current += 1;
}

Console.WriteLine("Программа завершена.");
*/