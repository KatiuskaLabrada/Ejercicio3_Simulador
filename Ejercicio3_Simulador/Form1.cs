using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Simulador
{
    public partial class Form1 : Form
    {
        int valueCorrectResp, valueIncorrectResp, valueFinalScore, scoreCR;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            correctRes.Clear();
            incorrectRes.Clear();
            finalScore.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Asignar valor a las variables
            valueCorrectResp = Convert.ToInt32(correctRes.Text);
            valueIncorrectResp = Convert.ToInt32(incorrectRes.Text);

            //Calculos matematicos
            scoreCR = valueCorrectResp * 4;
            valueFinalScore = scoreCR - valueIncorrectResp;

            //Mostrar los resultados
            this.finalScore.Text = valueFinalScore.ToString();
        }
    }
}
