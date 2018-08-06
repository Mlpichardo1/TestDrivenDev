using System;

namespace Canonicalizer
{
    class Program
    {
        static void Main(string[] args)
        {
           string empty = NaiveCanonicalizer.GetCanonicalForm(""); 
           System.Console.WriteLine(empty == "");
           empty = NaiveCanonicalizer.GetCanonicalForm(" "); 
           System.Console.WriteLine(empty == "");
           empty = NaiveCanonicalizer.GetCanonicalForm("  "); 
           System.Console.WriteLine(empty == "");


        //    System.Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life WondERful    ")); 
        //    System.Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life      WondERful    "));


        //    System.Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("Wonderful Life"));
        //    System.Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life Wonderful"));
        //    System.Console.WriteLine(NaiveCanonicalizer.GetCanonicalForm("life wonderfuL"));

           Console.Read();
        }
    }
}
