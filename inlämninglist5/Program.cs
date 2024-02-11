using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace inlämninglist5
{
    class Program
    {
        static void Main(string[] args)
        {
            double svar = 0;
            int gånger = 0;
            double sum = 0;
            List<double> månadslön = new List<double>();
            do
            {
                Console.WriteLine("Vad hade du den senaste månaden i lön");
                svar = double.Parse(Console.ReadLine());
                månadslön.Add(svar);
                gånger++;
            } while (svar != 0);
            månadslön.Sort();
            Console.WriteLine(månadslön[0]+" " + månadslön[gånger-1]);
            månadslön.Remove(0);
            foreach(double lön in månadslön)
            {
                sum += lön;
            }
            sum = sum / (gånger - 2);
            Console.WriteLine("Medel är "+sum);
            if ((månadslön.Count) % 2 == 0)
            {
                månadslön.RemoveRange(0, (gånger - 2) / 2);
                månadslön.RemoveRange((månadslön.Count-1) / 2+1, månadslön.Count - 2);
                månadslön.Sort();
                Console.WriteLine(månadslön[0] + " " + månadslön[1]);
            }
            else
            {
                månadslön.RemoveRange(0, (gånger - 2) / 2);
                månadslön.RemoveRange((månadslön.Count - 1) / 2, månadslön.Count - 2);
                månadslön.Sort();
                Console.WriteLine(månadslön[0]);
            }
        }
    }
}