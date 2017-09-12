using System;

namespace DevDraft
{
    class Test
    {
        public static bool IsDead(int Enemy, int damage)
        {
            if ((Enemy-damage)<=0)
                return false;
            else
                return true;
        }
        public static int NumOfKills(int NumOfEnemies, int Damage, int ReductionAmount, int[] Enemies)
        {
            int CurrentDamage = Damage;
            int TotalEnemiesKilled = 0;
            for (int i = 0; i < NumOfEnemies-1; i++)
            {
                if (IsDead(Enemies[i], CurrentDamage))
                {
                    TotalEnemiesKilled++;
                }
                CurrentDamage -= ReductionAmount;
            }
            return TotalEnemiesKilled;
        }

        static void Main()
        {
            string inputStream1 = Console.ReadLine();
            string inputStream2 = Console.ReadLine();

            string[] inputArray1 = inputStream1.Split(' ');
            string[] inputArray2 = inputStream2.Split(' ');

            int NumOfEnemies = Convert.ToInt32(inputArray1[0]);
            int Damage = Convert.ToInt32(inputArray1[1]);
            int Decrement = Convert.ToInt32(inputArray1[2]);

            int[] Enemies = new int[NumOfEnemies];

            for (int i = 0; i < inputArray2.Length-1; i++)
            {
                Enemies[i] = Convert.ToInt32(inputArray2[i]);
            }
            int total = NumOfKills(NumOfEnemies: NumOfEnemies, Damage: Damage, ReductionAmount: Decrement, Enemies: Enemies);
            Console.WriteLine(total);
        }
    }
}
