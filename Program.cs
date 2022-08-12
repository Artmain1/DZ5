/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int number = ReadInt("Введи трехкратное число:");

if (number > 100 && number < 999)
{
    num(number);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Введена не правильная цифра");
}

int num(int a)
{
    return a % 100 / 10;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}