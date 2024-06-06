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
        int bici = 0, moto = 0, tpublico = 0, auto = 0, cantencuestados=0;
        double promediobici, promediomoto, distancia;
        double acumdisttotal = 0, acumdistbici = 0, acumdistmoto = 0;

        private void rbPublico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPublico.Checked)
            {
                tpublico++;
            }
        }

        private void tbdistancia_TextChanged(object sender, EventArgs e)
        {
            distancia = Convert.ToDouble(tbdistancia.Text);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cantencuestados++;

            if (rbBicicleta.Checked == true)
            {
                acumdistbici = acumdistbici + distancia;
            }
            else if (rbMotos.Checked == true)
            {
                acumdistmoto = acumdistmoto + distancia;
            }

            promediobici = acumdistbici / bici;
            promediomoto = acumdistmoto / moto;
            
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                auto++;
            }
        }

        private void rbMotos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMotos.Checked)
            {
                moto++;
            }
        }

       
        public Form1()
        {
            InitializeComponent();
        }

        private void lbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbBicicleta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBicicleta.Checked)
            {
                bici++;
            }
        }
    }
}
