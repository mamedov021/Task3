using Task3.Entity.Dto.Response;

namespace Task3.Services.ServicesInterfaces
{
    public interface ICategoryService
    {


        ResponseBaseColumn GetAll();
        ResponseBaseColumn GetById(int id);

        ResponseBaseColumn Add(CategoryRequestDto categoryRequestDto);
        ResponseBaseColumn Delete(int id);
        ResponseBaseColumn Update(int id, CategoryRequestDto categoryRequestDto);
        

    }
}
