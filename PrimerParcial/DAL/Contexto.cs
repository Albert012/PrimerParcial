using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using PrimerParcial.Entidades;

namespace PrimerParcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupos { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
