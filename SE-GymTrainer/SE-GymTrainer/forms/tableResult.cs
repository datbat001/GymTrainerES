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
    public partial class tableResult : Form
    {
        public tableResult()
        {
            InitializeComponent();
        }
        public tableResult(string pesoIdeal)
        {
            string pesofinal = pesoIdeal;
            InitializeComponent();
            MessageBox.Show(pesofinal);
            tools.conexiones.fillDataGridView(pesofinal, table);
            table.GridColor = Color.Black;
            table.ReadOnly = true;
            table.AllowUserToAddRows = false;
            
        }

        private void tableResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymTrainerDataSet1.ejercicios' table. You can move, or remove it, as needed.
            this.ejerciciosTableAdapter.Fill(this.gymTrainerDataSet1.ejercicios);
            
        }
    }
}
