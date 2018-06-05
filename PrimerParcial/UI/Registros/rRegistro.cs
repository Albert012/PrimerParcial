﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.Entidades;


namespace PrimerParcial.UI.Registros
{
    public partial class rRegistro : Form
    {
        public rRegistro()
        {
            InitializeComponent();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Grupos grupo = LlenaClase();

            if(Validar())
            {
                

                if(grupoIdNumericUpDown.Value == 0)
                {
                    paso = BLL.GruposBLL.Guardar(grupo);
                }
                else
                {
                    paso = BLL.GruposBLL.Modificar(grupo);
                }

                if (paso)
                    MessageBox.Show("Guardado Correctamente", "Exito Al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Se Pudo Guardar", "Fallo Al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
     

        private Grupos LlenaClase()
        {
            Grupos grupo = new Grupos();

            grupo.GrupoId = Convert.ToInt32(grupoIdNumericUpDown.Value);
            grupo.Fecha = fechaDateTimePicker.Value.Date;
            grupo.Descripcion = descripcionTextBox.Text;
            grupo.Cantidad = Convert.ToInt32(cantidadNumericUpDown.Value);
            grupo.Grupo = Convert.ToInt32(grupoNumericUpDown.Value);
            grupo.Integrantes = Convert.ToInt32(integrantesNumericUpDown.Value);


            return grupo;
        }

        private bool Validar()
        {
            bool paso = true;
            

            if (descripcionTextBox.Text == "")
            {
                ValidarErrorProvider.SetError(descripcionTextBox, "Debes Introducir La Descripcion Del Estudiante");
                paso = false;
            }
            else
                if(cantidadNumericUpDown.Value == 0)
            {
                ValidarErrorProvider.SetError(cantidadNumericUpDown, "Debes Ingresar La Cantidad De Estudiantes");
                paso = false;
            }
            else
                if(grupoNumericUpDown.Value == 0)
            {
                ValidarErrorProvider.SetError(grupoNumericUpDown, "Debes Ingresar La Cantidad De Grupos Deseados");
                paso = false;
            }
                        
            
            return paso;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            grupoIdNumericUpDown.Value = 0;
            fechaDateTimePicker.ResetText();
            descripcionTextBox.Clear();
            cantidadNumericUpDown.Value = 0;
            grupoNumericUpDown.Value = 0;
            integrantesNumericUpDown.Value = 0;
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            int GrupoId = Convert.ToInt32(grupoIdNumericUpDown.Value);

            if (BLL.GruposBLL.Eliminar(GrupoId))
            {
                MessageBox.Show("Eliminado Correctamente", "Exito Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo_button.PerformClick();
            }
            else
                MessageBox.Show("No Se Pudoo Eliminar", "Fallo Al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int GrupoId = Convert.ToInt32(grupoIdNumericUpDown.Value);
            Grupos grupo = BLL.GruposBLL.Buscar(GrupoId);

            if (grupo != null)
            {
                fechaDateTimePicker.Value = grupo.Fecha;
                descripcionTextBox.Text = grupo.Descripcion;
                cantidadNumericUpDown.Value = grupo.Cantidad;
                grupoNumericUpDown.Value = grupo.Grupo;
                integrantesNumericUpDown.Value = grupo.Integrantes;

            }
            else
                MessageBox.Show("Datos No Encontrados", "Fallo Al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void grupoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //CalcularIntegrantes();
            int cant = Convert.ToInt32(cantidadNumericUpDown.Value), grp = Convert.ToInt32(grupoNumericUpDown.Value);

            if(cantidadNumericUpDown.Value != 0)
            {
                CalcularIntegrantes();
            }
            else
                if(grupoNumericUpDown.Value !=0 )
            {
                CalcularIntegrantes();
            }


           // integrantesNumericUpDown.Value = cant / grp;
        }

        //para calcular cantidad de integrantes pero despues de guardar
        private int CalcularIntegrantes()
        {
            int integrantes, cant = Convert.ToInt32(cantidadNumericUpDown.Value), grp = Convert.ToInt32(grupoNumericUpDown.Value);
                        
           integrantesNumericUpDown.Value = cant / grp;
            integrantes = Convert.ToInt32(integrantesNumericUpDown.Value);

            return integrantes;
        }

        private void integrantesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            //int cant = Convert.ToInt32(cantidadNumericUpDown.Value), grp = Convert.ToInt32(grupoNumericUpDown.Value);
            //integrantesNumericUpDown.Value = cant / grp;
        }

        private void rRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void integrantesNumericUpDown_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
