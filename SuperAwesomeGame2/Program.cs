using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAwesomeGame2
{
    internal class Program
    {
        static int score;
        static int Health;
        static int EnemyDMG;
        static int Shield;
        static float multiplier;
        static void Main(string[] args)
        {
            Console.WriteLine("The Super Awesome Real Game");

            score = 0;
            Health = 100;
            Shield = 100;
            int EnemyValue;
            EnemyDMG = 20;
            multiplier = 2;

            ShowHUD();
            Console.WriteLine();
            Console.WriteLine("You encounter an enemy!");
            Console.WriteLine();
            TakeDamage(20);
            ShowHUD();
            Console.WriteLine();


            Console.WriteLine("You defeated the enemy!");
            Console.WriteLine("The enemy had a multiplier!");
            Console.WriteLine();
            AddScoreMulti(100);
            ShowHUD();
            Console.WriteLine();


            Console.WriteLine("You found a Small Shield Restoration Unit!");
            Restore(20);
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();


            Console.WriteLine("You encountered a Goblin!");
            Console.WriteLine();
            TakeDamage(50);
            ShowHUD();
            Console.WriteLine();


            Console.WriteLine("You strike a mighty blow, defeating the Goblin!");
            Console.WriteLine();
            AddScore(250);
            ShowHUD();





            Console.ReadKey(true);
        }

      static void AddScoreMulti(float PointsGainedFloat)
        {
            PointsGainedFloat = PointsGainedFloat * multiplier;
            int PointsGainedInt = (int)PointsGainedFloat;
            score = score + PointsGainedInt;
        }
 

      static void ShowHUD()
        {
            Console.WriteLine("[-------------]");
            Console.WriteLine("Shield: " + Shield);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("[-------------]");

        }
      static void TakeDamage(int damage)
        {
            Shield = Shield - damage;
        }
     
      static void Restore(int SmallRestore)
        {
            Shield = Shield + SmallRestore;
        }

      static void AddScore(int PointsGained)
        {
            score = score + PointsGained;
        }

                
    }

}
