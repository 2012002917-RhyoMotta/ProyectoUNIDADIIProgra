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
    public partial class SUBMENU12 : Form
    {
        public SUBMENU12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblIngreso.Text, out double L))
            {
                if (L < 0)
                {
                    MessageBox.Show("La cantidad de litros no puede ser negativa.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblRespuesta.Text = "Error";
                    return;
                }

                double yd3 = L / 764.554858;

                lblRespuesta.Text = string.Format("{0:F4} yd³", yd3);
                lblIngreso.SelectAll();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para litros.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRespuesta.Text = "Error";
                lblIngreso.Focus();
                lblIngreso.SelectAll();
            }
        }
    }
}
