using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            namespace Zahnrad
    {
        class Program
        {
            static void Main(string[] args)
            {
                Double a, b, c, d, e, h, f, g, i, j, k, n;
                Console.WriteLine("a=Modul,b=Zaehnezahl,c=Teilkreisdurchmesser,d=Breite,");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("e=Kopfspiel,f=zahnfusshoehe,g=zahnkopfhoehe");
                e = 0.167 * a;
                h = 2 * a + e;
                f = a + e;
                g = a;
                Console.WriteLine("e={0}", e);

                Console.WriteLine("f={0}", f);

                Console.WriteLine("g={0}", g);


                Console.WriteLine("i=Teilung");
                i = Math.PI * a;
                Console.WriteLine("i={0}", i);


                Console.WriteLine("j=Fusskreisdurchmesser1,n=Fusskreisdurchmesser2");
                j = c - 2 * (a + e);
                n = c + 2 * (a + e);
                Console.WriteLine("j={0}", j);

                Console.WriteLine("n={0}", n);

                Console.WriteLine("k=Grundkreisdurchmesser");
                k = a * b * Math.Cos(20 * Math.PI / 180);

                Console.WriteLine("k={0}", k);

                Console.ReadKey();


            }
        }
}
