using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbProducto
{
    public string IdPro { get; set; } = null!;

    public string? DesPro { get; set; }

    public decimal? PrePro { get; set; }

    public int? StkAct { get; set; }

    public int? StkMin { get; set; }

    public string? CatePro { get; set; }
}
