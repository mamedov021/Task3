namespace Task3.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public int CatogeryId { get; set; }
        public string Description { get; set; }
        public bool IsWarranty { get; set; }
        public IFormFile Photo { get; set; }

       // public virtual Category Category { get; set; }
         
    }
}
