// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] array= new int [4];

// int count=0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     System.Console.Write(array[i]+ " "); 

//     if (array[i]%2==0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Кол-во равно "+ count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array= new int [4];

// int sum=0;
// int k=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,100);
//     System.Console.Write(array[i]+ " ");    
// }

// System.Console.WriteLine();

// while(k<array.Length)
// {
//     sum=sum+array[k];
//     k = k+2;
// }

// Console.WriteLine($"Сумма = {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// double [] array= new double [4];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round (new Random().NextDouble()*(100-0+0),2);
//     System.Console.WriteLine(array[i]);    
// }

// double min=array[0];
// double max=array[0];

// int k=1;

// while(k<array.Length)
// {
//     if(array[k]<min)
//     {
//         min=array[k];
//     }
//     if(array[k]>max)
//     {
//         max=array[k];
//     }
//     k++;
// }
// System.Console.WriteLine(max-min);