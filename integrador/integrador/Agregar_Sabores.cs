using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.Sqlite;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace integrador
{
    public partial class Agregar_Sabores : Form
    {
        FrmMain_Mostrar formInicio;
        Helado heladoEditar;
        public Agregar_Sabores(FrmMain_Mostrar form)
        {
            InitializeComponent();
            formInicio = form;
        }

        private void Agregar_Sabores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            formInicio.Show();
        }


        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text == "" || TxtDescrip.Text == "" || TxtPre.Text == "")
            {
                MessageBox.Show("Debe agregar datos.");
            }
            else { 
                Helado helado;

            string nomb = TxtNom.Text;
            string des = TxtDescrip.Text;
            int pre = int.Parse(TxtPre.Text);
            helado = new Helado(nomb, des, pre);
            helado.AgregarABaseDeDatos(formInicio.conexion);
            MessageBox.Show("Helado agregado correctamente.");
            formInicio.ActualizarListaHelado();
            formInicio.ActualizarDataGrid();
            }
        }
        public void MostrarAgregar()
        {
            TxtNom.Text = "";
            TxtDescrip.Text = "";
            TxtPre.Text = "";
            BtnAgregar.Visible = true;
            BtnAgregar.Enabled = true;
            BtnModif.Visible = false;
            BtnModif.Enabled = false;
            this.Show();
        }
        public void MostrarModificar(Helado heladoAModificar)
        {
            heladoEditar = heladoAModificar;
            TxtNom.Text = heladoEditar.Nombre;
            TxtDescrip.Text = heladoEditar.Descripcion;
            TxtPre.Text = heladoEditar.Precio.ToString();
            BtnAgregar.Visible = false;
            BtnAgregar.Enabled = false;
            BtnModif.Visible = true;
            BtnModif.Enabled = true;
            this.Show();
        }
        private void BtnModif_Click(object sender, EventArgs e)
        {
            heladoEditar.Nombre= TxtNom.Text;
            heladoEditar.Descripcion = TxtDescrip.Text;
            heladoEditar.Precio = int.Parse(TxtPre.Text.ToString());
            heladoEditar.EditarSabor(formInicio.conexion);
            
            MessageBox.Show("Helado editad correctamente.");
            formInicio.ActualizarListaHelado();
            formInicio.ActualizarDataGrid();
        }
    }
}
