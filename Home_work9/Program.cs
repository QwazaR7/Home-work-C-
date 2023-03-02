//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num-1);
}

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
/*
int SumNumber(int m, int n)
{
    if(m < n) return n + SumNumber(m,n-1);
    if(m > n) return m + SumNumber(m-1,n);
    else return 0;
}
int MinNumber(int m, int n)
{
    int min = m;
    if(min > n) min = n;
    return min;
}

Console.Write("Enter a number M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int minim = MinNumber(num1,num2);
int result = SumNumber(num1,num2) + minim;
Console.WriteLine($"Sum of all numbers {result}");
*/
/*
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}

Console.Write("Enter a number M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = FunctionAkkerman(num1,num2);
Console.WriteLine(result);
*/
// Функцию Аккермана честно стащил из сети. Не получилось самостоятельно с ней разобратьсяб
// при текущем уровне знаний =(