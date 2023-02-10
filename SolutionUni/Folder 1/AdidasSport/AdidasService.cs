using SolutionUni.MainClass;

namespace SolutionUni.Folder_1.AdidasSport
{
    public class AdidasService : Sneakers
    {
        private readonly List<AdidasSport> Sneakers;


        public AdidasService()
        {
            Sneakers = new List<AdidasSport>();
        }

        public override void Add()
        {
            var snk = new AdidasSport();

            Console.WriteLine("Enter name of the sneakers");
            snk.Name = Console.ReadLine();
            Console.WriteLine("Enter price of the sneakers");
            snk.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity of the sneakers");
            snk.Quantity = int.Parse(Console.ReadLine());

            Sneakers.Add(snk);

            foreach (var item in Sneakers)
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
            Console.WriteLine("Enter the number of the sneakers you want to remove: ");
            int numberToRemove = int.Parse(Console.ReadLine());
            try
            {
                var ifExist = Sneakers.Find(f => f.Name == snkToRemove && f.Quantity >= numberToRemove);
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
                var ifExist = Sneakers.First(f => f.Name == name);
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

