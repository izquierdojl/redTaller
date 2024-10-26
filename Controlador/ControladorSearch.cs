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
        SearchDB db;

        public ControladorSearch(string opcion, string tabla)
        {
            this.opcion = opcion;
            this.tabla = tabla;
        }

        public int Load()
        {
            int idSelect = 0;

            db = new SearchDB();

            Dictionary<string, CampoInfo> dc = new Dictionary<string, CampoInfo>();

            if (opcion == "CodigoPostal")
            {
                dc.Add("codigo", new CampoInfo { SelectCampo = "codigopostal.codigo", VisibleTabla = true, Header = "Código" });
                dc.Add("nombre", new CampoInfo { SelectCampo = "codigopostal.nombre", VisibleTabla = true, Header = "Nombre" });
                dc.Add("provincia", new CampoInfo { SelectCampo = "( SELECT provincia.nombre FROM provincia WHERE provincia.codigo=codigopostal.cod_provincia )", VisibleTabla = true, Header = "Nombre" });
                dc.Add("id", new CampoInfo { SelectCampo = "codigopostal.id", VisibleTabla = false, Header = "Id" });
            }

            db.dc = dc;

            VistaListaSearch vistaListaSearch = new VistaListaSearch(db.Load(tabla, null), dc, this);
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
