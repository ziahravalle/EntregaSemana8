using EntregaSemana8.Models;
using EntregaSemana8.Service.Interface;

namespace EntregaSemana8.Service.Repository
{
    public class UsuarioRepository : IUsuario 
    {
        private BdInfochill bd = new BdInfochill();

        public TbUsuario getValidarUsuario(TbUsuario usuario)
        {
            var obj = (from tusuario in bd.TbUsuarios
                       where tusuario.UsuUsuario == usuario.UsuUsuario &&
                                tusuario.UsuClave == usuario.UsuClave
                       select tusuario).FirstOrDefault();
            return obj;
        }

    }
}
