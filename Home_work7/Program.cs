// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] NewTwodimensArray(int line, int column)
{
    double[,] array = new double [line, column];

    for(int i = 0; i < line; i++)
        for(int j = 0; j < column; j++)
            array[i,j] = new Random().Next(-100,100)+Math.Round(new Random().NextDouble(),2);
    
    return array;        
} 

void Show2dArray(double[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

Console.Write("Enter the number of lines: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] myDoArray = NewTwodimensArray(line,column);
Show2dArray(myDoArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] CreatRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j=0; j<columns; j++)
            array[i,j]= new Random().Next(minValue,maxValue+1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

void Scanner2dArray(int[,] array, int a, int b)
{   
    int result = 0;
    if(a>=0 && a<=array.GetLength(0) 
    && b>=0 && b<=array.GetLength(1))
       for(int i = 0; i < a; i++)
        {   
            for(int j = 0; j < b; j++)
                result = array[i,j];     
        }
    else Console.WriteLine("The specified elemen does not exist");
    if(result == array[a-1,b-1])
        Console.WriteLine($"The desired element: {result}");
}

int[,] newArray = CreatRandom2dArray();

Show2dArray(newArray);

Console.Write("Specify the line number: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Specify the column number: ");
int column = Convert.ToInt32(Console.ReadLine());
Scanner2dArray(newArray,line,column);

*/

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

/*

int[,] CreatRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j=0; j<columns; j++)
            array[i,j]= new Random().Next(minValue,maxValue+1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

void ArithmeticMeanColumnArray (int[,] array)
{
    int x = array.GetLength(1);
    int y = array.GetLength(0);
    double [] sum = new double[x];
    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            sum[i] += array[j,i];
    for(int i = 0; i < x; i++)
    {
        Console.Write(Math.Round((sum[i] /y),2)  + "; ");
    }
}

int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
ArithmeticMeanColumnArray(myArray);

*/