using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class SUBMENU10 : Form
    {
        public SUBMENU10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblIngreso.Text, out double gall_liq))
            {
                if (gall_liq < 0)
                {
                    MessageBox.Show("La cantidad de gallon (liquid) no puede ser negativa.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblRespuesta.Text = "Error";
                    return;
                }

                double L = gall_liq * 3.78541;

                lblRespuesta.Text = string.Format("{0:F3} L", L);
                lblIngreso.SelectAll();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para gallon (liquid).", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRespuesta.Text = "Error";
                lblIngreso.Focus();
                lblIngreso.SelectAll();
            }
        }
    }
}
