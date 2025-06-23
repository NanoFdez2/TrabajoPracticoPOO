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

namespace TrabajoPracticoPOO.Windows
{
    public partial class frmGimnasio : Form
    {
        private RepositorioClientesOperadores? gestor;
        private RepositorioClientesLinq? gestorLinq;
        public frmGimnasio()
        {
            InitializeComponent();
            gestor = new RepositorioClientesOperadores();
            gestorLinq = new RepositorioClientesLinq();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmGimnasioAE frm = new frmGimnasioAE() { Text = "Agregar Cliente" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            Cliente cliente = frm.GetCliente();
            if (cliente == null)
            {
                var r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, cliente);
                AgregarFila(r);

            }
            else
            {
                MessageBox.Show("El cliente ya existe!!!");
            }

            ActualizarGrilla();

        }

        private void ActualizarGrilla()
        {
            dgvDatos.Rows.Clear();


            var lista = gestorLinq.ListarPersonal();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay clientes para mostrar.");
                return;
            }
            foreach (var cliente in lista)
            {
                var r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, cliente);
                AgregarFila(r);

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
            r.Cells[2].Value = cliente.fechaAlta.ToShortDateString();
            r.Cells[3].Value = cliente.localidad.ToString();
            r.Tag = cliente;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow == null)
            {
                MessageBox.Show("Elija una fila para borrar!");
                return;
            }
            string dni = dgvDatos.CurrentRow.Cells["colDNI"].Value.ToString()!;
            string nombre = dgvDatos.CurrentRow.Cells["colNombre"].Value.ToString()!;

            var resultado = MessageBox.Show(
                $"¿Seguro que desea borrar a {nombre}?",
                "Confirmar borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                var clienteABorrar = new SocioComun { DNI = dni };
                gestor = gestor - clienteABorrar;
                ActualizarGrilla();
                MessageBox.Show("Cliente eliminada!!!");
            }
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


            var frmEditar = new frmGimnasioAE();

            if (frmEditar.ShowDialog() == DialogResult.OK)
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
            //gestorLinq.AgregarCliente(new SocioPremium()
            //{
            //    nombre = "Gonzalo Martinez",
            //    DNI = "31442511",
            //    fechaAlta = DateTime.Today,
            //    localidad = Localidad.Catamarca,

            //});

            //ActualizarGrilla();

        }
    }
}
