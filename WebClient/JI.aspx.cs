﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class JI : System.Web.UI.Page
    {
        public int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1ji.Text = "0";  //заполнение TextBox 
                m_nm1ji.Text = "0";  //для узлов и
                m_np2ji.Text = "0";  //для значения 
                m_nm2ji.Text = "0";  //параметра
                m_bji.Text = "0";    //нулями
                m_t1ji.Text = "0";
                m_t2ji.Text = "0";
                warning.Visible = false;
            }
        }

        protected void NextJI_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = Int32.Parse(m_nextji.Text); //номер текущего ИТУТ
                if (int.Parse(m_np1ji.Text) > GV.nv || int.Parse(m_nm1ji.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_np2ji.Text) > GV.nv || int.Parse(m_nm2ji.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_np1ji.Text) == int.Parse(m_nm1ji.Text) ||
                    int.Parse(m_np2ji.Text) == int.Parse(m_nm2ji.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    if ((float.Parse(m_t1ji.Text) == 0 & float.Parse(m_t1ji.Text) == float.Parse(m_t2ji.Text)) || //если одновременно Т1 и Т2 равно нулю
                        (float.Parse(m_t2ji.Text) == 0 & float.Parse(m_t2ji.Text) == float.Parse(m_t1ji.Text)))
                    {
                        warning.Visible = true;
                        warning.Text = "Значения T1 и T2 не могут быть одновременно равны нулю, так как источник частотно-зависимый";
                    }
                    else
                    {
                        GV.in_ji[i, 0] = Int32.Parse(m_np1ji.Text); //заполнение  
                        GV.in_ji[i, 1] = Int32.Parse(m_nm1ji.Text); //массива
                        GV.in_ji[i, 2] = Int32.Parse(m_np2ji.Text); //включений
                        GV.in_ji[i, 3] = Int32.Parse(m_nm2ji.Text); //ИТУТ     
                        GV.z_ji[i, 1] = Single.Parse(m_t1ji.Text);  //заполнение вектора значений параметра
                        GV.z_ji[i, 2] = Single.Parse(m_t2ji.Text);  //заполнение вектора значений параметра
                        GV.z_ji[i, 0] = Single.Parse(m_bji.Text);  //заполнение вектора значений параметра

                        //GV.z_ji[i, 0] = Single.Parse(m_t1ji.Text);  //заполнение вектора значений параметра
                        //GV.z_ji[i, 1] = Single.Parse(m_t2ji.Text);  //заполнение вектора значений параметра
                        //GV.z_ji[i, 2] = Single.Parse(m_bji.Text);  //заполнение вектора значений параметра
                        i++;
                        m_nextji.Text = i.ToString(); //запись в TextBox номера следующего ИТУТ

                        if (i <= GV.nji)
                        {
                            m_np1ji.Text = "0";  //заполнение TextBox 
                            m_nm1ji.Text = "0";  //для узлов и
                            m_np2ji.Text = "0";  //для значения 
                            m_nm2ji.Text = "0";  //параметра
                            m_bji.Text = "0";    //нулями
                            m_t1ji.Text = "0";
                            m_t2ji.Text = "0";
                            m_np1ji.Focus();  //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.nei > 0)
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