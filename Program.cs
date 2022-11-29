using System;
using System.Globalization;

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


      var pt = new CultureInfo("pt-PT");
      var br = new CultureInfo("pt-BR");
      var en = new CultureInfo("en-US");
      var de = new CultureInfo("de-DE");
      var atual = CultureInfo.CurrentCulture;



      if (data.Date > DateTime.Now.Date)
      {
        Console.WriteLine("É igual");
      }
      else
      {
        Console.WriteLine("Não é igual");
      }

      Console.WriteLine(formatada);
      Console.WriteLine(alterada);
      Console.WriteLine(change);
      Console.WriteLine(changa);
      Console.WriteLine(chango);
      Console.WriteLine(data);
      Console.WriteLine(data.AddDays(-12));
      Console.WriteLine(data.AddMonths(1));
      Console.WriteLine(data.AddYears(1));

      Console.WriteLine(DateTime.Now.ToString("D", en));
      //Console.WriteLine(string.Format("{0:D}", DateTime.Now));
    }
  }
}