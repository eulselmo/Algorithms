/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class SearchNumbers {
  
  public static void printOut (int[] arr){
        for(int i=0; i< arr.Length; i++){
          Console.Write(arr[i] + " ");
        }
  }
  
  public static void insertionSort(int[] numbers)
  { 
        int i, key, value; 
        for (i=1; i < numbers.Length; i++){
                key = numbers [i]; //the second value of the array
                value = i - 1; //the first value of the array
            
                while (value >= 0 && numbers[value] > key){
                    //insertion of the correct number
                    numbers [value + 1] = numbers [value];
                    value = value - 1;
                }
                
                numbers [value + 1] = key;
                Console.WriteLine("----------------------------------");
                printOut(numbers);
            
        }
   } 
    
  static void Main(String[] args) {
      
        int[] numbers = { 2, 6, 4, 7, 1, 3 };
        printOut(numbers);
    
    
        insertionSort(numbers);
        
        Console.WriteLine("----------------------------------");
  }
  
}


