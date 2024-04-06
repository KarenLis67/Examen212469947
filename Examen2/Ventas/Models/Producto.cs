using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ventas.Models;

[Table("Producto")]
public partial class Producto
{
    [Key]
    [Column("idproducto")]
    public int Idproducto { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }
}
