using Task3.Entity;

namespace Task3.Repositories.RepositoriesInterfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int Id);
        Task<Category> Add(Category category);
        Task Delete(int Id);
        Task Update(int Id, Category category);
        
    }
}
