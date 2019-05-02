using System;

namespace LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int blue = 3;
            int red= 3;
            int yellow = 3;

            int nPlayer = 0;

            bool start = true;

            int asd = 0;

            Player[] players = new Player[2];

            for (int i = 0; i < 2; i++)
            {
                Player player = new Player(blue, red, yellow);

                players[i] = player;
            }

            /*for (int b = 0; b < 2; b++)
            {
                for (int c = 0; c < 1; c++)
                {
                    int pos1 = Convert.ToInt32(Console.ReadLine());
                    int pos2 = Convert.ToInt32(Console.ReadLine());
                    int pos3 = Convert.ToInt32(Console.ReadLine());

                    players[b].Positions(pos1, pos2, pos3);
                }
            }*/

            while (start)
            {
                Console.WriteLine("Choose the color of the ghost you want to put in (b = blue, r = red, y = yellow)");

                string input = Console.ReadLine();

                if (input == "b")
                {
                    
                    int pos1 = Convert.ToInt32(Console.ReadLine());
                    int pos2 = Convert.ToInt32(Console.ReadLine());
                    
                    players[0].Positions(pos1, pos2, asd);

                    asd++;
                }

                if (asd == 3)
                {
                    start = false;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "a")
                {
                    Console.WriteLine(players[nPlayer].GetGhostsBlue());
                    Console.WriteLine(players[nPlayer].GetGhostsRed());
                    Console.WriteLine(players[nPlayer].GetGhostsYellow());

                    for (int d = 0; d < 3; d++)
                    {
                        
                        Console.Write("({0}", players[nPlayer].getPos(d,0));

                        Console.Write(",{0})/n", players[nPlayer].getPos(d, 1));
                    }
                }
                if (input == "b")
                {
                    blue--;
                    red--;
                    yellow--;

                    players[nPlayer].Update(blue, red, yellow);
                }

                if (nPlayer == 0) nPlayer = 1;
                else nPlayer = 0;
            }
        }
    }
}
