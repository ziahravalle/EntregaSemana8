using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbUsuario
{
    public int IdUsuario { get; set; }

    public int? UsuUsuario { get; set; }

    public string UsuClave { get; set; } = null!;

    public virtual TbCliente? UsuUsuarioNavigation { get; set; }
}
