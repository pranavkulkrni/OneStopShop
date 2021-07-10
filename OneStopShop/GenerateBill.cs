using System;
using System.Collections;
using System.Collections.Generic;

namespace OneStopShop
{
    class GenerateBill
    {
        static void Main(string[] args)
        {            //List<string> MenuItem = new List<string>  { "ABC","kjdf","kjdb"};
            var MenuItem = new Dictionary<string, double>() { { "Bread", 88.52 } , { "Pasta ", 72.26}, { "Rice", 452.16 }, { "Semolina ", 22.42 }, { "Chickpeas", 52.65 } };
            Console.WriteLine("Enter Choice : \n 1. View Items \t 2. View Bill \t 3. Exit\n");
            int _userChoice = Convert.ToInt32(Console.ReadLine());
                switch (_userChoice)
                {
                case 1:
                    GenerateBill p = new GenerateBill();
                    p.ShowMenu(MenuItem);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("*****Invalid Choice*****");
                    Console.WriteLine("Enter Choice : \n 1. View Items \t 2. View Bill \t 3. Exit\n");
                    GenerateBill pr = new GenerateBill();
                    pr.ShowMenu(MenuItem);
                    break;
                }
            Console.WriteLine("What do You Want to buy?");
            Console.WriteLine();
            

        }

        public void ShowMenu(Dictionary<string,double> kv)
        {
            var MenuItem = kv;            
            Console.WriteLine("Item \t\t\t Price");
            Console.WriteLine("-------------------------\n");
            foreach (var i in MenuItem)
            {
                Console.WriteLine($"{i.Key}\t\t\t {i.Value}");
            }
        }     

        public void ShowBill(Dictionary<string, double> kv)
        {
            var MenuItem = kv;
            Console.WriteLine("Item \t\t\t Price");
            Console.WriteLine("-------------------------\n");
            foreach (var i in MenuItem)
            {
                Console.WriteLine($"{i.Key}\t\t\t {i.Value}");
            }
        }
    }
}
