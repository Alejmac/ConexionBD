using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConexionBD.Clases
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static string Servidor = "localHost";
        static string Bd = "pp";
        static string Usuario = "alej";
        static string Password = "Megan";
        static  string Puerto = "1433";

        string cadenaConexion = "Data Source=" + Servidor + "," + Puerto + ";" + "user id=" + Usuario + ";" + "password=" + Password + ";" + "Initial Catalog=" + Bd + ";" + "Persist Security Info = true";


        public SqlConnection establecerConexio ()
        { 
            try{
                conex.ConnectionString = cadenaConexion;
                conex.Open ();
                MessageBox.Show("se conecto a la base de datos ");
    
                }catch(SqlException e){
                MessageBox.Show(" no se logro conecto a la base de datos "+ e.ToString());
        
              }
                return conex;

        }


    }
}
