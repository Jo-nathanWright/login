using System;
using login.Models;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
      Accounts info = new Accounts();
      info.AddAcount(new Info("NinjaPie", "12345"));
      info.AddAcount(new Info("Username", "Password"));
      info.AddAcount(new Info("Test", "123"));
      info.AddAcount(new Info("Secure", "h89eth4ysl09"));
      info.AddAcount(new Info("Bad", "Bad"));
      bool loggen = true;
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.Clear();
      while(loggen){
        Console.WriteLine("Welcome To Foodie Chews, Login to Continue!");
        Console.Write("Username: ");
        string user = Console.ReadLine();
        Info username = info.Info.Find(u => u.Username == user);
        if(username == null){
          Console.Beep();
          Console.WriteLine("Please provide A vaild User");
        }
      }
    }
    }
}
