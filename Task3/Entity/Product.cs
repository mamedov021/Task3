namespace Task3.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool isDeleted { get; set; }
        public int catogeryId { get; set; }
        public bool isWarranty { get; set; }
         
    }
}
