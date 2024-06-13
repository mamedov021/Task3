using Task3.Entity;
using Task3.Entity.Dto.Response;
using Task3.Repositories.RepositoriesInterfaces;
using Task3.Services.ServicesInterfaces;

namespace Task3.Services
{


    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ResponseBaseColumn Add(CategoryResponseDto categoryResponseDto)
        {
            throw new NotImplementedException();
        }

        public   ResponseBaseColumn Delete(int id)
        {
            var category =    _categoryRepository.GetById(id);

            if (category != null)
            {
                 _categoryRepository.Delete(id);

                return new ResponseBaseColumn
                {
                    Data = null,
                    IsSuccess = true,
                    Message = "Category deleted successfully",
                    Status = "200"
                };
            }

            return new ResponseBaseColumn
            {
                Data = null,
                IsSuccess = false,
                Message = "Category not found",
                Status = "404"
            };
        }
        public  ResponseBaseColumn GetAll()
         {
            var responceColumns = new ResponseBaseColumn();
            var categories = _categoryRepository.GetAll;

            foreach (var category in categories) {
                responceColumns.Add(new ResponseBaseColumn
                {
                    Data = category,
                    IsSuccess = true,
                    Message = "successfully",
                    Status = "200" 
                }); 
            }
            return responceColumns;
         }

        
        public ResponseBaseColumn GetById(int id)
        {
            var category = _categoryRepository.GetById( id);
            if (category != null)
            {
                return new ResponseBaseColumn
                {
                    Data = category,
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

        public ResponseBaseColumn Update(int id, CategoryResponseDto categoryResponseDto)
        {
            throw new NotImplementedException();
        }

      
    }
}