using Task3.Entity;

namespace Task3.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        Category Add(Category category);
        void Delete(int id);
        void Update(int id, Category category);

    }
}
