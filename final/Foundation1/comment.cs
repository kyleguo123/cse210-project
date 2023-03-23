class Comment{

    public string name;
    public string comment;

    // public Comment(string name, string comment){
    //     this.name = name;
    //     this.comment = comment;
    // }


    List<string> names= new List<string>{
        "J",
        "K",
        "L",
        "C"
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
        name = names[randomIndex];
        comment= comments[random.Next(comments.Count)];


    }
 
    public void display(){
        Console.WriteLine($"{name}\n \"{comment}\" \n \n");
    }

}

