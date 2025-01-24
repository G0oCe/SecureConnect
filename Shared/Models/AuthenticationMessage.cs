namespace SecureConnect.Models;

public class AuthenticationMessage
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }
}
