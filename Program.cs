// import
using System;
using System.Collections.Generic;
using System.Threading;

// Project name and 'folder' that holds everything
namespace CSharpDay1
{
  //Singleton and is instantiated by the Dotnet Core Runner
  class Program
  {
    //Program for a console app only has the one method 'Main' and it will be invoked by Dotnet Core
    static void Main(string[] args)
    {
      Console.Clear();
      // Implicit Typing
      var x = 9;
      // Explicit Typing
      //string name = "Mark";
      bool j = false;

      // Console.log() in js
      // STRINGS
      // Concatenation
      //   Console.WriteLine("Hello World!" + " My name is Computer");

      // Interpolation
      //   Console.WriteLine($"Hello {name}");
      // 0th position of all the variables that come after
      //   Console.WriteLine("Hello {0}", name);

      //Numbers
      // INT (Whole Numbers abs() around 2billion)
      int age = 31;
      // float/double (Decimals without high precision)
      float y = 3.5f;
      double z = 4.56d;
      // decimal (Highest precision a number can hold in C#)
      decimal velocity = 3.23324523423m;

      //Bool Exactly the Same true/false
      //Conditionals must have a bool value
      //No truthy and falsey
      if (y != null) //cannot evaluate disparate types
      {

      }
      else
      {

      }

      // No undefined only null
      string nullString;

      //Arrays
      // Length is defined on creation and never changes
      string[] names = new string[] { "Mark", "Jake", "Darryl" };

      //List (Close to a js Array)
      // '<>' 'of type'
      // must be instantiated to be used
      List<string> listNames = new List<string>(){
          "Jek",
          "Drl"
      };
      listNames.Add("Mark");
      listNames.Remove("Jek");
      listNames.AddRange(new string[] { "Tim", "Britt", "Zach" });
      listNames.Insert(0, "jake"); // same as shift

      // lists do not have length they have count
      //   for (int i = 0; i < listNames.Count; i++)
      //   {
      //     Console.WriteLine(listNames[i]);
      //   }


      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();

      var message = $"Follow the white rabbit {name}";
      for (int i = 0; i < message.Length; i++)
      {
        Console.Write(message[i]);
        Thread.Sleep(50);
      }

      Console.Write("\nDo you wish to continue (y/n) >");
      var choice = Console.ReadKey().KeyChar;
      if (choice == 'y')
      {
        Console.WriteLine("\nLets see how deep the rabbit hole goes");
      }
      else if (choice == 'n')
      {
        Console.WriteLine("\nThe Matrix has you");
        return;
      }
      else
      {
        Console.WriteLine("\nAgent Detected");
        return;
      }

      //OBJECTS
      // No Such thing as a POCO
      // var obj = {};  // does not exist as a thing in CSharp
      Dictionary<string, string> characterDescriptions = new Dictionary<string, string>(){
          {"neo", "the hero of the story"},
          {"morpheus", "Looks balla in a Leather Trench Coat"},
          {"trinity", "Suppa bad a**"}
      };

      characterDescriptions.Add("Smith", "The Villain");

      System.Console.WriteLine(characterDescriptions["neo"]);




    }
  }
}
