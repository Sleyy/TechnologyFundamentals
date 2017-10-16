using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main()
        {
            Dictionary<string,Dictionary<string,int>> people = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] args = input.Split(':');
                var name = args[0];
                string[] cards = args[1].Trim().Split(new string[]{", "},StringSplitOptions.RemoveEmptyEntries);
                

                if (!people.ContainsKey(name))
                {
                    people.Add(name,new Dictionary<string, int>());
                    AddCardsToPerson(people[name], cards);
                }
                else
                {
                    AddCardsToPerson(people[name], cards);
                }
                input = Console.ReadLine();
            }
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()}");
            }
        }

        static void AddCardsToPerson(Dictionary<string, int> person, string[] cards)
        {
            foreach (var card in cards)
            {
                if (!person.ContainsKey(card))
                {
                    person.Add(card,GetCardValue(card));
                }
            }
        }

        static int GetCardValue(string card)
        {
            int power = 0;
            if (card[0] == '2')
            {
                power += 2;
            }
            else if (card[0] == '3')
            {
                power += 3;
            }
            else if (card[0] == '4')
            {
                power += 4;
            }
            else if (card[0] == '5')
            {
                power += 5;
            }
            else if (card[0] == '6')
            {
                power += 6;
            }
            else if (card[0] == '7')
            {
                power += 7;
            }
            else if (card[0] == '8')
            {
                power += 8;
            }
            else if (card[0] == '9')
            {
                power += 9;
            }
            else if (card[0] == '1')
            {
                power += 10;
            }
            else if (card[0] == 'J')
            {
                power += 11;
            }
            else if (card[0] == 'Q')
            {
                power += 12;
            }
            else if (card[0] == 'K')
            {
                power += 13;
            }
            else if (card[0] == 'A')
            {
                power += 14;
            }

            if (card[card.Length-1] == 'S')
            {
                power *= 4;
            }
            else if (card[card.Length - 1] == 'H')
            {
                power *= 3;
            }
            else if (card[card.Length - 1] == 'D')
            {
                power *= 2;
            }
            else if (card[card.Length - 1] == 'C')
            {
                power *= 1;
            }
            return power;

        }
    }
}
