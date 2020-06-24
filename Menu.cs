using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Hut
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            //MOSTRAMOS DATOS DE LA TABLA
            LinqClienteDataContext dataContext = new LinqClienteDataContext();
            var filtroProducto = from producto in dataContext.vistaProducto select producto;
            gvCliente.DataSource = filtroProducto;
        }

        private void ActualizarGvProductos(LinqClienteDataContext dataContext){
            var filtroProductos = from producto in dataContext.vistaProducto select producto;
            gvCliente.DataSource = filtroProductos;
        }

        private void _btAgregar_Click(object sender, EventArgs e)
        {
            string pizzaTamaño = "";
            int pizzaPrecio = 0;
            string agregado = "";
            int precioAgregado = 0;
            int total = 0;

            if(_rbFamiliar.Checked == true)
            {
                pizzaTamaño = "Pizza familiar";
                pizzaPrecio = 22000;
            }
            else if (_rbMediana.Checked == true)
            {
                pizzaTamaño = "Pizza mediana";
                pizzaPrecio = 12000;
            }
            else if (_rbIndividual.Checked == true)
            {
                pizzaTamaño = "Pizza individual";
                pizzaPrecio = 8000;
            }

            if (_rbBebidaFam.Checked == true)
            {
                agregado = "Bebida familiar";
                precioAgregado = 5000;
            }
            else if(_rbBebidaInd.Checked == true)
            {
                agregado = "Bebida individual";
                precioAgregado = 1500;
            }

            total = pizzaPrecio + precioAgregado;

            LinqClienteDataContext dataContext = new LinqClienteDataContext();

            Producto productos = new Producto();
            productos.nombre = pizzaTamaño;
            productos.precio = total;

            dataContext.Producto.InsertOnSubmit(productos);
            dataContext.SubmitChanges();

            ActualizarGvProductos(dataContext);
            _lbMontoTotal.Text = "$" + total;
        }

        private void _btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
