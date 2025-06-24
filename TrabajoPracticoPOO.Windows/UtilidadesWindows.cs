using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPOO.Entidades;

namespace TrabajoPracticoPOO.Utilidades
{
    public static class UtilidadesWindows
    {
        public static void CargarGrid<T>(DataGridView grid, List<T> datos)
        {
            if (grid == null) return;
            grid.DataSource = null;
            grid.DataSource = datos;
        }
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            return (DataGridViewRow)grid.RowTemplate.Clone();
        }

        public static void AgregarFila(DataGridView grid, DataGridViewRow fila)
        {
            if (grid == null || fila == null) return;
            grid.Rows.Add(fila);
        }

        public static void EliminarFila(DataGridView grid, int index)
        {
            if (index >= 0 && index < grid.Rows.Count)
                grid.Rows.RemoveAt(index);
        }

        public static void CargarCombo<T>(ComboBox combo, List<T> datos, string displayMember = null, string valueMember = null)
        {
            if (combo == null) return;

            if (typeof(T) == typeof(string))
            {
                combo.DataSource = datos;
            }
            else
            {
                combo.DataSource = datos;

                if (!string.IsNullOrEmpty(displayMember))
                    combo.DisplayMember = displayMember;

                if (!string.IsNullOrEmpty(valueMember))
                    combo.ValueMember = valueMember;
            }
        }
        public static void SetearFila(DataGridViewRow r, Cliente? cliente)
        {
            r.Cells[0].Value = cliente.ToString();
            r.Cells[1].Value = cliente.DNI;
            r.Cells[2].Value = cliente.GetType().Name;
            r.Cells[3].Value = cliente.localidad.ToString();
            r.Cells[4].Value = cliente.fechaAlta.ToShortDateString();
            r.Tag = cliente;
        }

    }
}
