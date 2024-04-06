using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;
using Ventas.Contratos_Ventas.Repositorios;
using Ventas.Models;

namespace Ventas
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private readonly IPedidoDetalle repos;

        public Function1(ILogger<Function1> logger, IPedidoDetalle _repos)
        {
            _logger = logger;
            repos = _repos;
        }

        //1. REALIZAR UN ENDPOINT PARA QUE REGISTRE UN PEDIDO Y SU RESPECTIVO DETALLE
        [Function("PedidoDetalle")]
        [OpenApiOperation("Accountspec", "Account", Description = "Obten las credenciales si son validas")]
        [OpenApiRequestBody("application/json", typeof(PedidoDetalle), Description = "Introduzaca el Objeto")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(PedidoDetalle), Description = "Todo bien")]
        public async Task<HttpResponseData> PedidoDetale([HttpTrigger(AuthorizationLevel.Function, "post", Route = "Insertar PedidoDetalle")] HttpRequestData req)
        {
            HttpResponseData respuesta;
            var registro= await req.ReadFromJsonAsync<PedidoDetalle>();
            
            bool sw = await repos.Create(registro);
            if (sw)
            {
                respuesta = req.CreateResponse(HttpStatusCode.OK);
                return respuesta;
            }
            else
            {
                respuesta = req.CreateResponse(HttpStatusCode.BadRequest);
                return respuesta;
            }
        }
        
        
    }
}
