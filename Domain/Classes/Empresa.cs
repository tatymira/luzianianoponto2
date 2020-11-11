using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Empresa : Usuario
    {
        public virtual string Cnpj { get; set; }
        public virtual string RazaoSocial { get; set; }
    }
}
