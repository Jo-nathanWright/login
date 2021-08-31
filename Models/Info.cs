namespace login.Models
{
    public class Info
    {
    public string Username { get; set; }

    private string Password { get; set; }

    public bool ValidPassword(string input)
    {
      return input == Password;
    }

    public Info(string name, string pass)
    {
      Username = name;
      Password = pass;
    }
  }
}