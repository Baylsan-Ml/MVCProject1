using MVCProject1.Models;

namespace MVCProject1.ViewModels
{
    public class ProductsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Rate { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
    }
}
