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
    public class ConsultaTipoDoc
    {
        public List<TipoDoc> ConsutaTipoDoc(TipoDoc tipodoc)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT Id_TipoDoc,cNombre,bVigencia from TBL_TipoDoc";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<TipoDoc> lista = new List<TipoDoc>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TipoDoc agregar = new TipoDoc();

                        agregar.Id_TipoDoc = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.bVigencia = int.Parse(dt.Rows[i][2].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<TipoDoc>();
                }
            }
            catch (Exception ex)
            {
                return new List<TipoDoc>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<TipoDoc> BuscarTipoDoc(TipoDoc tipodoc)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT Id_TipoDoc,cNombre,bVigencia from TBL_TipoDoc where Id_TipoDoc=" + tipodoc.Id_TipoDoc;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<TipoDoc> lista = new List<TipoDoc>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TipoDoc agregar = new TipoDoc();

                        agregar.Id_TipoDoc = int.Parse(dt.Rows[i][0].ToString());
                        agregar.cNombre = dt.Rows[i][1].ToString();
                        agregar.bVigencia = int.Parse(dt.Rows[i][2].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<TipoDoc>();
                }
            }
            catch (Exception ex)
            {
                return new List<TipoDoc>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraTipoDoc(TipoDoc tipodoc)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_TipoDoc VALUES ('" +
                                     tipodoc.cNombre + "'," +
                                     tipodoc.bVigencia + ");";

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
        public bool modificarTipoDoc(TipoDoc tipodoc)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_TipoDoc set cNombre='" + tipodoc.cNombre + "', bVigencia=" + tipodoc.bVigencia + " where Id_TipoDoc=" + tipodoc.Id_TipoDoc;

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryModifica, conectaBD.Conexion);

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
        public bool eliminarTipoDoc(TipoDoc tipodoc)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_TipoDoc set bVigencia=" + tipodoc.bVigencia + " where Id_TipoDoc=" + tipodoc.Id_TipoDoc;

                conectaBD.abrirConexion();

                SqlCommand cmd = new SqlCommand(queryElimina, conectaBD.Conexion);

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
