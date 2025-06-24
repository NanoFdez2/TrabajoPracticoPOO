using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPOO.Entidades;
using TrabajoPracticoPOO.Utilidades;

namespace TrabajoPracticoPOO.Windows
{
    public partial class frmGimnasioAE : Form
    {
        public Cliente? cliente;



        public frmGimnasioAE()
        {
            InitializeComponent();
            UtilidadesWindows.CargarCombo(localidadCbo, Enum.GetValues(typeof(Localidad)).Cast<Localidad>().ToList());

            UtilidadesWindows.CargarCombo(tipoClienteCbo, new List<string> { "SocioComun", "SocioPremium", "SocioCorporativo" });


        }

        public frmGimnasioAE(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CargarCliente(cliente);
        }



        public void CargarCliente(Cliente clienteExistente)
        {
            cliente = clienteExistente;

            txtNombre.Text = cliente.nombre;
            txtDNI.Text = cliente.DNI;
            localidadCbo.SelectedItem = cliente.localidad;
            tipoClienteCbo.SelectedItem = cliente.servicio;
            dtpFechaAlta.Value = cliente.fechaAlta;
            txtDNI.ReadOnly = true;
        }


        public Cliente GetCliente()
        {
            return cliente;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cliente == null)
                {
                    // Crear nuevo cliente
                    string nombre = txtNombre.Text.Trim();
                    string dni = txtDNI.Text.Trim();
                    DateTime fechaAlta = dtpFechaAlta.Value;
                    Localidad localidad = (Localidad)localidadCbo.SelectedItem;
                    string tipoSeleccionado = tipoClienteCbo.SelectedItem.ToString();
                    Servicio servicioAsignado = ObtenerServicioPorTipo(tipoSeleccionado);

                    switch (tipoSeleccionado)
                    {
                        case "SocioComun":
                            cliente = new SocioComun(nombre, dni, fechaAlta, localidad, servicioAsignado);
                            break;
                        case "SocioPremium":
                            cliente = new SocioPremium(nombre, dni, fechaAlta, localidad, servicioAsignado);
                            break;
                        case "SocioCorporativo":
                            cliente = new SocioCorporativo(nombre, dni, fechaAlta, localidad, servicioAsignado);
                            break;
                        default:
                            MessageBox.Show("Debe seleccionar un tipo de cliente válido.");
                            return;
                    }
                }
                else
                {
                    cliente.nombre = txtNombre.Text.Trim();
                    cliente.DNI = txtDNI.Text.Trim();
                    cliente.localidad = (Localidad)localidadCbo.SelectedItem;
                    cliente.servicio = ObtenerServicioPorTipo(tipoClienteCbo.SelectedItem.ToString());
                    cliente.fechaAlta = dtpFechaAlta.Value;
                }

                var context = new ValidationContext(cliente);
                var errores = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(cliente, context, errores, true);

                if (isValid)
                {
                    MessageBox.Show("Cliente guardado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(errores.First().ErrorMessage, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private Servicio ObtenerServicioPorTipo(string tipoCliente)
        {
            switch (tipoCliente)
            {
                case "SocioComun":
                    return Servicio.Gimnasio;
                case "SocioPremium":
                    return Servicio.GimnasioTrainer;
                case "SocioCorporativo":
                    return Servicio.GimnasioTrainerSpa;
                default:
                    throw new ArgumentException("Tipo de cliente no reconocido.");
            }
        }
        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDNI.Text.Trim(), @"^\d{8}$"))
            {
                esValido = false;
                errorProvider1.SetError(txtDNI, "El DNI debe tener exactamente 8 dígitos numéricos.");
            }

            if (localidadCbo.SelectedIndex == -1)
            {
                esValido = false;
                errorProvider1.SetError(localidadCbo, "Debe seleccionar una localidad.");
            }

            if (tipoClienteCbo.SelectedIndex == -1)
            {
                esValido = false;
                errorProvider1.SetError(tipoClienteCbo, "Debe seleccionar un tipo de cliente.");
            }

            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

