﻿// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.    23 + 0.19 NextDouble() 0 до 1 Важно.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetSumOfNegativs(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
 
    return sum;
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length,min,max);
ShowArray(myArray);

int sumOfNegativs = GetSumOfNegativs(myArray);
Console.WriteLine("sum of negativs is " + sumOfNegativs);
*/

// Задача 2. Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
int [] ArrayRandom (int length, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}
int [] ReversArray (int[] revers)
{
    for (int i = 0; i < revers; i++)
        revers[i] *= -1;
    return revers;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

ShowArray(ReversArray(ArrayRandom));


// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// Задача 4. Задайте массив из m случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].