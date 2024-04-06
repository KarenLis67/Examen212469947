using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Repositorio
{
    public class Detalle
    {
        public int idPedido { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Subtotal { get; set; }
        [ForeignKey("idPedido")]
        [InverseProperty("Detalles")]
        public virtual Pedido idPedidoNavigation { get; set; } = null;
        [ForeignKey("idProducto")]
        [InverseProperty("Detalles")]
        public virtual Producto idProductoNavigation { get; set; } = null;

    }
}
