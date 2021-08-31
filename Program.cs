using System;
using System.Threading;
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
      int tries = 6;
      Dictionary<String, Info> users = new Dictionary<string, Info>();
      Info jake = new Info("Jake", "IheartCode");
      Info jonathan = new Info("JoNathan", "12345");
      Info mark = new Info("Mark", "Password");
      users.Add(jake.Username, jake);
      users.Add(jonathan.Username, jonathan);
      users.Add(mark.Username, mark);

      //What you are Shown
        while(placingUser){
        Console.WriteLine("Welcome To Foodie Chews, Login to Continue!");
        Console.WriteLine("\n");
        tries--;
        Console.Write("Username: ");
        string name = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        if(users.ContainsKey(name) && users[name].ValidPassword(password)){
          placingUser = false;
          Console.WriteLine("Welcome Back " + name + "!");
        } else {
          if(tries == 0){
            placingUser = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Out of Attemps. Try Again Later!");
            Console.ForegroundColor = ConsoleColor.Black;
          } else {
            Console.Beep();
            Console.WriteLine("Invalid Username or Password, try again");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tries + " Attemps left.");
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(2500);
            Console.Clear();
          }
        }
      }
    }
    }
}
