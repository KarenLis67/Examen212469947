using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Models;

namespace Ventas.Contratos_Ventas.Repositorios
{
    public interface IPedidoDetalle
    {
        public Task<bool> Create(PedidoDetalle pedidodetalle);
        public Task<bool> Update(PedidoDetalle pedidodetalle, int id);
        public Task<bool> CreatePedidos(Pedido pedido);
        public Task<bool> UpdatePedidos(Pedido pedido,int id);
    }
}
