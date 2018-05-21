using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Size1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_nv.Text = "0";
                m_nr.Text = "0";
                m_nc.Text = "0";
                m_nl.Text = "0";
                m_nju.Text = "0";
                m_nji.Text = "0";
                m_nei.Text = "0";
                m_neu.Text = "0";
                m_nou.Text = "0";
                m_noui.Text = "0";
                m_ntb.Text = "0";
                m_ntu.Text = "0";
                m_ntr.Text = "0";
                m_ntri.Text = "0";
            }
        }

        protected void EnterDATA_Click(object sender, EventArgs e)
        {
            GV.nv = Int32.Parse(m_nv.Text); // Количество узлов
            GV.nr = Int32.Parse(m_nr.Text); // Количество резисторов
            GV.nc = Int32.Parse(m_nc.Text); // Количество конденсаторов
            GV.nl = Int32.Parse(m_nl.Text); // Количество индуктивностей
            GV.nju = Int32.Parse(m_nju.Text); // Количество ИТУН
            GV.neu = Int32.Parse(m_neu.Text); // Количество ИНУН
            GV.nji = Int32.Parse(m_nji.Text); // Количество ИТУТ
            GV.nei = Int32.Parse(m_nei.Text);  // Количество ИНУТ
            GV.ntb = Int32.Parse(m_ntb.Text);  // Количество б/п транзисторов
            GV.ntu = Int32.Parse(m_ntu.Text);  // Количество у/п транзисторов
            GV.nou = Int32.Parse(m_nou.Text);  // Количество операционных усилителей
            GV.ntr = Int32.Parse(m_ntr.Text); // Количество трансформаторов
            GV.noui = Int32.Parse(m_noui.Text); // Количество ид. операционных усилителей
            GV.ntri = Int32.Parse(m_ntri.Text);  // Количество ид. трансформаторов

            GV.in_r = new int[GV.nr + 1, 2];
            GV.in_c = new int[GV.nc + 1, 2];
            GV.in_l = new int[GV.nl + 1, 2];
            GV.in_ju = new int[GV.nju + 1, 4];
            GV.in_eu = new int[GV.neu + 1, 4];
            GV.in_ji = new int[GV.nji + 1, 4];
            GV.in_ei = new int[GV.nei + 1, 4];
            GV.in_tb = new int[GV.ntb + 1, 3];
            GV.in_tu = new int[GV.ntu + 1, 3];
            GV.in_ou = new int[GV.nou + 1, 5];
            GV.in_oui = new int[GV.noui + 1, 5];
            GV.in_tr = new int[GV.ntr + 1, 4];
            GV.in_tri = new int[GV.ntri + 1, 4];

            GV.z_r = new float[GV.nr + 1];
            GV.z_c = new float[GV.nc + 1];
            GV.z_l = new float[GV.nl + 1];
            GV.z_ju = new float[GV.nju + 1, 3];
            GV.z_ji = new float[GV.nji + 1, 3];
            GV.z_eu = new float[GV.neu + 1, 3];
            GV.z_ei = new float[GV.nei + 1, 3];

            GV.z_ou = new float[GV.nou + 1, 4];            
            GV.z_tri = new float[GV.ntri + 1];

            //GV.z_oui = new float[GV.noui + 1, 4];
            GV.z_tb = new float[GV.ntb + 1, 6];
            GV.z_tu = new float[GV.ntu + 1, 5];
            GV.z_tr = new float[GV.ntr + 1, 5];

            if (GV.nr > 0)
                Response.Redirect("R.aspx");
            else if (GV.nc > 0)
                Response.Redirect("C.aspx");
            else if (GV.nl > 0)
                Response.Redirect("L.aspx");
            else if (GV.nju > 0)
                Response.Redirect("JU.aspx");
            else if (GV.neu > 0)
                Response.Redirect("EU.aspx");
            else if (GV.nji > 0)
                Response.Redirect("JI.aspx");
            else if (GV.nei > 0)
                Response.Redirect("EI.aspx");
            else if (GV.ntb > 0)
                Response.Redirect("TB.aspx");
            else if (GV.ntu > 0)
                Response.Redirect("TU.aspx");
            else if (GV.nou > 0)
                Response.Redirect("OU.aspx");
            else if (GV.ntr > 0)
                Response.Redirect("TR.aspx");
            else if (GV.noui > 0)
                Response.Redirect("OUI.aspx");
            else if (GV.ntri > 0)
                Response.Redirect("TRI.aspx");
            else Response.Redirect("Default.aspx");
        }
        protected void m_nv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}