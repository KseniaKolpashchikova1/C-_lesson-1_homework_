using System;

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

//for (int i = 1; i<=a; i++)
while (i <= a)
{
if (i % 2 == 0) 
Console.Write(i); 
i = i+1;
}