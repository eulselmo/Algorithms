/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
    
    public static int[] insertionSort(int[] tab){
        
        int i, key, value; 
        for (i=1; i < tab.Length; i++){
                key = tab [i]; //the second value of the array
                value = i - 1; //the first value of the array
                
                
                while (value >= 0 && tab[value] > key){
                    //insertion of the correct number
                    tab [value + 1] = tab [value];
                    value = value - 1;
                }
                
                tab [value + 1] = key;
            
        }
        return tab;
   }
   
    public static int binarySearchTarget(int[] array, int targetValue) {
	    int min = 0;
	    int max = array.Length - 1;
        int guess;
        int result = -1;
    
        while ( min <= max ) {
            guess = ((min + max)/2);
            if (array[guess] == targetValue) { 
              result = guess; 
            } 
    
            if (array[guess] < targetValue ) {
                min = guess + 1;
            } 
            else { 
                max = guess - 1; 
            } 
        }
     return result;
    }
   
    public static void printOut (int[] arr){
        for(int i=0; i< arr.Length; i++){
          Console.Write(arr[i] + " ");
        }
    }
   
    static void Main() {
    
        int n = 100; 
        int min = 0; int max = 500;
        Random random = new Random();
        int[] listZero = new int[n];
        int value = 7;
        
        for (int i = 0; i < n; i++)
        {
            listZero[i] = random.Next(min, max);
        }
        
        Console.WriteLine("--------------------------------------");
        printOut(listZero);
        Console.WriteLine();
        
        Console.WriteLine("--------------------------------------");
        insertionSort(listZero);
        printOut(listZero);
        Console.WriteLine();
        
        Console.WriteLine("--------------------------------------");
        int result = binarySearchTarget(listZero, value);
        
        if (result == -1){
            Console.WriteLine("the value {0} was not found", value);
        }
        else{
            Console.WriteLine("the value {0} was found", value);
        }
        
        
        
        
  }
}
