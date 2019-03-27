/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//Hacer en JavaScript y en 2^n y 3^n//

using System;
class Program {
    public static bool IsPalindromo(string str){
        if(str.Length<=1){
            return true;
        }
        else
        {
            if(str[0] != str[str.Length -1]){
                return false;
            }
            else
                return IsPalindromo( str.Substring( 1, str.Length-2 ) );
        }
    }
    
    static void Main() {
        Console.WriteLine("1234121" + " - " + IsPalindromo("1234121"));
        Console.WriteLine("ala" + " - " + IsPalindromo("ala"));
    }
}
