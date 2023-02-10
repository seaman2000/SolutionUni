
using SolutionUni.Folder_1;
using SolutionUni.Folder_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolutionUni.Folder_2.NikeSport
{
    public class Vservice : Sneakers
    {
        private readonly List<Sneakers> sneakers;


        public Vservice()
        {
            sneakers = new List<Sneakers>();
        }

        public override void Add()
        {
            var snk = new NikeSport();

            Console.WriteLine("Enter name of the sneakers");
            snk.Name = Console.ReadLine();
            Console.WriteLine("Enter price of the sneakers");
            snk.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity of the Ssneakers");
            snk.Quantity = int.Parse(Console.ReadLine());

            sneakers.Add(snk);;

            foreach (var item in NikeSport)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Price:{item.Price}");
                Console.WriteLine($"Quantity: {item.Quantity}");
            }
        }
        public override void Remove()
        {
            Console.WriteLine("Enter the name of the vitamin you want to remove");
            string snkToRemove = Console.ReadLine();
            Console.WriteLine("Enter the number of the vitamins you want to remove");
            int numberToRemove = int.Parse(Console.ReadLine());
            try
            {
                var ifExist = NikeSport.Find(f => f.Name == snkToRemove && f.Quantity >= numberToRemove);
                var removed = ifExist.Quantity - numberToRemove;
                if (removed >= 0)
                {
                    ifExist.Quantity = removed;
                }
                Console.WriteLine(ifExist.Quantity);

            }
            catch (Exception)
            {
                Console.WriteLine("It does not exist.");
            }
        }

        public override void AddToExisting()
        {
            Console.WriteLine("Enter an existing sneakers");
            string name = Console.ReadLine();
            try
            {
                var ifExist = NikeSport.First(f => f.Name == name);
                Console.WriteLine("Enter Quantity of the sneakers");
                int quantityToAdd = int.Parse(Console.ReadLine());
                var newQuantity = ifExist.Quantity + quantityToAdd;
                ifExist.Quantity = newQuantity;
                Console.WriteLine($"{name}: {ifExist.Quantity}");

            }
            catch (Exception)
            {
                Console.WriteLine("It does not exist.");
            }

        }
    }
}
