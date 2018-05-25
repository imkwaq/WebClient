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
                warning.Visible = false;
            }
        }
        protected void RadioChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Text == "Единственная частотная точка")
            {
                warning.Visible = false;
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
                warning.Visible = false;
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
                warning.Visible = false;
                m_f1.Text = "0";
                m_f2.Text = "0";
                m_f3.Text = "0";
                GV.m_f = 2;
                m_t1.Text = "Минимальная частота Fmin(кгц)";
                m_t2.Text = "Максимальная частота Fmax(кгц)";
                m_t3.Text = "Отношение соседних частот K";
                m_f2.Visible = true;
                m_f2.Visible = true;
                m_f3.Visible = true;
                m_t2.Visible = true;
                m_t3.Visible = true;
            }


        }
        protected void EnterF_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            float fmin, fmax, df, kk;
            int kf;
            switch (GV.m_f)
            {
                case 0:
                    warning.Visible = false;
                    //GV.f[1] = (float)Convert.ToDouble(m_f1.Text);
                    GV.f[1] = Single.Parse(m_f1.Text);
                    GV.nf = 1;
                    break;
                case 1:
                    warning.Visible = false;
                    if (float.Parse(m_f3.Text) <= 0) //если шаг изменения частоты меньше или равен нулю
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректное значение шага изменения частоты dF(кГц)";
                    }
                    else
                    {
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
                        Response.Redirect("Default.aspx");
                    }                    
                    break;
                case 2:
                    warning.Visible = false;
                    if (float.Parse(m_f3.Text) == 1 || float.Parse(m_f3.Text) == 0) //если отношени соседних частот равно 0 или 1
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректное значение отношения соседних частот K";
                    }
                    else
                    {
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
                        Response.Redirect("Default.aspx");
                    }                    
                    break;
            }
        }
    }
}