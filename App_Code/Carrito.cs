using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de Comunes
/// </summary>
public class Carrito
{

    List<int> clavesCanciones;

    public Carrito()
    {
        this.clavesCanciones = new List<int>();
    }

    public bool alta(int clave)
    {
        if (!this.clavesCanciones.Contains(clave))
        {
            this.clavesCanciones.Add(clave);
            return true;
        }
        else return false;
    }

    public bool baja(int clave)
    {
        return this.clavesCanciones.Remove(clave);
    }

    public int getNum()
    {
        return clavesCanciones.Count;
    }

    public int getID(int i)
    {
        return clavesCanciones[i];
    }
}