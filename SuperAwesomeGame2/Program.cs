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
        static void Main(string[] args)
        {
            Console.WriteLine("The Super Awesome Real Game");

            score = 0;
            Health = 100;
            Shield = 100;
            int EnemyValue;
            EnemyDMG = 20;

            ShowHUD();
            Console.WriteLine();
            Console.WriteLine("You encounter an enemy!");
            TakeDamage(EnemyDMG);
            ShowHUD();

            Console.ReadKey(true);
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
            Shield = Shield - EnemyDMG;
        }
    }

}
