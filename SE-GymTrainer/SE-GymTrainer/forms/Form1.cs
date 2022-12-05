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
    public partial class Form1 : Form
    {

        models.userModel modelo = new userModel();


        public Form1()
        {
            InitializeComponent();
            lblTitle.BackColor = Color.Transparent;
            gbLogin.BackColor = Color.Transparent;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text.Trim() == String.Empty || txtBoxPassword.Text.Trim() == String.Empty)
            {
                MessageBox.Show("ERROR: Inicio de sesion invalido");
            }
            else
            {
                try
                {
                    userModel modelo = tools.conexiones.Login(txtBoxUsername.Text, txtBoxPassword.Text);
                    tools.conexiones.Activate(txtBoxUsername.Text, txtBoxPassword.Text);
                    //MessageBox.Show(modelo.Name);
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
        public string SetUserName(string username)
        {
            return username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
        public void GetName(TextBox txt)
        {
            //txt.Text = username;
        }
    }
}
