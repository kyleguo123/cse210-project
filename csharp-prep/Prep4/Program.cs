

using System;

class Program
{

    static int getnumber(){
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        int kgnumber= int.Parse(Console.ReadLine()) ;
        return kgnumber;
    }
    static void Main(string[] args)
    {


        List<int> numbers = new List<int>();
        int kgnumber = getnumber();
        int count = 1;
        int largest= -9999999;
        int smallest= 999999;
        while (kgnumber != 0){
            
            numbers.Add(kgnumber);
            kgnumber = getnumber();
            count+=1;

        }
        foreach (int newnumber in numbers){
            if (largest<newnumber ){
                largest = newnumber;
            }
            else if (smallest> newnumber && newnumber > 0){
                smallest = newnumber;
            }
        }

        int sum = numbers.AsQueryable().Sum();
        Console.WriteLine("The sum is {0}", sum);
        double avg = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine("The average is: "+avg);
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest number is {smallest}");


    }

}

