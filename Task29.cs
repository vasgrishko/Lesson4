﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(0, 9);
    }
}

void PrintArray(int[] arr)
{
   for(int i = 0; i < array.Length; i++) 
   {
        Console.Write($"{arr[i]}, ");
   } 
}

