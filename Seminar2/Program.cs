// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

/*
int CutNumber(int number) // 
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

int num = new Random().Next(100, 1000);
//Console.Write("Input a number: ");
//int num = Convert.ToInt32(Console.ReadLine());

int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/


// Задача 2. Напишите программу, которая получает случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
/*
int NumberMax( int number)

{
    int dec = number/10;
    int ed = number%10;
    int result = ed;
    if(dec > result)
    {
        result = dec;
    }
    return result;

}

int num = new Random().Next(10,100);
int numMax = NumberMax(num);

Console.WriteLine(numMax);
*/

// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
bool Multiple(int num1, int num2)
{   
    int result = false;
    if(num2%num1 == 0)
    {
        rusult = true;
    }
    return result;
}

// Задача 4. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.