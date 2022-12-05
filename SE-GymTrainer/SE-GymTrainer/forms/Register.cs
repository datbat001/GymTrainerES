using SE_GymTrainer.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_GymTrainer
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == String.Empty || txtpass.Text.Trim() == String.Empty || txtemail.Text.Trim() == String.Empty || txtpeso.Text.Trim() == String.Empty || txtestatura.Text.Trim() == String.Empty)
            {
                MessageBox.Show("ERROR: Registro invalido pendejo");
            }
            else
            {
                try
                {
                    tools.conexiones.Register(txtusername.Text, txtpass.Text, txtemail.Text, txtpeso.Text, txtestatura.Text);
                    //MessageBox.Show(modelo.Name);
                    MessageBox.Show("Usuario Creado");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
