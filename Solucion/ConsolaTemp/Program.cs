using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// nuevo
using System.Configuration;
using System.Data.SqlClient;
using Dominio;
using Repositorios;

namespace ConsolaTemp
{
    class Program
    {
        static void Main(string[] args)
        {

            // agregar referencia, References->Add Reference.../Assemblies/System.Configuration
            //string cs = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            //SqlConnection sc = new SqlConnection();
            //sc.ConnectionString = cs;

            /*
            LeerUnaCelda(sc);
            Console.WriteLine();
            LeerUnaColumna(sc);
            */


            /*
            Usuario user = new Usuario()
            {
            CI = 42935324,
            Pass = "123",
            Rol = Usuario.E_Rol.Admin,
            Nombre = "pepe",
            Apellido = "le pew",
            FechaDeNacimiento = new DateTime(1990, 2, 15),
            Celular = 099879995
            };
            */

            /*
            Solicitante sol = new Solicitante()
            {
                CI = 42935324,
                Pass = "123",
                Rol = Usuario.E_Rol.Admin,
                Nombre = "pepe",
                Apellido = "le pew",
                FechaDeNacimiento = new DateTime(1990, 2, 15),
                Celular = 099879995
            };
            */

            /*
            bool cedulaValida = sol.ValidarCI(32768558);
            Console.WriteLine(cedulaValida);
            */

            RUsuario rUsuario= new RUsuario();
            int ci = 230;

            if (rUsuario.FindById(ci) != null)
            {
                Console.WriteLine("Encontro!");
            }
            else
            {
                Console.WriteLine("No encontro!");
            }


            Console.WriteLine("end");
            Console.ReadLine();
        }


        static void LeerUnaCelda(SqlConnection pSc)
        {
            // un comando que devuelve un valor de una celda
            SqlCommand sqlCmd_BuscarCelda = new SqlCommand();
            sqlCmd_BuscarCelda.CommandText = "SELECT Usuario.Nombre FROM Usuario WHERE Usuario.CI = 200";
            sqlCmd_BuscarCelda.Connection = pSc;

            // abro la conexion con el servidor
            pSc.Open();

            // ejecutar commando de un solo campo
            object scalarFound = sqlCmd_BuscarCelda.ExecuteScalar();

            if (scalarFound != null) {
                string nombre = scalarFound.ToString();
                Console.WriteLine(nombre);
            }
            else
            {
                Console.WriteLine("User not found");
            }

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
