using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Data
{
    public class AutosDAL
    {
        private static AutosDAL instance = null;
        private string dbConnectionName = "Prueba";
        protected AutosDAL()
        {

        }

        public static AutosDAL Instance {
            get
            {
                if (instance == null)
                    instance = new AutosDAL();
                return instance;
            }
        }
        public IEnumerable<Model.Auto> ObtenerAutos()
        {
            ConnectionManager ConnectionManagerInstance = new ConnectionManager();
            string spName = "usp_ConsultaAutos";
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection(dbConnectionName))
            {
                var resultado = connection.Query<Model.Auto,
                                         Model.Marca,
                                         Model.Auto>(
                     spName,
                     (a, b) =>
                     {
                         a.Marca = (Model.Marca)b;
                         return a;
                     },
                     splitOn: "IdAuto,IdMarca",
                     commandType: CommandType.StoredProcedure);

                return resultado;

            }
        }
    }
}