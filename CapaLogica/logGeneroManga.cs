using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logGeneroManga
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logGeneroManga _instancia = new logGeneroManga();
        //privado para evitar la instanciación directa
        public static logGeneroManga Instancia
        {
            get
            {
                return logGeneroManga._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //Listar
        public List<entGeneroManga> ListarGeneroManga()
        {
            return datGeneroManga.Instancia.ListarGeneroManga();
        }

        ///Insertar
        public void InsertarGeneroManga(entGeneroManga genMan)
        {
            datGeneroManga.Instancia.InsertarGeneroManga(genMan);
        }

        //Editar
        public void EditarGeneroManga(entGeneroManga genMan)
        {
            datGeneroManga.Instancia.EditarGeneroManga(genMan);
        }

        public void EliminarGeneroManga(entGeneroManga genMan)
        {
            datGeneroManga.Instancia.EliminarGeneroManga(genMan);
        }

        #endregion metodos


    }
}
