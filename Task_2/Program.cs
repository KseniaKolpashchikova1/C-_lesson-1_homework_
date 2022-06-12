using System;

Console.Write ("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());

int[] arr = { a, b, c };
Console.WriteLine("Maximum number is " + arr.Max());
