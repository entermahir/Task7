using System.Diagnostics.Metrics;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Ask7);

        }
        static void Ask7()

             
        {

            //1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?

            string a = "1) Verilmish metnde {a} simvolun sayi {b} simvolun sayiVVnda nece defe coxdur?";
            int Count2 = 0;
            int Count1 = 0;
            char chqr = 'a';
            char chqr1 = 'b';


            foreach (char chr in a)
            {
                if (chr == chqr)
                {
                    Count1++;




                }

                if (chr == chqr1)
                {
                    Count2++;
                }

            }

            Console.WriteLine($" a simvolu---" + Count1);
            Console.WriteLine($" b simvolu---" + Count2);


            Console.WriteLine($"Cavab---" + Count1 / Count2);


        }



    }




}
