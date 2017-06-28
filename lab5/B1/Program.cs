
using Game;
using Game.CustomCollections;
using Game.Model;
using Game.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorZad.Iterators;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomCollection<Hero> zone1List = generateZone1();
            ICustomCollection<Hero> zone2List = generateZone2();
            ICustomCollection<Hero> zone3List = generateZone3();

            Console.WriteLine("------------------------- 1 --------------------");
            IIterator zone1ListIterator = zone1List.GetIterator();
            while (zone1ListIterator.hasNext())
            {
                Console.WriteLine("{0}", zone1ListIterator.next());
            }

            Console.WriteLine("\n-------------------------\n");

            IIterator zone2ListIterator = zone2List.GetIterator();
            while (zone2ListIterator.hasNext())
            {
                Console.WriteLine("{0}", zone2ListIterator.next());
            }

            Console.WriteLine("\n-------------------------\n");

            IIterator zone3ListIterator = zone3List.GetIterator();
            while (zone3ListIterator.hasNext())
            {
                Console.WriteLine("{0}", zone3ListIterator.next());
            }

            Console.WriteLine("------------------------- 2 --------------------");
            IIterator tournamentIterator = new TournamtneIterator(zone1List.GetIterator(),
                                                                  zone2List.GetIterator(),
                                                                  zone3List.GetIterator());
            while (tournamentIterator.hasNext())
            {
                Console.WriteLine("{0}", tournamentIterator.next());
            }

            Console.WriteLine("------------------------- 3 --------------------");
            Console.WriteLine("zone1 : Shaman");
            IIterator filterIterator1 = new FilterIterator(HeroClass.Shaman, zone1List.GetIterator());
            while (filterIterator1.hasNext())
            {
                Console.WriteLine("{0}", filterIterator1.next());
            }
            Console.WriteLine("zone2 : Warrior");
            IIterator filterIterator2 = new FilterIterator(HeroClass.Warrior, zone2List.GetIterator());
            while (filterIterator2.hasNext())
            {
                Console.WriteLine("{0}", filterIterator2.next());
            }
        }

        // DO NOT CHANGE CODE BELOW

        static ICustomCollection<Hero> generateZone1()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for(int i=0; i<20; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone2()
        {
            CustomLinkedList<Hero> result = new CustomLinkedList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }

        static ICustomCollection<Hero> generateZone3()
        {
            ReversedArrayList<Hero> result = new ReversedArrayList<Hero>();
            RandomHeroGenerator generator = new RandomHeroGenerator();

            for (int i = 0; i < 10; i++)
            {
                result.Add(generator.GenerateRandomHero());
            }

            return result;
        }
    }
}
