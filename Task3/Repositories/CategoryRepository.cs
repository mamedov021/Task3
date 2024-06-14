using Dapper;
using Npgsql;
using System.Data;
using System.Reflection;
using Task3.Entity;
using Task3.Repositories.RepositoriesInterfaces;

namespace Task3.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NpgsqlConnection _connection;


        public CategoryRepository(NpgsqlConnection connection)
        {
            _connection = connection;

        }

        public Category Add(CategoryRequestDto categoryRequestDto)
        {
            var sql = $@"INSERT INTO  Category
                                ( 
                                 Name,
                                 isDelete
                                 )
                                VALUES
                                (
                                 :Name,
                                  false
                                ) ";

            _connection.Execute(sql, new {categoryRequestDto.Name}   );

            var category = new Category
            {
                Name = categoryRequestDto.Name,
                IsDeleted = false

            };

            return category;
        }
         
        public async Task Delete(int Id)
        {
            var sql = "DELETE FROM Category WHERE Id = :Id";
            await _connection.ExecuteAsync(sql, new { Id });

        }



        public List<Category> GetAll()
        {
            var sql = @"select*from public.category";

            return (_connection.Query<Category>(sql)).ToList();
        }


        public Category GetById(int Id)
        {
            var sql = @"SELECT * FROM public.category WHERE Id = :Id";
            return _connection.QueryFirstOrDefault<Category>(sql, new { Id });
        }


        public async Task Update(int Id, Category category)
        {
            var sql = @"UPDATE Category SET Name = :Name   WHERE Id = @Id";
            await _connection.ExecuteAsync(sql,
                new
                {
                    category.Name,
                    Id
                }
            );
        }
    }
}
