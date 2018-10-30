using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagCompraExitosa : System.Web.UI.Page
{
    //variables de clase
    private Carrito car;
    GestorBD.GestorBD GestorBD;
    DataSet dsGeneral, dsTotal;
    string cadsql;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            car = (Carrito)Session["Carrito"];
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            dsGeneral = new DataSet();
            dsTotal = new DataSet();
            cadsql = "select * from canciones where id_cancion in " + car.listaCompras();
            GestorBD.consBD(cadsql, dsGeneral, "canciones");
            gridCompra.DataSource = dsGeneral.Tables["canciones"];
            gridCompra.DataBind();

            cadsql = "select sum(precio) as Total from canciones where id_cancion in " + car.listaCompras();
            GestorBD.consBD(cadsql, dsTotal, "Total");
            int total = Convert.ToInt32(dsTotal.Tables["Total"].Rows[0][0].ToString());
            lblTotal.Text = lblTotal.Text + total;
        }

    }
}