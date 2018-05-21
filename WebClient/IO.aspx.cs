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
            }
        }
        protected void OK_Click(object sender, EventArgs e)
        {
            GV.lp = Int32.Parse(m_lp.Text);
            GV.lm = Int32.Parse(m_lm.Text);
            GV.kp = Int32.Parse(m_kp.Text);
            GV.km = Int32.Parse(m_km.Text);
            Response.Redirect("Default.aspx");
        }
    }
}