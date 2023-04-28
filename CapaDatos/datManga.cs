using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class datManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datManga _instancia = new datManga();
        //privado para evitar la instanciación directa
        public static datManga Instancia
        {
            get
            {
                return datManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar Manga 
        public List<entManga> ListarManga()
        {
            SqlCommand cmd = null;
            List<entManga> lista = new List<entManga>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entManga Man = new entManga();
                    Man.idManga = Convert.ToInt32(dr["idManga"]);
                    Man.nombreMan = dr["nombreMan"].ToString();
                    Man.id_genMan = Convert.ToInt32(dr["m_idgeneroMan"]);
                    Man.nombre_genMan = dr["nombre_genMan"].ToString();
                    Man.id_autorMan = Convert.ToInt32(dr["m_idautorMan"]);
                    Man.nombre_autMan = dr["nombre_autMan"].ToString();
                    Man.id_iluMan= Convert.ToInt32(dr["m_idilustMan"]);
                    Man.nombre_ilustMan = dr["nombre_iluMan"].ToString();
                    Man.demografiaMan = dr["demografia"].ToString();

                    lista.Add(Man);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        //Insertar Manga
        public Boolean InsertarManga(entManga Man)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreMan", Man.nombreMan);
                cmd.Parameters.AddWithValue("@m_idgeneroMan", Man.id_genMan);
                cmd.Parameters.AddWithValue("@m_idautorMan", Man.id_autorMan);
                cmd.Parameters.AddWithValue("@m_idilustMan", Man.id_iluMan);
                cmd.Parameters.AddWithValue("@demografia", Man.demografiaMan);


                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        //Editar Manga
        public Boolean EditarManga(entManga Man)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMangas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreMan", Man.nombreMan);
                cmd.Parameters.AddWithValue("@m_idgeneroMan", Man.id_genMan);
                cmd.Parameters.AddWithValue("@m_idautorMan", Man.id_autorMan);
                cmd.Parameters.AddWithValue("@m_idilustMan", Man.id_iluMan);
                cmd.Parameters.AddWithValue("@demografia", Man.demografiaMan);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        //Eliminar Manga
        public Boolean EliminarManga(entManga Man)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarManga", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idManga", Man.idManga);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion metodos
    }
}
