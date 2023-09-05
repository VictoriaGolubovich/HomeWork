// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите число"); 
// int num = Convert.ToInt32(Console.ReadLine()); 

// int endNum =1; 
// string PrintNumber(int start, int end) 
// {   
//     if(start==end)   
//     {     
//         return start.ToString();   
//     }   
//     return (start + " "+PrintNumber(start-1, end));
// } 
// Console.WriteLine(PrintNumber(num,endNum));



// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// System.Console.WriteLine("Введите число M"); 
// int num = Convert.ToInt32(System.Console.ReadLine()); 

// System.Console.WriteLine("Введите число N"); 
// int num2 = Convert.ToInt32(System.Console.ReadLine()); 

// if (num < num2) 
// {     
//     Console.WriteLine(PrintNum(num,num2)); 
// } 
// else 
// {     
//     System.Console.WriteLine("Введите число N больше M"); 
// } 

// int PrintNum(int start, int end) 

// {     
//     if (start == end)     
//     {         
//         return start;     
//     }     
//     return(start + PrintNum(start+1, end)); 
// }



// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Введите число"); 
int num = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите число"); 
int num2 = Convert.ToInt32(Console.ReadLine()); 

int Akkerman(int m, int n) 
{   
    if(m==0)   
    {     
        return n+1;   
    }   
    if(n==0)   
    {     
        return Akkerman(m-1,1);   
    }   
    return Akkerman(m-1,Akkerman(m,n-1)); 
} 
Console.WriteLine(Akkerman(num,num2));