using CapaEntidades;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class ConsultaUsers
    {
        public string ConsutaLogin(Users usuario)
        {
            ConexionBD conectaBD = new ConexionBD();
            string nomUser = string.Empty;
            try
            {
                string queryInsert = "SELECT cNombres + ' ' + cApellidos from TBL_Usuario where cNombreUsuario = '" + usuario.user + "' and cClave = '" + usuario.password + "'";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryInsert, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                nomUser = dt.Rows[0].ItemArray[0].ToString();

                if (dt.Rows.Count > 0)
                {
                    return nomUser;
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return nomUser;
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
            return nomUser;
        }

        public List<Users> BuscaPerfil(Users users)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                                        "Id_Perfil," +
                                        "cNombrePerfil " +
                                        "from " +
                                        "TBL_Perfil";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Users> lista = new List<Users>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Users agregar = new Users();

                        agregar.id_perfil = int.Parse(dt.Rows[i][0].ToString());
                        agregar.nombreperfil = dt.Rows[i][1].ToString();

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Users>();
                }
            }
            catch (Exception ex)
            {
                return new List<Users>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Users> BuscaUsuario(Users users)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                                       "a.Id_Usuario, " +
                                        "a.Id_Perfil, " +
                                        "b.cNombrePerfil, " +
                                        "a.cNombreUsuario, " +
                                        "a.cClave, " +
                                        "a.iRut, " +
                                        "a.cDv, " +
                                        "a.cNombres, " +
                                        "a.cApellidos, " +
                                        "a.cCorreo, " +
                                        "a.dFechaNacimiento, " +
                                        "a.dFechaVigencia, " +
                                        "a.bVigencia " +
                                        "from " +
                                        "            TBL_Usuario a " +
                                        "inner join  TBL_Perfil  b " +
                                        "on a.Id_Perfil = b.Id_Perfil ";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Users> lista = new List<Users>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Users agregar = new Users();

                        agregar.rut = int.Parse(dt.Rows[i]["iRut"].ToString());
                        agregar.dv = dt.Rows[i]["cDv"].ToString();
                        agregar.nombre = dt.Rows[i]["cNombres"].ToString();
                        agregar.apellido = dt.Rows[i]["cApellidos"].ToString();
                        agregar.user = dt.Rows[i]["cNombreUsuario"].ToString();
                        agregar.correo = dt.Rows[i]["cCorreo"].ToString();
                        agregar.fecnacimiento = dt.Rows[i]["dFechaNacimiento"].ToString();
                        agregar.nombreperfil = dt.Rows[i]["cNombrePerfil"].ToString();

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Users>();
                }
            }
            catch (Exception ex)
            {
                return new List<Users>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Users> ListaOpciones(Users users)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT " +
                                        "Id_Opciones," +
                                        "cNombreOpciones " +
                                        "from " +
                                        "TBL_Opciones";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Users> lista = new List<Users>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Users agregar = new Users();

                        agregar.sel = false;
                        agregar.Id_Opciones = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombreOpciones = dt.Rows[i][1].ToString();

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Users>();
                }
            }
            catch (Exception ex)
            {
                return new List<Users>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraUsuario(Users usuario)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "insert into [TBL_Usuario] (cNombreUsuario, cClave, iRut, cDv, cNombres, cApellidos, cCorreo, dFechaNacimiento, bVigencia, Id_Perfil) values " +
                                    "('" + usuario.user + "','" +
                                    usuario.password + "'," +
                                    usuario.rut + ",'" +
                                    usuario.dv + "','" +
                                    usuario.nombre + "','" +
                                    usuario.apellido + "','" +
                                    usuario.correo + "','" +
                                    usuario.fecnacimiento + "','" +
                                    "" + "1" + "','" +
                                    "" + "1" + "');";

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryInsert, conectaBD.Conexion);

                int aux = cmd.ExecuteNonQuery();

                conectaBD.cerrarConexion();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
    }
}
