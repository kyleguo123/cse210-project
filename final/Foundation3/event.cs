// Name: Kyle Guo Date: Apirl 3 2023
public abstract class Event
{
  protected string kg_title;
  protected string kg_description; 

  protected string kg_additionalInfo;
  protected string kg_name;
  protected DateTime date;
  protected TimeSpan time;
  
  protected Address address;

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

  public abstract void Details();
    // public string GetStandardDetails() 
    // {
    //     return $"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}";
    // }

    // public string GetFullDetails()
    // {
    //   return $"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},E-MAIL:{kg_additionalInfo}";
    // }

    // public string ShortDescription()
    // {
    //   return $"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},weather:{kg_additionalInfo}";
    // }


    


}