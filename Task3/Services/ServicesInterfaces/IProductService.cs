using Task3.Entity;
using Task3.Entity.Dto.Response;

namespace Task3.Services.ServicesInterfaces
{
    public interface IProductService
    {
        ResponseBaseColumn GetAll();
        ResponseBaseColumn GetById(int id);

        ResponseBaseColumn Add(ProductRequestDto productRequestDto); 

        ResponseBaseColumn Delete(int id);
        Task<ResponseBaseColumn> Update(int id, ProductRequestDto productRequestDto);



    }
}
