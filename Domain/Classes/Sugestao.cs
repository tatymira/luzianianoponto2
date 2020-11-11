using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Sugestao
    {
        public virtual int Id { get; set; }
        public virtual double Longitude { get; set; }
        public virtual double Latitude { get; set; }
        public virtual string Descricao { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual Linha Linha { get; set; }
        public virtual PerfilUsuarioEnum Alocacao { get; set; }
    }
}
