using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }
        public virtual PerfilUsuarioEnum Perfil { get; set; }
    }
}
