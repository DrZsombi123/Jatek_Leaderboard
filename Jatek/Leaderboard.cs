using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        Dictionary<int, List<Eredmeny>> pontokSzerint = new Dictionary<int, List<Eredmeny>>();

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

            eredmenyek = eredmenyek.OrderByDescending(e => e.Pont).ToList();

            if (!pontokSzerint.ContainsKey(pont))
            {
                pontokSzerint[pont] = new List<Eredmeny>();
            }
            pontokSzerint[pont].Add(ujEredmeny);
        }
        public List<Eredmeny> GetBoard() { return eredmenyek; }

        public void Reset()
        {
            eredmenyek.Clear();
        }

        public List<Eredmeny> GetResults(int position)
        {
            var rendezettPontok = pontokSzerint.Keys.OrderByDescending(k => k).ToList();
            int currentPosition = 1;

            foreach (var pont in rendezettPontok)
            {
                var lista = pontokSzerint[pont];

                if (currentPosition == position)
                {
                    return new List<Eredmeny>(lista);
                }

                currentPosition++; 
            }
            throw new ArgumentException($"Nincs {position}. helyezett.");


            return new List<Eredmeny>();
        }

        public void RemoveResult(string nev)
        {
            eredmenyek.RemoveAll(e => e.Nev == nev);
        }


    }
}