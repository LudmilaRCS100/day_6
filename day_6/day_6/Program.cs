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
            /*

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
        */
            //i++=i+1
            int vertiba = 20;

            for (int i = 2; i < vertiba; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            int skaititais = 0;
            while (skaititais != 5)

            {
                Console.WriteLine(skaititais);
                skaititais++;


            }
            Console.ReadLine();

            /*


        static string PievienoSkaitli(string skaitlis)

        {

            string rezultats = "Mans skaitlis ir " + skaitlis;

            return rezultats;

        }



        static double SkaitluSalidzinasana(double skaitlis1, double skaitlis2)

        

            double rezultats;



            if (skaitlis1 < skaitlis2)

            {

                rezultats = skaitlis2;

            }

            else

            {

                rezultats = skaitlis1;

            }

            return rezultats; */

            string izvele = "";
            double result = 0;
            while (izvele != "izvele") ;


            Console.WriteLine("Vai gribat saskaitit vai iziet?");
            izvele = Console.ReadLine();
            if (izvele == "saskaitit")
            {
                Console.WriteLine("Ievadiet pirmo skaitli");
                string ievade1 = Console.ReadLine();
                double skaitlis1 = Convert.ToDouble(ievade1);

                Console.WriteLine("Ievadiet otro skaitli");
                string ievade2 = Console.ReadLine();
                double skaitlis2 = Convert.ToDouble(ievade1);

                result = Calculate(skaitlis1, skaitlis2);

                Console.WriteLine("Result=" + result);

            }


            Console.ReadLine();


        }
        static double Calculate(double skaitlis1, double skaitlis2)
        {

            return skaitlis1 + skaitlis2;
        }
    }

}