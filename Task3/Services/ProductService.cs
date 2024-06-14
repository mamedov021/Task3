using Task3.Entity;
using Task3.Entity.Dto.Response;
using Task3.Repositories;
using Task3.Repositories.RepositoriesInterfaces;
using Task3.Services.ServicesInterfaces;

namespace Task3.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
       
        public ResponseBaseColumn Add(ProductRequestDto productRequestDto)
        {
            if (productRequestDto == null)
            {
                return new ResponseBaseColumn
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "Invalid category data",
                    Status = "400"
                };
            }


            var product = new Product
            {
                Name = productRequestDto.Name,
                Price = productRequestDto.Price,
                Description = productRequestDto.Description,    
                CatogeryId = productRequestDto.CatogeryId,
                IsWarranty=productRequestDto.IsWarranty,
 



            };
            _productRepository.Add(product);

            return new ResponseBaseColumn
            {
                Data = product,
                IsSuccess = true,
                Message = " successfully",
                Status = "200"
            };
        }
       
        public ResponseBaseColumn Delete(int id)
        {
           var product = _productRepository.GetById(id);

            if (product != null)
            {
                _productRepository.Delete(id);

                return new ResponseBaseColumn
                {
                    Data = null,
                    IsSuccess = true,
                    Message = "Product deleted successfully",
                    Status = "200"
                };
            }

            return new ResponseBaseColumn
            {
                Data = null,
                IsSuccess = false,
                Message = "Product not found",
                Status = "404"
            };
        }

        public ResponseBaseColumn GetAll()
        {

            var products= _productRepository.GetAll();
            var responceColumns = new ResponseBaseColumn
            {
                IsSuccess = true,
                Message = "successfully",
                Status = "200",
                Data = products.Result,
            };

            return responceColumns;
        }

      
        public ResponseBaseColumn GetById(int id)
        {
           var product = _productRepository.GetById(id); 
            if (product != null) 
            {
                return new ResponseBaseColumn
                {
                    Data = product,
                    IsSuccess = true,
                    Message = " successfully",
                    Status = "200"

                };

            }
            else
            {
                return new ResponseBaseColumn
                {
                    Data = null,
                    IsSuccess = false,
                    Message = " not running",
                    Status = "404"

                };
            }
        }
        public async Task< ResponseBaseColumn> Update(int id, ProductRequestDto productRequestDto) 
        {
            var product = _productRepository.GetById(id);
            if (product != null) { 

                product.Result.Name = productRequestDto.Name;

           await _productRepository.Update(id,product.Result);

                return new ResponseBaseColumn
                {
                    Data = product,
                    IsSuccess = true,
                    Message = "Update successfully",
                    Status = "200"
                };
            }

            return new ResponseBaseColumn
            {
                Data = null,
                IsSuccess = false,
                Message = "Not found",
                Status = "404"
            };
        }
    }
}
