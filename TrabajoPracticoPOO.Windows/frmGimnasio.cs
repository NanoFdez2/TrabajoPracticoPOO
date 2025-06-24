using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPOO.Datos;
using TrabajoPracticoPOO.Entidades;
using TrabajoPracticoPOO.Utilidades;

namespace TrabajoPracticoPOO.Windows
{
    public partial class frmGimnasio : Form
    {
     
        private RepositorioClientesLinq? gestorLinq;
        private List<Cliente> clientes = new List<Cliente>();
        public frmGimnasio()
        {
            InitializeComponent();
            
            gestorLinq = new RepositorioClientesLinq();
            ActualizarGrilla();
        }
        //private void CargarClientes()
        //{
        //    UtilidadesWindows.CargarGrid(dgvDatos, clientes);  // Cargar la lista de clientes en el DataGridView
        //}

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmGimnasioAE frm = new frmGimnasioAE();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cliente nuevoCliente = frm.GetCliente();

                // ✅ Valido después de obtener el cliente desde el frmAE
                if (clientes.Any(c => c.DNI == nuevoCliente.DNI))
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clientes.Add(nuevoCliente);
                ActualizarGrilla(); // Refrescar la grilla
            }
        }

        private void ActualizarGrilla()
        {
            dgvDatos.Rows.Clear();


            var lista = gestorLinq.ListarTodos();

            foreach (var cliente in lista)
            {
                var r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, cliente);
                AgregarFila(r);

            }

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay clientes para mostrar.");
                return;
            }
           
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cliente? cliente)
        {
            r.Cells[0].Value = cliente.ToString();
            r.Cells[1].Value = cliente.DNI;
            r.Cells[2].Value = cliente.GetType().Name;
            r.Cells[3].Value = cliente.localidad.ToString();
            r.Cells[4].Value = cliente.fechaAlta.ToShortDateString();
            r.Tag = cliente;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            //if (dgvDatos.CurrentRow == null)
            //{
            //    MessageBox.Show("Elija una fila para borrar!");
            //    return;
            //}
            //string dni = dgvDatos.CurrentRow.Cells["colDNI"].Value.ToString()!;
            //string nombre = dgvDatos.CurrentRow.Cells["colNombre"].Value.ToString()!;

            //var resultado = MessageBox.Show(
            //    $"¿Seguro que desea borrar a {nombre}?",
            //    "Confirmar borrado",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning);

            //if (resultado == DialogResult.Yes)
            //{
            //    if (RepositorioClientesLinq.EliminarCliente(dni))
            //        ActualizarGrilla();
            //    else
            //        MessageBox.Show("Vehículo no encontrado.");
            //}
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
            MessageBox.Show("Lista actualizada!");
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona fila para editar.");
                return;
            }
            string dni = dgvDatos.CurrentRow.Cells["colDNI"].Value.ToString()!;

            var cliente = gestorLinq.ListarTodos().FirstOrDefault(p => p.DNI == dni);

            if (cliente == null)
            {
                MessageBox.Show("No hay cliente seleccionado");
                return;
            }


             frmGimnasioAE frm = new frmGimnasioAE();
            frm.CargarCliente(cliente);

            if (frm.ShowDialog() == DialogResult.OK)
            {

                ActualizarGrilla();
                MessageBox.Show("Datos actualizados correctamente.");
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }

        private void frmGimnasio_Load(object sender, EventArgs e)
        {


            gestorLinq = new RepositorioClientesLinq();
            ActualizarGrilla();

        }
    }
}
