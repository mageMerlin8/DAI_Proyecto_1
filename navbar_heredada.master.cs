using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class navbar_heredada : System.Web.UI.MasterPage
{

    protected GridView gridCanciones { get { return this.gridCancionesMaster; } }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddToCart_Click(object sender, EventArgs e)
    {
        Carrito car = (Carrito)Session["carrito"];
        foreach (GridViewRow row in this.gridCancionesMaster.Rows)
        {
            if (((CheckBox)row.FindControl("chkComprar")).Checked)
            {
                car.alta(Convert.ToInt32(row.Cells[0].Text));
            }
        }
        Session["carrito"] = car;
    }

    protected void btnPagar_Click(object sender, EventArgs e)
    {
        this.btnAddToCart_Click(null, null);
        Server.Transfer("pagConfirmacion.aspx");
    }
}
