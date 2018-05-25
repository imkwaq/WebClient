using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class OU : System.Web.UI.Page
    {
        public int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1ou.Text = "0";  //заполнение 
                m_nm1ou.Text = "0";  //TextBox
                m_np2ou.Text = "0";  // для узлов
                m_nm2ou.Text = "0";  // и
                m_riou.Text = "0";   //для значений
                m_roou.Text = "0";   //параметров
                m_mou.Text = "0";    //опер.усилителя  
                m_ftou.Text = "0";  //нулями
                warning.Visible = false;
            }
        }

        protected void NextOU_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = Int32.Parse(m_nextou.Text);  //номер текущего опер. усилителя
                if (int.Parse(m_np1ou.Text) > GV.nv || int.Parse(m_nm1ou.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_np2ou.Text) > GV.nv || int.Parse(m_nm2ou.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_np1ou.Text) == int.Parse(m_nm1ou.Text) ||
                    int.Parse(m_np2ou.Text) == int.Parse(m_nm2ou.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if (float.Parse(m_riou.Text) == 0 || float.Parse(m_roou.Text) == 0) //если введенные значения сопротивлений равны нулю
                    {
                        warning.Visible = true;
                        warning.Text = "Некорректные значения cопротивлений";
                    }
                    else
                    {
                        GV.in_ou[i, 1] = Int32.Parse(m_np1ou.Text);  //заполнение 
                        GV.in_ou[i, 2] = Int32.Parse(m_nm1ou.Text);  //массива
                        GV.in_ou[i, 3] = Int32.Parse(m_np2ou.Text);  //включений
                        GV.in_ou[i, 4] = Int32.Parse(m_nm2ou.Text);  //опер. усилителей
                        GV.z_ou[i, 0] = Single.Parse(m_riou.Text); //заполнение 
                        GV.z_ou[i, 1] = Single.Parse(m_roou.Text); //массива
                        GV.z_ou[i, 2] = Single.Parse(m_mou.Text);  //значений параметров
                        GV.z_ou[i, 3] = Single.Parse(m_ftou.Text);  //ид.опер. усилителей 
                        i++;
                        m_nextou.Text = i.ToString();  //запись в TextBox номера следующего опер. усилителя
                        if (i <= GV.nou)  //если номер текущего опер.усилителя не превышает введенное количество опер. усилителей
                        {
                            m_np1ou.Text = "0";  //заполнение 
                            m_nm1ou.Text = "0";  //TextBox
                            m_np2ou.Text = "0";  // для узлов
                            m_nm2ou.Text = "0";  // и
                            m_riou.Text = "0";   //для значений
                            m_roou.Text = "0";   //параметров
                            m_mou.Text = "0";    //опер.усилителя  
                            m_ftou.Text = "0";  //нулями
                            m_np1ou.Focus();    //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.ntr > 0)
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