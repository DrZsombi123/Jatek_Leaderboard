namespace Jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leaderboard leaderboard = new Leaderboard("Player1", 100, DateTime.Now);
            leaderboard.Rogzit("Player1", 100);
            leaderboard.Rogzit("Player2", 200);

            List<Eredmeny> eredmenyek = leaderboard.GetBoard();
            foreach (Eredmeny eredmeny in eredmenyek)
            {
                Console.WriteLine($"Név: {eredmeny.Nev}, Pont: {eredmeny.Pont}");
            }

            leaderboard.Reset();
        }
    }
}
