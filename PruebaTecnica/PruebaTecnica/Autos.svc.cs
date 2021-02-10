using System;
using System.Collections.Generic;

namespace PruebaTecnica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Autos : IAutos
    {
        
        public IEnumerable<Model.Auto> ObtenerAutos()
        {
            try
            {
                var autos = Data.AutosDAL.Instance.ObtenerAutos();
                return autos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
