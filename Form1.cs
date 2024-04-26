using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double distanciaKM = double.Parse(txtdistancia.Text);
                double galonesconsumidos = double.Parse(txtgalones.Text);
                double rendimientoKMPorGalon = distanciaKM / galonesconsumidos;

                lblrendimiento.Text = $"Rendimiento: {rendimientoKMPorGalon:F2} km/galón";
                lblgalonesconsumidos.Text = $"Galones consumidos: {galonesconsumidos:F2}";
            }
            catch
            {
                MessageBox.Show("Ingresa valores numericos validos para la distancia y los galones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblrendimiento_Click(object sender, EventArgs e)
        {

        }

        private void txtdistancia_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
