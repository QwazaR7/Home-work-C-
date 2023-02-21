// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] PositiveNumArray()
{
    Console.Write("Specify the number of numbers: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];
    return array;
}

void FillingArray(int[] array)
{
    if(array.Length != 0)
        for(int i=0; i<array.Length; i++)
        {
            Console.Write($"Enter your number {i+1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        } 
}

int PositiveNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i]>0)
            count++;
    return count;        
}

int[] numArray = PositiveNumArray();
FillingArray(numArray);
Console.WriteLine("numbers greater than zero: "+PositiveNum(numArray));
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*

double[] LinearEquation()
{
    Console.Write("Set the value a1: ");
    var a1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Set the value b1: ");
    var b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Set the value a2: ");
    var a2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Set the value b2: ");
    var b2 = Convert.ToDouble(Console.ReadLine());

    var x = Math.Round((b1-b2)/(a2-a1), 2);
    var y = Math.Round((a2*b1-a1*b2)/(a2-a1), 2);
    double[] result = {x,y};
    return result;
}

double[] resCord = LinearEquation();
Console.WriteLine($"The lines intersect in coordinates {resCord[0]} and {resCord[1]}");

*/