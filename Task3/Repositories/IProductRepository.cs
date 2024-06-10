using System.Collections.Generic;
using Task3.Entity;

namespace Task3.Repositories
{
    public interface IProductRepository
    {

        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        void Delete(int id);
        void Update(int id, Product product);


    }
}
