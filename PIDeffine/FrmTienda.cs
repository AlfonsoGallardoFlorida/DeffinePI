using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using PIDeffine.RecursosLocalizables;

namespace PIDeffine
{
    public partial class FrmTienda : Form
    {
        private List<Producto> productos;
        private List<PictureBox> listaPictureBoxes;
        public FrmTienda()
        {
            InitializeComponent();
            productos = new List<Producto>();
            listaPictureBoxes = new List<PictureBox>();
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private bool maximizar = true;

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Productos";
            CargarProductos(consulta);
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private void AplicarIdioma()
        {
            lblColecciones.Text = StringRecursos.Colecciones;
            lblContacta.Text = StringRecursos.Contacta;
            lblFiltrarRopa.Text = StringRecursos.FiltrarRopa;
            lblIdioma.Text = StringRecursos.Idioma;
            lblMaximo.Text = StringRecursos.Maximo;
            lblMinimo.Text = StringRecursos.Minimo;
            lblTalla.Text = StringRecursos.Talla;
            lblPrecio.Text = StringRecursos.Precio;
            rdbCamisetas.Text = StringRecursos.Camiseta;
            bttDesign.Text = StringRecursos.Diseño;
            bttFiltrar.Text = StringRecursos.Filtrar;
            rdbPantalones.Text = StringRecursos.Pantalones;
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
            string talla = cmbTalla.Text;
            decimal precioMin = nudMin.Value;
            decimal precioMax = nudMax.Value;
            string coleccion = "";
            string consulta;
            if (rdbCamisetas.Checked) coleccion = "Camiseta";
            else if (rdbPantalones.Checked) coleccion = "Pantalon";
            else if (rdTodo.Checked) coleccion = "";

            if (precioMin <= precioMax)
            {
                consulta = String.Format("SELECT * FROM Productos WHERE Precio >= '{0}' && Precio <= '{1}'", precioMin, precioMax);
                if (talla != "")
                {
                    consulta += String.Format(" && Talla LIKE '{0}'", talla);
                }
                if (coleccion != "")
                {
                    consulta += String.Format(" && Descripcion LIKE '%{0}%'", coleccion);
                }

                CargarProductos(consulta);
            }
            else
            {
                MessageBox.Show("Introduce bien el rango de precios");
            }
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
        private void CargarProductos(string consulta)
        {
            productos = Producto.CargarProductos(consulta); // Utilizar la variable de instancia productos
            panelPrinc.Controls.Clear(); // Limpiar el contenido actual del panel

            int rowIndex = 0;
            int columnIndex = 0;
            int maxColumns = 3;
            int itemWidth = 208;
            int itemHeight = 248;
            int spacingX = 10;
            int spacingY = 10;

            for (int i = 0; i < productos.Count; i++)
            {
                int idProducto = productos[i].IdProducto;
                string descripcion = productos[i].Descripcion;
                byte[] imagenBytes = productos[i].Imagen;

                // Crear el control de imagen
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(itemWidth, itemHeight);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = ByteArrayToImage(imagenBytes);
                pictureBox.Click += PictureBox_Click;
                listaPictureBoxes.Add(pictureBox);

                // Agregar borde a la imagen
                pictureBox.BorderStyle = BorderStyle.FixedSingle;

                // Asignar eventos MouseEnter y MouseLeave
                pictureBox.MouseEnter += (sender, e) =>
                {
                    pictureBox.BackColor = Color.FromArgb(168, 168, 168);
                };

                pictureBox.MouseLeave += (sender, e) =>
                {
                    pictureBox.BackColor = Color.FromArgb(41, 41, 41);
                };

                // Calcular la posición de la imagen
                int x = columnIndex * (itemWidth + spacingX);
                int y = rowIndex * (itemHeight + spacingY);

                // Establecer la posición de la imagen
                pictureBox.Location = new Point(x, y);

                // Agregar la imagen al panel
                panelPrinc.Controls.Add(pictureBox);

                // Calcular la siguiente posición
                columnIndex++;
                if (columnIndex >= maxColumns)
                {
                    columnIndex = 0;
                    rowIndex++;
                }
            }




        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void MostrarProductos()
        {
            foreach (Producto producto in productos)
            {
                // Create a PictureBox to display the image
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromStream(new System.IO.MemoryStream(producto.Imagen));

                // Create a Label to display the product name
                Label label = new Label();
                label.Text = producto.Descripcion;
                label.TextAlign = ContentAlignment.MiddleCenter;

                // Create a FlowLayoutPanel to hold the PictureBox and Label
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Width = 120;
                panel.Height = 160;
                panel.Margin = new Padding(10);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.WrapContents = false;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);

                // Add the panel to the main FlowLayoutPanel
                panelPrinc.Controls.Add(panel);
            }
        }

        private void bttDesign_Click(object sender, EventArgs e)
        {
            FrmDisenyo frmDisenyo = new FrmDisenyo();
            frmDisenyo.Show();
            this.Close();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            List<Producto> productos = Producto.CargarProductos("SELECT * FROM Productos");
            PictureBox pictureBox = (PictureBox)sender;
            Producto producto = ObtenerProductoDesdePictureBox(pictureBox);

            // Crear instancia del formulario FrmPedido
            FrmPedido frmPedido = new FrmPedido();

            // Asignar los valores del producto al formulario FrmPedido
            frmPedido.NombreProducto = producto.Descripcion;
            frmPedido.PrecioProducto = producto.Precio;
            frmPedido.ImagenProducto = producto.Imagen;

            // Cerrar el formulario FrmTienda
            this.Close();

            // Mostrar el formulario FrmPedido
            frmPedido.Show();
        }

        private void pcbCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.Show();
            this.Close();
        }

        private Producto ObtenerProductoDesdePictureBox(PictureBox pictureBox)
        {
            int indicePictureBox = listaPictureBoxes.IndexOf(pictureBox);
            if (indicePictureBox != -1 && indicePictureBox < productos.Count)
            {
                return productos[indicePictureBox];
            }
            return null;
        }
    }
}

