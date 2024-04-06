using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Repositorio
{
    public class Pedido
    {
        [Key]
        public int idPedido { get; set; }
        public int idCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Total {  get; set; }
        public string Estado { get; set; }
        [ForeignKey("idCliente")]
        [InverseProperty("Pedidos")]
        public virtual Cliente idClienteNavigation { get; set; } = null;

    }
}
