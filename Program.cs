using System.Diagnostics.Metrics;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task7_1 //done;
            //Task7_2 //done;
            //Task7_3 //done;
            //Task7_4 //done;
            //Task7_5 //done;
            //Task7_6 //done;
            //Task7_15* 

            /* 15)*Verilmish metinde ilk ve son simvol eynidirse,ve metn daxilinde yanashi gelen { a}
             simvolu varsa, ve metn daxilinde { b} simvolu yoxdursa o zaman bu metnde butun { c}            
                    simvollari yox et ve neticede alinan metn zerkalni olub olmadigini yoxla.*/
            Console.Write(" Metni daxil et:");
            string metn =Console.ReadLine();
            int fi = metn.IndexOf('a');
            int li=metn.LastIndexOf("a");

            if (fi==0 && li == metn.Length)
            {

                if (fi==0)
                {

                }





            }


                Console.WriteLine("Zerkalni metn Yazmisan ))");









        }
        static void Task7_1()


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

        static void Task7_2(string a)
        {
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?

            string x = "2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?";

            char indx = 'a';

            for (int i = 0; i < x.Length; i++)
            {
                if (i % 2 == 0)

                {

                    if (indx == x[i])
                    {

                        Console.WriteLine("he");


                    }
                    else
                        Console.WriteLine("yox"); break;





                }






            }






        }

        static void Task7_3(string a)
        {
            // 3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}
            // -ye beraberdir.
            string h = "3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.";
            char b = 'b';
            int Counter = 0;
            for (int i = 0; i < h.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (b == h[i])
                    {
                        Counter++;

                    }

                }


            }

            Console.WriteLine(Counter);








        }

        static void Task7_4(string a)
        {

            /*4) Verilmish metnde sol terefden ilk rast gelinen { a}
            simvolunun yeri tek ededdi yoxsa cut ?*/

            string q = "4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?";
            char indx = 'a';
            for (int i = 0; i < q.Length; i++)
            {
                if (indx == q[i])
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("cut"); break;

                    }
                    else Console.WriteLine("tek"); break;

                }


            }







        }


        static void Task7_5(string a)
        {

            //5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?
            string y = "5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?";
            char ind1 = 'a';
            char ind2 = 'b';
            char ind3 = 'c';
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] == ind1)
                {
                    Console.WriteLine("{a} simvolu"); break;

                }
                else if (y[i] == ind2)
                {
                    Console.WriteLine("b simvolu"); break;

                }
                else if (y[i] == ind3)
                {
                    Console.WriteLine("c simvolu"); break;

                }






            }














        }

        static void Task7_6(string a)
        {
            //6) Verilmish metnde { a }simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            string r = "6) Verilmish metnde { a }simvolunun sol terefden ve sag terefden indexleri eydidirmi?";

            int x = r.IndexOf('a');
            int y = r.LastIndexOf('a');

            if (x == y)
            {

                Console.WriteLine("Beli");
            }

            else Console.WriteLine("Xeyr");


        }


        static void Task7_7(string a)
        {






        }



    }




}
