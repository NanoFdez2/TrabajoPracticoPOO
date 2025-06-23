using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void CargarCombo<T>(ComboBox combo, List<T> datos, string displayMember = null, string valueMember = null)
        {
            if (combo == null) return;

            combo.DataSource = datos;

            if (!string.IsNullOrEmpty(displayMember))
                combo.DisplayMember = displayMember;

            if (!string.IsNullOrEmpty(valueMember))
                combo.ValueMember = valueMember;
        }
    }
}
