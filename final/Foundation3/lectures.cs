// Name: Kyle Guo Date: Apirl 3 2023
public class Lectures:Event
{
    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity,string name): base(title, description, date, time, address, speaker + ", " + capacity, name) {

      name = "Lectures";
    }
}