using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Parada
    {
        public virtual int Id { get; set; }
        public virtual int Numero { get; set; }
        public virtual double Longitude { get; set; }
        public virtual double Latitude { get; set; }
    }
}
