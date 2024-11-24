using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    internal class Acceso
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=Fravega;Integrated Security=True");
        SqlTransaction tx;
        private void conectar()
        {
            if(cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        private void desconectar()
        {
            cn.Close();
        }

        private void IniciarTx()
        {
            if (cn.State == ConnectionState.Open)
            {
                tx=cn.BeginTransaction();
            }
        }
        private void ConfirmarTx()
        {

                tx.Commit();
        }
        private void CancelarTx()
        {
                tx.Rollback();
        }


        public DataTable leer(string sp, SqlParameter[] parametros)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conectar();
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = sp,
                    Connection = cn
                };
                if (parametros != null)
                {
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddRange(parametros);
                }
                da.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                desconectar();
            }

            return dataTable;

        }
        public int escribir(string sp, SqlParameter[] parametros)
        {
            int fa = 0;

            try
            {
                conectar();
                IniciarTx();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = cn;
                cmd.Transaction = tx;

                if (parametros != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(parametros);
                }

                fa = cmd.ExecuteNonQuery();
                ConfirmarTx();
            }
            catch (Exception ex)
            {
                CancelarTx();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                desconectar();
            }
            return fa;
        }

        public int escribirXml(string sp,string NombreArchivo ,SqlParameter[] parametros)
        {
            try
            {
                conectar();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand()
                {
                    Connection = cn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = sp
                };
                if(parametros != null)
                {
                    adapter.SelectCommand.Parameters.Clear();
                    adapter.SelectCommand.Parameters.AddRange(parametros);
                }
                adapter.Fill(ds);
                ds.WriteXml(@"D:\.UAI\LUG\Fravega\" + NombreArchivo);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                desconectar();
            }

            return 0;
        }

        public int getId(string sp, SqlParameter[] parametros)
        {
            int id = 0;
            try
            {
            conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if(parametros != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parametros);
            }
            id = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                desconectar();
            }
            return id;
        }

    }
}
