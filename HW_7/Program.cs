// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите первую размерность");
// int rows= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int columns= Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Math.Round((new Random().Next(0,10) + new Random().NextDouble()),2);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите первую размерность");
// int rows= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int columns= Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите строку");
// int rows1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите столбец");
// int columns1= Convert.ToInt32(Console.ReadLine());

// if (rows1>=matrix.GetLength(0) || columns1>=matrix.GetLength(1))
// {
//     Console.WriteLine("Такой позиции в массиве нет");
// }
// else
// {
//     Console.WriteLine(matrix[rows1,columns1]);
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("Введите первую размерность");
// int rows= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int columns= Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];
// double sum =0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum+=matrix[i,j];
        
//     }
//     Console.Write(sum/rows +" ");
//     sum=0;
// }