using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class OUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1oui.Text = "0";  //заполнение 
                m_nm1oui.Text = "0";  //TextBox
                m_np2oui.Text = "0";  // для узлов
                m_nm2oui.Text = "0";  // и        
                warning.Visible = false;
            }
        }
        protected void NextOUI_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            try
            {
                int i = Int32.Parse(m_nextoui.Text);  //номер текущего идеального опер. усилителя
                if (int.Parse(m_np1oui.Text) > GV.nv || int.Parse(m_nm1oui.Text) > GV.nv ||  //если значения введенных узлов
                    int.Parse(m_np2oui.Text) > GV.nv || int.Parse(m_nm2oui.Text) > GV.nv ||  //превышают общее число узлов или они равны
                    int.Parse(m_np1oui.Text) == int.Parse(m_nm1oui.Text) ||
                    int.Parse(m_np2oui.Text) == int.Parse(m_nm2oui.Text))
                {
                    warning.Visible = true;
                    warning.Text = "Некорректные значения узлов";
                }
                else
                {
                    
                        GV.in_oui[i, 1] = Int32.Parse(m_np1oui.Text);  //заполнение 
                        GV.in_oui[i, 2] = Int32.Parse(m_nm1oui.Text);  //массива
                        GV.in_oui[i, 3] = Int32.Parse(m_np2oui.Text);  //включений
                        GV.in_oui[i, 4] = Int32.Parse(m_nm2oui.Text);  //опер. усилителей            
                        i++;
                        m_nextoui.Text = i.ToString();  //запись в TextBox номера следующего опер. усилителя
                        if (i <= GV.noui)  //если номер текущего опер.усилителя не превышает введенное количество опер. усилителей
                        {
                            m_np1oui.Text = "0";  //заполнение 
                            m_nm1oui.Text = "0";  //TextBox
                            m_np2oui.Text = "0";  // для узлов
                            m_nm2oui.Text = "0";
                            m_np1oui.Focus();    //ставится курсор в TextBox для n1+
                        }
                        else
                        {
                            if (GV.ntri > 0)
                                Response.Redirect("TRI.aspx");
                            else Response.Redirect("Default.aspx");
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