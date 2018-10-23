using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagInicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        Carrito car = (Carrito)Session["carrito"];
        foreach (GridViewRow row in this.gridCanciones.Rows)
        {
            if (((CheckBox)row.FindControl("chkBorrar")).Checked)
            {
                car.baja(Convert.ToInt32(row.Cells[0].Text));
            }
        }
        Session["carrito"] = car;
        Server.Transfer("pagCarrito.aspx");
    }

    protected void btnPagar_Click(object sender, EventArgs e)
    {
        this.btnBorrar_Click(null, null);
        Server.Transfer("pagConfirmacion.aspx");
    }
}