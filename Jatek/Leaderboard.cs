using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    internal class Leaderboard
    {
        string name;
        int score;
        DateTime date;
        List<Eredmeny> eredmenyek = new List<Eredmeny>();

        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }
        public DateTime Date { get => date; set => date = value; }

        public Leaderboard(string name, int score, DateTime date)
        {
            this.Name = name;
            this.Score = score;
            this.Date = date;
        }

        public void Rogzit(string nev, int pont)
        {
            Eredmeny ujEredmeny = new Eredmeny(nev, pont);
            eredmenyek.Add(ujEredmeny);
        }
        public List<Eredmeny> GetBoard() { return eredmenyek; }

        public void Reset()
        {
            eredmenyek.Clear();
        }


    }
}