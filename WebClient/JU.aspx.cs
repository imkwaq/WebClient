using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class JU : System.Web.UI.Page
    {
        public int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1ju.Text = "0";  //заполнение   
                m_nm1ju.Text = "0";  //TextBox
                m_np2ju.Text = "0";  // для узлов
                m_nm2ju.Text = "0";  // и                
                m_t1ju.Text = "0";  
                m_t2ju.Text = "0";   
                m_y0ju.Text = "0";   //для значений
                warning.Visible = false;
            }
        }

        protected void NextJU_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = Int32.Parse(m_nextju.Text); //номер текущего ИТУН
                if (int.Parse(m_np1ju.Text) > GV.nv || int.Parse(m_nm1ju.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_np2ju.Text) > GV.nv || int.Parse(m_nm2ju.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_np1ju.Text) == int.Parse(m_nm1ju.Text) ||
                    int.Parse(m_np2ju.Text) == int.Parse(m_nm2ju.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if ((float.Parse(m_t1ju.Text) == 0 & float.Parse(m_t1ju.Text) == float.Parse(m_t2ju.Text)) || //если одновременно Т1 и Т2 равно нулю
                        (float.Parse(m_t2ju.Text) == 0 & float.Parse(m_t2ju.Text) == float.Parse(m_t1ju.Text)))
                    {
                        warning.Visible = true;
                        warning.Text = "Значения T1 и T2 не могут быть одновременно равны нулю, так как источник частотно-зависимый";
                    }
                    else
                    {
                        GV.in_ju[i, 0] = Int32.Parse(m_np1ju.Text);  //заполнение 
                        GV.in_ju[i, 1] = Int32.Parse(m_nm1ju.Text);  //массива
                        GV.in_ju[i, 2] = Int32.Parse(m_np2ju.Text);  //включений
                        GV.in_ju[i, 3] = Int32.Parse(m_nm2ju.Text);  //ИТУН

                        GV.z_ju[i, 1] = Single.Parse(m_t1ju.Text);  //значений параметров
                        GV.z_ju[i, 2] = Single.Parse(m_t2ju.Text);  //ИТУН
                        GV.z_ju[i, 0] = Single.Parse(m_y0ju.Text);  //заполнение массива

                        //GV.z_ju[i, 0] = Single.Parse(m_t1ju.Text);  //значений параметров
                        //GV.z_ju[i, 1] = Single.Parse(m_t2ju.Text);  //ИТУН
                        //GV.z_ju[i, 2] = Single.Parse(m_y0ju.Text);  //заполнение массива
                        i++;
                        m_nextju.Text = i.ToString();  //запись в TextBox номера следующего ИНУН
                        if (i <= GV.nju)  //если номер текущего ИНУН не превышает введенное количество ИНУН
                        {
                            m_np1ju.Text = "0";  //заполнение   
                            m_nm1ju.Text = "0";  //TextBox
                            m_np2ju.Text = "0";  // для узлов
                            m_nm2ju.Text = "0";  // и
                            m_y0ju.Text = "0";   //для значений
                            m_t1ju.Text = "0";   //параметров
                            m_t2ju.Text = "0";   //нулями
                            m_np1ju.Focus();   //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.neu > 0)
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