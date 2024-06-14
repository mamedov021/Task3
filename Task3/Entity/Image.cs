namespace Task3.Entity
{
    
    public class Image
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public int ProductId { get; set; }
        public bool IsDeleted { get; set; }
     //   public IFormFile Photo { get; set; }

    }
}
 