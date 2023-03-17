using System;

public class Word{

    private string _word;

    public Word(string word){
        _word = word;
    }

    public void hide_word(){
        int letternum = _word.Count();
        _word = "";
        for (int i = 0; i < letternum; i++){
            _word=_word + "_";
        }
    }
    public void show_word(){
        Console.Write(_word + " ");
    }


    // public void word(){
    //     foreach (string item in words)
    // {
    //     string [] parts = item.Split(" ");
    //     int num_words = words.Count;
    //     Random rnm = new Random();
    //     int rindex= rnm.Next(num_words);
        
    // }
        

    // }
    
    

}


// int numberofpromt= prompt.Count;
//         Random rnm = new Random();
//         int rindex= rnm.Next(numberofpromt);
//         _prompt = prompt[rindex];
//         Console.WriteLine(_prompt);
//         Console.WriteLine("Please enter your entry");
//         _entry = Console.ReadLine();



        //     string[] parts = line.Split(",");
        //     Entry entry = new Entry();

        //     entry._date = parts[0];
        //     entry._prompt = parts[1];
        //     entry._entry = parts[2];
        //     entries.Add(entry);
        // }
