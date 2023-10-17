using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbTrabajador
{
    public int CodTrabaj { get; set; }

    public string? NomTrabaj { get; set; }

    public string? ApeTrabaj { get; set; }

    public float? DniTrabaj { get; set; }

    public string? TlfTrabaj { get; set; }

    public decimal? SueldoTrabaj { get; set; }

    public DateTime? FechaIngreTrabaj { get; set; }
}
