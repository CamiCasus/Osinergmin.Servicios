using AutoMapper;
using Infraestructura.Data.MainModule.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MainModule.Core
{
    public class BaseAppService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public BaseAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
