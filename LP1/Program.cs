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

            Player[] players = new Player[2];

            for (int i = 0; i < 2; i++)
            {
                Player player = new Player(blue, red, yellow);

                players[i] = player;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "a")
                {
                    Console.WriteLine(players[nPlayer].GetGhostsBlue());
                    Console.WriteLine(players[nPlayer].GetGhostsRed());
                    Console.WriteLine(players[nPlayer].GetGhostsYellow());
                }
                if (input == "b")
                {
                    blue--;

                    players[nPlayer].Update(blue, red, yellow);
                }

                if (nPlayer == 0) nPlayer = 1;
                else nPlayer = 0;
            }
        }
    }
}
