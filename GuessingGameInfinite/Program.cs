using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            // kasutaja peab seda numbrit ära arvama;
            // kui kasutaja suutis numbri ära arvata, siis kasutaja on mängu võitnud;
            // katsete arv piiramatu.
            //* programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (cpuNumber !=0) 
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
                    Console.WriteLine($"Vale vastus, palun proovige uuesti");

                }

                
                



            }
            Console.WriteLine("Kena päeva");



         
            
            

            

                 
            
            
            
        }

    }
}
