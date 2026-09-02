using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP03
{
    public partial class ingresoRepuestos : Form
    {
        public struct Repuestos
        {
            public char Marca;
            public char Origen;
            public int Numero;
            public string Descripcion;
            public float Precio;
        }

        Repuestos[] inventario = new Repuestos[100];
        int cantidad = 0;
        public ingresoRepuestos()
        {
            InitializeComponent();
        }

        private void btnIngresarRepuesto_Click(object sender, EventArgs e)
        {
            if (cantidad >= 100)
            {
                MessageBox.Show("Se ha alcanzado el maximo de 100 repuestos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbBoxMarcas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbBoxOrigenDeRepuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Origen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtBoxNumeroDeRepuestos.Text.Trim(), out int numero) || numero <= 0)
            {
                MessageBox.Show("El numero de repuesto debe ser numero y mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string descripcion = txtboxDescripcion.Text.Trim();
            if(string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!float.TryParse(txtBoxPrecio.Text.Trim(), out float precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Repuestos nuevo;
            nuevo.Marca = cmbBoxMarcas.SelectedItem.ToString()[0];
            nuevo.Origen = cmbBoxOrigenDeRepuesto.SelectedItem.ToString()[0];
            nuevo.Numero = numero;
            nuevo.Descripcion = descripcion;
            nuevo.Precio = precio;

            inventario[cantidad] = nuevo;
            cantidad++;

            MessageBox.Show("Repuesto registrado con exito","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBoxNumeroDeRepuestos.Clear();
            txtboxDescripcion.Clear();
            txtBoxPrecio.Clear();
            cmbBoxMarcas.SelectedIndex = -1;
            cmbBoxOrigenDeRepuesto.SelectedIndex = -1;

        }

        private void btnConsultarRepuestos_Click(object sender, EventArgs e)
        {
            lstBoxConsulta.Items.Clear();
            if(cmbBoxFiltrarMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una marca para realizar la búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char marcaBuscada = cmbBoxFiltrarMarca.SelectedItem.ToString()[0];
            if(!rbtnNacional.Checked && !rbtnImportado.Checked)
            {
                MessageBox.Show("Seleccione el origen a consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            char origenBuscado = rbtnNacional.Checked ? 'N' : 'I';
            
            int encontrados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                if (inventario[i].Marca == marcaBuscada && inventario[i].Origen  == origenBuscado)
                {
                    lstBoxConsulta.Items.Add(string.Format("N°: {0} - Desc: {1} - Precio: ${2}",
                        inventario[i].Numero,
                        inventario[i].Descripcion,
                        inventario[i].Precio));
                    encontrados++;
                }
            }
        }
    }
}
