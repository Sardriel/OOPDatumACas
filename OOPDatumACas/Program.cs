using System;

namespace OOPDatumACas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datumCas = new DateTime(2021, 11, 13, 15, 43, 0);
            Console.WriteLine(datumCas);

            DateTime datumCasJedna = DateTime.Now;
            Console.WriteLine("Dnes je: {0} (Now)", datumCasJedna);
            
            DateTime datumCasDva = DateTime.Today;
            Console.WriteLine("Dnes je: {0} (Today)", datumCasDva);

            DateTime datumCasTri = DateTime.Now;
            Console.WriteLine("Dnes je {0} {1}.", datumCasTri.DayOfWeek, datumCasTri.Day); 
            Console.WriteLine("Je {0}. měsíc a rok {1}.", datumCasTri.Month, datumCasTri.Year);
            Console.WriteLine("{0} hodin, {1} minut a {2} sekund.", datumCasTri.Hour, datumCasTri.Minute, datumCasTri.Second);

            Console.WriteLine("Zadej datum narození: ");
            DateTime narozen = DateTime.Parse(Console.ReadLine());
            TimeSpan vek = DateTime.Today - narozen;
            Console.WriteLine("Je Ti {0} let", Math.Floor(vek.Days/365.255));
            Console.WriteLine("To je ve dnesch {0} a v hodinách {1}", vek.TotalDays, vek.TotalHours);
            Console.ReadKey();
        }
    }
}
