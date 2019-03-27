/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//O(n)//
using System;
class Program {
    public static int FactorialRecursive(int n){
        int result;
        
        if(n < 1){
            return -1;
        }
        else{
            result = n * FactorialRecursive(n -1);
        }
        
        return result;
    }

    static void Main() {
        int value = 5;
        int result;
        
        result = FactorialRecursive(value);
        
        Console.WriteLine("El valor del factorial {0} es {1}", value, result);
    }
}
