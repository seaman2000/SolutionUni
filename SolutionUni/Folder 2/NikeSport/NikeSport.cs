using System.Transactions;

namespace SolutionUni.Folder_2
{
    public class NikeSport
    {
        public NikeSport(int quantity, decimal price, string? name)
        {
            Quantity = quantity;
            Price = price;
            Name = name;
        }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Name { get; set; }
    }
}
