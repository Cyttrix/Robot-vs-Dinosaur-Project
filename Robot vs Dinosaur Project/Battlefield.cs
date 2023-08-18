using System.Security.Cryptography.X509Certificates;

namespace Robot_vs_Dinosaur_Project
{
    internal class Battlefield
    {

        Dinosaur tRex = new Dinosaur("T-Rex", 100, 10);
        Robot bender = new Robot("Bender", 100);

        //Display a Welcome Message
        public void WelcomeMessage()
            {
            Console.WriteLine("Welcome to a battle never before seen, a T-Rex vs Bender!");
            

            }


        //Run main battle sequence
            public void RunBattle()
            {

           
            
            
            

            while (bender.health > 0 && tRex.health > 0)
            {
                tRex.attack(bender);
                Console.WriteLine($"{tRex.name} attacks {bender.name} for {tRex.attackPower}");
                Console.WriteLine($"Bender has {bender.health} health left");
                if (bender.health > 0)
                {
                    bender.attack(tRex);
                    Console.WriteLine($"{bender.name} attacks {tRex.name} for {bender.activeWeapon.attackPower}");
                    Console.WriteLine($"T-Rex has {tRex.health} health left");
                }
            } 

           
            }


            //Announce winner of the game
            public void DisplayWinner()
            {
            
            if (bender.health <= 0)
            {
                Console.WriteLine("T-Rex Wins!");
            }
            else
            {
                Console.WriteLine("Bender Wins!");
            }
            
            }

            //One "RunGame method which will call its other methods in order.
            public void RunGame()
            {
                WelcomeMessage();
                
                RunBattle();

                DisplayWinner();

            
        }

    }
}