using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Lector
        {
            get { return reader;}
        }

        public AccesoDatos()
        {
            connection = new SqlConnection("server=.\\SQLSERVER; database=TURNOSDOC_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void storedProcedure(string sp)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sp;
        }
        public void setParameters(string nombre,object valor)
        {
            command.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLectura()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void CerrarConexion()
        {
            if (reader != null)
                reader.Close();
            connection.Close();
        }

    }
}
