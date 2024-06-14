﻿namespace Task3.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean IsDeleted { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
