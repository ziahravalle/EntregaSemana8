using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbAlumno
{
    public int CodAlumno { get; set; }

    public string? UserCli { get; set; }

    public string? PassCli { get; set; }

    public string? NomAlu { get; set; }

    public string? ApeAlu { get; set; }

    public float? DniAlu { get; set; }

    public string? TlfAlu { get; set; }

    public byte? Estado { get; set; }

    public virtual ICollection<TbVentum> TbVenta { get; set; } = new List<TbVentum>();
}
