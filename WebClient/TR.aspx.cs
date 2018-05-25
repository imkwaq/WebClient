using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class TR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1tr.Text = "0";  //заполнение TextBox для узлов
                m_nm1tr.Text = "0";
                m_np2tr.Text = "0";
                m_nm2tr.Text = "0";
                m_ztrr1.Text = "0"; //и для значений параметров ид. трансформатора нулями
                m_ztrr2.Text = "0"; 
                m_ztrl1.Text = "0";
                m_ztrl2.Text = "0"; 
                m_ztrm.Text = "0";
                warning.Visible = false;
            }
        }

        protected void NextTR_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = Int32.Parse(m_nexttr.Text);  //номер текущего трансформатора
                if (int.Parse(m_np1tr.Text) > GV.nv || int.Parse(m_nm1tr.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_np2tr.Text) > GV.nv || int.Parse(m_nm2tr.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_np1tr.Text) == int.Parse(m_nm1tr.Text) ||
                    int.Parse(m_np2tr.Text) == int.Parse(m_nm2tr.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if (float.Parse(m_ztrr1.Text) == 0 || float.Parse(m_ztrr2.Text) == 0 || float.Parse(m_ztrl1.Text) == 0 || float.Parse(m_ztrl2.Text) == 0) //если введенные значения сопротивлений равны нулю
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректные значения cопротивлений и индуктивностей";
                    }
                    else
                    {
                        GV.in_tr[i, 0] = Int32.Parse(m_np1tr.Text);  //заполнение массива
                        GV.in_tr[i, 1] = Int32.Parse(m_nm1tr.Text);  //включений ид. трансформатора
                        GV.in_tr[i, 2] = Int32.Parse(m_np2tr.Text);
                        GV.in_tr[i, 3] = Int32.Parse(m_nm2tr.Text);
                        GV.z_tr[i, 0] = Single.Parse(m_ztrr1.Text);  //заполнение вектора значений параметра
                        GV.z_tr[i, 1] = Single.Parse(m_ztrr2.Text);  //заполнение вектора значений параметра
                        GV.z_tr[i, 2] = Single.Parse(m_ztrl1.Text);  //заполнение вектора значений параметра
                        GV.z_tr[i, 3] = Single.Parse(m_ztrl2.Text);  //заполнение вектора значений параметра
                        GV.z_tr[i, 4] = Single.Parse(m_ztrm.Text);  //заполнение вектора значений параметра
                        i++;
                        m_nexttr.Text = i.ToString();  //запись в TextBox номера следующего ид. трансформатора
                        if (i <= GV.ntr)  //если номер текущего ид. трансформатора не превышает введенное количество ид. трансформаторов
                        {
                            m_np1tr.Text = "0";  //заполнение TextBox для узлов
                            m_nm1tr.Text = "0";
                            m_np2tr.Text = "0";
                            m_nm2tr.Text = "0";
                            m_ztrr1.Text = "0"; //и для значений параметров ид. трансформатора нулями
                            m_ztrr2.Text = "0";
                            m_ztrl1.Text = "0";
                            m_ztrl2.Text = "0";
                            m_ztrm.Text = "0";
                            m_np1tr.Focus();    //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.noui > 0)
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