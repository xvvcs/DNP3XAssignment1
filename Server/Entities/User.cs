namespace Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    
    public User() { }
    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public User(string username, string password, int id)
    {
        Id = id;
        Username = username;
        Password = password;
    }
}