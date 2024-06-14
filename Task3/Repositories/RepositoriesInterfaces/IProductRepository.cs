using System.Collections.Generic;
using System.Threading.Tasks;
using Task3.Entity;

namespace Task3.Repositories.RepositoriesInterfaces
{
    public interface IProductRepository
    {

        Task<Product> Add(Product product);
        Task Delete(int Id); 
        Task<List<Product>> GetAll();
        Task<Product> GetById(int Id); 
        Task Update(int Id, Product product);

       
    }
}
