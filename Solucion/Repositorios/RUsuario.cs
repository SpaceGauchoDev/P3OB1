using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Configuration;
using System.Data.SqlClient;
using Dominio;

namespace Repositorios
{
    public class RUsuario : IRepositorio<Usuario>
    {
        public bool Add(Usuario pT)
        {
            if (pT == null || !pT.Validar()) {
                return  false;
            }

            Conexion connexion = new Conexion();
            SqlConnection cn = connexion.CrearConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario VALUES (@CI,@Pass,@Rol,@Nombre,@Apellido,@FechaDeNacimiento,@Email,@Celular)", cn);
            cmd.Parameters.Add(new SqlParameter("@CI", pT.CI));
            cmd.Parameters.Add(new SqlParameter("@Pass", pT.Pass));

            if (pT.Rol == Usuario.E_Rol.Admin)
            {
                cmd.Parameters.Add(new SqlParameter("@Rol", 'A'));
            }
                 // TODO verificar que no hallan maneras mas seguras de implementar esta bifurcacion
            else // if (pT.Rol == Usuario.E_Rol.Solicitante)
            {
                cmd.Parameters.Add(new SqlParameter("@Rol", 'S'));
            }
            cmd.Parameters.Add(new SqlParameter("@Nombre", pT.Nombre));
            cmd.Parameters.Add(new SqlParameter("@Apellido", pT.Apellido));
            string fechaParaDB = pT.FechaDeNacimiento.ToString("yyyyMMdd");
            cmd.Parameters.Add(new SqlParameter("@FechaDeNacimiento", fechaParaDB));
            cmd.Parameters.Add(new SqlParameter("@Email", pT.Email));
            cmd.Parameters.Add(new SqlParameter("@Celular", pT.Celular));

            try
            {
                if (connexion.AbrirConexion(cn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connexion.CerrarConexion(cn);
            }
        }

        public IEnumerable<Usuario> FindAll()
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", cn);
            try
            {
                if (conexion.AbrirConexion(cn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Usuario> usuarios = new List<Usuario>();
                    while (dr.Read())
                    {
                        if (dr["Rol"].ToString() == "S")
                        {
                            Solicitante s = new Solicitante()
                            {
                                CI = (int)dr["CI"],
                                Pass = dr["Pass"].ToString(),
                                Rol = Usuario.E_Rol.Solicitante,
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechaDeNacimiento = (DateTime)dr["FechaDeNacimiento"],
                                Celular = dr["Celular"].ToString(),
                                Email = dr["Apellido"].ToString(),
                            };
                            usuarios.Add(s);
                        }

                        if (dr["Rol"].ToString() == "A")
                        {
                            Admin a = new Admin()
                            {
                                CI = (int)dr["CI"],
                                Pass = dr["Pass"].ToString(),
                                Rol = Usuario.E_Rol.Admin,
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechaDeNacimiento = (DateTime)dr["FechaDeNacimiento"],
                                Celular = dr["Celular"].ToString(),
                                Email = dr["Apellido"].ToString(),
                            };
                            usuarios.Add(a);
                        }
                    }
                    return usuarios;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally

            {
                conexion.CerrarConexion(cn);
            }
        }

        public Usuario FindById(object pId)
        {
            // TODO Encontrar una manera mas segura de castear
            int idComoNumero = (int)pId;

            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.CrearConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usuario.CI =" + idComoNumero.ToString();
            cmd.Connection = cn;

            try
            {
                Usuario usuario = null;
                if (conexion.AbrirConexion(cn))
                {
                    // TODO ver de usar CommandBehavior.SingleRow para mejorar performance
                    // https://www.c-sharpcorner.com/blogs/how-to-make-faster-sql-server-search-part-three
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr["Rol"].ToString() == "S")
                        {
                            Solicitante s = new Solicitante()
                            {
                                CI = (int)dr["CI"],
                                Pass = dr["Pass"].ToString(),
                                Rol = Usuario.E_Rol.Solicitante,
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechaDeNacimiento = (DateTime)dr["FechaDeNacimiento"],
                                Celular = dr["Celular"].ToString(),
                                Email = dr["Apellido"].ToString(),
                            };
                            usuario = s;
                        }

                        if (dr["Rol"].ToString() == "A")
                        {
                            Admin a = new Admin()
                            {
                                CI = (int)dr["CI"],
                                Pass = dr["Pass"].ToString(),
                                Rol = Usuario.E_Rol.Admin,
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                FechaDeNacimiento = (DateTime)dr["FechaDeNacimiento"],
                                Celular = dr["Celular"].ToString(),
                                Email = dr["Apellido"].ToString(),
                            };
                            usuario = a;
                        }
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }
        }

        public bool Remove(Usuario pT)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario pT)
        {
            throw new NotImplementedException();
        }
    }
}
