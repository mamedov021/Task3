using Task3.Entity.Dto.Response;

namespace Task3.Services.ServicesInterfaces
{
    public interface ICategoryService
    {


        ResponseBaseColumn GetAll();
        ResponseBaseColumn GetById(int id);

        ResponseBaseColumn Add(CategoryResponseDto categoryResponseDto);
        ResponseBaseColumn Delete(int id);
        ResponseBaseColumn Update(int id, CategoryResponseDto categoryResponseDto);
 

    }
}
