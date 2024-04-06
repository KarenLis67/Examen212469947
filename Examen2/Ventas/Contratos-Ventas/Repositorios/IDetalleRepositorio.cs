using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Models;

namespace Ventas.Contratos_Ventas.Repositorios
{
    public interface IDetalleRepositorio
    {
        public Task<bool> Create(Detalle detalle);
        public Task<bool> Update(Detalle detalle);
        public Task<bool> Delete(string partitionKey, string rowkey);
        public Task<List<Detalle>> GetAll();
        public Task<Detalle> Get(string id);
    }

}
