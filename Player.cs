using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_ZM
{
    internal class Player
    {
        //sets a get and set for int "Health" and a get for string "GamerTag." 
        public int Health { get; set; }

        public string GamerTag { get; }

        //makes the words Health and GamerTag into Params.
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        //lets the player join the game and checks if there is a queue. If there is a queue then it will list how many others are in queue before you.
        public void JoinGame(Game game, Queue<Player> queue)
        {
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }
        //returns the GamerTag param to the ToString.
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
