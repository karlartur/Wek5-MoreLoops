using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei suuda kolme korral numbrit ära arvata
            //siis mängu võitab arvuti
            //katse arv on 3;
            //*programm genereerib juhusliku numbrit ühte korda

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);//number 1 kuni 10
            
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta juhuslik number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuRandom )
                {
                    Console.WriteLine("Sa võitsid");
                    //break;
                    i = 3;
                }
                else
                {
                    i = i + 1 ;
                    Console.WriteLine($"Vale number. {3 - i} Katset on jäänud. Proovi uuesti!");

                }

            }
            Console.WriteLine("Arvuti võitis.");
            Console.WriteLine("Kena päeva!");
        }
    }
}
