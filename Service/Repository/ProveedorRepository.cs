using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;

namespace EntregaSemana8.Service.Repository
{
    public class ProveedorRepository : IProveedores
    {
        private BdInfochill bdChill = new BdInfochill();

        public IEnumerable<TbProveedor> GetAllProveedores()
        {
            return bdChill.TbProveedors;
        }
        public void Add(TbProveedor proveedor)
        {
            try
            {
                bdChill.TbProveedors.Add(proveedor);
                bdChill.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(int id)
        {
            var obj = (from tproveedor in bdChill.TbProveedors
                       where tproveedor.CodProveedor == id
                       select tproveedor).Single();
            bdChill.TbProveedors.Remove(obj);//delete from <tabla> where <campo>=id
            bdChill.SaveChanges();
        }


        public TbProveedor GetProveedor(int id)
        {
            var obj = (from tproveedor in bdChill.TbProveedors
                       where tproveedor.CodProveedor == id
                       select tproveedor).Single();
            return obj;
        }

        public void Update(TbProveedor cliModificado)
        {
            var objAModificado = (from tproveedor in bdChill.TbProveedors
                                  where tproveedor.CodProveedor == cliModificado.CodProveedor
                                  select tproveedor).FirstOrDefault();
            if (objAModificado != null)
            {
                objAModificado.CodProveedor = cliModificado.CodProveedor;
                objAModificado.RazSocial = cliModificado.RazSocial;
                objAModificado.DirProveedor = cliModificado.DirProveedor;
                objAModificado.TlfProveedor = cliModificado.TlfProveedor;
                objAModificado.RepartidorVenta = cliModificado.RepartidorVenta;

                bdChill.SaveChanges();
            }
        }
    }
}
