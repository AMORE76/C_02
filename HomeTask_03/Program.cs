﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Порядковый номер дня недели: ");

int DayNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayNumber);

if ( DayNumber == 6 || DayNumber == 7 )
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний  день");
}
