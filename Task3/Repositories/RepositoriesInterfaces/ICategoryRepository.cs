using Task3.Entity;

namespace Task3.Repositories.RepositoriesInterfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int Id);
        Category Add(CategoryRequestDto categoryRequestDto);
        Task Delete(int Id);
        Task Update(int Id, Category category);
        
    }
}
