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
    public partial class FrmPedido : Form
    {
        //string consulta = String.Format("SELECT IdCliente FROM Clientes WHERE Correo='{0}'", )  
       // Pedido pedido = new Pedido();

        public FrmPedido()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }

        public FrmPedido(string productName, decimal productPrice, Image productImage)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productImage = productImage;
        }
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public byte[] ImagenProducto { get; set; }

        public FrmPedido(string descripcion, decimal precio, byte[] imagen)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.imagen = imagen;
        }

        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private string productName;
        private decimal productPrice;
        private Image productImage;
        private string descripcion;
        private decimal precio;
        private byte[] imagen;

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            if (ImagenProducto != null)
            {
                using (MemoryStream ms = new MemoryStream(ImagenProducto))
                {
                    productImage = Image.FromStream(ms);
                }
                pcbProd1.Image = productImage;
            }
            lblNomProd.Text = NombreProducto;
            lblPrecioProducto.Text = Convert.ToString(PrecioProducto);

        }

        private void lblVerGuia_Click(object sender, EventArgs e)
        {
            FrmGuiaDeTallas frmguiadetallas = new FrmGuiaDeTallas();
            frmguiadetallas.Show();
        }

        private void bttAnyadir_Click(object sender, EventArgs e)
        {
            //ConBD.AbrirConexion();
           // string consulta = String.Format("INSERT INTO Detalle_Pedido (IdPedido, IdProducto, Cantidad, Subtotal) VALUES ('{0}', '{1}', '{2}', '{3}')", );
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
        private void lblTallas_Click(object sender, EventArgs e)
        {

        }

        private void lblContacta_MouseEnter(object sender, EventArgs e)
        {
            lblContacta.ForeColor = Color.Aqua;
        }

        private void lblContacta_MouseLeave(object sender, EventArgs e)
        {
            lblContacta.ForeColor = Color.White;

        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void pcbCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmcarrito = new FrmCarrito();
            frmcarrito.Show();
            this.Close();
        }

        private void lblContacta_Click(object sender, EventArgs e)
        {
   
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }
        }
    }
}
