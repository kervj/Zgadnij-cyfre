using System;

namespace numberGame
{
    class guessTheNumber
    {
        static void Main(string[] args)
        {

            bool endApp = false;

            while (!endApp)
            {
                Random random = new Random();
                int guessTheNumber = random.Next(101);

                Console.WriteLine("===ZGADNIJ NUMER===");
                Console.WriteLine("\n");
                Console.WriteLine("Podaj cyfrę od 1-100");
                Console.WriteLine("\n");
                Console.WriteLine(guessTheNumber);

                string myType = Console.ReadLine();

                int cleanType = 0;

                

                while (!int.TryParse(myType, out cleanType))
                {
                    Console.WriteLine("Podaj prosze poprawna liczbe w zakresie 1-100");
                    myType = Console.ReadLine();
                }

                if (cleanType > 100)
                {
                    Console.WriteLine("Podałeś za dużą cyfrę, program się zrestartuje");
                    break;
                }


                while (cleanType != guessTheNumber)
                {
                    if(cleanType > 100)
                    {
                        Console.WriteLine("Podana cyfra jest za duża - spróbuj jescze raz");
                        myType = Console.ReadLine();
                        while (!int.TryParse(myType, out cleanType)) ;
                    }
                    else
                    {
                        Console.WriteLine("Niestety, nie zgadłeś - spróbuj jeszcze raz!");
                        myType = Console.ReadLine();
                        while (!int.TryParse(myType, out cleanType)) ;
                    }
                                        
                }

                if (cleanType == guessTheNumber)
                {
                    Console.WriteLine("Brawo - zgadłeś! Ta cyfra to " + guessTheNumber);
                    endApp = true;
                }               

            }
            return;

           
        }
    }
}