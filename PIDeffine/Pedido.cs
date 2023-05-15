using PIDeffine;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace PIDeffine
{
    internal class Pedido
    {
        int idPedido;
        int idCliente;
        string direccion;
        decimal precioTotal;

        public Pedido(int idClie, string dir, decimal precioTot)
        {
            idCliente = idClie;
            direccion = dir;
            precioTotal = precioTot;
        }

        //public static List<Producto> Carrito(int idProduct)
        //{

        //}

        public static decimal ComprobarImporteTotal(int idProducto)
        {
            ConBD.AbrirConexion();
            string consulta = String.Format("SELECT precio FROM Productos WHERE idProducto = '{0}'", idProducto);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            ConBD.CerrarConexion();
            return 0;
        }
    }
}
