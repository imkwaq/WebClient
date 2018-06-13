using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class TU : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_tunz.Text = "0";  //заполнение TextBox для узлов
                m_tuns.Text = "0";
                m_tuni.Text = "0";
                m_zturc.Text = "0";
                m_ztuczi.Text = "0"; //и для значений параметров ид. трансформатора нулями
                m_ztuczs.Text = "0";
                m_ztucsi.Text = "0";
                m_ztus.Text = "0";
                warning.Visible = false;
            }
        }

        protected void NextTU_Click(object sender, EventArgs e)
        {

            warning.Visible = false;
            try
            {
                
                int i = Int32.Parse(m_nexttu.Text);  //номер текущего у/п транзистора
                if (int.Parse(m_tunz.Text) > GV.nv || int.Parse(m_tuns.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_tuni.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_tunz.Text) == int.Parse(m_tuns.Text) ||
                    int.Parse(m_tunz.Text) == int.Parse(m_tuni.Text) ||
                    int.Parse(m_tuns.Text) == int.Parse(m_tuni.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if (float.Parse(m_zturc.Text) == 0 || float.Parse(m_ztuczi.Text) == 0 || float.Parse(m_ztuczs.Text) == 0 || float.Parse(m_ztucsi.Text) == 0 ) //если введенные значения сопротивлений равны нулю
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректные значения cопротивления или емкостей";
                    }
                    else
                    {
                        GV.in_tu[i, 0] = Int32.Parse(m_tunz.Text);  //заполнение массива
                        GV.in_tu[i, 1] = Int32.Parse(m_tuns.Text);  //включений ид. трансформатора
                        GV.in_tu[i, 2] = Int32.Parse(m_tuni.Text);
                        GV.z_tu[i, 0] = Single.Parse(m_zturc.Text);  //заполнение вектора значений параметра
                        GV.z_tu[i, 1] = Single.Parse(m_ztuczi.Text);  //заполнение вектора значений параметра
                        GV.z_tu[i, 2] = Single.Parse(m_ztuczs.Text);  //заполнение вектора значений параметра
                        GV.z_tu[i, 3] = Single.Parse(m_ztucsi.Text);  //заполнение вектора значений параметра
                        GV.z_tu[i, 4] = Single.Parse(m_ztus.Text);  //заполнение вектора значений параметра
                        i++;
                        m_nexttu.Text = i.ToString();  //запись в TextBox номера следующего ид. трансформатора
                        if (i <= GV.ntu)  //если номер текущего ид. трансформатора не превышает введенное количество ид. трансформаторов
                        {
                            m_tunz.Text = "0";  //заполнение TextBox для узлов
                            m_tuns.Text = "0";
                            m_tuni.Text = "0";
                            m_zturc.Text = "0";
                            m_ztuczi.Text = "0"; //и для значений параметров ид. трансформатора нулями
                            m_ztuczs.Text = "0";
                            m_ztucsi.Text = "0";
                            m_ztus.Text = "0";
                            m_tunz.Focus();    //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.nou > 0)
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