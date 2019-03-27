using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    
    public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    
    public static int[] insertionSort(int[] tab, bool display){
        int comparisons = 0;
        int swaps= 0;
        int i, key, value; 
        for (i=1; i < tab.Length; i++){
                key = tab [i]; //the second value of the array
                value = i - 1; //the first value of the array
                if(display){
                    comparisons ++;    
                }
                
                while (value >= 0 && tab[value] > key){
                    //insertion of the correct number
                    tab [value + 1] = tab [value];
                    value = value - 1;
                    if (display){
                        swaps ++;    
                    }
                    
                }
                
                tab [value + 1] = key;
            
        }
        Console.WriteLine("comparisons " + comparisons);
        Console.WriteLine("swaps " + swaps);
        return tab;
   }
   
   public static int[] insertionSort2(List <int> tab, bool display){
        int comparisons = 0;
        int swaps= 0;
        int i, key, value; 
        for (i=1; i < tab.Count; i++){
                key = tab [i]; //the second value of the array
                value = i - 1; //the first value of the array
                if(display){
                    comparisons ++;    
                }
                
                while (value >= 0 && tab[value] > key){
                    //insertion of the correct number
                    tab [value + 1] = tab [value];
                    value = value - 1;
                    if (display){
                        swaps ++;    
                    }
                    
                }
                
                tab [value + 1] = key;
            
        }
        Console.WriteLine("comparisons " + comparisons);
        Console.WriteLine("swaps " + swaps);
        return tab;
   }
   
    public static void printOut(List <int> arr, int everyNth){
            Console.WriteLine();
            for (int i = 0; i < arr.Count; i++)
            {
                if (i % everyNth == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        
    public static void printOutAll(List <int> arr){
            for (int i = 0; i < arr.Count; i++)
            {
                    Console.Write(arr[i] + " ");
                
            }
        }
    
    
  static void Main() {
      
        int[] tab={1,0,4,8,11,3,8,-2,5};
        DateTime start;
        TimeSpan timeItTook;
        int n = 5000; int th = 500;
        int min = 0; int max = 500;
        Random random = new Random();
        
        //-------------------------------
        List <int> listZero = new int[n];
        List <int> listOne = new int[n];
        List <int> listTwo = new int[n];
        List <int> listThree = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            listZero[i] = random.Next(min, max);
        }
        
        for (int i = 0; i < n; i++)
            {
                listOne[i] = listZero[i];
                listTwo[i] = listZero[i];
            }
        
        Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listTwo = insertionSort(listTwo, true);
            timeItTook  = DateTime.Now - start;
            printOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
        Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listSix = insertionSort(listOne, false);
            timeItTook  = DateTime.Now - start;
            printOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
        
        int[] test2 = {2,1,7,0,5};
        test2 = insertionSort(test2, true);
        printOutAll(test2);
        
        Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listSix = insertionSort2(listThree, false);
            timeItTook  = DateTime.Now - start;
            printOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
        
        Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listSix = insertionSort2(listThree, false);
            timeItTook  = DateTime.Now - start;
            printOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");            
  }
}




