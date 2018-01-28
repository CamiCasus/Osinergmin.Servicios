using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intertek.Osinergmin.Servicios.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intertek.Osinergmin.Servicios.Controllers
{
    [Produces("application/json")]
    [Route("api/Guia")]
    public class GuiaController : Controller
    {
        [HttpGet("Listado")]        
        public List<GuiaListado> Listado()
        {
            return new List<GuiaListado>
            {
                new GuiaListado
                {
                    Codigo = "PER/0866-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0867-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0868-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0869-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0870-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0871-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0872-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0873-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0874-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0875-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0876-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0877-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0878-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Codigo = "PER/0879-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                }
            };
        }
    }
}