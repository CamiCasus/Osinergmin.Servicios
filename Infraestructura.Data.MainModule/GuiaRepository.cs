using Domain.MainModule.Entities;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule
{
    public class GuiaRepository : Repository<GuiaEntity, int>, IGuiaRepository
    {
        public GuiaRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public async override Task<GuiaEntity> Get(int id, bool @readonly = true)
        {
            //return await
            //        (@readonly ? DbSet.AsNoTracking() : DbSet)
            //            .Include(p => p.Detalles)
            //            .ThenInclude(d => d.Producto)
            //            .FirstOrDefaultAsync(p => p.Id == id);

            string query = @"SELECT [Id]
                              ,[Codigo]
                              ,[Comentario]
                              ,[DniRepresentanteIntertek]
                              ,[DniRepresentanteOsinergmin]
                              ,[Estado]
                              ,[FechaRecepcion]
                              , '' AS [GuiaAdjunta]
                              ,[NombreArchivo]
                              ,[RepresentanteIntertek]
                              ,[RepresentanteOsinergmin]
                              ,[SupervisorExtraccionMuestra]
                              ,[NumeroGuia] 
                            FROM Guias
                            WHERE Id = {0}";

            var guiaActual = await (@readonly ? DbSet.AsNoTracking() : DbSet)
                                                    .FromSql(query, id)
                                                    .Include(d => d.Detalles)
                                                    .ThenInclude(d => d.Producto)
                                                    .SingleOrDefaultAsync();

            return guiaActual;
        }
    }
}
