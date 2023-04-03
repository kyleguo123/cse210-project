// Name: Kyle Guo Date: Apirl 3 2023
public abstract class Event
{
  private string kg_title;
  private string kg_description; 

  private string kg_additionalInfo;
  private string kg_name;
  private DateTime date;
  private TimeSpan time;
  
  private Address address;

  public Event(string title, string description, DateTime date, TimeSpan time, Address address,string additionalInfo, string name) 
  {
        
        this.kg_title = title;
        this.kg_description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.kg_additionalInfo= additionalInfo;
        this.kg_name = name;
    }

    public string GetStandardDetails() 
    {
        return $"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}";
    }

    public string GetFullDetails()
    {
      return $"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},E-MAIL:{kg_additionalInfo}";
    }

    public string ShortDescription()
    {
      return $"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},weather:{kg_additionalInfo}";
    }


    


}