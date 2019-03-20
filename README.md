# Algorithms
 **In this programs we develop and improve the use of sort algorithms. Seems like Binary Search, Insertion, Selection and Bubble Sorts.**

## Binary Insertion
* **BinaryInsertion.cs** - The program takes the data.csv database that contains information about each country. Through a Linq type query, the countries with density greater than 100 from a single continent are shown. The objective of the program is to show the total of Countries that pass the condition and information about it, such as Country Name, Density, Population and Area. 

```
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
```
```
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
```
**Result**
  ![Country](img/Country.PNG)

## Binary Sort
* **BinarySort.cs** - The program takes the data.csv database that contains information about each country. Through a Linq type query, the countries with density greater than 100 from a single continent are shown. The objective of the program is to show the total of Countries that pass the condition and information about it, such as Country Name, Density, Population and Area. 

```
public static int GuessTheNumber(int a, int b){
        Random random  = new Random();
        int steps = 0;
        int numberSecret = random.Next(a, b);
        bool notFound = true;
        
        int letItBe;
        while(notFound){
            
            letItBe = (a+b)/2;
            
            if(letItBe == numberSecret){
                notFound=false;
            }
            
            if(numberSecret > letItBe){
                a = letItBe; 
            }
            
            else{
                b = letItBe;
            }
            
            steps++;
              
        }
        
        return steps;
    }
```
**Result**
  ![Country](img/Country.PNG)

## Search Numbers with the Insertion Sort
* **SearchNumbers.cs** - This other program also gets the data.csv database. The program performs a Linq query to show the countries with the highest density of a continent. The program also shows the total of Countries that pass the condition, and information on Country Name, Density, Population and Area.

```
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
```
**Result**
  ![Country 2](img/Country2.PNG)

## Insertion, Bubble and Selection Sorts
* **Sorts.cs** - The last program takes the data.csv database. A Linq type query is carried out showing the countries with the highest density in a continent. This program shows the total of Countries that pass this condition, the total population in the world, and information such as Country Name, Density, Population and Area

```
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
```

```
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
```

```
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
```
**Result**
  ![Country 3](img/Country3.PNG)# Algorithms
