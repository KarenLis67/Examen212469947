using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Ventas.Models;

[Table("Pedido")]
public partial class Pedido
{
    [Key]
    [Column("idpedido")]
    public int Idpedido { get; set; }

    [Column("idcliente")]
    public int Idcliente { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("total")]
    public int? Total { get; set; }

    [Column("estado")]
    [StringLength(50)]
    public string? Estado { get; set; }
    [JsonIgnore]
    [ForeignKey("Idcliente")]
    [InverseProperty("Pedidos")]
    public virtual Cliente IdclienteNavigation { get; set; } = null!;
}
