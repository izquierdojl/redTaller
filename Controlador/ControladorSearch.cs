using redTaller.Database;
using redTaller.Vista.VistaSearch;
using redTaller.Vista.VistaTaller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace redTaller.Controlador
{
    internal class ControladorSearch
    {

        string opcion;
        string tabla;
        string condicion;
        SearchDB db;

        public ControladorSearch(string opcion, string tabla)
        {
            this.opcion = opcion;
            this.tabla = tabla;
            this.condicion = null;
        }

        public int Load()
        {
            int idSelect = 0;

            db = new SearchDB();

            Dictionary<string, CampoInfo> dc = new Dictionary<string, CampoInfo>();

            if (opcion == "CodigoPostal" )
            {
                dc.Add("codigo", new CampoInfo { SelectCampo = "codigopostal.codigo", VisibleTabla = true, Header = "Código" });
                dc.Add("nombre", new CampoInfo { SelectCampo = "codigopostal.nombre", VisibleTabla = true, Header = "Nombre" });
                dc.Add("provincia", new CampoInfo { SelectCampo = "( SELECT provincia.nombre FROM provincia WHERE provincia.codigo=codigopostal.cod_provincia )", VisibleTabla = true, Header = "Nombre" });
                dc.Add("id", new CampoInfo { SelectCampo = "codigopostal.id", VisibleTabla = false, Header = "Id" });
            }
            else if ( opcion == "Taller" )
            {
                dc.Add("nif", new CampoInfo { SelectCampo = "taller.nif", VisibleTabla = true, Header = "NIF" });
                dc.Add("nombre", new CampoInfo { SelectCampo = "taller.nombre", VisibleTabla = true, Header = "Nombre" });
                dc.Add("pob", new CampoInfo { SelectCampo = "taller.pob", VisibleTabla = true, Header = "Población" });
                dc.Add("pro", new CampoInfo { SelectCampo = "taller.pro", VisibleTabla = true, Header = "Provincia" });
                dc.Add("id", new CampoInfo { SelectCampo = "taller.id", VisibleTabla = false, Header = "Id" });
            }
            else if (opcion == "Cliente" )
            {
                dc.Add("nif", new CampoInfo { SelectCampo = "cliente.nif", VisibleTabla = true, Header = "NIF" });
                dc.Add("nombre", new CampoInfo { SelectCampo = "cliente.nombre", VisibleTabla = true, Header = "Nombre" });
                dc.Add("pob", new CampoInfo { SelectCampo = "cliente.pob", VisibleTabla = true, Header = "Población" });
                dc.Add("pro", new CampoInfo { SelectCampo = "cliente.pro", VisibleTabla = true, Header = "Provincia" });
                dc.Add("id", new CampoInfo { SelectCampo = "cliente.id", VisibleTabla = false, Header = "Id" });
            }
            else if (opcion == "Matricula")
            {
                dc.Add("matricula", new CampoInfo { SelectCampo = "matricula.matricula", VisibleTabla = true, Header = "Matrícula" });
                dc.Add("marca", new CampoInfo { SelectCampo = "matricula.marca", VisibleTabla = true, Header = "Marca" });
                dc.Add("modelo", new CampoInfo { SelectCampo = "matricula.modelo", VisibleTabla = true, Header = "Modelo" });
                dc.Add("id", new CampoInfo { SelectCampo = "matricula.id", VisibleTabla = false, Header = "Id" });
            }

            db.dc = dc;

            VistaListaSearch vistaListaSearch = new VistaListaSearch(db.Load(tabla,null,condicion), dc, this);
            if (vistaListaSearch.ShowDialog() == DialogResult.OK)
            {
                idSelect = vistaListaSearch.SelectedId;
            }

            return idSelect;

        }

        public void filtrar(VistaListaSearch vistaListaSearch, string filtro)
        {
            vistaListaSearch.recargaGrid(db.Load(tabla, filtro));
        }

    }
}
