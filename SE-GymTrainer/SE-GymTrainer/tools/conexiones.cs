using SE_GymTrainer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_GymTrainer.tools
{
    internal class conexiones
    {
         
        private static readonly string sCnn = "Data Source=.\\sqlexpress;" +
            "Initial Catalog=GymTrainer;Integrated Security=True; " +
            "User ID=YourUserHere; Password=YourPasswordHere";

        private static readonly string[] Querys =  {
            "SELECT [nick],[password] FROM [dbo].[user] WHERE [nick] = '{1}' and [password] = '{2}'",                                       //0
            "INSERT INTO [dbo].[user] ([nick],[password],[email],[peso],[altura],[active],[Tipo]) VALUES ('{1}','{2}','{3}','{4}','{5}',0,1)",                  //1
            "UPDATE [dbo].[user] SET [active] = 1 WHERE [nick] = '{1}' and [password] = {2}",                                               //2               
            "SELECT [nick],[password],[email],[peso],[altura] FROM [GymTrainer].[dbo].[user] Where [Active] = 1",                           //3
            "UPDATE [dbo].[user] SET [nick] = '{1}' ,[password] = '{2}',[email] = '{3}',[peso] = {4},[altura] = {5} WHERE [Active] = 1",    //4        
            "UPDATE [dbo].[user] SET [active] = 0",                                                                                         //5
            "SELECT  [peso],[altura] FROM [GymTrainer].[dbo].[user] Where [active] = 1",                                                    //6
            "SELECT [Tipo],[Body_Part],[Ejercicio],[Serie],[Repeticion] FROM [GymTrainer].[dbo].[ejercicios] WHERE [Tipo] = '{1}'"                 //7
        };
        private static string construyeQuery(params Object[] parametros)
        {
            string q = Querys[int.Parse(parametros[0].ToString())];
            for (int x = 1; x < parametros.Length; x++)
            {
                q = q.Replace("{" + x + "}", parametros[x].ToString());
            }
            return q;
        }
        private static void nonQuery(string q)
        {
            SqlConnection connection = new SqlConnection(sCnn);
            SqlCommand command = new SqlCommand(q, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static userModel Login(string usr, string clv)
        {
            userModel modelo = new userModel();
            SqlConnection connection = new SqlConnection(sCnn);
            SqlCommand command = new SqlCommand(construyeQuery(0, usr, clv), connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // aqui trabajamos 
                while (reader.Read())
                {
                    modelo = new userModel(
                        reader.GetString(0), 
                        reader.GetString(1));
                }
            }
            else
            {
                throw new Exception("Error de inicio de sesion");
            }
            connection.Close();
            return modelo;
        }
        public static void Register(string usr, string clv, string email, string peso, string altura)
        {
            nonQuery(construyeQuery(1, usr, clv, email, peso, altura));
            
        }
        public static void Activate(string usr,string pass)
        {   nonQuery(construyeQuery(2, usr, pass)); }
        public static void llenarForm(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            SqlConnection connection = new SqlConnection(sCnn);
            SqlCommand command = new SqlCommand(construyeQuery(3), connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txt1.Text = reader.GetString(0);
                txt2.Text = reader.GetString(1);
                txt3.Text = reader.GetString(2);
                txt4.Text = reader.GetInt32(3).ToString();
                txt5.Text = reader.GetInt32(4).ToString();
            }
            connection.Close();
        }
        public static void Update(string usr, string clv, string email, string peso, string altura)
        {
            nonQuery(construyeQuery(4, usr, clv, email, peso, altura));
        }
        public static void Logout()
        {
            nonQuery(construyeQuery(5));
        }
        public  static void  GetPeso(int peso)
        {
            SqlConnection connection = new SqlConnection(sCnn);
            SqlCommand command = new SqlCommand(construyeQuery(6), connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                peso = reader.GetInt32(0);
            }
            connection.Close();
            forms.Select.SetPeso(peso);
        }
        public static void GetAltura(int altura)
        {
            SqlConnection connection = new SqlConnection(sCnn);
            SqlCommand command = new SqlCommand(construyeQuery(6), connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                altura = reader.GetInt32(1);
                
            }
            connection.Close();
            forms.Select.SetAltura(altura);
        }

        public static void fillDataGridView(string tipo, DataGridView dgv)
        {
            string value = "";
            if (tipo == "No es tu peso ideal")
            {
                value = "Sobre Peso";
            }
            else if (tipo == "Peso ideal")
            {
                value = "Peso Ideal";
            }
            else if (tipo == "Tonificar")
            {
                value = "Tonificar";
            }
            try
            {
                SqlConnection connection = new SqlConnection(sCnn);
                SqlCommand command = new SqlCommand(construyeQuery(7, value), connection);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgv.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
