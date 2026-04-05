using System.ComponentModel.DataAnnotations;

public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, string date, string time, Address address, string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \n Type: Reception \n RSVP at: {_rsvpEmail}";
    }
}