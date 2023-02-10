namespace SolutionUni
{
    public class Program
    {
        static void Main(string[] args)
        {
            var NikeSport = new Folder_1.AdidasSport.AdidasService();
            var AdidasSport = new Folder_2.NikeSport.NikeService();

            Console.WriteLine("Choose an option below:");
            Console.WriteLine("1. Add New Sneakers");
            Console.WriteLine("2. Remove Sneakers");
            Console.WriteLine("3. Add to existing Shoes");
            Console.WriteLine("4. Exit");


            Console.WriteLine("Enter:");
            string option = Console.ReadLine();
            while (option != "4")
            {
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Select type 1: Adidas or 2 for Nike");
                        string ShoesToAdd = Console.ReadLine();
                        if (ShoesToAdd == "1")
                        {
                            AdidasSport.Add();
                        }
                        else if (ShoesToAdd == "2")
                        {
                            NikeSport.Add();
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Select type 1: Adidas or 2 for Nike ");
                        string ShoesToRemove = Console.ReadLine();
                        if (ShoesToRemove == "1")
                        {
                            AdidasSport.Remove();
                        }
                        else if (ShoesToRemove == "2")
                        {
                            NikeSport.Remove();
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Select type 1: Adidas or 2 for Nike to add to existing");
                        string ShoesAddToExisting = Console.ReadLine();
                        if (ShoesAddToExisting == "1")
                        {
                            AdidasSport.AddToExisting();
                        }
                        else if (ShoesAddToExisting == "2")
                        {
                            NikeSport.AddToExisting();
                        }
                        break;
                }

                Console.WriteLine("Select option");
                Console.WriteLine("1. Add New Sneakers");
                Console.WriteLine("2. Remove Sneakers");
                Console.WriteLine("3. Add to existing Sneakers");
                Console.WriteLine("4. Exit");
                option = Console.ReadLine();
            }
        }
    }
}