using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Queues_ZM
{
    class Game
    {

        //puts a get to the int "MaxPlayers".
        public int MaxPlayers { get; }

        //puts a get and set to int "CurrentPlayers".
        public int CurrentPlayers { get; set; }

        //sets the words MaxPlayers and CurrentPlayers as a Param.
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        //kicks the CurrentPlayers in the game to make room for other players in queue.
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        //checks the queue. If the MaxPlayers is larger then the CurrentPlayers then it will Dequeue the CurrentPlayers. If not then it will say "No players in the queue!"
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if (CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }

    }
}
