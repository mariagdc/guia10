using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region dominio
        int bici = 0, moto = 0, tpublico = 0, auto = 0;
        double promediobici, promediomoto;

        int CantidadDePoblacion()
        {
            return bici + moto + tpublico + auto;
        }
        #endregion
        double Promediobicis()
        {
            return acumdistbici / bici;
        }

        double Promediomotos()
        {
            return acumdistmoto / moto;
        }


        private void btnResultados_Click(object sender, EventArgs e)
        {
            lbResultados.Items.Clear();

            int poblacion = CantidadDePoblacion();
            double pbici =Promediobicis();
            double pmoto = Promediomotos();
            lbResultados.Items.Add($"Población: {poblacion}, Bici {bici}, Moto {moto}, Auto {auto}, Transporte Publico {tpublico}");
            lbResultados.Items.Add($"Promedio Bicis: {pbici}");
            lbResultados.Items.Add($"Promedio motos: {pmoto}");
        }

        double acumdistbici = 0, acumdistmoto = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            double distancia=Convert.ToDouble(tbdistancia.Text);

            if (rbBicicleta.Checked == true)
            {
                bici++;
                acumdistbici  += distancia;
            }
            else if (rbMotos.Checked == true)
            {
                moto++;
                acumdistmoto += distancia;
            }
            else if (rbAuto.Checked == true)
            {
                auto++;
            }
            else if (rbPublico.Checked == true)
            {
                tpublico++;
            }


            rbBicicleta.Checked = false;
            rbMotos.Checked = false;
            rbAuto.Checked = false;
            rbPublico.Checked = false;
            tbdistancia.Clear();
        }

       
        

       

    
    }
}
