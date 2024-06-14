using Dapper;
using Npgsql;
using Task3.Entity;
using Task3.Repositories.RepositoriesInterfaces;

namespace Task3.Repositories
{
    public class ProductRepository : IProductRepository  
    {
        private readonly NpgsqlConnection _connection;


        public ProductRepository(NpgsqlConnection connection)
        {
            _connection = connection;

        }
    
        public async Task<Product> Add(Product product)
        {
            var sql = $@"INSERT INTO [Product]
                                ( 
                                 [Name], [Price],[isDeleted],[category_id], [description], [is_warranty]


                                VALUES
                                (
                                 :Name,
                                 :Price,
                                 :IsDeleted,
                                 :Category_id,
                                 :Description,
                                 :IsWarranty


                                ) ";

            await _connection.ExecuteAsync(sql, product);
            return product;
        }



     
        public async Task Delete(int Id)
        {
            var sql = "DELETE FROM Product WHERE Id = :Id";
            await _connection.ExecuteAsync(sql, new { Id });

        }
 
        public async Task<List<Product>> GetAll()
        {
            var sql = @"SELECT * FROM Product";

            return (await _connection.QueryAsync<Product>(sql)).ToList();
        }

 
        public  async Task<Product> GetById(int Id)
        {
            var sql = @"SELECT * FROM Product WHERE Id = :Id";
            return  await _connection.QueryFirstOrDefaultAsync<Product>(sql, new { Id });
        }
       

        public async Task Update(int Id, Product product)
        {
            var sql = @"UPDATE Product SET Name = :Name, Price =: Price, Category_id =: CategoryID, Description =: Description, is_warranty =: IsWarranty    WHERE Id = @Id";
            await _connection.ExecuteAsync(sql,
                new
                {
                    product.Name,
                    product.Price,
                    product.CatogeryId,
                    product.Description,
                    product.IsWarranty,
                    Id
                }
            );
        }

    }
}
