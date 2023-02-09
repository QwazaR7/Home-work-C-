//Задача 21 Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LenthPoint(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double kat1 = xB - xA;
    double kat2 = yB - yA;
    double kat3 = zB - zA;
    double gip = Math.Sqrt(Math.Pow(kat1,2)+Math.Pow(kat2,2)+Math.Pow(kat3,2) );
    return gip;
}

Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB: ");
double zB = Convert.ToDouble(Console.ReadLine());
double result = LenthPoint(xA,yA,zA,xB,yB,zB);
Console.WriteLine(Math.Round(result,2));
*/

//Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableCub (int num)
{
    int count = 1;
    while (count <= num) 
    {
        Console.Write(Math.Pow(count,3) + " ");
        count++;
    }
}
Console.Write("Enter a number: ");
int cub = Convert.ToInt32(Console.ReadLine());
TableCub(cub);
*/

//Задача 19 Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

/*
bool PalindromeNum (int num)
{
    int set = num;
    int result = 0;
    int dec = 0;
    while(set > 0)
    {   
        dec = set % 10;
        set = set / 10; 
        result = result * 10 + dec;

    }
    return result == num;

}
void ResultFact(bool res)
{
    if(res == true)
    Console.WriteLine("Yes");
    else Console.WriteLine("No");
    
}

Console.Write("Enter a number: ");
int sum = Convert.ToInt32(Console.ReadLine());

ResultFact((PalindromeNum(sum)));
*/