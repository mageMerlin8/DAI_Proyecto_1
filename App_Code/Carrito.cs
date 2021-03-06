﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Text;

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
    public bool isEmpty()
    {
        return clavesCanciones.Count == 0;
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

    public string listaCompras()
    {
        StringBuilder resp;
        int size = 2 + 2 * clavesCanciones.Count + 1;
        resp = new StringBuilder(size);
        resp.Append("(");
        foreach (int i in clavesCanciones)
            resp.Append(i.ToString() + ",");
        resp.Insert(size - 2, "0");
        resp.Append(")");


        return resp.ToString();
    }
    public string insertaCancionesStr(int idCompra)
    {
        string ini = "insert into compras_cancion values ( ";
        string resp = "";
        foreach(int i in clavesCanciones)
            resp = resp + ini + i + ", " + idCompra + ")";
        return resp;
    }
    
}