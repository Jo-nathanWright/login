using System;
using login.Models;
using System.Collections.Generic;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {

      //Setting Up the Console and the Accounts
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      bool placingUser = true;
      Dictionary<String, Info> users = new Dictionary<string, Info>();
      Info jake = new Info("Jake", "IheartCode");
      Info jonathan = new Info("JoNathan", "12345");
      Info mark = new Info("Mark", "Password");
      users.Add(jake.Username, jake);
      users.Add(jonathan.Username, jonathan);
      users.Add(mark.Username, mark);

      //What you are Shown
        Console.WriteLine("Welcome To Foodie Chews, Login to Continue!");
        Console.WriteLine("\n");
        while(placingUser){
        Console.Write("Username: ");
        string name = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        if(users.ContainsKey(name) && users[name].ValidPassword(password)){
          placingUser = false;
          Console.WriteLine("Welcome Back " + name + "!");
        } else {
          Console.Beep();
          Console.WriteLine("Invalid Username or Password, try again");
        }
      }
    }
    }
}
