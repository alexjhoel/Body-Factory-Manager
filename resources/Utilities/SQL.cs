using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public class SQL
    {
        SqlConnection conexion;
        public SQL(string c)
        {
            conexion = new SqlConnection(c);
        }

        public void Modificar(string consulta, Dictionary<string, object> p = null, bool mostrarError = true)
        {
            DataTable tabla = new DataTable();
            try
            {
                //Realiza consulta que cambie datos en la base de datos
                Dictionary<string, object> parameters = p == null ? new Dictionary<string, object>() : p;


                SqlCommand sqlComando = new SqlCommand(consulta, conexion);

                conexion.Open();

                foreach (string parameter in parameters.Keys)
                {
                    object value = "";
                    parameters.TryGetValue(parameter, out value);
                    sqlComando.Parameters.AddWithValue(parameter, value);
                }

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                conexion.Close();
                if (mostrarError) MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        public DataTable Obtener(string consulta, Dictionary<string, object> p = null, bool mostrarError = true)
        {
            DataTable tabla = new DataTable();
            try
            {
                //Realiza consulta que sea de obtención de datos en la base de datos
                Dictionary<string, object> parameters = p == null ? new Dictionary<string, object>() : p;
                SqlCommand sqlComando = new SqlCommand(consulta, conexion);
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {
                    foreach (string parameter in parameters.Keys)
                    {
                        object value = "";
                        parameters.TryGetValue(parameter, out value);
                        sqlComando.Parameters.AddWithValue(parameter, value);
                    }



                    miAdaptadorSql.Fill(tabla);


                }
            }
            catch (Exception e)
            {
                if (mostrarError) MessageBox.Show(e.Message);

            }
            return tabla;
        }

        public DataTable Obtener(string consulta, bool mostrarError)
        {
            DataTable tabla = new DataTable();
            try
            {
                //Realiza consulta que sea de obtención de datos en la base de datos, sin parametros

                SqlCommand sqlComando = new SqlCommand(consulta, conexion);
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {
                    miAdaptadorSql.Fill(tabla);
                    return tabla;


                }
            }
            catch (Exception e)
            {
                if (mostrarError) MessageBox.Show(e.Message);

            }
            return tabla;
        }
    }
}
