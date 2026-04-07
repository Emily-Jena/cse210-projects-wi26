using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    

    public Event(string title, string description, string date, string time, Address address)
    {
         _title = title;
         _description = description;
         _date = date;
         _time = time;
         _address = address;
    }
    public string GetStandardDetails()
    {
        return $"Title: {_title} \nDescription: {_description} \nDate: {_date} at {_time} \nLocation: {_address.GetFullAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Event Type: General \nTitle: {_title} \nDate: {_date}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}