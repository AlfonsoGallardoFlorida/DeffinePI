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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private bool maximizar = true;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lbliniciosesion_MouseHover(object sender, EventArgs e)
        {
            lbliniciosesion.ForeColor = Color.Aqua;
        }

        private void lbliniciosesion_MouseLeave(object sender, EventArgs e)
        {
            lbliniciosesion.ForeColor = Color.White;
        }

        private void lblRegistrarse_MouseHover(object sender, EventArgs e)
        {
            lblRegistrarse.ForeColor = Color.Aqua;
        }

        private void lblRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrarse.ForeColor = Color.White;
        }

        private void lblContraOlvidada_MouseHover(object sender, EventArgs e)
        {
            lblContraOlvidada.ForeColor = Color.Aqua;
        }

        private void lblContraOlvidada_MouseLeave(object sender, EventArgs e)
        {
            lblContraOlvidada.ForeColor = Color.White;
        }

        private void lblcorreoayuda_MouseHover(object sender, EventArgs e)
        {
            lblcorreoayuda.ForeColor = Color.Aqua;
        }

        private void lblcorreoayuda_MouseLeave(object sender, EventArgs e)
        {
            lblcorreoayuda.ForeColor = Color.White;
        }

        private void lblcorreoayuda_Click(object sender, EventArgs e)
        {
            if (lblIdioma.Text == "Language")
            {
                DialogResult help = MessageBox.Show("Do you want to send a help e-mail?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (help == DialogResult.Yes)
                {
                    MessageBox.Show("Send an e-mail to: 'deffineyourstyle@info.com'.", "Help E-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                DialogResult ayuda = MessageBox.Show("¿Desea enviar un correo eléctronico de ayuda?", "Ayuda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ayuda == DialogResult.Yes)
                {
                    MessageBox.Show("Envíe un correo electronico a: 'deffineyourstyle@info.com'.", "Correo de Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lbliniciosesion_Click(object sender, EventArgs e)
        {
            /*
             * IF USUARIO NO EXISTE
             * {
             * DialogResult crearNuevo = MessageBox.Show("No existe una cuenta con el correo proporcionado\n¿Desea crear una cuenta nueva?","Correo Inexistente",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
             * if(crearNuevo == DialogResult.Yes) ABRIR FORMULARIO DE REGISTRO
             * }
             * else ClearAll();
             * IF USUARIO EXISTE
             * {
             * ABRIR FORMULARIO DE LA TIENDA
             * }
             */
        }

        private void IdiomaIngles()
        {
            lblContra.Text = "Password";
            lblLogIn.Show();
            lbliniciosesion.Hide();
            lblContraOlvidada.Text = "Have you forgot the password? ";
            lblCuenta.Text = "Don't have an account?";
            lblAyuda.Text = "DO YOU NEED HELP?";
            lblnuftno.Text = "Phone Number +34 *********";
            lblcorreoayuda.Text = "Send us an e-mail";
            lblIdioma.Text = "Language";
        }
        private void IdiomaSpanish()
        {
            lblContra.Text = "Contraseña";
            lblLogIn.Hide();
            lbliniciosesion.Show();
            lblContraOlvidada.Text = "¿Has olvidado tu contraseña? ";
            lblCuenta.Text = "¿No tienes cuenta?";
            lblAyuda.Text = "¿NECESITAS AYUDA?";
            lblnuftno.Text = "Número de Teléfono +34 *********";
            lblcorreoayuda.Text = "Envíanos un correo electrónico";
            lblIdioma.Text = "Idioma";

        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro form = new FrmRegistro();
            form.Show();
            this.Hide();
        }

        private void pcbspain_Click(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }

        private void pcbingle_Click(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();
        }

        private void pcbOjoCerrado_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado.Hide();
            pcbOjoAbierto.Show();
            txtContra.PasswordChar = '●';

        }

        private void pcbOjoAbierto_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto.Hide();
            pcbOjoCerrado.Show();
            txtContra.PasswordChar = '\0';
        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }
        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Estas seguro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    Form formulario = Application.OpenForms[i];

                    formulario.Close();
                    formulario.Dispose();
                }
            }
        }

        private void pcbMaximizar_Click(object sender, EventArgs e)
        {
            if (maximizar)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizar = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizar = true;
            }
        }

        private void lblLogIn_MouseHover(object sender, EventArgs e)
        {
            lblLogIn.ForeColor = Color.Aqua;

        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
