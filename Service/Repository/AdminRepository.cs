﻿using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;
namespace EntregaSemana8.Service.Repository
{
    public class AdminRepository : IAdmin
    {
        private BdInfochill bd = new BdInfochill();

        public IEnumerable<TbProducto> GetAllProductos()
        {
            return bd.TbProductos;
        }
        public void Add(TbProducto producto)
        {
            try
            {
                bd.TbProductos.Add(producto);
                bd.SaveChanges();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }



        public TbProducto GetProducto(string id)
        {
            var obj = (from tproducto in bd.TbProductos
                       where tproducto.IdPro == id
                       select tproducto).Single();
            return obj;
        }

        public void Update(TbProducto productoModi) 
        { 
            var objModificado = (from tproducto in bd.TbProductos
                                 where tproducto.IdPro == productoModi.IdPro
                                 select tproducto).FirstOrDefault();
            if(objModificado != null)
            {
                objModificado.IdPro = productoModi.IdPro;
                objModificado.DesPro = productoModi.DesPro;
                objModificado.PrePro = productoModi.PrePro;
                objModificado.StkAct = productoModi.StkAct;
                objModificado.StkMin = productoModi.StkMin;
                objModificado.CatePro= productoModi.CatePro;
                bd.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var obj = (from tproducto in bd.TbProductos
                       where tproducto.IdPro == id
                       select tproducto).Single();
            bd.TbProductos.Remove(obj);
            bd.SaveChanges();
        }
    }
}
