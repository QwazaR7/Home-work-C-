// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
       row2 >= 0 && row2 < array.GetLength(1) &&
       row1 != row2)
       {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;
        }
       }
    else Console.WriteLine("Error!");   
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of the first row for changing: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second row for changing: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray,r1,r2);
Show2dArray(newArray);

*/
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

void MatrixReplace (int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = i +1; j< array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
                    
}
int [,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
MatrixReplace(myArray);
Show2dArray(myArray);
*/


// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] MinNumArray(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] < array[minI,minJ])
             {
                minI = i;
                minJ = j;
             }
    int[] minimum = {minI,minJ};
    return minimum;
}

int[,] DeleteRowColum(int[,] array, int[] minimum)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0, x = 0; i < array.GetLength(0); i++)
        if(i != minimum[0])
        {
            for(int j = 0, y = 0; j < array.GetLength(1); j++)
                if(j != minimum[1])
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            x++;        
        }
        return newArray;
}


int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
int[] indexCord = MinNumArray(myArray);
ShowArray(indexCord);
int[,] stripArray = DeleteRowColum(myArray,indexCord);
Show2dArray(stripArray);