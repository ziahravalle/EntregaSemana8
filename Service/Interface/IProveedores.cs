using EntregaSemana8.Models;

namespace EntregaSemana8.Service.Interface
{
    public interface IProveedores
    {
        IEnumerable<TbProveedor> GetAllProveedores();
        void Add(TbProveedor proveedor);
        void Update(TbProveedor proveedor);
        void Delete(int id);
        TbProveedor GetProveedor(int id);
    }
}
