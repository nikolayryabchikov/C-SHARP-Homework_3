// Homework #3

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

/*
bool Palindrome(int num)
{
    int tempNum = num;
    int reversNum = 0;
    int lastDigit = 0;
    while (tempNum > 0)
    {
        lastDigit = tempNum % 10;
        reversNum = reversNum * 10 + lastDigit;
        tempNum /= 10;
    }

    if (reversNum == num) return true;
    return false;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Является ли число {num} палиндромом? ");
Console.WriteLine(Palindrome(num));
*/

//  Задача 21. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

/*
double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double lenghtX = x2 - x1;
    double lenghtY = y2 - y1;
    double lenghtZ = z2 - z1;

    double lenghtXYZ = Math.Sqrt(Math.Pow(lenghtX,2) + Math.Pow(lenghtY,2) + Math.Pow(lenghtZ,2));
    return lenghtXYZ;
}

Console.WriteLine("Введите координаты первой точки в трехмерном пространстве");
Console.Write("Координата X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки в трехмерном пространстве");
Console.Write("Координата X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Расстояние между этими точками: ");
Console.Write(Math.Round(Lenght(x1, y1, z1, x2, y2, z2), 2));

*/

// Task 23 Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int num)
{
    	for (int i = 1; i <= num; i++)
		Console.WriteLine($"{i} - {Math.Pow(i, 3)}");
}

Console.Write("Введите ваше число 'N': ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/
