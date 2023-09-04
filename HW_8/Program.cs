// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// void ChengeArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1)-1; k++)
//             {
//                 if (matrix[i,k]<matrix[i,k+1])
//                 {
//                     int temp = matrix[i,k+1];
//                     matrix[i,k+1]= matrix[i,k];
//                     matrix[i,k]= temp;
//                 }    
//             }
//         }
//     }
// }

// GetArray();
// PrintArray();
// ChengeArray();
// Console.WriteLine();
// PrintArray();


// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[] sumArray = new int[matrix.GetLength(0)];

// void MinSum()
// {
    
//     int sum=0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum+=matrix[i,j];
//         }
//         sumArray[i]=sum;
//         Console.Write(sum +" ");
//         sum=0;
//     } 
// }
// void Sum()  
// {
//     int minSum = sumArray[0];
//     int minRow=0;
//     for (int k = 1; k < sumArray.Length; k++)
//     {
//         if (sumArray[k] < minSum)
//         {
//         minSum = sumArray[k];
//         minRow=k+1;  
//         }
//     }
//     Console.WriteLine(minSum);
//     Console.WriteLine(minRow +" строка");
// }

// GetArray();
// PrintArray();
// Console.WriteLine();
// MinSum();
// Sum();



// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] matrix1 = new int[2,2];

// {
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         {
//             matrix1[i,j] = new Random().Next(0,10);
//             Console.Write(matrix1[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("___________");

// int[,] matrix2 = new int[2,2];

// {
//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix2[i,j] = new Random().Next(0,10);
//             Console.Write(matrix2[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("___________");

// int[,] matrix3 = new int[2,2];

// {
//     for (int i = 0; i < matrix3.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3.GetLength(1); j++)
//         {
//             int sum=0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 sum+=matrix1[i,k]*matrix2[k,j];
//             }
//             Console.Write((matrix3[i,j]=sum)+ " ");
//         }
//         Console.WriteLine();
//     }
// }


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] matrix = new int[2,2,2];

// void GetArray()
// {
//     int count = 10;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i,j,k]+=count;
//                 count+=3;
//             }
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");

//             }
//         }
//     }
// }
// GetArray();
// PrintArray();


// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] matrix = new int[2,2];

// int count=0;
// int i=0;
// int j=0;

// for (j = 0; j < matrix.GetLength(1); j++)
// {
//     matrix[i,j]=count+1;
//     count++;   
// }
// j=3;
// for (i = 1; i < matrix.GetLength(0); i++)
// {
//     matrix[i,j]=count+1;
//     count++;   
// }
// i=3;
// for (j = 2; j >=0; j-=1)
// {
//     matrix[i,j]=count+1;
//     count++;   
// }
// j=0;
// for (i = 2; i>=1; i-=1)
// {
//     matrix[i,j]=count+1;
//     count++;   
// }
// i=1;
// for (j = 1; j <=2; j++)
// {
//     matrix[i,j]=count+1;
//     count++;   
// }
// i=2;
// for (j = 2; j >=1; j-=1)
// {
//     matrix[i,j]=count+1;
//     count++;   
// }

// for (i = 0; i < matrix.GetLength(0); i++)
// {
//     for (j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");