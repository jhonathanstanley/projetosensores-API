using SensoresAPI.DAO;
using SensoresAPI.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SensoresAPI.Controllers
{
    public class SensoresController : ApiController
    {
        [HttpPost]
        public string Post(JsonSensores jsonSensores)
        {
            try
            {
                SensoresDAO.InsertSensores(jsonSensores);
            }
            catch (Exception)
            {

                throw;
            }
                return "Sensores";
        }
    }
}
