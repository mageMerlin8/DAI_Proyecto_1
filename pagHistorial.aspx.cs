using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagInicio : System.Web.UI.Page
{

    //variables de la clase
    protected GestorBD.GestorBD gestor;
    string cadsql;
    DataSet dsGeneral = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        calFin.SelectedDate = DateTime.Today;
        llenaGridCompras();
    }

    public void gridCompras_rowCommand(Object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "Select")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            GridViewRow seleccion = gridCompras.Rows[rowIndex];

            int idCompra = Convert.ToInt16(seleccion.Cells[2].Text);

            this.llenaGridCanciones(idCompra);
        }
    }
    protected void llenaGridCanciones(int compra)
    {
        gestor = (GestorBD.GestorBD)Session["GestorBD"];
        cadsql = "select * from canciones where id_cancion in (select id_cancion from compras_cancion where id_compra = " + compra.ToString() + ")";
        gestor.consBD(cadsql, dsGeneral, "canciones");
        gridCanciones.DataSource = dsGeneral.Tables["canciones"];
        gridCanciones.DataBind();
    }

    private void llenaGridCompras()
    {
        gestor = (GestorBD.GestorBD)Session["GestorBD"];
        string fechaIni, fechaFin;
        fechaIni = calIni.SelectedDate.ToString();
        fechaFin = calFin.SelectedDate.ToString();
        cadsql = "SELECT * FROM compras WHERE id_cliente=" + Session["num_usuario"];
        gestor.consBD(cadsql, dsGeneral, "compras");
        gridCompras.DataSource = dsGeneral.Tables["compras"];
        gridCompras.DataBind();        
    }


}