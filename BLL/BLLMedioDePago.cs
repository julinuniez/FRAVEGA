using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLLMedioDePago
    {
        MP_MedioDePago mapper = new MP_MedioDePago();

        public List<MedioDePago> ListarMedioDePago(int Dni)
        {
            return mapper.ListarMedioDePago(Dni);
        }

        public int AgregarMedioDePago(MedioDePago mdp)
        {
            return mapper.AgregarMedioDePago(mdp);
        }

        public int EliminarMedioDePago(string nroTarjeta)
        {
            return mapper.EliminarMedioDePago(nroTarjeta);
        }

        public bool generarXML()
        {
            return mapper.generarXMLMedioDePago();
        }
    }
}
