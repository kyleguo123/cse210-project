class Video {

    public string title;
    public string author;
    public int length;

    public Video (string title, string author, int length){
        this.title = title;
        this.author = author;
        this.length = length;
    }
    List<Comment> comments = new List<Comment>{
        new Comment(),
        new Comment(),
        new Comment()
    
    };

    



    public int GetNumberComment(){

        return comments.Count;
    }


    public void display(){
        Console.WriteLine($"Title: {title}, Author name: {author}, Duration: {length}");
        Console.WriteLine($"Comments : {GetNumberComment()}");
        foreach(Comment comment in comments){
            comment.display();
        }
        
    }
}