/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

int value = new Random().Next(100,1000);

int x = value/100;
int y = value - x*100;
int z = y/10;
int result = z;

Console.WriteLine(value);
Console.Write("Вторая цифра заданного числа: ");
Console.Write( result);
