namespace MVCProject1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CreateProductViewModel> Products { get; set; }
    }
}
