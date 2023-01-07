using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage of your grade? ");
        string grades = Console.ReadLine();
        int number = int.Parse(grades);

        string letter = "";

        if (number >= 93){
            letter = "A";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 90)
        {
            letter = "A-";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 87)
        {
            letter = "B+";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 83)
        {
            letter = "B";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 80)
        {
            letter = "B-";;
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 77)
        {
            letter = "C+";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 73)
        {
            letter = "C";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 70)
        {
            letter = "C-";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 67)
        {
            letter = "D+";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 63)
        {
            letter = "D";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else if (number >= 60)
        {
            letter = "D-";
            Console.WriteLine("congratulation! You passed the exam!");
        }
        else 
        {
            letter = "F";
            Console.WriteLine("You can do better next time!");
        }
        Console.WriteLine($"Your grade is: {letter}");
    }
}



// if (x > y)
// {
//     Console.WriteLine("greater than y");
// }
// else if (x > z)
// {
//     Console.WriteLine("greater than z")
// }
// else
// {
//     Console.WriteLine("less than both");
// }