using System;

namespace GameProject
{
    class Board
    {
        private int G1, G2, G3;

        public Board(int g1, int g2, int g3)
        {
            G1 = g1;
            G2 = g2;
            G3 = g3;
        }

        public void PrintGame()
        {
            Console.Write("Group 1 : ");
            for (int i = 1; i <= G1; i++)
            {
                Console.Write("o ");
            }
            Console.Write("\nGroup 2 : ");
            for (int i = 1; i <= G2; i++)
            {
                Console.Write("o ");
            }
            Console.Write("\nGroup 3 : ");
            for (int i = 1; i <= G3; i++)
            {
                Console.Write("o ");
            }
            Console.WriteLine();
        }

        public bool IsGameOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
            {
                return true;
            }
            return false;
        }

        public void PickBall(int group, int balls)
        {
            InvalidOperationException eGroup = new InvalidOperationException("Group must be 1, 2 or 3");
            InvalidOperationException eB = new InvalidOperationException("Balls must be greater than 0 and less or equal than balls remaining in group");
            if (group == 1)
            {
                if (balls > G1)
                    throw eB;
                G1 -= balls;
            }
            else if (group == 2)
            {
                if (balls > G1)
                    throw eB;
                G2 -= balls;
            }
            else if (group == 3)
            {
                if (balls > G1)
                    throw eB;
                G3 -= balls;
            }
            else
            {
                throw eGroup;
            }
        }
    }
}
