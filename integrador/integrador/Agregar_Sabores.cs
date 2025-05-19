using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integrador
{
    public partial class Agregar_Sabores : Form
    {
        FrmMain_Mostrar forminicio;
        public Agregar_Sabores(FrmMain_Mostrar form)
        {
            InitializeComponent();
            forminicio = form;
        }

        private void Agregar_Sabores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            forminicio.Show();
        }
    }
}
