using System;
class Program {
    
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
    
    
    static void Main() {
        
        Console.WriteLine(GuessTheNumber(0, 1000));
            
    }

}
