//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
*/
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i+j.0 Выведите полученный массив на экран.

/*
int[,] CreatRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j=0; j<columns; j++)
            array[i,j]= i + j;
        
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
int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);

  Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

*/
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
void SquaresOfNumber(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i= i+2)
        for(int j =0; j<array.GetLength(1); j= j+2)
            array[i,j] *= array[i,j];
}


int[,] newArray = CreatRandom2dArray();
SquaresOfNumber(newArray);
Show2dArray(newArray);
*/

//Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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
void SumArray(int[,] array)
{
    int sum = 0;
    for(int i=0; i < array.GetLength(0); i++)
        sum += array[i,i];
    Console.WriteLine($"Sum nuumbers = {sum}");          
}
int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
SumArray(newArray);