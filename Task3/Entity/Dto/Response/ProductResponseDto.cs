using System;

public class ProductResponseDto
{
	 

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool isDeleted { get; set; }
    public int catogeryId { get; set; }
    public bool isWarranty { get; set; }
 
}
