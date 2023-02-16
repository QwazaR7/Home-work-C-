// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] ThreeDigitNumbersArray (int length)
{
    int[] array = new int[length];
    for(int i=0; i < length; i++)
        array[i] = new Random().Next(100,1000);
    return array;        
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int NumberOfEvenNum(int[]array)
{
    int quantity = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i]%2 == 0)
            quantity++;
    return quantity;        
}
Console.Write("Specify the length of the array: " );
int[] newArray = ThreeDigitNumbersArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(newArray);
Console.Write("Number of even numbers: " + NumberOfEvenNum(newArray));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] NewArray (int length, int maxValue)
{
    int[] array = new int[length];
    for(int i=0; i<length; i++)
        array[i] = new Random().Next(0,maxValue);
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int SumNumbersArray(int[] array)
{
    int sumArray = 0;
    for(int i=1; i < array.Length; i=i+2)
        sumArray+=array[i];
    return sumArray;    
}

Console.Write("Set the length of the array: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
Console.Write("Set the maximum number in the array: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] sumArray = NewArray(arrLen,maxNum);

ShowArray(sumArray);
Console.WriteLine(SumNumbersArray(sumArray));
*/

// Задача 38: Задайте массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] NewArray (int length, int maxValue)
{
    double[] array = new double[length];
    for(int i=0; i<length; i++)
        array[i] = new Random().Next(0,maxValue+1) + Math.Round(new Random().NextDouble(),2);
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double MaxNumDoubleArray(double[] array)
{
double max = array[0];
for (int i=1; i < array.Length; i++)
    if(max < array[i])
        max = array[i];
    return max;
}

double MinNumDoubleArray(double[] array)
{
double min = array[0];
for (int i=1; i < array.Length; i++)
    if(min > array[i])
        min = array[i];
    return min;
}

void VisidleActions(double num1)
{
    Console.WriteLine(num1);
    //Console.WriteLine(num2);
}

void DiffOfNum(double max, double min)
{
    double result = max - min;
    Console.WriteLine(Math.Round(result,2));
}

Console.Write("Input a length of new array: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double[] myArray = NewArray(num1,num2);
ShowArray(myArray);

double max = MaxNumDoubleArray(myArray);
VisidleActions(max);
double min = MinNumDoubleArray(myArray);
VisidleActions(min);
DiffOfNum(max,min);