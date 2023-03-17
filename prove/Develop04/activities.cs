class Activity{

    public string activity;
    public string description;

    public int duration;

    public void inro(){
        Console.WriteLine($"Welcome to the {activity} Activity");
        Console.WriteLine(description);

        Console.WriteLine("How long, in seconds, would you like for your section?");
        duration= int.Parse (Console.ReadLine());

    }

    public void end(){
        
    }

}

