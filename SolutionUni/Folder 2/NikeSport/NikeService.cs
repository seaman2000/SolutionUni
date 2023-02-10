using SolutionUni.MainClass;

namespace SolutionUni.Folder_2.NikeSport
{
    public class NikeService : Sneakers
    {
        private readonly List<NikeSport> sneakers;

        public NikeService()
        {
            sneakers = new List<NikeSport>();
        }

        public override void Add()
        {
            var nikeSnk = new NikeSport();

            Console.WriteLine("Enter name of the sneakers");
            nikeSnk.Name = Console.ReadLine();
            Console.WriteLine("Enter price of the sneakers");
            nikeSnk.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity of the Ssneakers");
            nikeSnk.Quantity = int.Parse(Console.ReadLine());

            sneakers.Add(nikeSnk);
            

            foreach (var item in sneakers)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Price:{item.Price}");
                Console.WriteLine($"Quantity: {item.Quantity}");
            }
        }
        public override void Remove()
        {
            Console.WriteLine("Enter the name of the sneakers you want to remove");
            string snkToRemove = Console.ReadLine();
            Console.WriteLine("Enter the number of the sneakers you want to remove");
            int numberToRemove = int.Parse(Console.ReadLine());
            try
            {
                var ifExist = sneakers.Find(f => f.Name == snkToRemove && f.Quantity >= numberToRemove);
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
                var ifExist = sneakers.First(f => f.Name == name);
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
