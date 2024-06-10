using Dapper;
using System.Data;
using System.Reflection;
using Task3.DbContext;
using Task3.Entity;
using Task3.Repositories;

namespace Task3.Services
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly DapperDbContext _context;
        private readonly IDbConnection _dbConnection;

        public CategoryRepository(DapperDbContext context, IDbConnection dbConnection)
        {
            _context = context;
            _dbConnection = dbConnection;
            
        }

        public Task<Category> Add(Category category)
        {
            var sql = $@"INSERT INTO [Category]
                                ( 
                                 [CategoryName],
                                 [isDeleted]
                                 
                                VALUES
                                (
                                 @CategoryName,
                                 @false
                                ) ";

            using var connection = _context.CreateConnection();
            //await connection.ExecuteAsync(sql, model);
            //return model;
        }


        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

  

        public async Task<List<Category>> GetAll()
        {
            var sql = @"SELECT * FROM [Category]";

            using var connection = _context.CreateConnection();
            return (await connection.QueryAsync<Category>(sql)).ToList();
        }




        public Category GetById(int id) 
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
