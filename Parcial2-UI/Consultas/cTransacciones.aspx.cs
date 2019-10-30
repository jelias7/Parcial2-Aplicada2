using BLL;
using Entidades;
using Parcial2_UI.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2_UI.Consultas
{
    public partial class cTransacciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DesdeFecha.Text = DateTime.Today.ToString("yyyy-MM-dd");
                HastaFecha.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            Expression<Func<Transacciones, bool>> filtros = x => true;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();

            DateTime Desde = Utils.ToDateTime(DesdeFecha.Text);
            DateTime Hasta = Utils.ToDateTime(HastaFecha.Text);

            int filtro;
            filtro = Utils.ToInt(CriterioTextBox.Text);

            if (CheckBoxFecha.Checked == true)
            {
                switch (FiltroDropDown.SelectedIndex)
                {
                    case 0: //Todo
                        break;
                    case 1: //ID                  
                        filtros = c => c.TransaccionId == filtro && c.Fecha >= Desde && c.Fecha <= Hasta;
                        break;
                    case 2: //Tipo
                        filtros = c => c.Tipo.Contains(CriterioTextBox.Text) && c.Fecha >= Desde && c.Fecha <= Hasta;
                        break;
                    case 3: //Monto
                        filtros = c => c.Monto == filtro && c.Fecha >= Desde && c.Fecha <= Hasta;
                        break;
                }
            }
            else
            {
                switch (FiltroDropDown.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:                  
                        filtros = c => c.TransaccionId == filtro;
                        break;
                    case 2:
                        filtros = c => c.Tipo.Contains(CriterioTextBox.Text);
                        break;
                    case 3:
                        filtros = c => c.Monto == filtro;
                        break;
                }
            }
            Grid.DataSource = repositorio.GetList(filtros);
            Grid.DataBind();
        }
    }
}