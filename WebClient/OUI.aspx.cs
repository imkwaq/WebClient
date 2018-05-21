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
            }
        }
        protected void NextOUI_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextoui.Text);  //номер текущего опер. усилителя
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
}