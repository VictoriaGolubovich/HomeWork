﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите количество чисел");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [n];
// int kol=0;

// void Numbers(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.WriteLine("Введите число");
//         array[i]=Convert.ToInt32(Console.ReadLine());
//     }
// }
// int count(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//             kol++;
//         }
//     }
//     return kol;
// }
// Numbers(n);
// Console.Write($"количество чисел больше нуля: {count(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите число b1");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите число k1");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите число b2");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите число k2");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x=Math.Round((b2-b1)/(k1-k2),2);
// double y=Math.Round(k1*x+b1,2);

// Console.WriteLine($"Пересечение в точке: {x}, {y}");