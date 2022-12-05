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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            conexiones.llenarForm(txtNickName, txtPass, txtMail, txtPeso, txtEstatura);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNickName.ReadOnly = false;
            txtPass.ReadOnly = false;
            txtMail.ReadOnly = false;
            txtPeso.ReadOnly = false;
            txtEstatura.ReadOnly = false;
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNickName.ReadOnly == false)
            {
                conexiones.Update(txtNickName.Text, txtPass.Text, txtMail.Text, txtPeso.Text, txtEstatura.Text);
                MessageBox.Show("Datos actualizados");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se han realizado cambios");
            }
        }
    }
}
