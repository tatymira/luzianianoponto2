using System;

namespace Domain.Classes
{
    public class Linha
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual decimal Tarifa { get; set; }

        public virtual string Origem { get; set; }

        public virtual string Destino { get; set; }

        public virtual int Numero { get; set; }

        //public virtual Empresa Empresa { get; set; }

        public virtual string LinhaMap { get; set; }
    }
}
