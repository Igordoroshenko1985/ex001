﻿Console.Clear();
Console.Write("Введите число А:");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B:");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число C:");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.Write(max);