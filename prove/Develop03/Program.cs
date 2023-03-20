using System;

class Program
{
    //     List<string> words = new List<string>(){

    //     "3 Philip, and Bartholomew; Thomas, and Matthew the apublican; James the son of Alphæus, and Lebbæus, whose surname was Thaddæus;"
    // };


    static void Main(string[] args)
    {
        string entry;
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);


        do{
            Console.Clear();
            scripture.display();
            Console.WriteLine("Press enter to continue or type quit to finish. ");
            entry = Console.ReadLine();
             scripture.hide_word();
            scripture.hide_word();
            scripture.hide_word();
            // Console.WriteLine(scripture.numbers.Count);
            if (scripture.numbers.Count == 0){
                break;
            }
        }
        while(entry!= "quit" );
        Console.Clear();
        scripture.display();
    }
}