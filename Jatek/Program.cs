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
            leaderboard.Rogzit("Player4", 200);

            Console.WriteLine("Név\tPont\tIdő");
            foreach (Eredmeny eredmeny in leaderboard.GetBoard()) 
            {
                Console.WriteLine(eredmeny.ToString());
            }
            
            leaderboard.RemoveResult("Player2"); 
            foreach (Eredmeny eredmeny in leaderboard.GetBoard())
            {
                Console.WriteLine(eredmeny.ToString());
            }
            Console.WriteLine("----------------------------------------");
            try
            {
                Console.WriteLine("Kérem adja meg a helyezés számát (pl. 1, 2, 3):");
                int helyezesSzam = int.Parse(Console.ReadLine());
                List<Eredmeny> helyezes = leaderboard.GetResults(helyezesSzam);
                Console.WriteLine($"A {helyezesSzam}. helyezettek:");
                foreach (var e in helyezes)
                {
                    Console.WriteLine(e);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // "Nincs 4. helyezett."
            }
        }
    }
}