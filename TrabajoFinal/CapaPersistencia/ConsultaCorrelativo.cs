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
    public class ConsultaCorrelativo
    {
        public List<Correlativo> ConsutaCorrelativo(Correlativo correlativo)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT Id_Correlativo,Id_TipoDoc,iNInicial,iNFinal,bVigencia from TBL_Correlativo";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Correlativo> lista = new List<Correlativo>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Correlativo agregar = new Correlativo();

                        agregar.Id_Correlativo = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_TipoDoc = int.Parse(dt.Rows[i][1].ToString());
                        agregar.iNInicial = int.Parse(dt.Rows[i][2].ToString());
                        agregar.iNFinal = int.Parse(dt.Rows[i][3].ToString());
                        agregar.bVigencia = int.Parse(dt.Rows[i][4].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Correlativo>();
                }
            }
            catch (Exception ex)
            {
                return new List<Correlativo>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Correlativo> BuscarCorrelativo(Correlativo correlativo)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryBuscar = "SELECT Id_Correlativo,Id_TipoDoc,iNInicial,iNFinal,bVigencia from TBL_Correlativo where Id_Correlativo=" + correlativo.Id_Correlativo;

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryBuscar, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Correlativo> lista = new List<Correlativo>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Correlativo agregar = new Correlativo();

                        agregar.Id_Correlativo = int.Parse(dt.Rows[i][0].ToString());
                        agregar.Id_TipoDoc = int.Parse(dt.Rows[i][1].ToString());
                        agregar.iNInicial = int.Parse(dt.Rows[i][2].ToString());
                        agregar.iNFinal = int.Parse(dt.Rows[i][3].ToString());
                        agregar.bVigencia = int.Parse(dt.Rows[i][4].ToString());

                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Correlativo>();
                }
            }
            catch (Exception ex)
            {
                return new List<Correlativo>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public bool registraCorrelativo(Correlativo correlativo)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryInsert = "INSERT INTO TBL_Correlativo VALUES (" +
                                    correlativo.Id_TipoDoc + "," +
                                    correlativo.iNInicial + "," +
                                    correlativo.iNFinal + "," +
                                    correlativo.bVigencia + ");";

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
        public bool modificarCorrelativo(Correlativo correlativo)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryModifica = "UPDATE TBL_Correlativo set iNInicial=" + correlativo.iNInicial + ", iNFinal=" + correlativo.iNFinal +  ", bVigencia=" + correlativo.bVigencia + " where Id_Correlativo=" + correlativo.Id_Correlativo;

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
        public bool eliminarCorrelativo(Correlativo correlativo)
        {
            ConexionBD conectaBD = new ConexionBD();

            try
            {
                string queryElimina = "UPDATE TBL_Correlativo set bVigencia=" + correlativo.bVigencia + " where Id_Correlativo=" + correlativo.Id_Correlativo;

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
