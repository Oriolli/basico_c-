using System;
using System.Globalization;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var arr = new int[3];
      try
      {
        for (var index = 0; index < 10; index++)
        {
          Console.WriteLine(arr[index]);
        }
      }
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o índice na lista");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ops, algo deu errado!");
      }
      finally
      {
        Console.WriteLine("Chegou ao fim!");
      }

      var data = DateTime.Now;
      var dateTime = DateTime.UtcNow;
      var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
      var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
      var timezones = TimeZoneInfo.GetSystemTimeZones();
      foreach (var timezone in timezones)
      {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
        Console.WriteLine("-------------------------");
      }

      var timeSpan = new TimeSpan();
      Console.WriteLine(timeSpan);



      var alterada = String.Format("{0:D}", data);
      var change = String.Format("{0:r}", data);
      var changa = String.Format("{0:s}", data);
      var chango = String.Format("{0:u}", data);


      var pt = new CultureInfo("pt-PT");
      var br = new CultureInfo("pt-BR");
      var en = new CultureInfo("en-US");
      var de = new CultureInfo("de-DE");
      var atual = CultureInfo.CurrentCulture;


      var meuArray = new int[5] { 0, 1, 2, 3, 4 };

      for (var index = 0; index < meuArray.Length; index++)
      {
        Console.WriteLine(meuArray[index]);
      }

      foreach (var item in meuArray)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine(meuArray[0]);
      Console.WriteLine(meuArray[1]);
      Console.WriteLine(meuArray[2]);
      Console.WriteLine(meuArray[3]);
      Console.WriteLine(meuArray[4]);


      decimal valor = 10536.25m;
      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(Math.Round(valor));
      Console.WriteLine(Math.Ceiling(valor));
      Console.WriteLine(Math.Floor(valor));
      //C - exibe como moeda
      //N - somente o número sem formatação de moeda
      //P - exibe a porcentagem
      //Math.Round - arredonda o valor
      //Math.Ceiling - arredonda pra cima
      //Math.Floor - arredonda pra baixo

      if (data.Date > DateTime.Now.Date)
      {
        Console.WriteLine("É igual");
      }
      else
      {
        Console.WriteLine("Não é igual");
      }
      Console.WriteLine(DateTime.Now);
      Console.WriteLine(dateTime);
      Console.WriteLine(dateTime.ToLocalTime());
      Console.WriteLine(timezoneAustralia);
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
    static void Salvar(String texto)
    {
      if (string.IsNullOrEmpty(texto))
        throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
    }
  }
}