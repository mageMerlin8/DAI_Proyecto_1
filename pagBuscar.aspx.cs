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
        rbCancion.Checked = true;
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        //Recupero los datos de la sesión
        gestor = (GestorBD.GestorBD)Session["GestorBD"];

        //Buscamos la canción por nombre de la canción 
        if (rbCancion.Checked)
        {
            cadsql = "Select * from canciones where nombre like '%" + txtNombre.Text + "%'";
            gestor.consBD(cadsql, dsGeneral, "Canciones");
        }
        else
        {
            cadsql = "Select * from Canciones ca, artistas a, albums al where a.nombre like '%" + txtNombre.Text + "%' and a.id_artista = al.id_artista and al.id_album = ca.id_album";
            gestor.consBD(cadsql, dsGeneral, "Canciones");
        }
        Master.gridCanciones.DataSource = dsGeneral.Tables["Canciones"];
        Master.gridCanciones.DataBind();

    }
    
}