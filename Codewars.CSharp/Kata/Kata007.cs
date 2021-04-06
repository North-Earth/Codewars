using System.Collections.Generic;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.
    /// Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
    /// Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?
    /// Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. Otherwise return NO.
    /// </summary>
    public class Kata007
    {
        private const string Success = "YES";
        private const string Failed = "NO";

        private const int TicketCost = 25;

        private static List<int> Cash = new List<int>();

        public static string Tickets(int[] peopleInLine)
        {
            Cash.Clear();

            foreach (var bill in peopleInLine)
            {
                var change = bill - TicketCost;

                Cash.Add(bill);

                if (change > 0 && !Exists(change)) { return Failed; }
            }

            return Success;
        }

        private static bool Exists(int count)
        {
            var bills = new List<int>();

            foreach (var bill in Cash.Where(c => c <= count).OrderByDescending(c => c))
            {
                if (bill <= (count - bills.Sum())) { bills.Add(bill); }

                if (bills.Sum() == count)
                {
                    bills.ForEach(b => Cash.Remove(b));
                    return true;
                }
            }

            return false;
        }

        public static string TicketsBestPractice1(int[] peopleInLine)
        {
            int twentyFives = 0, fifties = 0;

            foreach (var bill in peopleInLine)
            {
                switch (bill)
                {
                    case 25:
                        ++twentyFives;
                        break;
                    case 50:
                        --twentyFives;
                        ++fifties;
                        break;
                    case 100:
                        if (fifties == 0)
                        {
                            twentyFives -= 3;
                        }
                        else
                        {
                            --twentyFives;
                            --fifties;
                        }
                        break;
                }

                if (twentyFives < 0 || fifties < 0)
                {
                    return "NO";
                }
            }

            return "YES";
        }

        public static string TicketsBestPractice2(int[] p)
        {
            int m25 = 0, m50 = 0;
            for (int i = 0; i < p.Length & m25 >= 0; i++)
            {
                m25 += (p[i] == 25 ? 25 : p[i] == 50 ? -25 : m50 < 50 ? -75 : -25);
                m50 += (p[i] == 25 ? 0 : p[i] == 50 ? 50 : m50 < 50 ? 0 : -50);
            }
            return m25 < 0 ? "NO" : "YES";
        }
    }
}
