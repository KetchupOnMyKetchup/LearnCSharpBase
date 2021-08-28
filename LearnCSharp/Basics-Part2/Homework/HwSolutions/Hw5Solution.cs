using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnCSharp;

namespace LearnCSharp.Part2.Homework
{
    /// <summary>
    /// Classes practice
    /// BONUS Hw: implement the ability for Player to sell items back to shop!
    /// </summary>
    public class Hw5Solution
    { 
        // -----------------------------------------------------------
        // Create a new project called Zelda Shop using classes!!!
        // -----------------------------------------------------------
        public enum Rareness
        {
            Common,
            Uncommon,
            Rare,
            Legendary
        }

        
        public class Shop
        {
            public Shop(List<Item> initialItems)
            {
                Inventory = new List<Item>();
                Inventory.AddRange(initialItems);
            }
            // Put this class into a new file

            // Make properties for shop items available to buy, shop profit (gold)

            public List<Item> Inventory { get; set; }
            public int Profit { get; set; }

            // Make methods for all shop Prompts such as welcoming Player, listing items for sale, asking player if they want to buy,
            // allowing player to buy items, selling an item, listing shop profit (gold)

            public void PrintGreetingMessage()
            {
                Console.WriteLine("Welcome to my shop!");
            }

            public void PrintExitMessage()
            {
                Console.WriteLine("Thank you!");
            }

            public void PrintProfit()
            {
                Console.WriteLine($"Shop has {Profit} gold now.");
            }

            public void PrintInventory()
            {
                if (Inventory.Count == 0)
                {
                    Console.WriteLine("Sorry! Inventory is empty!");
                }

                Console.WriteLine($"My shop has the following items:");

                foreach (var item in Inventory)
                {
                    Console.WriteLine($"{item.Name} costs {item.Cost} which is {item.Rarity}");
                }

                Console.WriteLine("What would you like to buy? Or type exit to leave.");
            }

            public void AddItem(Item item)
            {
                Inventory.Add(item);
            }
            public void SellItem(string itemName, Player player)
            {
                // remove from inventory
                Item item = Inventory.Where(x => x.Name == itemName).FirstOrDefault();
                if (item == null)
                {
                    Console.WriteLine("Sorry this item does not exist, try again!");
                    return;
                }

                if (player.Gold < item.Cost)
                {
                    Console.WriteLine("Sorry you can't afford that! Try again!");
                    return;
                }

                if (player.IsAtItemLimit)
                {
                    Console.WriteLine("Sorry you are holding too many items! Discard one before trying to buy more.");
                    return;
                }
                
                Inventory.Remove(item);
                player.Inventory.Add(item);

                player.Gold -= item.Cost;
                Profit += item.Cost;

                PrintProfit();
                player.PrintGold();
                Console.WriteLine("Thank you! Anything else?");
            }
            
        }

        public class Item
        {
            // Put this class into a new file

            // Add properties for name, description, cost, and rarity
            public string Name { get; set; }
            public string Description { get; set; }
            public int Cost { get; set; }
            public Rareness Rarity { get; set; }
        }

        public class Player
        {
            // Put this class into a new file
            public Player(string name, int initialGold, int itemLimit)
            {
                Inventory = new List<Item>();
                
                Name = name;
                Gold = initialGold;
                ItemLimit = itemLimit;
            }

            // Add properties for name, gold, and inventory
            public string Name { get; set; }
            public int Gold { get; set; }
            public List<Item> Inventory { get; set; }

            // Optional: add limitation on items
            public int ItemLimit { get; set; }
            public bool IsAtItemLimit => Inventory.Count == ItemLimit ? true : false;     

            // Add methods to print out Player's inventory and amount of gold
            //public bool AddItemToInventory(Item item) => IsAtItemLimit
            //{
            //    if (IsAtItemLimit) return false;
            //    return true;
            //}

            public void RemoveItemFromInventory(Item item)
            {
                // check if item exists
                if (Inventory.Where(x => x.Name == item.Name) != null)
                {
                    Inventory.Remove(item);
                    Console.WriteLine($"{item.Name} has been tossed out!");
                }
                else
                {
                    Console.WriteLine($"{item.Name} does not exist in inventory!");
                }
            }

            public void PrintGold() 
            {
                Console.WriteLine($"{Name} has {Gold} gold.");
            }

            public void PrintInventory()
            {
                if (Inventory.Count == 0)
                {
                    Console.WriteLine("Sorry! Inventory is empty!");
                }

                Console.WriteLine($"{Name} has the following items:");

                foreach (var item in Inventory)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        public void Run()
        {
            // Seed the shop with 3 items
            List<Item> seedItems = new List<Item>();

            Item sword = new Item()
            {
                Name = "Fine Sword",
                Cost = 100,
                Description = "It's a fine sword, alright, not the best.",
                Rarity = Rareness.Common
            };

            Item shield = new Item()
            {
                Name = "Iffy Shield",
                Cost = 100,
                Description = "It's might protect you.",
                Rarity = Rareness.Common
            };

            Item wand = new Item()
            {
                Name = "Ridiculous Wand",
                Cost = 99999,
                Description = "I bet you can't afford it anyways.",
                Rarity = Rareness.Legendary
            };

            seedItems.Add(sword);
            seedItems.Add(shield);
            seedItems.Add(wand);

            // Instantiate shop
            Shop dungeonShop = new Shop(seedItems);

            // Seed the player with name and 1000 gold
            Player player = new Player("Crystal", 1000, 1);

            // Simulate a player entering shop and being welcomed
            dungeonShop.PrintGreetingMessage();
            dungeonShop.PrintInventory();

            // Have console readlines to allow Player (you) to choose items to buy as many items as you want or until shop runs out of items
            string playerResponse = Console.ReadLine();
            while (playerResponse != "exit")
            {
                dungeonShop.SellItem(playerResponse, player);
                playerResponse = Console.ReadLine();
            }

            // Upon exit of shop, print out shop profit + shop inventory leftover + player gold + player inventory
            dungeonShop.PrintExitMessage();
            dungeonShop.PrintProfit();
            player.PrintInventory();
            player.PrintGold();
        }
    }
}