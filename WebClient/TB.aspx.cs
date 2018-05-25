using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class TB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_tbne.Text = "0";  //заполнение TextBox для узлов
                m_tbnc.Text = "0";
                m_tbnb.Text = "0";
                m_ztbrb.Text = "0";
                m_ztbre.Text = "0"; //и для значений параметров ид. трансформатора нулями
                m_ztbrc.Text = "0";
                m_ztbce.Text = "0";
                m_ztbcc.Text = "0";
                m_ztbb.Text = "0";
                warning.Visible = false;
            }
        }

        protected void NextTB_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = Int32.Parse(m_nexttb.Text);  //номер текущего б/п транзистора
                if (int.Parse(m_tbnc.Text) > GV.nv || int.Parse(m_tbne.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_tbnb.Text) > GV.nv  ||  //превышают общее число узлов или они равны
                    int.Parse(m_tbnc.Text) == int.Parse(m_tbne.Text)  ||
                    int.Parse(m_tbnc.Text) == int.Parse(m_tbnb.Text) ||
                    int.Parse(m_tbnb.Text) == int.Parse(m_tbne.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if (float.Parse(m_ztbrb.Text) == 0 || float.Parse(m_ztbre.Text) == 0 || float.Parse(m_ztbrc.Text) == 0 || float.Parse(m_ztbcc.Text) == 0 || float.Parse(m_ztbce.Text) == 0) //если введенные значения сопротивлений равны нулю
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректные значения cопротивлений или емкостей";
                    }
                    else
                    {
                        GV.in_tb[i, 0] = Int32.Parse(m_tbne.Text);  //заполнение массива
                        GV.in_tb[i, 1] = Int32.Parse(m_tbnc.Text);  //включений ид. трансформатора
                        GV.in_tb[i, 2] = Int32.Parse(m_tbnb.Text);
                        GV.z_tb[i, 0] = Single.Parse(m_ztbrb.Text);  //заполнение вектора значений параметра
                        GV.z_tb[i, 1] = Single.Parse(m_ztbre.Text);  //заполнение вектора значений параметра
                        GV.z_tb[i, 2] = Single.Parse(m_ztbrc.Text);  //заполнение вектора значений параметра
                        GV.z_tb[i, 3] = Single.Parse(m_ztbce.Text);  //заполнение вектора значений параметра
                        GV.z_tb[i, 4] = Single.Parse(m_ztbcc.Text);  //заполнение вектора значений параметра
                        GV.z_tb[i, 5] = Single.Parse(m_ztbb.Text);  //заполнение вектора значений параметра
                        i++;
                        m_nexttb.Text = i.ToString();  //запись в TextBox номера следующего ид. трансформатора
                        if (i <= GV.ntb)  //если номер текущего ид. трансформатора не превышает введенное количество ид. трансформаторов
                        {
                            m_tbne.Text = "0";  //заполнение TextBox для узлов
                            m_tbnc.Text = "0";
                            m_tbnb.Text = "0";
                            m_ztbrb.Text = "0";
                            m_ztbre.Text = "0"; //и для значений параметров ид. трансформатора нулями
                            m_ztbrc.Text = "0";
                            m_ztbce.Text = "0";
                            m_ztbcc.Text = "0";
                            m_ztbb.Text = "0";
                            m_tbne.Focus();    //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.ntu > 0)
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