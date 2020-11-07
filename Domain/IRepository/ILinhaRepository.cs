using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IRepository
{
    public interface ILinhaRepository
    {
        void Salvar(Linha linha);
    }
}
