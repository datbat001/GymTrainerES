using SE_GymTrainer.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_GymTrainer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ejerciciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                int peso = 0;
                int altura = 0;
                tools.conexiones.GetPeso(peso);
                tools.conexiones.GetAltura(altura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile perfil = new Profile();
            perfil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select eleccion = new Select();
            eleccion.ShowDialog();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           
            if (f1.Validate() ==  true)
            {
                tools.conexiones.Logout(); 
                this.Close();
            }  
            f1.Show();
        }
    }
}
