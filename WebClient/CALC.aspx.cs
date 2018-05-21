using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebClient.MNS_Service1;


//using WebClient.Web_Service_MNS;
//using WebClient.MNS_localhost;

namespace WebClient
{
    public partial class CALC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Packing to one-dimensional array

            GV.In_r = new int[GV.nr + GV.nr + 1];
            for (int i = 1; i <= GV.nr; i++)
            {
                GV.In_r[i] = GV.in_r[i, 0];
                GV.In_r[GV.nr + i] = GV.in_r[i, 1];
            }
            GV.In_c = new int[GV.nc + GV.nc + 1];
            for (int i = 1; i <= GV.nc; i++)
            {
                GV.In_c[i] = GV.in_c[i, 0];
                GV.In_c[GV.nc + i] = GV.in_c[i, 1];
            }
            GV.In_l = new int[GV.nl + GV.nl + 1];
            for (int i = 1; i <= GV.nl; i++)
            {
                GV.In_l[i] = GV.in_l[i, 0];
                GV.In_l[GV.nl + i] = GV.in_l[i, 1];
            }
            GV.In_ju = new int[GV.nju * 4 + 1];
            for (int i = 1; i <= GV.nju; i++)
            {
                GV.In_ju[i] = GV.in_ju[i, 0];
                GV.In_ju[GV.nju + i] = GV.in_ju[i, 1];
                GV.In_ju[GV.nju * 2 + i] = GV.in_ju[i, 2];
                GV.In_ju[GV.nju * 3 + i] = GV.in_ju[i, 3];
            }
            GV.In_ji = new int[GV.nji * 4 + 1];
            for (int i = 1; i <= GV.nji; i++)
            {
                GV.In_ji[i] = GV.in_ji[i, 0];
                GV.In_ji[GV.nji + i] = GV.in_ji[i, 1];
                GV.In_ji[GV.nji * 2 + i] = GV.in_ji[i, 2];
                GV.In_ji[GV.nji * 3 + i] = GV.in_ji[i, 3];
            }
            GV.In_eu = new int[GV.neu * 4 + 1];
            for (int i = 1; i <= GV.neu; i++)
            {
                GV.In_eu[i] = GV.in_eu[i, 0];
                GV.In_eu[GV.neu + i] = GV.in_eu[i, 1];
                GV.In_eu[GV.neu * 2 + i] = GV.in_eu[i, 2];
                GV.In_eu[GV.neu * 3 + i] = GV.in_eu[i, 3];
            }

            GV.In_tri = new int[GV.ntri * 4 + 1];
            for (int i = 1; i <= GV.ntri; i++)
            {
                GV.In_tri[i] = GV.in_tri[i, 0];
                GV.In_tri[GV.ntri + i] = GV.in_tri[i, 1];
                GV.In_tri[GV.ntri * 2 + i] = GV.in_tri[i, 2];
                GV.In_tri[GV.ntri * 3 + i] = GV.in_tri[i, 3];
            }

            GV.In_ou = new int[GV.nou * 5 + 1];
            for (int i = 1; i <= GV.nou; i++)
            {
                GV.In_ou[i] = GV.in_ou[i, 0];
                GV.In_ou[GV.nou + i] = GV.in_ou[i, 1];
                GV.In_ou[GV.nou * 2 + i] = GV.in_ou[i, 2];
                GV.In_ou[GV.nou * 3 + i] = GV.in_ou[i, 3];
                GV.In_ou[GV.nou * 4 + i] = GV.in_ou[i, 4];
            }

