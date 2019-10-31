using BLL;
using Entidades;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2_UI.Reportes
{
    public partial class ReporteTransacciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
                var lista = repositorio.GetList(x => true);

                MyReportViewer.ProcessingMode = ProcessingMode.Local;
                MyReportViewer.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\ListadoTransacciones.rdlc");

                MyReportViewer.LocalReport.DataSources.Add(new ReportDataSource("Transacciones", lista));
                MyReportViewer.LocalReport.Refresh();

            }
        }
    }
}