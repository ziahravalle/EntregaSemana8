using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbProveedor
{
    public int CodProveedor { get; set; }

    public int RazSocial { get; set; }

    public string DirProveedor { get; set; } = null!;

    public string? TlfProveedor { get; set; }

    public string RepartidorVenta { get; set; } = null!;
}
