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


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

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