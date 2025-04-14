namespace EventEase.Shared.Models;

public class EventModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }

    public EventModel() : this(0, string.Empty, DateTime.MinValue, string.Empty, null) { }

    public EventModel(int id, string name, DateTime date, string location, string? description = null)
    {
        Id = id;
        Name = name;
        Date = date;
        Location = location;
        Description = description ?? string.Empty;
    }
}