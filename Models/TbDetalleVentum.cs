using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbDetalleVentum
{
    public int? IdVenta { get; set; }

    public string? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Total { get; set; }

    public virtual TbProducto? IdProductoNavigation { get; set; }

    public virtual TbVentum? IdVentaNavigation { get; set; }
}
