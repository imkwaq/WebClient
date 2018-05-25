using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class EI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1ei.Text = "0";  //заполнение   
                m_nm1ei.Text = "0";  //TextBox
                m_np2ei.Text = "0";  // для узлов
                m_nm2ei.Text = "0";  // и
                m_t1ei.Text = "0";
                m_t2ei.Text = "0";
                m_zei.Text = "0";   //для значений
                warning.Visible = false;
            }
        }
        protected void NextEI_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = int.Parse(m_nextei.Text); //номер текущего ИНУН
                if (int.Parse(m_np1ei.Text) > GV.nv || int.Parse(m_nm1ei.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_np2ei.Text) > GV.nv || int.Parse(m_nm2ei.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_np1ei.Text) == int.Parse(m_nm1ei.Text) ||
                    int.Parse(m_np2ei.Text) == int.Parse(m_nm2ei.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if ((float.Parse(m_t1ei.Text) == 0 & float.Parse(m_t1ei.Text) == float.Parse(m_t2ei.Text)) || //если одновременно Т1 и Т2 равно нулю
                        (float.Parse(m_t2ei.Text) == 0 & float.Parse(m_t2ei.Text) == float.Parse(m_t1ei.Text)))
                    {
                        warning.Visible = true;
                        warning.Text = "Значения T1 и T2 не могут быть одновременно равны нулю, так как источник частотно-зависимый";
                    }
                    else
                    {
                        GV.in_ei[i, 0] = int.Parse(m_np1ei.Text);
                        GV.in_ei[i, 1] = int.Parse(m_nm1ei.Text);
                        GV.in_ei[i, 2] = int.Parse(m_np2ei.Text);
                        GV.in_ei[i, 3] = int.Parse(m_nm2ei.Text);
                        GV.z_ei[i, 1] = float.Parse(m_t1ei.Text);
                        GV.z_ei[i, 2] = float.Parse(m_t2ei.Text);
                        GV.z_ei[i, 0] = float.Parse(m_zei.Text);
                        i++;
                        m_nextei.Text = i.ToString();  //запись в TextBox номера следующего ИНУН
                        if (i <= GV.nju)  //если номер текущего ИНУН не превышает введенное количество ИНУН
                        {
                            m_np1ei.Text = "0";  //заполнение   
                            m_nm1ei.Text = "0";  //TextBox
                            m_np2ei.Text = "0";  // для узлов
                            m_nm2ei.Text = "0";  // и
                            m_t1ei.Text = "0";
                            m_t2ei.Text = "0";
                            m_zei.Text = "0";   //для значений
                            m_np1ei.Focus();   //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.ntb > 0)
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