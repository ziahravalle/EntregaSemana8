using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbVentum
{
    public int IdVenta { get; set; }

    public int? IdCliente { get; set; }

    public int? TotalProducto { get; set; }

    public decimal? MontoTotal { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? IdTransaccion { get; set; }

    public DateTime? FechaVenta { get; set; }

    public virtual TbCliente? IdClienteNavigation { get; set; }
}
