using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtrado_Glomerular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            double dceResultado;
            double scr = double.Parse(creatininaTxt.Text);
            int edad = int.Parse(edadTxt.Text);
            double k;
            double alpha;
            string estadio = "";
            double relacioAC = double.Parse(relacionACTxt.Text);
            string kDigo = "";

            // cálculo fórmula CKD-EPI
            if (sexoHombreRadioButton.Checked == true)
            {
                k = 0.9;
                alpha = -0.411;
                dceResultado = 141 * Math.Pow((minimo(scr / k, 1)), alpha) * Math.Pow(maximo(scr / k, 1), -1.209) * Math.Pow(0.993, edad);
            }
            else
            {
                k = 0.7;
                alpha = -0.329;
                dceResultado = 141 * Math.Pow((minimo(scr / k, 1)), alpha) * Math.Pow(maximo(scr / k, 1), -1.209) * Math.Pow(0.993, edad) * 1.018;
            }
            if (razaNegraCheckBox.Checked == true)
            {
                dceResultado = dceResultado * 1.159;
            }

            if (dceResultado > 90)
            {
                estadio = "Estadío 1";
            }
            if (dceResultado > 60 && dceResultado <= 90)
            {
                estadio = "Estadío 2";
            }
            if (dceResultado > 45 && dceResultado <= 60)
            {
                estadio = "Estadío 3A";
            }
            if (dceResultado > 30 && dceResultado <= 45)
            {
                estadio = "Estadío 3B";
            }
            if (dceResultado >= 15 && dceResultado <= 30)
            {
                estadio = "Estadío 4";
            }
            if (dceResultado < 15)
            {
                estadio = "Estadío 5";
            }


            if (relacioAC > 300)
            {
                kDigo = "A3 KDIGO";
            }
            if (relacioAC >= 30 && relacioAC <= 300)
            {
                kDigo = "A2 KDIGO";
            }
            if (relacioAC < 30 && relacioAC > 0)
            {
                kDigo = "A1 KDIGO";
            } 
            if(relacioAC == 0)
            {
                kDigo = "Sin reporte de micro albuminuria";
            }

            dceResultado = Math.Round(dceResultado, 2);
            String CKDEPIresultado = "CKD-EPI: TFG: " + dceResultado.ToString()+ " ml/min " + estadio + " " + kDigo;


            // cálculo fórmula Cockroft-Gault
            double dceResultadoCG;
            double peso = double.Parse(pesoTxt.Text);
            String estadioCG = "";

            dceResultadoCG = ((140 - edad) * peso) / (72 * scr);

            if (sexoMujerRadioButton.Checked == true)
            {
                dceResultadoCG = dceResultadoCG * 0.85;
            }

            if (dceResultadoCG > 90)
            {
                estadioCG = "Estadío 1";
            }
            if (dceResultadoCG > 60 && dceResultadoCG <= 90)
            {
                estadioCG = "Estadío 2";
            }
            if (dceResultadoCG > 45 && dceResultadoCG <= 60)
            {
                estadioCG = "Estadío 3A";
            }
            if (dceResultadoCG > 30 && dceResultadoCG <= 45)
            {
                estadioCG = "Estadío 3B";
            }
            if (dceResultadoCG >= 15 && dceResultadoCG <= 30)
            {
                estadioCG = "Estadío 4";
            }
            if (dceResultadoCG < 15)
            {
                estadioCG = "Estadío 5";
            }

            dceResultadoCG = Math.Round(dceResultadoCG, 2);
            String CockroftGaultResultado = "  -  Cockroft-Gault: TFG: " + dceResultadoCG.ToString() + " ml/min " + estadioCG + " " + kDigo;
            
            // envejecimiento renal

            int envejecimiento = 130 - edad;

            resultadoTxt.Text = CKDEPIresultado + CockroftGaultResultado + " - Envejecimiento renal: " + envejecimiento.ToString() + " ml/min";
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            edadTxt.ResetText();
            pesoTxt.ResetText();
            creatininaTxt.ResetText();
            relacionACTxt.ResetText();
            razaNegraCheckBox.Checked = false;
            resultadoTxt.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double minimo(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        double maximo(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultadoTxt.Text);
        }
    }
}
