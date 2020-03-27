using System;
using System.IO;
using System.Linq;

namespace Crimson 
{
  class ColorfulLines 
  {
    public static void WriteBool(bool bol, ConsoleColor color)
      {
        Console.ForegroundColor = color;
        Console.WriteLine(bol);
        Console.ResetColor();
      }

      public static void WriteChar(char chr, ConsoleColor color)
      {
        Console.ForegroundColor = color;
        Console.WriteLine(chr);
        Console.ResetColor();
      }

      public static void WriteStr(string str, ConsoleColor color)
      {
        Console.ForegroundColor = color;
        Console.WriteLine(str);
        Console.ResetColor();
      }

      public static void WriteNum(int inter, ConsoleColor color)
      {
        Console.ForegroundColor = color;
        Console.WriteLine(inter);
        Console.ResetColor();
      }

      public static void WriteDouble(double dbl, ConsoleColor color)
      {
        Console.ForegroundColor = color;
        Console.WriteLine(dbl);
        Console.ResetColor();
      }

      public static void WriteFloat(float flt, ConsoleColor color)
      {
        Console.ForegroundColor = color;
        Console.WriteLine(flt);
        Console.ResetColor();
      }
  }
}
