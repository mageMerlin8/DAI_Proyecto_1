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
        
    }
}