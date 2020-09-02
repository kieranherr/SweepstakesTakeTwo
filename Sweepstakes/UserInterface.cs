using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        static int regNumCount = 0;
        public static string GetUserInput()
        {
            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1. Create a new Contestant.");
            Console.WriteLine("2. Use the Queue Manager.");
            Console.WriteLine("3. Use the Stack Manager.");
            Console.WriteLine("4. Create a new Sweepstake.");
            string prompt = Console.ReadLine();
            return prompt;
            
        }
        public static void switchcase()
        {
            string prompt = GetUserInput();
            switch (prompt)
            {
                case "1":
                    NewContestant();
                    break;
                case "2":
                    UseQueue();
                    break;
                case "3":
                    UseStack();
                    break;
                case "4":
                    Console.WriteLine("What would you like to call your sweepstakes?");
                    string ans = Console.ReadLine();
                    NewSweepstakes(ans);
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }
        public static Contestant NewContestant()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();
            Contestant contestant = new Contestant(firstName, lastName, email, regNumCount);
            regNumCount++;
            return contestant;
        }
        public static SweepstakesQueueManager UseQueue()
        {
            SweepstakesQueueManager queue = new SweepstakesQueueManager();
            return queue;
        }
        public static SweepstakesStackManager UseStack()
        {
            SweepstakesStackManager stack = new SweepstakesStackManager();
            return stack;
        }
        public static Sweepstakes NewSweepstakes(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes(name);
            return sweepstakes;
        }
    }
}
