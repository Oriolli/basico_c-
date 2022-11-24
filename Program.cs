using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var data = DateTime.Now;
      var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
      var alterada = String.Format("{0:D}", data);
      var change = String.Format("{0:r}", data);
      var changa = String.Format("{0:s}", data);
      var chango = String.Format("{0:u}", data);

      Console.WriteLine(formatada);
      Console.WriteLine(alterada);
      Console.WriteLine(change);
      Console.WriteLine(changa);
      Console.WriteLine(chango);
    }
  }
}