using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class F : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_f1.Text = "0";
                m_f2.Text = "0";
                m_f3.Text = "0";
            }
        }
        protected void RadioChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Text == "Единственная частотная точка")
            {
                m_f1.Text = "0";
                GV.m_f = 0;
                m_t1.Text = "Значение частоты (кГц)";
                m_t2.Text = "";
                m_t3.Text = "";
                m_f2.Visible = true;
                m_f2.Visible = false;
                m_f3.Visible = false;
                m_t2.Visible = false;
                m_t3.Visible = false;
            }

            else if (r.Text == "Линейный закон изменения частоты")
            {
                m_f1.Text = "0";
                m_f2.Text = "0";
                m_f3.Text = "0";
                GV.m_f = 1;
                m_t1.Text = "Минимальная частота Fmin(кгц)";
                m_t2.Text = "Максимальная частота Fmax(кгц)";
                m_t3.Text = "Шаг изменения частоты dF(кгц)";
                m_f2.Visible = true;
                m_f2.Visible = true;
                m_f3.Visible = true;
                m_t2.Visible = true;
                m_t3.Visible = true;
            }
            else
            {
                m_f1.Text = "0";
                m_f2.Text = "0";
                m_f3.Text = "0";
                GV.m_f = 2;
                m_t1.Text = "Минимальная частота Fmin(кгц)";
                m_t2.Text = "Максимальная частота Fmax(кгц)";
                m_t3.Text = "Шаг изменения частоты dF(кгц)";
                m_f2.Visible = true;
                m_f2.Visible = true;
                m_f3.Visible = true;
                m_t2.Visible = true;
                m_t3.Visible = true;
            }


        }
        protected void EnterF_Click(object sender, EventArgs e)
        {

            float fmin, fmax, df, kk;
            int kf;
            switch (GV.m_f)
            {
                case 0:
                    GV.f[1] = Single.Parse(m_f1.Text);
                    GV.nf = 1;
                    break;
                case 1:
                    fmin = GV.f[1] = Single.Parse(m_f1.Text);
                    fmax = Single.Parse(m_f2.Text);
                    df = Single.Parse(m_f3.Text);
                    kf = 1;
                    while (GV.f[kf] < fmax)
                    {
                        GV.f[kf + 1] = GV.f[kf] + df;
                        kf = kf + 1;
                    }
                    GV.nf = kf;
                    break;
                case 2:
                    GV.f[1] = Single.Parse(m_f1.Text);
                    fmax = Single.Parse(m_f2.Text);
                    kk = Single.Parse(m_f3.Text);
                    kf = 1;
                    while (GV.f[kf] < fmax)
                    {
                        GV.f[kf + 1] = kk * GV.f[kf];
                        kf = kf + 1;
                    }
                    GV.nf = kf;
                    break;
            }
            Response.Redirect("Default.aspx");
        }
    }
}