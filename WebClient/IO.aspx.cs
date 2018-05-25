using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class IO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_lp.Text = "0";
                m_lm.Text = "0";
                m_kp.Text = "0";
                m_km.Text = "0";
                warning.Visible = false;
            }
        }
        protected void OK_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            if (int.Parse(m_lp.Text) > GV.nv || int.Parse(m_lm.Text) > GV.nv || //если хоть один из узлов больше введенного общего числа узлов
                int.Parse(m_kp.Text) > GV.nv || int.Parse(m_km.Text) > GV.nv ||
                int.Parse(m_kp.Text) == int.Parse(m_lp.Text))// || //или входной n+ равен выходному n+)
            {
                warning.Visible = true;
                warning.Text = "Некорректные значения узлов";
            }
            else
            {
                GV.lp = Int32.Parse(m_lp.Text);
                GV.lm = Int32.Parse(m_lm.Text);
                GV.kp = Int32.Parse(m_kp.Text);
                GV.km = Int32.Parse(m_km.Text);
                Response.Redirect("Default.aspx");
            }
            
        }
    }
}