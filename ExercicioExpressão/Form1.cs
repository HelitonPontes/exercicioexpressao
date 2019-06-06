using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioExpressão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Expressão Ex = new Expressão();


        //(X + 5 + 8 / 2 . 50 + 3 - Y )

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Ex.X = float.Parse(txtX.Text);
            Ex.Y = float.Parse(txtY.Text);

            Ex.Resultado = (Ex.X + 5 +8 / 2 * 50 + 3 - Ex.Y);

            txtCalcular.Text = Convert.ToString(Ex.Resultado);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtCalcular.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
