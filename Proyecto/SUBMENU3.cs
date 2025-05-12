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
    public partial class SUBMENU3 : Form
    {
        public SUBMENU3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblIngreso.Text, out double m3))
            {
                if (m3 < 0)
                {
                    MessageBox.Show("La cantidad de metros cúbicos no puede ser negativa.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblRespuesta.Text = "Error";
                    return;
                }

                double L = m3 * 1000.0;

                lblRespuesta.Text = string.Format("{0:F1} L", L);
                lblIngreso.SelectAll();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para metros cúbicos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRespuesta.Text = "Error";
                lblIngreso.Focus();
                lblIngreso.SelectAll();
            }
        }
    }
}
