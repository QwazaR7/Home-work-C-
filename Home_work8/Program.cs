// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreatRandom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of cells: ");
    int cells = Convert.ToInt32(Console.ReadLine());
    
    int[,,] array = new int[rows,columns,cells];

    for(int i=0; i < rows; i++)
        for(int j=0; j<columns; j++)
            for(int n=0; n<cells; n++)
                array[i,j,n]= new Random().Next(10,100);
        
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int n=0; n <array.GetLength(2); n++)
                Console.Write($"{array[i,j,n]} ({i},{j},{n})" + " ");
            Console.WriteLine();    
        }
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int [,,] myArray = CreatRandom3dArray();
Show3dArray(myArray);

*/

// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortingArray (int[,] array)
{

        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1)-1; j++)
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                     if (array[i,k] < array[i,k+1])
                    {
                        int temp = array[i,k];
                        array[i,k] = array[i,k+1];
                        array[i,k+1] = temp;
                    }    

}

int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);

SortingArray(myArray);

Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
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

int[] SmallerAmountArray (int[,] array)
{
    int [] sumArray = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            sumArray[i] += array[i,j];
    return sumArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

void ShowMinRows (int[] array)
{
    int arrMin = array[0];
    int min = 0;
    for(int i = 0; i < array.Length; i++)
        if(arrMin > array[i])
        {
            arrMin = array[i];
            min = i;
        }
    Console.WriteLine($"Minimum amount per line № {min+1}.");
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
int[] minLinesArray = SmallerAmountArray(newArray);
ShowArray(minLinesArray);
ShowMinRows(minLinesArray);

*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*

int[,] SpiralArray(int size)
{
int[,] array = new int[size,size];
int num = 1;
int i = 0;
int j = 0;

while (num <= 4 * 4)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    num++;
}
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

int[,] newArray = SpiralArray(4);
Show2dArray(newArray);

*/