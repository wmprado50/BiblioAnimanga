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
    public class datAnime
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAnime _instancia = new datAnime();
        //privado para evitar la instanciación directa
        public static datAnime Instancia
        {
            get
            {
                return datAnime._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar Anime
        public List<entAnime> ListarAnime()
        {
            SqlCommand cmd = null;
            List<entAnime> lista = new List<entAnime>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAnime Ani = new entAnime();
                    Ani.idAnime = Convert.ToInt32(dr["idAnime"]);
                    Ani.nombreAni = dr["nombreAni"].ToString();
                    Ani.id_estAni = Convert.ToInt32(dr["a_idestudioAni"]);
                    Ani.nombre_estAni = dr["nombre_estAni"].ToString();
                    Ani.id_genAni = Convert.ToInt32(dr["a_idgeneroAni"]);
                    Ani.nombre_genAni = dr["nombre_genAni"].ToString();
                    Ani.episodiosAni = Convert.ToInt32(dr["episodiosAni"]);
                    Ani.temporadaAni = dr["temporadaAni"].ToString();
                    Ani.duracionAni = Convert.ToInt32(dr["duracionAni"]);
                    Ani.demografiaAni = dr["demografiaAni"].ToString();

                    lista.Add(Ani);
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
        //Insertar Anime
        public Boolean InsertarAnime(entAnime Ani)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreAni", Ani.nombreAni);
                cmd.Parameters.AddWithValue("@a_idestudioAni", Ani.id_estAni);
                cmd.Parameters.AddWithValue("@a_idgeneroAni", Ani.id_genAni);
                cmd.Parameters.AddWithValue("@episodiosAni", Ani.episodiosAni);
                cmd.Parameters.AddWithValue("@temporadaAni", Ani.temporadaAni);
                cmd.Parameters.AddWithValue("@duracionAni", Ani.duracionAni);
                cmd.Parameters.AddWithValue("@demografiaAni", Ani.demografiaAni);


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
        //Editar Anime
        public Boolean EditarAnime(entAnime Ani)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarAnimes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreAni", Ani.nombreAni);
                cmd.Parameters.AddWithValue("@a_idestudioAni", Ani.id_estAni);
                cmd.Parameters.AddWithValue("@a_idgeneroAni", Ani.id_genAni);
                cmd.Parameters.AddWithValue("@episodiosAni", Ani.episodiosAni);
                cmd.Parameters.AddWithValue("@temporadaAni", Ani.temporadaAni);
                cmd.Parameters.AddWithValue("@duracionAni", Ani.duracionAni);
                cmd.Parameters.AddWithValue("@demografiaAni", Ani.demografiaAni);

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
        //Eliminar Anime
        public Boolean EliminarAnime(entAnime Ani)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarAnime", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAnime", Ani.idAnime);
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
