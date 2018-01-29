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
        List<GuiaListado> listaGuiasListado = new List<GuiaListado>
            {
                new GuiaListado
                {
                    Id = 1,
                    Codigo = "PER/0866-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 2,
                    Codigo = "PER/0867-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 3,
                    Codigo = "PER/0868-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 4,
                    Codigo = "PER/0869-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 5,
                    Codigo = "PER/0870-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 6,
                    Codigo = "PER/0871-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 7,
                    Codigo = "PER/0872-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 8,
                    Codigo = "PER/0873-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 9,
                    Codigo = "PER/0874-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 10,
                    Codigo = "PER/0875-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 11,
                    Codigo = "PER/0876-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 12,
                    Codigo = "PER/0877-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 13,
                    Codigo = "PER/0878-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                },
                new GuiaListado
                {
                    Id = 14,
                    Codigo = "PER/0879-18",
                    RepresentanteIntertek = "Gustavo Daniel",
                    RepresentanteOsinergmin = "Ortiz Reyes",
                    FechaIngreso = new DateTime(2018, 1, 14)
                }
            };

        [HttpGet("Listado")]
        public List<GuiaListado> Listado()
        {
            return listaGuiasListado;
        }

        [HttpGet("detalle/{id}")]
        public List<DetalleGuiaListado> Detalle(int id)
        {
            var codigoGuia = listaGuiasListado.First(p => p.Id == id).Codigo;

            return new List<DetalleGuiaListado>
            {
                new DetalleGuiaListado
                {
                    Id = 1,
                    Guia =codigoGuia,
                    NumeroMuestra = 2,
                    TipoMuestra = 1,
                    Ensayos = "densidad, octanaje"
                },
                new DetalleGuiaListado
                {
                    Id = 2,
                    Guia =codigoGuia,
                    NumeroMuestra = 2,
                    TipoMuestra = 2,
                    Ensayos = "densidad, octanaje"
                },
                new DetalleGuiaListado
                {
                    Id = 3,
                    Guia =codigoGuia,
                    NumeroMuestra = 2,
                    TipoMuestra = 2,
                    Ensayos = "densidad, octanaje"
                },
                new DetalleGuiaListado
                {
                    Id = 4,
                    Guia =codigoGuia,
                    NumeroMuestra = 2,
                    TipoMuestra = 1,
                    Ensayos = "densidad, octanaje"
                },
                new DetalleGuiaListado
                {
                    Id = 5,
                    Guia =codigoGuia,
                    NumeroMuestra = 2,
                    TipoMuestra = 1,
                    Ensayos = "densidad, octanaje"
                },
                new DetalleGuiaListado
                {
                    Id = 6,
                    Guia =codigoGuia,
                    NumeroMuestra = 2,
                    TipoMuestra = 2,
                    Ensayos = "densidad, octanaje"
                }
            };
        }
    }
}