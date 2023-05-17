using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmTienda : Form
    {
        public FrmTienda()
        {
            InitializeComponent();
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private bool maximizar = true;
        private void FrmTienda_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form formulario = Application.OpenForms[i];

                formulario.Close();
                formulario.Dispose();
            }
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            // FUNCION QUE CIERRE SESION DE USUARIO

            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }
        }

        private void bttTallaPeque_Click(object sender, EventArgs e)
        {
            // INSERCION SQL MUESTRA LAS TALLAS ORDENADAS DE MAS PEQUEÑAS A MAS GRANDES
        }

        private void bttTallaGrande_Click(object sender, EventArgs e)
        {
            // INSERCION SQL MUESTRA LAS TALLAS ORDENADAS DE MAS GRANDES A MAS PEQUEÑAS

        }

        private void bttCamis_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE CAMISETAS
        }

        private void bttPants_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE PANTALONES

        }

        private void bttZapas_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE ZAPATILLAS

        }

        private void bttDiseño_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE EL PRODUCTO DE DISEÑAR TU CAMISETA

        }

        private void lblContacta_Click(object sender, EventArgs e)
        {
            if (lblIdioma.Text == "Language")
            {
                DialogResult help = MessageBox.Show("Do you want to send a help e-mail?", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (help == DialogResult.Yes)
                {
                    MessageBox.Show("Send an e-mail to: 'deffineyourstyle@info.com'.", "Help e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void FiltrarPrecio(double minPrecio, double maxPrecio)
        {
            if (minPrecio < maxPrecio)
            {
                // INSERCION SELECT PRODUCTOS WHERE PRECIO = minPrecio && PRECIO = MAXPRECIO no se hacer sql perdon(?)
            }
        }

        private void bttFiltrar_Click(object sender, EventArgs e)
        {
            // LLAMADA A LA FUNCION FILTRAR PRECIO Y QUE MUESTRE EN EL FORMULARIO PRODUCTOS QUE ESTEN ENTRE LOS PRECIOS INTRODUCIDOS
        }

        private void cmbTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DEPENDIENDO SI LA TALLA ES XS S M L XL O XXL MOSTRARA EN EL FORM LOS PRODUCTOS CON LA TALLA SELECCIONADA
        }

        private void pcbPerfil_Click(object sender, EventArgs e)
        {
            // ABRE EL FORMULARIO CON LA INFORMACIÓN DEL USUARIO
        }

        private void bttFiltrar_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void bttFiltrar_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pcbspain_Click(object sender, EventArgs e)
        {

        }

        private void pcbingle_Click(object sender, EventArgs e)
        {

        }
        private void pcbCamiBlanca_Click(object sender, EventArgs e)
        {
            FrmPedido frm = new FrmPedido();
            frm.Show();
            this.Hide();
        }

        private void pcbDisenyo_Click(object sender, EventArgs e)
        {
            FrmDisenyo frm = new FrmDisenyo();
            frm.Show();
            this.Hide();
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
        private void CargarProductos()
        {
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                List<Producto> productos = Producto.CargarProductos();

                if (productos != null && productos.Count > 0)
                {
                    int x = 10, y = 10;
                    int peliculaCount = 0;
                    int maxPeliculasPorFila = 5;
                    panelPrinc.Width = 698;
                    panelPrinc.Height = 531;
                    panelPrinc.Text = "";
                    this.Controls.Add(panelPrinc);
                    foreach (Producto producto in productos)
                    {
                        PictureBox imagen = new PictureBox();
                        imagen.Tag = producto.Descripcion;
                        imagen.Click += new EventHandler(pictureBox_Click);

                        imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagen.BorderStyle = BorderStyle.FixedSingle;
                        using (MemoryStream ms = new MemoryStream(producto.Imagen))
                        {
                            imagen.Image = Image.FromStream(ms);
                        }
                        imagen.Width = 208;
                        imagen.Height = 248;
                        imagen.Location = new Point(x, y);
                        panelPrinc.Controls.Add(imagen);
                        peliculaCount++;


                        if (peliculaCount % maxPeliculasPorFila == 0)
                        {
                            x = 10;
                            y = imagen.Bottom + 10;
                        }
                        else
                        {
                            x = imagen.Right + 10;
                        }
                    }
                    ConBD.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No existe conexión a la Base de datos");
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
