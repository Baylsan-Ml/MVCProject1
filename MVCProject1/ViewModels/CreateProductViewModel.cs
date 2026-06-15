using MVCProject1.Models;

namespace MVCProject1.ViewModels
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Rate { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
