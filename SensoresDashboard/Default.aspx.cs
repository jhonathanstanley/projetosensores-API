using SensoresAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SensoresDashboard
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregarGV();
        }

        public void carregarGV()
        {
            gdvSensores.DataSource = SensoresDAO.FindFirst();
            gdvSensores.DataBind();
        }
    }
}