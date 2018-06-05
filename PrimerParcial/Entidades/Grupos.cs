using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class Grupos
    {
        [Key]

        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }//Cantidad de Estudiantes
        public int Grupo{ get; set; }//Grupo deseado
        public int Integrantes { get; set; }//Integrantes por grupo

        public Grupos()
        {
            GrupoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            Grupo = 0;
            Integrantes = 0;
        }

       



    }
}
