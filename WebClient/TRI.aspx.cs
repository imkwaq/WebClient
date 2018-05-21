using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class TRI : System.Web.UI.Page
    {
        public int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_np1tri.Text = "0";  //заполнение TextBox для узлов
                m_nm1tri.Text = "0";
                m_np2tri.Text = "0";
                m_nm2tri.Text = "0";
                m_ztri.Text = "0"; //и для значений параметров ид. трансформатора нулями
            }
        }

        protected void NextTRI_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nexttri.Text);  //номер текущего ид. трансформатора
            GV.in_tri[i, 0] = Int32.Parse(m_np1tri.Text);  //заполнение массива
            GV.in_tri[i, 1] = Int32.Parse(m_nm1tri.Text);  //включений ид. трансформатора
            GV.in_tri[i, 2] = Int32.Parse(m_np2tri.Text);
            GV.in_tri[i, 3] = Int32.Parse(m_nm2tri.Text);
            GV.z_tri[i] = Single.Parse(m_ztri.Text);  //заполнение вектора значений параметра
            i++;
            m_nexttri.Text = i.ToString();  //запись в TextBox номера следующего ид. трансформатора
            if (i <= GV.ntri)  //если номер текущего ид. трансформатора не превышает введенное количество ид. трансформаторов
            {
                m_np1tri.Text = "0";  //заполнение TextBox для узлов
                m_nm1tri.Text = "0";
                m_np2tri.Text = "0";
                m_nm2tri.Text = "0";
                m_ztri.Text = "0"; //и для значений параметров ид. трансформатора нулями
                m_np1tri.Focus();    //ставится курсор в TextBox для n1+
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}