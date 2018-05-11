using System;



namespace day_6

{

    class Program

    {

        static void Main(string[] args)

        {

            //1.uzd.

            /*Console.WriteLine("Ievadiet skaitli:");

            string ievads = Console.ReadLine();



            Console.WriteLine(PievienoSkaitli(ievads));



            string izvade = PievienoSkaitli(ievads);

            Console.WriteLine(izvade);



            int skaits = izvade.Length; //sadi parbaudam simbolu skaitu virkne



            Console.WriteLine(skaits);*/



            //2.uzd

            Console.WriteLine("Ievadiet pirmo skaitli: ");

            string ievade1 = Console.ReadLine();

            double skaitlis1 = Convert.ToDouble(ievade1);



            Console.WriteLine("Ievadiet otro skaitli: ");

            ievade1 = Console.ReadLine();

            double skaitlis2 = Convert.ToDouble(ievade1);



            if (skaitlis1 != skaitlis2)

            {

                double izvade = SkaitluSalidzinasana(skaitlis1, skaitlis2);

                Console.WriteLine("Lielakais skaitlis ir " + izvade);

            }

            else

            {

                Console.WriteLine("Abi skaitli ir vienadi!");

            }





            Console.ReadLine();

        }



        static string PievienoSkaitli(string skaitlis)

        {

            string rezultats = "Mans skaitlis ir " + skaitlis;

            return rezultats;

        }



        static double SkaitluSalidzinasana(double skaitlis1, double skaitlis2)

        {

            double rezultats;



            if (skaitlis1 < skaitlis2)

            {

                rezultats = skaitlis2;

            }

            else

            {

                rezultats = skaitlis1;

            }

            return rezultats;

        }

    }

}