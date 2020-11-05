using Domain.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Context
{
    public class LinhaContext : DbContext
    {
        public DbSet<Linha> Linha { get; set; } 
    }
}
