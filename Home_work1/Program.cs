﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("The number are equal");
}
if (num1 > num2)
{
    Console.WriteLine("The first number is larger");
}
if (num1 < num2) 
{
    Console.WriteLine("The second number is larger");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(num1 > max)
{
 max = num1;
}
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}
Console.WriteLine("Maximum number: " + max);
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

/*
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Yes");
}
if(num % 2 == 1)
{
    Console.WriteLine("No");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int grow = 2;
while(grow <= n)
{
    Console.Write(grow + " ");
    grow = grow + 2;
}
*/