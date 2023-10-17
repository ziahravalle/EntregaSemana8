using System;
using System.Collections.Generic;

namespace EntregaSemana8.Models;

public partial class TbCliente
{
    public int CodCliente { get; set; }

    public string? NomCli { get; set; }

    public string? ApeCli { get; set; }

    public float? DniCli { get; set; }

    public string? TlfCli { get; set; }

    public byte? Estado { get; set; }

    public virtual ICollection<TbVentum> TbVenta { get; set; } = new List<TbVentum>();
}
