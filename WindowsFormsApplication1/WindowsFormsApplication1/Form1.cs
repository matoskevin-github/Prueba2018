using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   try
               {
                   string oradb = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString.ToString();
                   OracleConnection conn = new OracleConnection();
                   conn.ConnectionString = oradb;
                   conn.Open();
                   MessageBox.Show(conn.State.ToString());
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }*/


            string conexionString = "User id = SYSTEM; Password=Peru123.;Data Source = db11g;";

    
            OracleConnection conexion = new OracleConnection(conexionString);
            conexion.Open();
            MessageBox.Show(conexion.State.ToString());

        }
    }
}
