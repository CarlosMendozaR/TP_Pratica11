using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class CincoMetodos
    {
        //combinado, solo hielo, shot, personalizado
        public string Combinado(int alcohol, int refresco, int agua, byte hielo)
        {
            int total = alcohol+refresco+agua;
            if(total>250)
            {
                return "Parece que tu trago es demasiado grande para el vaso.";
            }
            else if(total <6)
            {
                return "Tu trago es demasiado pequeño.";
            }
            else()
        }

    }
}
