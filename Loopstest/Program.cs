using System;

namespace Loopstest
{
    class Program
    {
        static void Main(string[] args)
        {
            double wert = 0;
            int werte = 0;

            while (true)
            {
                Console.WriteLine("Bitte Note Eingeben(-1 Beendet): ");
                string sconsoledummy = Console.ReadLine();
                double dconsoledummy;
                if (double.TryParse(sconsoledummy, out dconsoledummy))
                {
                    if(dconsoledummy == -1)
                    {
                        Console.WriteLine("Durschnitt wird errechnet");
                        if (werte>0)
                        {
                            wert = wert / werte;
                            Console.WriteLine("Durschnitt ist: " + wert);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Keine Werte eingegeben");
                        }
                       
                        
                    }
                    else if (dconsoledummy < 1 || dconsoledummy > 6)
                    {
                        Console.WriteLine("Wert muss zwischen 1 und 6 sein!!!");
                    }
                    else
                    {
                        Console.WriteLine("Alles Klar!");
                       werte ++;
                       wert += dconsoledummy;
                    }
                }
                else
                {
                    Console.WriteLine("Fehlerhafter eingabewert");
                }
            }

        }
    }
}
