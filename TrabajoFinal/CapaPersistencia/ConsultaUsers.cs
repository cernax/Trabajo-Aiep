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
                string queryInsert = "SELECT CONCAT(cNombres, ' ', cApellidos) from [TALLER-NET].[dbo].[TBL_Usuario] where cNombreUsuario = '" + usuario.user + "' and cClave = '" + usuario.password + "'";

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
    }
}
