// Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11;  82 -> 10;  9012 -> 12   

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(num));

int SumNumbers(int num)
{
    int sum = 0;
    int i = num;
    while(num > 0)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    return(sum);
} 