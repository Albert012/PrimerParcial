using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using PrimerParcial.Entidades;
using PrimerParcial.DAL;
using System.Data.Entity;


namespace PrimerParcial.BLL
{
    public class GruposBLL
    {
        /// <summary>
        /// Nos permite Guardar un grupo de estudiante
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns>retorna true si guardo y false sino guardo</returns>
        public static bool Guardar(Grupos grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.Grupos.Add(grupo)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        /// <summary>
        /// Nos permite modificar el grupo de estudiante
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns>retona true si modifico y false sino modifico</returns>
        public static bool Modificar(Grupos grupo)
        {
            bool paso = true;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(grupo).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        /// <summary>
        /// Nos permite Eliminar un grupo de estudiante
        /// </summary>
        /// <param name="id"></param>
        /// <returns>retorna true si elimino y false sino</returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Grupos grupo = contexto.Grupos.Find(id);
                contexto.Grupos.Remove(grupo);

                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        /// <summary>
        /// Nos permite buscar un grupo de estudiante
        /// </summary>
        /// <param name="id"></param>
        /// <returns>retorna el grupo encontrado</returns>
        public static Grupos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Grupos grupo = new Grupos();

            try
            {
                grupo = contexto.Grupos.Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return grupo;
        }

        /// <summary>
        /// Nos permite listar un grupos de estudiantes
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>retorna la lista del grupo de estudiantes</returns>
        public static List<Grupos> GetList(Expression<Func<Grupos,bool>> expression)
        {
            List<Grupos> grupos = new List<Grupos>();
            Contexto contexto = new Contexto();

            try
            {
                grupos = contexto.Grupos.Where(expression).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return grupos;
        }


        public static Decimal CalcularIntegrantes(Decimal cantidad, Decimal grupo)
        {
            return cantidad / grupo;
        }
    }
}
