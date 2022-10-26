using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppVentasFer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
                
                using(SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    MessageBox.Show("Conexion realizada");
                    conexion.Close();
                }
            }
            catch
            {
                MessageBox.Show("No se pudo conectar");
            }
        }
    }
}
