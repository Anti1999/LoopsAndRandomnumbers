using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            // kasutaja peab seda numbrit ära arvama;
            // kui kasutaja suutis numbri ära arvata, siis kasutaja on mängu võitnud;
            // kasutajal on kolm katset,kui kui kasutaja ei suutnud ära arvata siis arvuti võidab
            //* programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;


            while (i < 3)
            {
                Console.WriteLine("Sisestage number 1-10 ni");
                int Usernumb = Convert.ToInt32(Console.ReadLine());




                if (cpuNumber == Usernumb)
                {
                    Console.WriteLine("Palju õnne olete numbri ära arvanud!");
                    break;
                }

                else
                {

                    i++;

                    Console.WriteLine($"Vale vastus. {3 - i} katset on jäänud, palun proovige uuesti");

                }






            }
            Console.WriteLine("Kena päeva");

        }
    }
}
