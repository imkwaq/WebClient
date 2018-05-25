using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class L1 : System.Web.UI.Page
    {
        public int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_npl.Text = "0";
                m_nml.Text = "0";
                m_zl.Text = "0";
                warning.Visible = false;
            }
        }

        protected void NextL_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                i = Int32.Parse(m_nextl.Text);
                if (int.Parse(m_npl.Text) > GV.nv || int.Parse(m_nml.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_npl.Text) == int.Parse(m_nml.Text)) //превышают общее число узлов или они равны
                {
                    warning.Visible = true;
                    warning.Text = "Неккоректное значение узлов схемы";
                }
                else
                {
                    if (float.Parse(m_zl.Text) == 0) //если введенное значение сопротивления равно 0
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректное значение индуктивности";
                    }
                    else
                    {
                        GV.in_l[i, 0] = Int32.Parse(m_npl.Text);
                        GV.in_l[i, 1] = Int32.Parse(m_nml.Text);
                        GV.z_l[i] = Single.Parse(m_zl.Text);
                        i++;
                        m_nextl.Text = i.ToString();
                        if (i <= GV.nl)
                        {
                            m_npl.Text = "0";
                            m_nml.Text = "0";
                            m_zl.Text = "0";
                        }
                        else
                        {
                            if (GV.nju > 0)
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
                    }
                }
            }
            catch (Exception)
            {
                warning.Visible = true;
                warning.Text = "Ошибка ввода";
            }         
        }
    }    
}