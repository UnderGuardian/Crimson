using System;
using System.IO;
using System.Linq;
namespace Crimson
{
  class Codes 
  {
    public string ToHex(int value)
    {
      return String.Format("{0:X}", value);
    }

    public void Display (int option) {
      switch(option)
      {
        case 1: New(); break;
        case 2: Load(); break;
        case 3: Console.WriteLine("No fuck u"); break;
      }
    }
    public void New()
    {
      Random rand = new Random();
      using (StreamWriter sw = File.AppendText("Users.txt"))
      {
        int num = rand.Next(0,80000000);
        string account = ToHex(num);
        Console.WriteLine("What's ur name?");
        string name = Console.ReadLine();
        sw.WriteLine($"{name}: {account}");
      }
    }

    public void Load()
    {
      using (StreamReader sr = new StreamReader("Users.txt"))
      {
        string lines = "";
        while((lines = sr.ReadLine()) != null)
        {
          Console.WriteLine(lines);
        }
      }
    }
  }
}
