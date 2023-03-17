using System;

class Program


{   
    static int getmagicnumber(){
        Random randomGenerator = new Random();
        int numbers = randomGenerator.Next(1, 99);
        return numbers;
    }
    static int getguess(){
        Console.Write("What is your guess? ");
        int guess= int.Parse(Console.ReadLine()) ;
        return guess;
    }
    static void displayhigher(int mnumber, int uguess){
        if(mnumber > uguess){
            Console.WriteLine("higher");
        }
    }
    static void displaylower(int mnumber, int uguess){
        if (mnumber< uguess){
            Console.WriteLine("lower");
        }
    }
    static void displaycorrect(int mnumber, int uguess){
        if (mnumber == uguess){
            Console.WriteLine("You guess it!");
        }
    }

    static void displayguesses(int count){
        Console.WriteLine($"It took to {count} times to guess it");
    }


    static string playagain(){
        Console.Write("Do you want to play again?(yes or no) ");
        string answer = Console.ReadLine();

        return answer;

    }

    static void Main(string[] args)
    { 
        int count = 1;

        int mnumber = getmagicnumber();

        int uguess = getguess();

        while (mnumber != uguess){
            displayhigher(mnumber, uguess);

            displaylower(mnumber, uguess);

            uguess = getguess();
            count +=1;
        }
        displaycorrect(mnumber, uguess);  
    }
}