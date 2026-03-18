namespace Jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leaderboard leaderboard = new Leaderboard("Player1", 100, DateTime.Now);
            leaderboard.Rogzit("Player1", 100);
            leaderboard.Rogzit("Player2", 200);
            leaderboard.Rogzit("Player3", 150);

            Console.WriteLine("Név\tPont\tIdő");
            List<Eredmeny> eredmenyek = leaderboard.GetBoard().OrderByDescending(e => e.Pont).ToList();
            foreach (Eredmeny eredmeny in eredmenyek)
            {
                Console.WriteLine(eredmeny.ToString());
            }

            leaderboard.Reset();
        }
    }
}