namespace login.Models
{
    public class Info
    {
    public string Username { get; set; }

    public string Password { get; set; }

    public Info(string u, string p)
    {
      Username = u;
      Password = p;
    }
  }
}