            GV.Z_ju = new float[GV.nju * 3 + 1];
            for (int i = 1; i <= GV.nju; i++)
            {
                GV.Z_ju[i] = GV.z_ju[i, 0];
                GV.Z_ju[GV.nju + i] = GV.z_ju[i, 1];
                GV.Z_ju[GV.nju * 2 + i] = GV.z_ju[i, 2];
            }
            GV.Z_eu = new float[GV.neu * 3 + 1];
            for (int i = 1; i <= GV.neu; i++)
            {
                GV.Z_eu[i] = GV.z_eu[i, 0];
                GV.Z_eu[GV.neu + i] = GV.z_eu[i, 1];
                GV.Z_eu[GV.neu * 2 + i] = GV.z_eu[i, 2];
            }
            GV.Z_ji = new float[GV.nji * 3 + 1];
            for (int i = 1; i <= GV.nji; i++)
            {
                GV.Z_ji[i] = GV.z_ji[i, 0];
                GV.Z_ji[GV.nji + i] = GV.z_ji[i, 1];
                GV.Z_ji[GV.nji * 2 + i] = GV.z_ji[i, 2];
            }
            GV.Z_ou = new float[GV.nou * 4 + 1];
            for (int i = 1; i <= GV.nou; i++)
            {
                GV.Z_ou[i] = GV.z_ou[i, 0];
                GV.Z_ou[GV.nou + i] = GV.z_ou[i, 1];
                GV.Z_ou[GV.nou * 2 + i] = GV.z_ou[i, 2];
                GV.Z_ou[GV.nou * 3 + i] = GV.z_ou[i, 3];
            }
            #endregion

                        
            Web_Service_MNSClient client = new Web_Service_MNSClient();
            GV.Out = client.OnCalc(GV.In_r, GV.z_r, GV.nr, GV.In_c, GV.z_c, GV.nc, GV.In_l, GV.z_l, GV.nl, GV.nv, GV.lp, GV.lm, GV.kp, GV.km, GV.f, GV.nf, GV.nju, GV.In_ju, GV.Z_ju, GV.neu, GV.In_eu, GV.Z_eu, GV.nji, GV.In_ji, GV.Z_ji, GV.nou, GV.In_ou, GV.Z_ou, GV.ntri, GV.In_tri, GV.z_tri);

            client.Close();
                // , GV.neu, GV.In_eu, GV.z_eu

            for (int i = 1; i <= GV.MF; i++)
            {
                GV.kum[i] = GV.Out[i];
                GV.kua[i] = GV.Out[i + GV.MF];
                GV.rim[i] = GV.Out[i + 2 * GV.MF];
                GV.ria[i] = GV.Out[i + 3 * GV.MF];
                GV.rom[i] = GV.Out[i + 4 * GV.MF];
                GV.roa[i] = GV.Out[i + 5 * GV.MF];
            }
            
            Output(GV.f, GV.nf, GV.lp, GV.lm, GV.kp, GV.km, GV.kum, GV.kua, GV.rim, GV.ria, GV.rom, GV.roa);
        }
        private void Output(float[] f, int nf, int lp, int lm, int kp, int km, float[] kum, float[] kua, float[] rim, float[] ria, float[] rom, float[] roa)
        {
            #region Output of results

            string str = "";
            str = "Результаты моделирования";
            str += "\r\n";
            TextBox1.Text = str;
            if ((lp == 1) && (lm == 0) && (kp == 2) && (km == 0))
            {
                str += "     f кГЦ \t   kum\t       kua\trim \t \t ria \trom \t \t  roa";
                TextBox1.Text = str;
                str += "\r\n";
                //TextBox1.Text=(str + "\r\n");
                for (int kf = 1; kf <= nf; kf++)
                {
                    str += String.Format("{0,12:F2}{1,12:E2}{2,12:F2}" +
                        "{3,12:E2}{4,12:F2}{5,12:E2}{6,12:F2}",
                          f[kf], kum[kf], kua[kf], rim[kf],
                          ria[kf], rom[kf], roa[kf]);
                    str += "\r\n";
                    TextBox1.Text = str;

                }
            }
            else
            {
                str += "    f кГц  \tkum \t\t kua \t rim \t \tria";
                str += "\r\n";
                TextBox1.Text = str;
                for (int kf = 1; kf <= nf; kf++)
                {
                    str += String.Format("{0,12:F2}{1,12:E2}{2,12:F2}" +
                        "{3,12:E2}{4,12:F2}",
                            f[kf], kum[kf], kua[kf], rim[kf], ria[kf]);
                    str += "\r\n";
                    TextBox1.Text = str;
                }
            }
#endregion
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
    }
}