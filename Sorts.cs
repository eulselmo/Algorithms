using System;
class Program {
    
    //--------------SELECTION SORT------------------------------
    
    public static int[] sortBySelection(int[] tab, bool display){
        
            long swaps = 0;
            int comparisons = 0;
            //int minIndex;
            int min = tab[0];
            int minIndex = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                int tmp = tab[i];
                
                for (int j = i + 1; j < tab.Length; j++){
                    if (display){
                        comparisons++;
                    }
                    
                    if (tab[j] < min)
                    {
                        min = tab[j];
                        minIndex = j;
                    }
                }
                
                if (i != minIndex)
                {
                   tab[i] = tab[minIndex];
                   tab[minIndex] = tmp;
                   if (display){
                        swaps ++;    
                   }
                   
                   //swaps++;      
                }
            }
            
            Console.WriteLine("swaps " + swaps);
            Console.WriteLine("comparisons " + comparisons);
            return tab;
    }

    
    //-------------INSERTION SORT-------------------------------
    
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
    
    //-------------BUBBLE SORT-------------------------------
    
    public static int[] BubleSort(int[] tab, bool display){
            long comparisons = 0;
            long swaps= 0;
            
            int n = tab.Length;
            
            do{
                
                for(int i=0; i< n-1; i++){
                    int tmp = tab[i];
                    if (display){
                        comparisons ++;    
                    }
                    if(tmp > tab[i+1]){
                        //tab.swap(tab[i],tab[i+1]);
                        tab[i]=tab[i+1];
                        tab[i+1]=tmp;
                        if (display){
                            swaps ++;    
                        }
                        
                        //swapped = true;
                        
                    }
                }
                
                n= n-1;
            }while(n != 1);
            Console.WriteLine("comparisons " + comparisons);
            Console.WriteLine("swaps " + swaps);
            return tab;
        }
    
    //--------------------------------------------
    
    public static void printOut(int[] arr, int everyNth){
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % everyNth == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        
    public static void printOutAll(int[] arr){
            for (int i = 0; i < arr.Length; i++)
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
        int[] listZero = new int[n];
        int[] listOne = new int[n];
        int[] listTwo = new int[n];
        int[] listThree = new int[n];
        int[] listFour = new int[n];
        int[] listFive = new int[n];
        int[] listSix = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            listZero[i] = random.Next(min, max);
        }
        
        for (int i = 0; i < n; i++)
            {
                listOne[i] = listZero[i];
                listTwo[i] = listZero[i];
                listThree[i] = listZero[i];
                listFour[i] = listZero[i];
                listFive[i] = listZero[i];
                listSix[i] = listZero[i];
            }
        
        //Show the results of BubleSort
        //tab = BubleSort(listOne);
        //printOut(tab, th);
        //Console.WriteLine("------------------------------------------------------------------");
        
        //Show the results of InsertionSort
        //tab = insertionSort(listTwo);
        //printOut(tab, th);
        //Console.WriteLine("------------------------------------------------------------------");
        
        //Show the results of SelectionSort
        //tab = sortBySelection(listThree);
        //printOut(tab, th);
        //Console.WriteLine("------------------------------------------------------------------");
        
        Console.WriteLine("\nSorting by Selection");
            start = DateTime.Now;
            listOne = sortBySelection(listOne, true);
            timeItTook  = DateTime.Now - start;
            printOut(listOne, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
        
        Console.WriteLine("\nSorting by Selection");
            start = DateTime.Now;
            listFive = sortBySelection(listFive, false);
            timeItTook  = DateTime.Now - start;
            printOut(listOne, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
        
        Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listTwo = insertionSort(listTwo, true);
            timeItTook  = DateTime.Now - start;
            printOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
        Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listSix = insertionSort(listSix, false);
            timeItTook  = DateTime.Now - start;
            printOut(listTwo, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
        Console.WriteLine("\nSorting by Bubble");
            start = DateTime.Now;
            listThree = BubleSort(listThree, true);
            timeItTook  = DateTime.Now - start;
            printOut(listThree, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
        Console.WriteLine("\nSorting by Bubble");
            start = DateTime.Now;
            listFour = BubleSort(listFour, false);
            timeItTook  = DateTime.Now - start;
            printOut(listThree, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
        //----------------------------------------------   
        
        int[] test1 = {2,1,7,0,5};
        test1 = BubleSort(test1, true);
        printOutAll(test1);
        
        int[] test2 = {2,1,7,0,5};
        test2 = insertionSort(test2, true);
        printOutAll(test2);
        
        int[] test3 = {2,1,7,0,5};
        test3 = sortBySelection(test3, true);
        printOutAll(test3);
  }
}



