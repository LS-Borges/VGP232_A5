using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory(10);

            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            Character hero = new Character("Bob", RaceCategory.Human, 100);

            Console.WriteLine("{0} has entered the forest", hero.Name);

            string monster = "goblin";
            int damage = 10;

            Console.WriteLine("A {0} appeared and attacks {1}", monster, hero.Name);

            Console.WriteLine("{0} takes {1} damage", hero.Name, damage);

            hero.TakeDamage(damage);
            Console.WriteLine(hero);

            Console.WriteLine("{0} flees from the enemy", hero.Name);

            string itemName1 = "small health potion";
            int restoreAmount = 10;

            Item item1 = new Item(itemName1, restoreAmount, ItemGroup.Consumable);

            string itemName2 = "mana potion";
            int restoreAmount2 = 5;

            Item item2 = new Item(itemName2, restoreAmount2, ItemGroup.Consumable);

            inventory.AddItem(item1);
            inventory.AddItem(item2);

            Console.WriteLine("{0} find a {1} and drinks it", hero.Name, itemName1);

            bool takeItemCheck = inventory.TakeItem(item1);

            if(takeItemCheck)
            {
                Console.WriteLine("{0} restores {1} health", hero.Name, restoreAmount);

                hero.RestoreHealth(restoreAmount);
            }

            Console.WriteLine(hero);

            if (hero.IsAlive)
            {
                Console.WriteLine("Congratulations! {0} survived.", hero.Name);
            }
            else
            {
                Console.WriteLine("{0} has died.", hero.Name);
            }

            inventory.ListAllItems();
        }
    }
}
