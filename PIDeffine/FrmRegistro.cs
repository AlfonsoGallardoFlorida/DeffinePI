using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }
        private void pcbingle_Click(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();

        }

        private void pcbspain_Click(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }
        private void IdiomaIngles()
        {
            lblRegistro.Text = "SIGN IN";
            lblDatos.Text = "LOGIN DATA";
            lblCorreo.Text = "E-Mail";
            lblContra.Text = "Password";
            lblConfirmContra.Text = "Confirm Password";
            lblDatosPers.Text = "PERSONAL DATA";
            lblNombre.Text = "Name";
            lblPrimerApe.Text = "First Surname";
            lblSegundoApe.Text = "Second Surname ";
            lblRegistrarse.Text = "Sign in";
            lblIdioma.Text = "Language";
        }
        private void IdiomaSpanish()
        {
            lblRegistro.Text = "REGISTRARSE";
            lblDatos.Text = "DATOS DE ACCESO";
            lblCorreo.Text = "Correo Electrónico";
            lblContra.Text = "Contraseña";
            lblConfirmContra.Text = "Confirmar Contraseña";
            lblDatosPers.Text = "DATOS PERSONALES";
            lblNombre.Text = "Nombre";
            lblPrimerApe.Text = "Primer Apellido";
            lblSegundoApe.Text = "Segundo Apellido";
            lblRegistrarse.Text = "Registrarse";
            lblIdioma.Text = "Idioma";

        }

        private void pcbspain_Click_1(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }

        private void pcbingle_Click_1(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();
        }
    }
}
