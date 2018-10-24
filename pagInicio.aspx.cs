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
    string msgBienvendia = "bienvenido a la aplicaciòn de venta de canciones";


    private const int OK = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //obtiene el nombre del usuario y pone el mensaje de bienvenida
            cadsql = "SELECT usuarios.nombre FROM usuarios WHERE usuarios.email = '" + Session["nombre_usuario"] + "'";
            gestor = (GestorBD.GestorBD)Session["GestorBD"];
            gestor.consBD(cadsql, dsGeneral, "usuario");
            lblBienvenida.Text = dsGeneral.Tables["usuario"].Rows[0]["nombre"] + msgBienvendia;
            this.carga_grid();
        }
    }

    private void carga_grid()
    {
        gestor = (GestorBD.GestorBD)Session["GestorBD"];
        cadsql = "SELECT canciones.* from canciones " +
                 "WHERE canciones.id_cancion in " +
                    "(SELECT TOP 5 id_cancion " +
                     "FROM compras_cancion " +
                     "GROUP BY id_cancion " +
                     "ORDER BY COUNT(compras_cancion.id_cancion) desc, id_cancion asc)";
        gestor.consBD(cadsql, dsGeneral, "canciones");
        Master.gridCanciones.DataSource = dsGeneral.Tables["canciones"];
        Master.gridCanciones.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}