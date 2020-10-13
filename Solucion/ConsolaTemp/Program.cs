using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// nuevo
using System.Configuration;
using System.Data.SqlClient;

namespace ConsolaTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            // agregar referencia, References->Add Reference.../Assemblies/System.Configuration
            string cs = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = cs;

            LeerUnaCelda(sc);
            Console.WriteLine();
            LeerUnaColumna(sc);

            Console.WriteLine("end");
            Console.ReadLine();
        }


        static void LeerUnaCelda(SqlConnection pSc) {
            // un comando que devuelve un valor de una celda
            SqlCommand sqlCmd_BuscarCelda = new SqlCommand();
            sqlCmd_BuscarCelda.CommandText = "SELECT Usuario.Nombre FROM Usuario WHERE Usuario.CI = 11";
            sqlCmd_BuscarCelda.Connection = pSc;

            // abro la conexion con el servidor
            pSc.Open();

            // ejecutar commando de un solo campo
            string nombre = sqlCmd_BuscarCelda.ExecuteScalar().ToString();
            Console.WriteLine(nombre);

            // cierro la conexion con el servidor
            pSc.Close();
        }


        static void LeerUnaColumna(SqlConnection pSc)
        {
            // un comando que devuelve un valor de una celda
            SqlCommand sqlCmd_BuscarColumna = new SqlCommand();
            sqlCmd_BuscarColumna.CommandText = "SELECT Usuario.Nombre FROM Usuario";
            sqlCmd_BuscarColumna.Connection = pSc;

            // abro la conexion con el servidor
            pSc.Open();

            SqlDataReader reader = sqlCmd_BuscarColumna.ExecuteReader();
            
            while (reader.Read())
            {
                Console.WriteLine(reader["Nombre"].ToString());
            }

            // cierro la conexion con el servidor
            pSc.Close();
        }




    }
}
