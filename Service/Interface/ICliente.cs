using EntregaSemana8.Models;

namespace EntregaSemana8.Service.Interface
{
    public interface ICliente
    {
        IEnumerable<TbCliente> GetAllClientes();
        void Add(TbCliente cliente);
        void Update(TbCliente cliente);
        void Delete(int id);
        TbCliente GetCliente(int id);
    }
}
