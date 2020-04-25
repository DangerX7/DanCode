using System;

namespace ConsoleApp5
{
    enum BossState
    {
        Attack,
        Defend,
        Charge
    }
    class Program
    {

        static void Main(string[] args)
        {
        int enemyHp = 5;
        int playerHp = 3;
        int enemyState = 0;
        int playerState = 0;
            bool x = true;///////////delete

            var bossAction = BossState.Attack;

            switch (bossAction)
            {
                case BossState.Attack:
               //     Console.WriteLine("douche");
                    break;
                case BossState.Defend:
               //     Console.WriteLine("X");
                    break;
                case BossState.Charge:
               //     Console.WriteLine("X");
                    break;
            }

            //  int i = Convert.ToInt32(BossState.Attack);

            int i = 1;

            while(i < 4)
            {
                while (i == 1)
                {
                    Console.WriteLine("Enemy is defending");
                    Console.WriteLine("What will you do? A: attack, B: parry, C: stand");
                    var input = Convert.ToString(Console.ReadLine());


                    if (input == "A")
                    {
                        Console.WriteLine("Your attack won't reach");
                        i = 2;
                    }
                    else if (input == "B")
                    {
                        Console.WriteLine("Not a good timing for this...");
                        i = 2;
                    }
                    else if (input == "C")
                    {
                        Console.WriteLine("Good choise");
                        i = 2;
                    }
                    else
                    {
                        Console.WriteLine("Unknown command");
                        continue;
                    }
                }
                while (i == 2)
                {
                    Console.WriteLine("Enemy is charging");
                    Console.WriteLine("What will you do? A: attack, B: parry, C: stand");
                    var input = Convert.ToString(Console.ReadLine());


                    if (input == "A")
                    {
                        Console.WriteLine("The enemy took damage!");
                        i = 3;
                        enemyHp -= 1;
                        if (enemyHp == 0)
                        {
                            Console.WriteLine("You win!");
                            i = 4;
                        }
                    }
                    else if (input == "B")
                    {
                        Console.WriteLine("Not a good timing for this...");
                        i = 3;
                    }
                    else if (input == "C")
                    {
                        Console.WriteLine("Nothing happened...");
                        i = 3;
                    }
                    else
                    {
                        Console.WriteLine("Unknown command");
                        continue;
                    }
                }

                while (i == 3)
                {
                    Console.WriteLine("Enemy is about to strike");
                    Console.WriteLine("What will you do? A: attack, B: parry, C: stand");
                    var input = Convert.ToString(Console.ReadLine());


                    if (input == "A" || input == "C")
                    {
                        Console.WriteLine("You took damage!");
                        i = 1;
                        playerHp -= 1;
                        if (playerHp == 0)
                        {
                            Console.WriteLine("You lost!");
                            i = 4;
                        }
                    }
                    else if (input == "B")
                    {
                        Console.WriteLine("You successfully reflected the attack");
                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("Unknown command");
                        continue;
                    }
                }
            }
        }
    }
}
