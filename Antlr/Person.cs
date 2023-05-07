namespace Antlr;

public class Person // Poco class
{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int NumberOfGuests { get; set; }
    public override string ToString()
    {
        return $"{FirstName}-{LastName}-{NumberOfGuests}";
    }
}