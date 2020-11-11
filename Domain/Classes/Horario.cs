using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Horario
    {
        public virtual int Id { get; set; }
        public virtual string HoraSaida { get; set; }
        public virtual Linha Linha { get; set; }
        
    }
}
