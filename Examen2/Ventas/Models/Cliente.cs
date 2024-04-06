using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ventas.Models;

[Table("Cliente")]
public partial class Cliente
{
    [Key]
    [Column("idcliente")]
    public int Idcliente { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [InverseProperty("IdclienteNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
