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


}