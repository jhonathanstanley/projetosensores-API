using Microsoft.Win32;
using SensoresAPI.JSON;
using SensoresAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SensoresAPI.DAO
{
    public class SensoresDAO
    {
        static sensoresEntities db = new sensoresEntities();

        public static List<sensores> FindFirst()
        {
            return db.sensores.OrderByDescending(p => new { p.dataEnvio }).ToList();
            
        }
        public static void InsertSensores(JsonSensores jsonSensores)
        {
            db.sensores.Add(new sensores
            {
                bairoo = jsonSensores.Bairro,
                cidade = jsonSensores.Cidade,
                estado = jsonSensores.Estado,
                latitude = jsonSensores.Latitude,
                longitude = jsonSensores.Longitude,
                luminosidade = jsonSensores.Luminosidade,
                pais = jsonSensores.Pais,
                proximidade = jsonSensores.Proximidade,
                rua = jsonSensores.Rua,
                temperatura = jsonSensores.Temperatura,
                umidade = jsonSensores.Umidade,
                dataEnvio = DateTime.Now
            });

            db.SaveChanges();
            
            

        }
    }
}