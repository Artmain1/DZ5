/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.Write("Введи трехкратное число:");
int number = Convert.ToInt16(Console.ReadLine());

if(number > 100 && number < 999)
{
    number = (number % 100 / 10);
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Введена не правильная цифра");
}
