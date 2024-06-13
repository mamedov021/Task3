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

        public async Task<Category> Add(Category category)
        {
            var sql = $@"INSERT INTO [Category]
                                ( 
                                 [CategoryName],
                                 [isDeleted]
                                 
                                VALUES
                                (
                                 :Name,
                                 :false
                                ) ";

            await _connection.ExecuteAsync(sql, category);
            return category;
        }


        public async Task Delete(int Id)
        {
            var sql = "DELETE FROM Category WHERE Id = :Id";
            await _connection.ExecuteAsync(sql, new { Id });

        }



        public async Task<List<Category>> GetAll()
        {
            var sql = @"SELECT * FROM Category";

            return (await _connection.QueryAsync<Category>(sql)).ToList();
        }
         

        public async Task<Category> GetById(int Id)
        {
            var sql = @"SELECT * FROM Category WHERE Id = :Id";
            return await _connection.QueryFirstOrDefaultAsync<Category>(sql, new { Id });
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
