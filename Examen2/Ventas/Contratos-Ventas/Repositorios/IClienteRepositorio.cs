using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Models;

namespace Ventas.Contratos_Ventas.Repositorios
{
    public interface IClienteRepositorio
    {
        public Task<bool> Create(Cliente cliente);
        
    }

}
