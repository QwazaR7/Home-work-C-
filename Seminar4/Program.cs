﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
    {
        sum += current;
    }
    /*
    int current = 1;
    while(current <= num)
    {
        sum += current;
        current++;
    }
    /
    return sum;
}
Console.Write("Input a positive number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of elements form 1 to {a} is {result}");
*/
/*
int a;

do
{
    Console.Write("Input positive number; ");
    a = Convert.ToInt32(Console.ReadLine());
}
while(a < 0);
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int DigitCount(int number)
{
    int count = 0;
    while(number != 0)
    {
        number/=10;
        count++;
    }
    return count;
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Factorial(int number)
{
    int result = 1;
    /* for(int i = 1; i <= number; i++)
        result *= i; */
        
    while(number > 1)  result *= number--;
       // number--;
    return result;
}

Console.Write("Enter number N: ");
//int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(Convert.ToInt32(Console.ReadLine())));