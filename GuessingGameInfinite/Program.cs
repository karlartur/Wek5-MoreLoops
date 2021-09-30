using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katse arv on piiramatu;
            //*programm genereerib juhusliku numbrit ühte korda
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);//number 1 kuni 10
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta juhuslik number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuRandom)
                {
                    Console.WriteLine("You Won!!!");
                    //break;
                    loopActive = false;
                    
                }
                else
                {
                    Console.WriteLine("Vale number. Proovi uuesti.");
                }
                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
