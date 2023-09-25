using Queues_ZM;

class Program
{
    static void Main(string[] args)
    {
       
        //sets the line of code that will allow us to use the code below it. sorta like a foundation. 
        Game myGame = new Game(50, 49);

        Queue<Player> waitingToJoinQ = new Queue<Player>();

        //lists how much Health p1, p2, p3, and p4 then their GamerTags.
        Player p1 = new Player(100, "MMSix");
        Player p2 = new Player(100, "xXAwesomenessXx");
        Player p3 = new Player(100, "Get Good");
        Player p4 = new Player(100, "ZombieSlaya");

        //p1, p2, p3, and p4 JoinGame and starts to wait to join queue as it scans how many are in said queue.
        p1.JoinGame(myGame, waitingToJoinQ);
        p2.JoinGame(myGame, waitingToJoinQ);
        p3.JoinGame(myGame, waitingToJoinQ);
        p4.JoinGame(myGame, waitingToJoinQ);

        //Writes the line "Players in da Q:," displaying how many are in queue then the amount are in queue.
        Console.WriteLine("Players in da Q:");
        foreach (Player player in waitingToJoinQ)
        {
            Console.WriteLine(player);
        }

        //kicks the layers in the game then checks the queue again right after.
        myGame.KickPlayer();
        myGame.CheckQueue(waitingToJoinQ);

        //lists how many players are in queue.
        Console.WriteLine("\nPlayers in da Q:");
        foreach (Player player in waitingToJoinQ)
        {
            Console.WriteLine(player);
        }
    }
}