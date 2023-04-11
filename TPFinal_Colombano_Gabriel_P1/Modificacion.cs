using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal_Colombano_Gabriel_P1
{
    public partial class FormModifica : Form
    {
        public string datoAnterior;
        public string datoModificado { get; private set; }


        public FormModifica(string datoAnterior)
        {
            InitializeComponent();
            this.datoAnterior = datoAnterior;
            txtDatoAnterior.Text = datoAnterior;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string datoModificado = txtDatoNuevo.Text;
            this.datoModificado = datoModificado;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
