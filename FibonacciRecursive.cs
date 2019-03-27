/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

public class Program
{
    
    public static void Fibonacci(int a, int b, int counter, int number)
    {
        
        Console.WriteLine(a);
        if (counter < number) Fibonacci(b, a+b, counter+1, number);
        
    }
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Please introduce the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Fibonacci(0, 1, 1, number);
    
    }  
    
}

