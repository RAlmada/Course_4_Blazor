namespace EventEase.Services;

public class AttendanceService
{
    private readonly Dictionary<int, HashSet<string>> _eventAttendance = new()
    {
        // SAmple Data
        { 1, new HashSet<string> { "John Doe", "Jane Smith", "Michael Johnson", "Emily Davis", "David Wilson" } },
        { 2, new HashSet<string> { "Alice Johnson", "Bob Brown" } },
        { 3, new HashSet<string> { "Charlie Davis", "Diana Prince", "Eve Green", "Frank Wilson" } },
    };

    public void MarkAttendance(int eventId, string userName)
    {
        if (!_eventAttendance.ContainsKey(eventId))
        {
            _eventAttendance[eventId] = [];
        }

        _eventAttendance[eventId].Add(userName);
    }

    public IEnumerable<string> GetAttendees(int eventId)
    {
        return _eventAttendance.ContainsKey(eventId) ? _eventAttendance[eventId] : new HashSet<string>();
    }
}
