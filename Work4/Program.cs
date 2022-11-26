Console.WriteLine("Задача 25:");
void Zadacha25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, который 
    //принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

    Random a = new Random();
    double numOne = a.Next(1, 10);
    Random b = new Random();
    double numSec = b.Next(1, 10);
    double Pow = Math.Pow(numOne, numSec);
    Console.WriteLine($"{numOne} в {numSec} степени:" + Pow);
}

Zadacha25();

Console.WriteLine("Задача 27:");
void Zadacha27()
{   
    //Задача 27: Напишите программу, которая принимает на вход число и 
    //выдаёт сумму цифр в числе.
    //452 -> 11
    Random rand = new Random();
    int num = rand.Next(0, 10000);
    int sum = num/1000%100 + num/100%10 + num/10%10 + num%10;
    Console.WriteLine($"Сумма цифр {num}=" + sum);
}

Zadacha27();


void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-100, 100);
    }
}

void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine("Задача 29:");
void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 
    //случайных целых чисел и выводит отсортированный по модулю массив.
    //-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19] 
    //6, 1, -33 -> [1, 6, -33]
    int size = 8;
    int[] a = new int[size];
    FillArray(a);
    PrintArray(a);
    for (int i = 0; i < size - 1; i++)
    {
        for (int j = 0; j < size - 1; j++)
        {
            if (Math.Abs(a[j]) > Math.Abs(a[j + 1]))
            {
                int t = a[j];
                a[j] = a[j + 1];
                a[j + 1] = t;
            }
        }
        if (Math.Abs(a[i]) > Math.Abs(a[i + 1]))
        {
            int t = a[i];
            a[i] = a[i + 1];
            a[i + 1] = t;
        }
    }
    PrintArray(a);
}

Zadacha29();





