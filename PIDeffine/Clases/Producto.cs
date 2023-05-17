using PIDeffine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data.SqlClient;

namespace PIDeffine
{
    internal class Producto
    {
        int idProducto;
        string descripcion;
        string talla;
        string genero;
        string color;
        decimal precio;
        int stock;
        byte[] imagen;
        public int IdProducto { get {return idProducto; }}
        public string Descripcion { get { return descripcion; } }
        public string Talla { get { return talla; } }
        public string Genero { get { return genero; } }
        public string Color { get { return color; } }
        public decimal Precio { get { return precio; } }
        public int Stock { get { return stock; } }
        public byte[] Imagen { get { return imagen; } set { imagen = value; } }

        public Producto(string desc, string tall, string gen, string col, decimal prec, int sto, byte[] img)
        {
            descripcion = desc;
            talla = tall;
            genero = gen;
            color = col;
            precio = prec;
            stock = sto;
            imagen = img;
        }

        public Producto()
        {
        }

        //public static List<Producto> ListarProductos()
        //{
        //    ConBD.AbrirConexion();
        //    List<Producto> lista = new List<Producto>();
        //    string consulta = String.Format("SELECT * FROM Productos");
        //    MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Producto product = new Producto(reader.GetInt32("idProducto"), reader.GetString("Descripcion"), reader.GetString("Talla"), reader.GetString("Genero"), reader.GetString("Color"), reader.GetDecimal("Precio"), reader.GetInt32("Stock"), reader.GetByte("Imagen"));
        //        lista.Add(product);
        //    }
        //    reader.Close();
        //    ConBD.CerrarConexion();
        //    return lista;
        //}
        public void CargarImagen()
        {
            try
            {
                using (MySqlConnection connection = ConBD.Conexion)
                {
                    connection.Open();

                    string query = "SELECT Imagen FROM Productos WHERE idProducto = @ID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", idProducto);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    Imagen = (byte[])reader["Imagen"];
                                }
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen: " + ex.Message);
            }
        }
        public static void AgregarProducto(string descripcion, string talla, string genero, string color, decimal precio, int stock, byte[] imagen)
        {
            ConBD.AbrirConexion();
            Producto nuevoProducto = new Producto(descripcion, talla, genero, color, precio, stock, imagen);
            string consulta = String.Format("INSERT INTO Productos (Descripcion, Talla, Genero, Color, Precio, Stock, Imagen) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}, '{6}'", descripcion, talla, genero, color, precio, stock, imagen);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            ConBD.CerrarConexion();
        }

        public static void BorrarProducto(int idProducto)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("DETELE FROM Productos WHERE IdProducto = '{0}'", idProducto);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            ConBD.CerrarConexion();
        }

        public static bool ComprobarStock(int idProducto, string talla)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT stock FROM Productos WHERE idProducto = '{0}' AND Talla = '{1}'", idProducto, talla);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                ConBD.CerrarConexion();
                return true;
            }
            else
            {
                reader.Close();
                ConBD.CerrarConexion();
                return false;
            }
        }

        public static decimal ComprobarPrecio(int idProducto)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT precio FROM Productos WHERE idProducto = '{0}'", idProducto);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            decimal precioProducto = 0;
            if (reader.Read())
            {
                precioProducto = reader.GetDecimal(0);
            }

            reader.Close();
            return precioProducto;
        }

        public static void ComprobarClaveValida(string clave)
        {

        }
        public static List<Producto> CargarProductos(string consulta)
        {
            List<Producto> productos = new List<Producto>();
            ConBD.AbrirConexion();
            // Aquí se ejecutaría el código para obtener los productos de la base de datos
            // y cargarlos en la lista 'productos'

            // Ejemplo ficticio de obtención de productos desde la base de datos
            // Supongamos que se utiliza un objeto 'command' para ejecutar una consulta SQL
            MySqlCommand command = new MySqlCommand(consulta,ConBD.Conexion);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("IdProducto");
                    string descripcion = (string)reader["Descripcion"];
                    string talla = (string)reader["Talla"];
                    string genero = (string)reader["Genero"];
                    string color = (string)reader["Color"];
                    decimal precio = (decimal)reader["Precio"];
                    int stock = (int)reader["Stock"];
                    byte[] imagen = (byte[])reader["Imagen"];

                    Producto producto = new Producto(descripcion, talla, genero, color, precio, stock, imagen);
                    productos.Add(producto);
                }
            }
            ConBD.CerrarConexion();
            return productos;
        }
    }
}
