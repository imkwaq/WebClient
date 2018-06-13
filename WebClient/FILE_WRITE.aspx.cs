using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebClient
{
    public partial class FILE_WRITE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void WriteFile_Click(object sender, EventArgs e)
        {
            
            //GV.filename = Server.MapPath("~/DATA/") + TextBox1.Text + ".txt";
            GV.filename = Server.MapPath("~/Tests/") + TextBox1.Text + ".txt";
            StreamWriter fout = new StreamWriter(GV.filename);//создание экземпляра класса StreamWriter для заданного файла
            String str = "";  //объявление переменной для записи
            str = GV.nv.ToString() + " " + GV.nr.ToString() //запись в str через пробел количества узлов и каждого компонента
                + " " + GV.nc.ToString() + " " + GV.nl.ToString()
                + " " + GV.nju.ToString() + " " + GV.neu.ToString() + " " + GV.nji.ToString() + " " + GV.nei.ToString() + " " + GV.ntb.ToString() + " " + GV.ntu.ToString() + " " + GV.nou.ToString() + " " + GV.ntr.ToString() + " " + GV.noui.ToString() + " " + GV.ntri.ToString();
            fout.WriteLine(str);  //запись в fout
            for (int i = 1; i <= GV.nr; i++)   //для всех резисторов
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.z_r[i].ToString();   //и вектора значений параметра резисторов
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.nc; i++)   //для всех конденсаторов
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.z_c[i].ToString();  //и вектора значений параметра конденсаторов
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.nl; i++)   //для всех индуктивностей 
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " "//запись в str элементов массива включений
                    + GV.z_l[i].ToString();   //и вектора значений параметра индуктивностей
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.nju; i++)   //для всех ч/з ИТУН
            {
                str = GV.in_ju[i, 0].ToString() + " " + GV.in_ju[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_ju[i, 2].ToString() + " " + GV.in_ju[i, 3].ToString() + " "
                    + GV.z_ju[i, 0].ToString() + " " + GV.z_ju[i, 1].ToString() + " "   //и массива значений параметров ч/з ИТУН
                    + GV.z_ju[i, 2].ToString();
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.neu; i++)    //для всех ч/з ИНУН
            {
                str = GV.in_eu[i, 0].ToString() + " " + GV.in_eu[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_eu[i, 2].ToString() + " " + GV.in_eu[i, 3].ToString() + " "
                    + GV.z_eu[i, 0].ToString() + " " + GV.z_eu[i, 1].ToString() + " " + GV.z_eu[i, 2].ToString();   //и вектора значений параметра ч/н ИТУТ
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.nji; i++)    //для всех ч/з ИТУТ
            {
                str = GV.in_ji[i, 0].ToString() + " " + GV.in_ji[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_ji[i, 2].ToString() + " " + GV.in_ji[i, 3].ToString() + " "
                    + GV.z_ji[i, 0].ToString() + " " + GV.z_ji[i, 1].ToString() + " " + GV.z_ji[i, 2].ToString();   //и вектора значений параметра ч/н ИТУТ
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.nei; i++)    //для всех ч/з ИНУТ
            {
                str = GV.in_ei[i, 0].ToString() + " " + GV.in_ei[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_ei[i, 2].ToString() + " " + GV.in_ei[i, 3].ToString() + " "
                    + GV.z_ei[i, 0].ToString() + " " + GV.z_ei[i, 1].ToString() + " " + GV.z_ei[i, 2].ToString();   //и вектора значений параметра ч/н ИТУТ
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.ntb; i++)    ///для всех опер. усилителей
            {
                str = GV.in_tb[i, 0].ToString() + " " + GV.in_tb[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_tb[i, 2].ToString() + " " + GV.z_tb[i, 0].ToString() + " "
                    + GV.z_tb[i, 1].ToString() + " " + GV.z_tb[i, 2].ToString() + " "  //и массива значений параметров опер. усилителей
                    + GV.z_tb[i, 3].ToString() + " " + GV.z_tb[i, 4].ToString() + " "
                    + GV.z_tb[i, 5].ToString();
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.ntu; i++)    ///для всех опер. усилителей
            {
                str = GV.in_tu[i, 0].ToString() + " " + GV.in_tu[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_tu[i, 2].ToString() + " " + GV.z_tu[i, 0].ToString() + " "
                    + GV.z_tu[i, 1].ToString() + " " + GV.z_tu[i, 2].ToString() + " "  //и массива значений параметров опер. усилителей
                    + GV.z_tu[i, 3].ToString() + " " + GV.z_tu[i, 4].ToString();
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.nou; i++)    ///для всех опер. усилителей
            {
                str = GV.in_ou[i, 1].ToString() + " " + GV.in_ou[i, 2].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_ou[i, 3].ToString() + " " + GV.in_ou[i, 4].ToString() + " "
                    + GV.z_ou[i, 0].ToString() + " " + GV.z_ou[i, 1].ToString() + " "  //и массива значений параметров опер. усилителей
                    + GV.z_ou[i, 2].ToString() + " " + GV.z_ou[i, 3].ToString();
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.ntr; i++)    ///для всех опер. усилителей
            {
                str = GV.in_tr[i, 0].ToString() + " " + GV.in_tr[i, 1].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_tr[i, 2].ToString() + " " + GV.in_tr[i, 3].ToString() + " "
                    + GV.z_tr[i, 0].ToString() + " "  + GV.z_tr[i, 1].ToString() + " " 
                    + GV.z_tr[i, 2].ToString() + " "  + GV.z_tr[i, 3].ToString() + " " 
                    + GV.z_tr[i, 4].ToString(); //и массива значений параметров опер. усилителей
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.noui; i++)    ///для всех опер. усилителей
            {
                str = GV.in_oui[i, 1].ToString() + " " + GV.in_oui[i, 2].ToString() + " "  //запись в str элементов массива включений 
                    + GV.in_oui[i, 3].ToString() + " " + GV.in_oui[i, 4].ToString();
                fout.WriteLine(str);  //запись в fout
            }
            for (int i = 1; i <= GV.ntri; i++)    //для всех ид. трансформаторов
            {
                str = GV.in_tri[i, 0].ToString() + " " + GV.in_tri[i, 1].ToString() + " " //запись в str элементов массива включений
                    + GV.in_tri[i, 2].ToString() + " " + GV.in_tri[i, 3].ToString() + " "
                    + GV.z_tri[i].ToString();   //и вектора значений параметра ид. трансформаторов
                fout.WriteLine(str);  //запись в fout
            }

            fout.Close();  //закрытие fout

            Response.Redirect("Default.aspx");
        }
    }
}