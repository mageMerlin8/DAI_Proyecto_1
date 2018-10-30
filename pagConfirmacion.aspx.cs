using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagConfirmacion : System.Web.UI.Page
{ 
    private Carrito car;
    GestorBD.GestorBD GestorBD;
    DataSet DsPago, DsCompra, DSCanciones;
    string cadsql;
    int idUsuario, idUltCom, idNuevaComp;
    double total;
    DataRow fila;
    static int OK = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            car = (Carrito)Session["Carrito"];
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            DSCanciones = new DataSet();

            cadsql = "select * from canciones where id_cancion in " + car.listaCompras();
            GestorBD.consBD(cadsql, DSCanciones, "canciones");
            gridCompras.DataSource = DSCanciones.Tables["Canciones"];
            gridCompras.DataBind();
        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        car = (Carrito)Session["Carrito"];
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        DsPago = new DataSet();
        DsCompra = new DataSet();
        cadsql = "select sum(precio) as Total from canciones where id_cancion in " + car.listaCompras();
        GestorBD.consBD(cadsql, DsPago, "Pago");
        fila = DsPago.Tables["Pago"].Rows[0];
        total = Convert.ToDouble(fila[0].ToString());

        cadsql = "select top 1 id_compra from compras order by id_compra desc";
        GestorBD.consBD(cadsql, DsCompra, "id_compra");
        fila = DsCompra.Tables["id_compra"].Rows[0];
        idUltCom = Convert.ToUInt16(fila["id_compra"].ToString());

        idNuevaComp = idUltCom + 1;
        idUsuario = Convert.ToInt16(Session["num_usuario"].ToString());
        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
        cadsql = "insert into compras values (" + idUsuario + "," + idNuevaComp + ", '" + fecha + "', " + total + " )";
        //Falta agregar el alta de compra_canciones no se me ocurrio como hacerlo el id de la compra ya esta es idNuevaComp solo falta agregar a la table cancion por cancion con ese id_compra
        if (GestorBD.altaBD(cadsql) == OK)
        {
            if (GestorBD.altaBD(car.insertaCancionesStr(idNuevaComp)) == OK)
                Server.Transfer("pagCompraExitosa.aspx");

        }
        else
        {

        }
    }
}