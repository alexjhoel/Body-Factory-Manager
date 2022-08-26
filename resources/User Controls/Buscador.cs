using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Buscador : UserControl
    {


        private FiltroBusqeda[] filtrosPrefijados;
        Action<FiltroBusqeda> buscar; 
        Action descartar;
        public Buscador(Action <FiltroBusqeda> buscar, Action descartar, FiltroBusqeda[] filtrosPrefijados)
        {
            InitializeComponent();
            busqueda1ADTP.Hide();
            busqueda1BDTP.Hide();
            busqueda2ADTP.Hide();
            busqueda2BDTP.Hide();
            busqueda1ANUD.Hide();
            busqueda1BNUD.Hide();
            busqueda2ANUD.Hide();
            busqueda2BNUD.Hide();
            this.filtrosPrefijados = filtrosPrefijados;
            foreach (FiltroBusqeda filtro in filtrosPrefijados)
            {
                filtro1CBX.Items.Add(filtro.textoAMostrar);
            }
            filtro1CBX.SelectedIndex = 0;
            this.buscar = buscar;
            this.descartar = descartar;

        }

        private void filtro1CBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambioFiltro();

        }

        private void CambioFiltro()
        {
            if (filtrosPrefijados[filtro1CBX.SelectedIndex].tipo == TipoFiltro.String)
            {
                busqueda1ADTP.Hide();
                busqueda1BDTP.Hide();
                busqueda1ANUD.Hide();
                busqueda1BNUD.Hide();
            }
            if (filtrosPrefijados[filtro1CBX.SelectedIndex].tipo == TipoFiltro.Numero)
            {
                busqueda1ADTP.Hide();
                busqueda1BDTP.Hide();
                busqueda1BNUD.Hide();
            }
            if (filtrosPrefijados[filtro1CBX.SelectedIndex].tipo == TipoFiltro.Fecha)
            {
                busqueda1BDTP.Hide();
                busqueda1ANUD.Hide();
                busqueda1BNUD.Hide();
            }
            if (filtrosPrefijados[filtro1CBX.SelectedIndex].tipo == TipoFiltro.NumeroRango)
            {
                busqueda1ADTP.Hide();
                busqueda1BDTP.Hide();

            }
            if (filtrosPrefijados[filtro1CBX.SelectedIndex].tipo == TipoFiltro.FechaRango)
            {
                busqueda1ANUD.Hide();
                busqueda1BNUD.Hide();
            }
        }


        private void buscarBTN_Click(object sender, EventArgs e)
        {
            FiltroBusqeda filtro1 = new FiltroBusqeda("",filtrosPrefijados[filtro1CBX.SelectedIndex].propiedad,
                filtrosPrefijados[filtro1CBX.SelectedIndex].tipo);
            if(filtro1.tipo == TipoFiltro.String)
            {
                filtro1.valor1 = busqueda1TBX.Text;
                filtro1.valor1 = busqueda1TBX.Text;
            }
            buscar(filtro1);
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            descartar();
        }
    }

    public class FiltroBusqeda
    {
        public string textoAMostrar = "";
        public string propiedad;
        public string valor1;
        public string valor2;
        public TipoFiltro tipo = TipoFiltro.Nada;
        
        public FiltroBusqeda(string textoAMostrar,string propiedad, TipoFiltro tipo)
        {
            this.textoAMostrar = textoAMostrar;
            this.propiedad = propiedad;
            this.tipo = tipo;
            valor1 = " ";
            valor2 = " ";
        }

        public string ObtenerWhereConsulta()
        {
            if (tipo == TipoFiltro.Nada) return "1=1";
            if (tipo == TipoFiltro.String) return propiedad + " LIKE '%" + valor1 + "%'";
            if (tipo == TipoFiltro.Fecha) return "CONVERT(DATETIME, " + propiedad + ", 103) ='" + valor1 + "'";
            if (tipo == TipoFiltro.Numero) return propiedad + "=" + valor1;
            if (tipo == TipoFiltro.NumeroRango) return propiedad + " BETWEEN " + valor1 + " AND" + valor2;
            if (tipo == TipoFiltro.FechaRango) return propiedad + " BETWEEN '" + valor1 + "' AND '" + valor2 + "'";
            return "";
        }


    }

    public enum TipoFiltro
    {
        Nada,
        String,
        Fecha,
        Numero,
        NumeroRango,
        FechaRango
    }
}
