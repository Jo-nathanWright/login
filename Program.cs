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
      bool placingUser = true;
      bool placingPass = true;
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      while(placingUser){
        Console.WriteLine("Welcome To Foodie Chews, Login to Continue!");
        Console.Write("Username: ");
        string user = Console.ReadLine();
        Info username = info.Info.Find(u => u.Username == user);
        if(username == null){
          Console.Beep();
          Console.WriteLine("Please provide A vaild User");
        } else {
          placingUser = false;
          while(placingPass){
            Console.WriteLine("Password Required!");
            Console.Write("Password: ");
            string pass = Console.ReadLine();
            Info password = info.Info.Find(p => p.Password == pass);
            if(password == null){
              Console.WriteLine("Invalid Password!");
            } else {
              placingPass = false;
              Console.WriteLine("Welcome Back " + user + "!");
            }
          }
        }
      }
    }
    }
}
