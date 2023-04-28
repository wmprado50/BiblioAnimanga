using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logAutorManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAutorManga _instancia = new logAutorManga();
        //privado para evitar la instanciación directa
        public static logAutorManga Instancia
        {
            get
            {
                return logAutorManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar
        public List<entAutorManga> ListarAutorManga()
        {
            return datAutorManga.Instancia.ListarAutorManga();
        }

        ///Insertar
        public void InsertarAutorManga(entAutorManga autMan)
        {
            datAutorManga.Instancia.InsertarAutorManga(autMan);
        }

        //Editar
        public void EditarAutorManga(entAutorManga autMan)
        {
            datAutorManga.Instancia.EditarAutorManga(autMan);
        }

        public void EliminarAutorManga(entAutorManga autMan)
        {
            datAutorManga.Instancia.EliminarAutorManga(autMan);
        }

        #endregion metodos



    }
}
