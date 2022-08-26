using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Body_Factory_Manager
{
    public class SQL
    {
        SqlConnection conexion;
        public SQL(string c)
        {
            conexion = new SqlConnection(c);
        }

        public void Modificar(string consulta, Dictionary<string, object> p = null)
        {
            DataTable tabla = new DataTable();
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

            conexion.Close();



        }

        public DataTable Obtener(string consulta, Dictionary<string, object> p = null)
        {
            DataTable tabla = new DataTable();
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

            return tabla;
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }


    }
}
