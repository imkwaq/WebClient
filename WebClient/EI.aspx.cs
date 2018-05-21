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
            }
        }
        protected void NextEI_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextei.Text); //номер текущего ИНУН
            GV.in_ei[i, 0] = int.Parse(m_np1ei.Text);
            GV.in_ei[i, 1] = int.Parse(m_nm1ei.Text);
            GV.in_ei[i, 2] = int.Parse(m_np2ei.Text);
            GV.in_ei[i, 3] = int.Parse(m_nm2ei.Text);            
            GV.z_ei[i, 0] = float.Parse(m_t1ei.Text);
            GV.z_ei[i, 1] = float.Parse(m_t2ei.Text);
            GV.z_ei[i, 2] = float.Parse(m_zei.Text);
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