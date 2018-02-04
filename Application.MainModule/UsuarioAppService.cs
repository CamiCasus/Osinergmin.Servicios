using Application.MainModule.Core;
using Application.MainModule.Interfaces;
using AutoMapper;
using Infraestructura.Data.MainModule.Core;
using Infraestructura.Data.MainModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.MainModule
{
    public class UsuarioAppService : BaseAppService, IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioAppService(
            IUnitOfWork unitOfWork, 
            IMapper mapper,
            IUsuarioRepository usuarioRepository)
            :base(unitOfWork, mapper)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool Autenticar(string usuario, string password)
        {
            var resultado =_usuarioRepository.Find(p => p.Usuario == usuario && p.Password == password);
            return resultado.Any();
        }
    }
}
