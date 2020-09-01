using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            Random rnd = new Random();
            int winner = rnd.Next(0, contestants.Count - 1);
            return contestants.ElementAt(winner).Value;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestant = PickWinner();
            Console.WriteLine("The winner is: "+contestant);
            Console.ReadLine();
        }
    }
}
