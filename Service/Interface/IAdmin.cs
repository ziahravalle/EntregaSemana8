using EntregaSemana8.Models;
namespace EntregaSemana8.Service.Interface
{
    public interface IAdmin
    {
        IEnumerable<TbProducto> GetAllProductos();
        void Add(TbProducto producto);
        void Update(TbProducto producto);
        void Delete(string id);
        TbProducto GetProducto(string id);
    }
}
