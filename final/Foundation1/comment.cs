class Comment{

    public string kg_name;
    public string kg_comment;

    // public Comment(string name, string comment){
    //     this.name = name;
    //     this.comment = comment;
    // }


    List<string> names= new List<string>{
        "John",
        "Kyle",
        "Laurn",
        "Cao"
    };

    List<string> comments = new List<string>{
        "You are looking good!!!",
        "Good jobs!!!",
        "This video looks great!",
        "What the holy smoke!!!",
        "This video is amazing!"
    };

    public Comment(){
        
        Random random = new Random();
        int randomIndex = random.Next(names.Count);
        kg_name = names[randomIndex];
        kg_comment= comments[random.Next(comments.Count)];


    }
 
    public void display(){
        Console.WriteLine($"{kg_name}\n \"{kg_comment}\" \n \n");
    }

}

