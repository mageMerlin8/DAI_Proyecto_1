using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Variables de clase
    GestorBD.GestorBD gestor;
    DataSet dsGeneral = new DataSet();
    string cadsql;

    //inicializa la ventana
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gestor = new GestorBD.GestorBD("SQLOLEDB", "112SALAS27",
              "sa", "sqladmin", "em_proyecto_1");
            Session["GestorBD"] = gestor;
        }

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //recupera el gestor de la sesion
        gestor = (GestorBD.GestorBD)Session["GestorBD"];
        //busca el usuario con email y la contraseña (valida)
        cadsql = "select * from usuarios where email = '" + Login1.UserName + "' and " +
            " contraseña = '" + Login1.Password + "' ";
        gestor.consBD(cadsql, dsGeneral, "usuario");
        if (dsGeneral.Tables["usuario"].Rows.Count != 0)
        {
            //guarda al usuario en la sesion
            Session["nombre_usuario"] = Login1.UserName;
            //crea un carrito para el usuario
            Carrito carro = new Carrito();
            Session["carrito"] = carro;
           
            Server.Transfer("pagInicio.aspx");
        }

    }
}