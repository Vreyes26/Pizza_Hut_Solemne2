using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Hut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void _iniciodesession_Click(object sender, EventArgs e)
        {
            var nombre = _txtCuenta.Text;
            var contraseña = _txtPass.Text;
            
            if(nombre != "CajeroAdm" && contraseña != "HnmX2020!")
            {
                MessageBox.Show("Datos incorrectos.");
                _txtCuenta.Clear();
                _txtPass.Clear();
            }
            else
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            
            
        }
    }
}
