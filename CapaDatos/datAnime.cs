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
        //Patron Singleto
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






    }
}
