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
    public class ConsultaGrafico
    {
        public List<Grafico> ConsutaGraficoCnt(Grafico grafico)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT  " +
                                        "sum(Id_NCorrelativo)" +                                           
                                        "from " +
                                        "TBL_Documento";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Grafico> lista = new List<Grafico>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Grafico agregar = new Grafico();

                        agregar.Cantidad = int.Parse(dt.Rows[i][0].ToString());
                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Grafico>();
                }
            }
            catch (Exception ex)
            {
                return new List<Grafico>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
        public List<Grafico> ConsutaGraficoMto(Grafico grafico)
        {
            ConexionBD conectaBD = new ConexionBD();
            try
            {
                string queryConsulta = "SELECT  " +
                                        "sum(iTotalGeneral)" +
                                        "from " +
                                        "TBL_Documento";

                conectaBD.abrirConexion();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryConsulta, conectaBD.Conexion);

                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);

                conectaBD.cerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    List<Grafico> lista = new List<Grafico>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Grafico agregar = new Grafico();

                        agregar.Monto = int.Parse(dt.Rows[i][0].ToString().Split(',')[0]);
                        lista.Add(agregar);
                    }

                    return lista;
                }
                else
                {
                    return new List<Grafico>();
                }
            }
            catch (Exception ex)
            {
                return new List<Grafico>();
            }
            finally
            {
                conectaBD.cerrarConexion();
            }
        }
    }
}
