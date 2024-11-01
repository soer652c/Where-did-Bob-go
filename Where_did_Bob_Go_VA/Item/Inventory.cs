﻿using System;
using System.Diagnostics;

using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.GUI_NS;
using Where_did_Bob_Go_VA.Item_NS;
using Where_did_Bob_Go_VA.NPC_NS;
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;
using Where_did_Bob_Go_VA.Player_NS;
using Where_did_Bob_Go_VA.Proc_Gen_NS;
using Where_did_Bob_Go_VA.World_NS;
using Where_did_Bob_Go_VA.Game_NS;


namespace Where_did_Bob_Go_VA.Item
{
    public class Inventory
    {
        public List<Item> ItemList = new List<Item>();

        //constructor
        public Inventory()
        {

        }

        //Metode Add.Item
        public void Add(Item item)
        {
            ItemList.Add(item);
        }

        // Metode Use Item
        public void Use(Item item)
        {
            if (ItemList.Contains(item))
            {
                Console.WriteLine("You used this item");
            }
            else
            {
                Console.WriteLine("Item not found on the list in Inventory");
            }
        }
        // metode til use.int
        public void Use(int number)
        {
            if (number >= 0 && number < ItemList.Count)
            {
                ItemList[number].Use();
            }
            else
            {
                Console.WriteLine("Invalid, list is out of range");
            }
        }
        //metode til Remove.int 
        public void Remove(int number)
        {
            if (ItemList.Contains(ItemList[number]))
                ItemList.RemoveAt(number);
        }

        //Remove Item 
        public void Remove(Item item)
        {
            if (ItemList.Contains(item))
            {
                ItemList.Remove(item);
                Console.WriteLine("Item removed" + " " + item.nameOfItem);
            }
            else
            {
                Console.WriteLine("Item not found on the list in Inventory");
            }
        }
        //display inventory 
        public void Display()
        {
            Console.WriteLine("Inventorylist");
            foreach (Item item in ItemList)
            {
                Console.WriteLine(item.nameOfItem + "\n" + "This is the name Item; " + item.nameOfItem + "\n" + " And this is the description of the item: " + item.description + "\n");
            }
        }
    }
}
