using System.ComponentModel.DataAnnotations;

namespace EventEase.Shared.Models;

public class RegistrationModel
{
    public static int RegistrationIdCounter = 0;
    public static int GetNextRegistrationId()
    {
        return ++RegistrationIdCounter;
    }

    public int Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    public string PhoneNumber { get; set; }
    public DateTime RegistrationDate { get; set; }
    public int EventId { get; set; }

    public RegistrationModel() : this(GetNextRegistrationId(), string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0) { }

    public RegistrationModel(DateTime registrationDate, int eventId)
        : this(GetNextRegistrationId(), string.Empty, string.Empty, string.Empty, registrationDate, eventId) { }

    public RegistrationModel(int id, string name, string email, string phoneNumber, DateTime registrationDate, int eventId)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        RegistrationDate = registrationDate;
        EventId = eventId;
    }
}
