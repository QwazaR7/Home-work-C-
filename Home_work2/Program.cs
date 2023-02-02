// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
int SecondNumber ( int number )
{
    int dec = number / 10;
    int result = dec % 10;
    if (number > 999 || number < 100)
    {
       result = -1;
    }
    return result;
} 
Console.Write("Enter a tree-digit number: ");
int numUser = Convert.ToInt32(Console.ReadLine());
int numAlt = SecondNumber(numUser);
Console.WriteLine($"A finite number: {numAlt}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.


 int ThirdDigit ( int num )
 {
    int result = -1;
    if (num >=100 && num <=999)
    {
        result = num % 10;
    }
    if (num >=1000 && num <= 9999)
    {
        int dec = num / 10;
        result = dec % 10;
    }
    if (num >=10000 && num <=99999)
    {
        int sot = num / 100;
        result = sot % 10;
    }
    if (num >=100000 && num <=999999)
    {
        int thous = num / 1000;
        result = thous % 10;
    }
    if ( num >= 1000000 && num <=9999999)
    {
        int mill = num / 10000;
        result = mill % 10;
    }
    return result;
 }
 Console.Write("Enter your number: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int digit = ThirdDigit(number);
 Console.WriteLine($"{digit} the third digit of the number {number}");

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekday (int num)
{
    bool day = false;
    if ( num > 5 && num <= 7)
    {
        day = true;
    }
    return day;
}  
Console.Write("Enter a number from 1 to 7: ");
int numDay = Convert.ToInt32(Console.ReadLine());
bool result = Weekday(numDay);
Console.WriteLine(result);
*/