/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
    public static int Factorial(int n){
        int result = 1;
        
        for(int i = 1; i <= n; i++){
            result = result * i; 
        }
        
        return result;
    }

    static void Main() {
        int value = 5;
        int result;
        
        result = Factorial(value);
        
        Console.WriteLine("El valor del factorial {0} es {1}", value, result);
    }
}