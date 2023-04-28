using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaLogica
{
    public class logGeneroAnime
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logGeneroAnime _instancia = new logGeneroAnime();
        //privado para evitar la instanciación directa
        public static logGeneroAnime Instancia
        {
            get
            {
                return logGeneroAnime._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listar
        public List<entGeneroAnime> ListarGeneroAnime()
        {
            return datGeneroAnime.Instancia.ListarGeneroAnime();
        }

        ///Insertar
        public void InsertarGeneroAnime(entGeneroAnime genAni)
        {
            datGeneroAnime.Instancia.InsertarGeneroAnime(genAni);
        }

        //Editar
        public void EditarGeneroAnime(entGeneroAnime genAni)
        {
            datGeneroAnime.Instancia.EditarGeneroAnime(genAni);
        }

        public void EliminarGeneroAnime (entGeneroAnime genAni)
        {
            datGeneroAnime.Instancia.EliminarGeneroAnime(genAni);
        }

        #endregion metodos

    }
}
