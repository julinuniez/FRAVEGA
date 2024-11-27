using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLTipoTarjeta
    {
        MP_TipoTarjeta mapper = new MP_TipoTarjeta();

        public List<TipoTarjeta> ListarTipoTarjeta()
        {
            return mapper.ListarTipoTarjeta();
        }

        public int AgregarTipoTarjeta(TipoTarjeta tipo)
        {
            return mapper.AgregarTipoTarjeta(tipo);
        }

        public int EliminarTipoTarjeta(int id)
        {
            return mapper.EliminarTipoTarjeta(id);
        }
        public int obtenerIdTipoTarjeta(string nombreTarjeta)
        {
            return mapper.obtenerIdTipoTarjeta(nombreTarjeta);
        }

    }
}
