using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeduccionesAsalariado
{
    public partial class Form1 : Form
    {

        List<float> límiteInferior = new List<float>();
        List<float> límiteSuperior = new List<float>();
        List<float> cuotaFija = new List<float>();
        List<float> excedente = new List<float>();
        public Form1()
        {
            InitializeComponent();
            ISR.Enabled = false;
            
        }

        private float ParseStringToFloat(string value)
        {
            float.TryParse(value, out float floatValue);
            return floatValue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\marco.antonio\\Documents";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = "Archivo leido";
                label1.BackColor = Color.Green;
                ISR.Enabled = true;

                using (var reader = new StreamReader(openFileDialog1.FileName))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split('-');
                        límiteInferior.Add(ParseStringToFloat(values[0]));
                        límiteSuperior.Add(ParseStringToFloat(values[1]));
                        cuotaFija.Add(ParseStringToFloat(values[2]));
                        excedente.Add(ParseStringToFloat(values[3]));
                    }
                }
            }
        }

        private float CalculoISR(float ingresosAnuales)
        {
            var i = 0;

            if (límiteInferior.Count > 0)
            {
                while (ingresosAnuales > límiteInferior[i] && i < límiteInferior.Count)
                {
                    i++;
                }
                i--;
                var x = (ingresosAnuales - límiteInferior[i]) * (excedente[i]/100);
                return cuotaFija[i] + x;
            }
            return 0;
        }

        private void ISR_Click(object sender, EventArgs e)
        {
            float topeDeducciones = 0.15F; 
            if (label1.Text != "Archivo leido")
                return;
            float.TryParse(ingresos.Text, out float ingresosAnuales);
            float.TryParse(deducciones.Text, out float deduciones2);

            if (deduciones2 > (ingresosAnuales* topeDeducciones))
            {
                deduciones2 = ingresosAnuales * topeDeducciones;
            }
            Trace.WriteLine(ingresosAnuales);
            Trace.WriteLine(límiteInferior[2]);
            var isrSinDeducciones = CalculoISR(ingresosAnuales);
            var isrConDeducciones = CalculoISR(ingresosAnuales - deduciones2);
            saldo.Text = (isrSinDeducciones - isrConDeducciones).ToString(); 
            isr1.Text = isrSinDeducciones.ToString();
            isr2.Text = isrConDeducciones.ToString();
            isr1.Enabled = false;
            isr2.Enabled = false;
            saldo.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
