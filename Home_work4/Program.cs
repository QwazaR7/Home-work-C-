// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
void DegreeNum (int num1, int num2)
{
    int res = num1;
    int count = 1;
    while(count < num2)
    {
        res = res * num1;
        count++;
    }
    Console.WriteLine(res);
}
Console.Write("Enter a number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
DegreeNum(num1, num2);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void SumNum (int num)
{
    int set = num;
    int unit = 0;
    int result = 0;
    while(set > 0)
    {
        unit  = set%10;
        set = set/10;
        result += unit;
    }
    Console.WriteLine($"The sum of digits in a number = {result}");
}
Console.Write("Enter a number: ");
SumNum(Convert.ToInt32(Console.ReadLine()));
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] TheMainArray(int length) //, int minValue, int maxValue можно добавить, чтобы задать диапозон чисел в массиве
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
        array[i] = new Random().Next(0,1000+1);

    return array;    
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}
Console.Write("Specify the length of the array: ");
ShowArray(TheMainArray(Convert.ToInt32(Console.ReadLine())));
*/