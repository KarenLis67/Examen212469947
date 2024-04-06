using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Ventas.Models;

[Keyless]
[Table("Detalle")]
public partial class Detalle
{
    [Column("idpedido")]
    public int Idpedido { get; set; }

    [Column("idproducto")]
    public int Idproducto { get; set; }

    [Column("cantidad")]
    public int? Cantidad { get; set; }

    [Column("precio")]
    public int? Precio { get; set; }

    [Column("subtotal")]
    public int? Subtotal { get; set; }
    [JsonIgnore]
    [ForeignKey("Idpedido")]
    public virtual Pedido IdpedidoNavigation { get; set; } = null!;
    [JsonIgnore]
    [ForeignKey("Idproducto")]
    public virtual Producto IdproductoNavigation { get; set; } = null!;
}
