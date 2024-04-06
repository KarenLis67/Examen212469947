using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Models;

namespace Ventas.Contratos_Ventas.Repositorios
{
    public interface IPedidoRepositorio
    {
        public Task<bool> Create(Pedido pedido);
        public Task<bool> Update(Pedido pedido);
        public Task<bool> Delete(string partitionKey, string rowkey);
        public Task<List<Pedido>> GetAll();
        public Task<Pedido> Get(string id);
    }

}
