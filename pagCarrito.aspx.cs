using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagCarrito2 : System.Web.UI.Page
{
    //Variables de clase. 
    private Carrito car;

    private GestorBD.GestorBD gestorBD;

    private DataSet DSCancionestemp = new DataSet();
    private DataSet DSCanciones = new DataSet();

    private DataRow fila;

    private DataTable carritoTB;

    private String sql;

    private int idC;

    private GridView gridCanciones;


    protected void Page_Load(object sender, EventArgs e)
    {
        //saca el grid de la pagina maestra
        this.gridCanciones = Master.gridCanciones;
        car = (Carrito)Session["Carrito"];
        gestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        carritoTB = DSCanciones.Tables.Add("Carrito");

        for (int i = 0; i < car.getNum(); i++)
        {
            idC = car.getID(i);
            sql = ("Select * from Canciones where id_cancion = " + idC);
            gestorBD.consBD(sql, DSCancionestemp, "CarritoTemp");
            fila = DSCancionestemp.Tables["CarritoTemp"].Rows[0];
            DSCanciones.Tables["Carrito"].Rows.Add(fila);
            gridCanciones.DataSource = DSCanciones;
            gridCanciones.DataBind();

            //fila=DSCancionestemp.Tables["Carrito"].Rows[i];
            // gridCanciones.Rows[i]. = fila;
        }
        Master.gridCanciones = gridCanciones;
    }
}