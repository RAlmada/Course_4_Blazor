namespace EventEase.Services;

public class UserSessionService
{
    public string? UserId { get; private set; }
    public string? UserName { get; private set; }
    public bool IsLoggedIn => !string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(UserName);
    public Dictionary<string, object> SessionData { get; private set; } = new();

    public void InitializeSession(string userId, string userName)
    {
        UserId = userId;
        UserName = userName;
    }

    public void SetData(string key, object value)
    {
        SessionData[key] = value;
    }

    public T? GetData<T>(string key)
    {
        return SessionData.ContainsKey(key) ? (T?)SessionData[key] : default;
    }

    public void ClearSession()
    {
        UserId = null;
        UserName = null;
        SessionData.Clear();
    }
}
