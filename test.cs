// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Operations on a number using c# \n\nEnter a Number- \n");
        
        //taking the nubmber from the user
        int number;
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nYou Entered-   "+number+"\n\n");
        
        //tell use about opearions
        Console.WriteLine("Choose an Opeation- \nA -Prime No \nB -Factors \nC -Even Odd  \nD -Composite Number\n\n");
        
        //taking the operation from user
        char operation = Convert.ToChar(Console.ReadLine());
    
    

        //using switch case to perform operations on the number
        switch (operation) {

        case 'A': //prime Number
        for (int i = 2; i < number/2; i++){
            if (number % i != 0){
            Console.WriteLine("Prime");
            break;
        }else{
            Console.WriteLine("Not Prime");
            break;
        }
        }
        break;

        case 'B'://Factors
        Console.WriteLine("Factors of "+number+ "are");
            // finding and printing factors b/w 1 to num
        for (int i = 1; i <= number; i++){
        if (number % i == 0)
            Console.WriteLine(" " + i);
        }
        break;
        
        case 'C'://Even Odd
        Console.WriteLine("No "+number+" is");
        if(number%2 ==0){
            Console.WriteLine("Even.");
        }else{
            Console.WriteLine("Odd.");
        }
        break;
        
        case 'D'://Composite Number
        int j,count=0;
        
        for(j=1; j<=number; j++)
        {
            if(number % j == 0)
            count++;
        }
 
        if(count > 2)
            Console.WriteLine(number+" is Composite Number");
        else
            Console.WriteLine(number+" is not a Composite Number");
            
        break;
        }
        


        
    
        
    }
}
