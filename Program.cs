using System;
using System.Collections.Generic;

namespace C_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
                stocks.Add("GM", "General Motors");
                stocks.Add("CAT", "Caterpillar");
                stocks.Add("AMZN", "Amazon");
                stocks.Add("NFLX", "Netflix");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            // GM Purchases:
                purchases.Add (new Dictionary<string, double>(){ {"GM", 230.21} });
                purchases.Add (new Dictionary<string, double>(){ {"GM", 580.98} });
                purchases.Add (new Dictionary<string, double>(){ {"GM", 406.34} });
            // CAT Purchases:
                purchases.Add(new Dictionary<string, double>(){{"CAT", 300.01}});
                purchases.Add(new Dictionary<string, double>(){{"CAT", 400.71}});
                purchases.Add(new Dictionary<string, double>(){{"CAT", 500.61}});
            // AMZN Purchases:
                purchases.Add(new Dictionary<string, double>(){{"AMZN", 555.71}});
                purchases.Add(new Dictionary<string, double>(){{"AMZN", 456.51}});
                purchases.Add(new Dictionary<string, double>(){{"AMZN", 243.21}});

            // NFLX Purchases:
                purchases.Add(new Dictionary<string, double>(){{"NFLX", 650.91}});
                purchases.Add(new Dictionary<string, double>(){{"NFLX", 384.41}});
                purchases.Add(new Dictionary<string, double>(){{"NFLX", 534.81}});

        Dictionary<string, double> stockReport = new Dictionary<string, double>();
        foreach (Dictionary<string, double> purchase in purchases) {
            {
                foreach (KeyValuePair<string, double> kvp in purchase)
                {
                   if (stockReport.ContainsKey(stocks[kvp.Key])){
                       stockReport[stocks[kvp.Key]] += kvp.Value;
                   } else {
                       stockReport[stocks[kvp.Key]] = kvp.Value;
                   }
                }
            }
        }
          foreach(KeyValuePair<string, double> item in stockReport)
                    {
                        Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
                        Console.WriteLine($"_________________________________________________");
                    }

// Planet practice
        List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};

        List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
                probes.Add(new Dictionary<string, string>(){{"Earth", "spacecraft1"}});
                probes.Add(new Dictionary<string, string>(){{"Mercury", "dustyBoy"}});
                probes.Add(new Dictionary<string, string>(){{"Mercury", "MercyProbe"}});
                probes.Add(new Dictionary<string, string>(){{"Venus", "niceProbe"}});
                probes.Add(new Dictionary<string, string>(){{"Mars", "orangeCrush"}});
                probes.Add(new Dictionary<string, string>(){{"Jupiter", "bigBoy"}});
                probes.Add(new Dictionary<string, string>(){{"Saturn", "rings"}});
                probes.Add(new Dictionary<string, string>(){{"Uranus", "yikes"}});
                probes.Add(new Dictionary<string, string>(){{"Neptune", "nobody"}});
                probes.Add(new Dictionary<string, string>(){{"Neptune", "thisIsFarAway"}});
                probes.Add(new Dictionary<string, string>(){{"Neptune", "Eww"}});



        planetList.ForEach(planet => {
            // Console.WriteLine(planet);
            List<string> matchingProbes = new List<string>();
            foreach (Dictionary<string, string> probe in probes){
                if (probe.ContainsKey(planet)){
                    matchingProbes.Add(probe[planet]);
                }
            }
            Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
        });
        }
    }
}
