using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagCarrito : System.Web.UI.Page
{
    //Variables de clase. 
    private Carrito car;

    private GestorBD.GestorBD gestorBD;
    private string cadsql;
    
    private DataSet DSCanciones = new DataSet();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        car = (Carrito)Session["Carrito"];
        gestorBD = (GestorBD.GestorBD)Session["GestorBD"];

        cadsql = "select * from canciones where id_cancion in " + car.listaCompras();
        gestorBD.consBD(cadsql, DSCanciones, "canciones");
        gridCanciones.DataSource = DSCanciones.Tables["canciones"];
        gridCanciones.DataBind();

        if (car.isEmpty())
        {
            gridCanciones.Visible = false;
            Label1.Visible = true;
            btnPagar.Visible = false;            
        }else
        {
            gridCanciones.Visible = true;
            Label1.Visible = false;
            btnPagar.Visible = true;

        }
    }
    protected void btnPagar_Clicked(object sender, EventArgs e)
    {
        Server.Transfer("pagConfirmacion.aspx");
    }

    protected void gridCanciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "Select")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selec = gridCanciones.Rows[index];
            int idCancion = Convert.ToInt32(selec.Cells[1].Text);
            car = (Carrito)Session["Carrito"];
            car.baja(idCancion);
            Server.Transfer("pagCarrito.aspx");
        }
    }
}