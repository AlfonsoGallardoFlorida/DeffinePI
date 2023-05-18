using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIDeffine.RecursosLocalizables;
using System.Threading;
using System.Globalization;
using System.Net.Mail;
using System.Configuration;
using System.Web;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

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

        private void AplicarIdioma()
        {
            lblAyuda.Text = StringRecursos.Ayuda;
            lblContra.Text = StringRecursos.Contra;
            lblContraOlvidada.Text = StringRecursos.ContraOlvidada;
            lblcorreoayuda.Text = StringRecursos.correoAyuda;
            lblCuenta.Text = StringRecursos.Cuenta;
            lbliniciosesion.Text = StringRecursos.InicioSesion;
            lblnuftno.Text = StringRecursos.numTelefono;
            lblRegistrarse.Text = StringRecursos.Registrarse;
            lblIdioma.Text = StringRecursos.Idioma;
        }

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
            string correo = txtCorreo.Text;
            string contraseña = txtContra.Text;
            if (correo != "")
            {
                if (Cliente.ComprobarExistencia(correo))
                {
                    if (Cliente.ComprobarClave(correo, contraseña))
                    {
                        FrmTienda tienda = new FrmTienda();
                        tienda.Show();
                        this.Hide();
                        Cliente.clienteLogeado(correo);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El correo indicado no está registrado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Inserta el campo correo electronico","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void IdiomaIngles()
        {
            string cultura = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }
        private void IdiomaSpanish()
        {
            string cultura = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();

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
            Application.Exit();
        }

        private void lblContraOlvidada_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            if (correo != "")
            {
                if (Cliente.ComprobarExistencia(correo))
                {
                    DialogResult respuesta = MessageBox.Show("¿Deseas recibir un correo de recuperacion de contraseña a esta direccion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.Yes)
                    {
                        try
                        {
                            string contraseña = Cliente.DevolverClave(correo);
                            MailMessage email = new MailMessage();
                            email.To.Add(new MailAddress(correo));
                            email.From = new MailAddress("deffinepi@gmail.com");
                            email.Subject = "Recuperacion de contraseña (" + DateTime.Now.ToString("dd / MM / yyy hh:mm:ss") + " )";
                            email.Body = ("Has solicitado la recuperacion de la contraseña, si no es asi informalo a nuestro equipo\n Tu contraseña es: " + contraseña);
                            email.IsBodyHtml = true;
                            email.Priority = MailPriority.Normal;

                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.EnableSsl = true;
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("deffinepi@gmail.com", "kzjiwbnktbhwtmww");


                            smtp.Send(email);
                            email.Dispose();
                            MessageBox.Show("Comprueba tu buzon de entrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al mandar el correo: " + ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El correo indicado no existe en la base de datos, asegurate de estar registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellena el campo de correo con el correo electronico del que deseas recuperar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelAyuda_Click(object sender, EventArgs e)
        {
            FrmDisenyo frm = new FrmDisenyo();
            frm.Show();
            this.Hide();
        }

        private void lblAyuda_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.Show();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
