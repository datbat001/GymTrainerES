using SE_GymTrainer.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_GymTrainer.forms
{
    public partial class Select : Form
    {
        static int pesof;
        static int alturaf;
        static string pesofinal = "";
        public Select()
        {
            string pesoIdeal = "";
            InitializeComponent();
            if (alturaf >= 155 && alturaf <= 160)
            {
                if (pesof >= 50 && pesof <= 56)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 161 && alturaf <= 165)
            {
                if (pesof >= 53 && pesof <= 60)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 166 && alturaf < 170)
            {
                if (pesof >= 56 && pesof <= 63)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 171 && alturaf <= 175)
            {
                if (pesof >= 60 && pesof <= 67)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 176 && alturaf <= 180)
            {
                if (pesof >= 63 && pesof <= 71)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 181 && alturaf <= 185)
            {
                if (pesof >= 67 && pesof <= 75)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 186 && alturaf <= 190)
            {
                if (pesof >= 71 && pesof <= 78)
                {
                    pesoIdeal = "Peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 155 && alturaf <= 160)
            {
                if (pesof > 56)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 161 && alturaf <= 165)
            {
                if (pesof > 60)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 166 && alturaf <= 170)
            {
                if (pesof > 63)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 171 && alturaf <= 175)
            {
                if (pesof > 67)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 176 && alturaf <= 180)
            {
                if (pesof > 71)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 181 && alturaf <= 185)
            {
                if (pesof > 75)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            else if (alturaf >= 186 && alturaf <= 190)
            {
                if (pesof > 78)
                {
                    pesoIdeal = "Sobre Peso";
                    MessageBox.Show(pesoIdeal);
                }
                else
                {
                    pesoIdeal = "No es tu peso ideal";
                    MessageBox.Show(pesoIdeal);
                }
            }
            //MessageBox.Show(pesoIdeal).ToString();
            if (pesoIdeal == "No es tu peso ideal" || pesoIdeal == "Sobre Peso")
            {
                btnMantener.Enabled = false;
                bttnBajar.Enabled = true;
                btnTonificar.Enabled = false;
            }
            else
            {
                btnMantener.Enabled = true;
                bttnBajar.Enabled = false;
                btnTonificar.Enabled = true;
            }
            pesofinal = pesoIdeal;
        }

        private void Select_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Peso: " + pesof.ToString() + " Altura: " + alturaf.ToString());
        }
        public static int SetPeso(int peso)
        {
            pesof = peso;
            return peso;
        }
        public static int SetAltura(int altura)
        {
            alturaf = altura;
            return altura;
        }

        private void bttnBajar_Click(object sender, EventArgs e)
        {
            tableResult result = new tableResult(pesofinal);
            //this.Hide();
            result.Show();
        }

        private void btnMantener_Click(object sender, EventArgs e)
        {
            tableResult result = new tableResult(pesofinal);
            //this.Hide();
            result.Show();
        }

        private void btnTonificar_Click(object sender, EventArgs e)
        {
            string pesoTonificar = "Tonificar";
            tableResult result = new tableResult(pesoTonificar);
            //this.Hide();
            result.Show();
        }
    }
}
