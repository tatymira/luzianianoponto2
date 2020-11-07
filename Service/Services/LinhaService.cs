using Domain.Classes;
using Domain.IRepository;
using Domain.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class LinhaService : ILinhaService
    {
        private readonly ILinhaRepository _linhaRep;
        public LinhaService(ILinhaRepository linhaRep)
        {
            _linhaRep = linhaRep;
        }

        public void Salvar(Linha linha) {
            _linhaRep.Salvar(linha);
        }


    }
}
