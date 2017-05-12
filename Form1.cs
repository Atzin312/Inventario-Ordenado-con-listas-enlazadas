using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Inventario
{
    public partial class Form1 : Form
    {

        Inventario inventario;

        public Form1()
        {
            InitializeComponent();
            Inventario inventario = new Inventario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inventario.Agregar(producto);
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            if (inventario.Buscar(codigo) != null)
            {
                txtReporte.Text = inventario.Buscar(codigo).nombre;
            }
            else
            {
                txtReporte.Clear();
            }
        }

        
        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.Reporte();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.Eliminar(Convert.ToInt32(txtCodigo.Text));
        }
    }
}
