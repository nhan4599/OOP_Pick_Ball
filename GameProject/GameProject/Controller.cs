using System;

namespace GameProject
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public void PlayGame()
        {
            while (true)
            {
                Game.PrintGame();
                P1.PickBall(Game);
                if (Game.IsGameOver())
                {
                    Console.WriteLine("{0} loses AND {1} wins", P1.GetName(), P2.GetName());
                    break;
                }
                Game.PrintGame();
                P2.PickBall(Game);
                if (Game.IsGameOver())
                {
                    Console.WriteLine("{0} loses AND {1} wins", P2.GetName(), P1.GetName());
                    break;
                }
            }
        }

        public Controller()
        {
            P1 = new Player("Nhan");
            P2 = new Player("Kiet");
            Game = new Board(3, 4, 6);
        }
    }
}
