using Domain.Classes;
using Domain.IRepository;
using Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositories
{
    public class LinhaRepository : ILinhaRepository
    {
        public void Salvar(Linha linha)
        {
            using (LinhaContext db = new LinhaContext()) 
            {
                db.Add(linha);
                db.SaveChanges();
            }
                
        }


    }
}
