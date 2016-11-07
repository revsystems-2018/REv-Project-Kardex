using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    class Conexion
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader read;
        String res = "";

        public Conexion() 
        {
            try 
            {
                conn = new SqlConnection("Data Source=RICARDO_T381; Initial Catalog=REV_DataBase; User ID=sa; Password=revsystems");
                //conn.Open();
                //res = "Conectado";
                //MessageBox.Show(res, "");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de Conexion con la Base de Datos."+ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        
        }

        public void Comando(String cadena) 
        {
            try
            {
                cmd = new SqlCommand(cadena,conn);
            }
            catch(Exception ex){
                MessageBox.Show("Existe un Error con el Comando Ingresado." + ex.ToString()+ "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public SqlConnection GetCONN() 
        {
            return conn;
        }

        public SqlCommand GetCMD() {
            return cmd;
        }

        public SqlDataReader LeerDatos() {
            try
            {
                read = cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existe un Error con el Comando Ingresado." + ex.ToString() + "\n Verificar el Comando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return read;
        }

        public void OpenCnn() { conn.Open(); }

        public void CerrarCnn() { conn.Close(); }

    }
}
