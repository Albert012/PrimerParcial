using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimerParcial.Entidades;

namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class GruposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            
             bool paso = false;
             Grupos grupo = new Grupos();
             grupo.GrupoId = 1;
             grupo.Descripcion = "Jevi";
             grupo.Cantidad = 20;
             grupo.Grupo = 4;

            paso = BLL.GruposBLL.Guardar(grupo);
            Assert.AreEqual(paso,true);
             
        }

        [TestMethod()]
        public void ModificarTest()
        {
             bool paso = false;
             Grupos grupo = new Grupos();
             grupo.GrupoId = 8;             
             grupo.Descripcion = "Jevi";
             grupo.Cantidad = 30;
             grupo.Grupo = 2;

            paso = BLL.GruposBLL.Modificar(grupo);
            Assert.AreEqual(paso,true);
            
        }

        [TestMethod()]
        public void EliminarTest()
        {
            
             bool paso = false;
             paso = BLL.GruposBLL.Eliminar(2);
             Assert.AreEqual(paso,true);
             
        }

        [TestMethod()]
        public void BuscarTest()
        {
             Grupos grupo = new Grupos();
             grupo = BLL.GruposBLL.Buscar(6);
             Assert.IsNotNull(grupo);
        }

        [TestMethod()]
        public void GetListTest()
        {
             var lista = BLL.GruposBLL.GetList(g => true);
             Assert.IsNotNull(lista);
             
        }
    }
}