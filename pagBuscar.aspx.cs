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
    GestorBD.GestorBD gestor;
    DataSet dsGeneral = new DataSet();
    string cadsql;

    private const int OK = 1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {

    }
}