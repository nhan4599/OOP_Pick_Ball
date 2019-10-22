using System;

namespace GameProject
{
    class Player
    {
        private string Name;

        public Player(string name)
        {
            Name = name;
        }

        public void PickBall(Board game)
        {
            Console.WriteLine("This is turn of {0}", Name);
            Console.Write("What's group do you choose : ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls do you want to pick : ");
            int balls = int.Parse(Console.ReadLine());
            try
            {
                game.PickBall(group, balls);
            }catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                PickBall(game);
            }
        }

        public string GetName()
        {
            return Name;
        }
    }
}
