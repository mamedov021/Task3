namespace Task3.Entity
{
    
    public class Image
    {
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public int productId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
 