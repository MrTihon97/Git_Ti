﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;


while (counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}