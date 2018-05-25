using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

namespace WebClient
{
    public partial class FILE_READ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void ReadFile_Click(object sender, EventArgs e)
        {
            //GV.filename = Server.MapPath("~/DATA/") + TextBox1.Text + ".txt";
            GV.filename = Server.MapPath("~/Tests/") + TextBox1.Text + ".txt";
            StreamReader fin;
            fin = new StreamReader(GV.filename);
            //fin = new StreamReader("D:\\File\\test.txt");
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s = str.Split(sep, 14);//объявление вектора строк, считанных из файла
            GV.nv = Int32.Parse(s[0]);  //запись переменных количества узлов и компонентов их вектора строк 
            GV.nr = Int32.Parse(s[1]);
            GV.nc = Int32.Parse(s[2]);
            GV.nl = Int32.Parse(s[3]);
            GV.nju = Int32.Parse(s[4]);
            GV.nji = Int32.Parse(s[5]);
            GV.neu = Int32.Parse(s[6]);
            GV.nei = Int32.Parse(s[7]);
            GV.ntb = Int32.Parse(s[8]);
            GV.ntu = Int32.Parse(s[9]);
            GV.nou = Int32.Parse(s[10]);
            GV.ntr = Int32.Parse(s[11]);
            GV.noui = Int32.Parse(s[12]);
            GV.ntri = Int32.Parse(s[13]);

            //Создание объектов
            GV.in_r = new int[GV.nr + 1, 2];  //создание массивов включений
            GV.z_r = new float[GV.nr + 1];   //создание векторов (массивов) значений параметров компонентов

            GV.in_c = new int[GV.nc + 1, 2];
            GV.z_c = new float[GV.nc + 1];

            GV.in_l = new int[GV.nl + 1, 2];
            GV.z_l = new float[GV.nl + 1];

            GV.in_ju = new int[GV.nju + 1, 4];
            GV.z_ju = new float[GV.nju + 1, 3];

            GV.in_eu = new int[GV.neu + 1, 4];
            GV.z_eu = new float[GV.neu + 1, 3];

            GV.in_ji = new int[GV.nji + 1, 4];
            GV.z_ji = new float[GV.nji + 1, 3];           

            GV.in_ei = new int[GV.nei + 1, 4];
            GV.z_ei = new float[GV.nei + 1, 3];

            GV.in_tb = new int[GV.ntb + 1, 3];
            GV.z_tb = new float[GV.ntb + 1, 6];

            GV.in_tu = new int[GV.ntu + 1, 3];
            GV.z_tu = new float[GV.ntu + 1, 5];

            GV.in_ou = new int[GV.nou + 1, 5];
            GV.z_ou = new float[GV.nou + 1, 4];

            GV.in_tr = new int[GV.ntr + 1, 4];
            GV.z_tr = new float[GV.ntr + 1, 5];

            GV.in_oui = new int[GV.noui + 1, 5];

            GV.in_tri = new int[GV.ntri + 1, 4];
            GV.z_tri = new float[GV.ntri + 1];

            //Ввод описания компонентов
            for (int i = 1; i <= GV.nr; i++)  //для всех резиторов
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);  //создание вектора строк из входной строки
                GV.in_r[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_r[i, 1] = Int32.Parse(s[1]);
                GV.z_r[i] = Single.Parse(s[2]);  //и вектор значений параметра
            }
            for (int i = 1; i <= GV.nc; i++)  //для всех конденсаторов
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);  //создание вектора строк из входной строки
                GV.in_c[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_c[i, 1] = Int32.Parse(s[1]);
                GV.z_c[i] = Single.Parse(s[2]);  //и вектор значений параметра
            }
            for (int i = 1; i <= GV.nl; i++)  //для всех индуктивностей
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);  //создание вектора строк из входной строки
                GV.in_l[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_l[i, 1] = Int32.Parse(s[1]);
                GV.z_l[i] = Single.Parse(s[2]);  //и вектор значений параметра
            }
            for (int i = 1; i <= GV.nju; i++)  //для всех ч/з ИТУН
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);  //создание вектора строк из входной строки
                GV.in_ju[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_ju[i, 1] = Int32.Parse(s[1]);
                GV.in_ju[i, 2] = Int32.Parse(s[2]);
                GV.in_ju[i, 3] = Int32.Parse(s[3]);
                GV.z_ju[i, 0] = Single.Parse(s[4]);  //и массив значений параметров
                GV.z_ju[i, 1] = Single.Parse(s[5]);
                GV.z_ju[i, 2] = Single.Parse(s[6]);
            }
            for (int i = 1; i <= GV.neu; i++)  //для всех ч/з ИНУН
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);  //создание вектора строк из входной строки
                GV.in_eu[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_eu[i, 1] = Int32.Parse(s[1]);
                GV.in_eu[i, 2] = Int32.Parse(s[2]);
                GV.in_eu[i, 3] = Int32.Parse(s[3]);
                GV.z_eu[i, 0] = Single.Parse(s[4]);  //и массив значений параметров
                GV.z_eu[i, 1] = Single.Parse(s[5]);
                GV.z_eu[i, 2] = Single.Parse(s[6]);
            }
            for (int i = 1; i <= GV.nji; i++)  //для всех ч/з ИТУТ
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);  //создание вектора строк из входной строки
                GV.in_ji[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_ji[i, 1] = Int32.Parse(s[1]);
                GV.in_ji[i, 2] = Int32.Parse(s[2]);
                GV.in_ji[i, 3] = Int32.Parse(s[3]);
                GV.z_ji[i, 0] = Single.Parse(s[4]);  //и вектор значений параметра
                GV.z_ji[i, 1] = Single.Parse(s[5]);
                GV.z_ji[i, 2] = Single.Parse(s[6]);
            }
            for (int i = 1; i <= GV.nei; i++)  //для всех ч/з ИТУН
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);  //создание вектора строк из входной строки
                GV.in_ei[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_ei[i, 1] = Int32.Parse(s[1]);
                GV.in_ei[i, 2] = Int32.Parse(s[2]);
                GV.in_ei[i, 3] = Int32.Parse(s[3]);
                GV.z_ei[i, 0] = Single.Parse(s[4]);  //и вектор значений параметра
                GV.z_ei[i, 1] = Single.Parse(s[5]);
                GV.z_ei[i, 2] = Single.Parse(s[6]);
            }
            for (int i = 1; i <= GV.ntb; i++)  //для всех биполярных транзисторов
            {
                str = fin.ReadLine();
                s = str.Split(sep, 9);  //создание вектора строк из входной строки
                GV.in_tb[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_tb[i, 1] = Int32.Parse(s[1]);
                GV.in_tb[i, 2] = Int32.Parse(s[2]);
                GV.z_tb[i, 0] = Single.Parse(s[3]);  //и вектор значений параметра
                GV.z_tb[i, 1] = Single.Parse(s[4]);
                GV.z_tb[i, 2] = Single.Parse(s[5]);
                GV.z_tb[i, 3] = Single.Parse(s[6]);
                GV.z_tb[i, 4] = Single.Parse(s[7]);
                GV.z_tb[i, 5] = Single.Parse(s[8]);
            }
            for (int i = 1; i <= GV.ntu; i++)  //для всех униполярных транзисторов
            {
                str = fin.ReadLine();
                s = str.Split(sep, 8);  //создание вектора строк из входной строки
                GV.in_tu[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_tu[i, 1] = Int32.Parse(s[1]);
                GV.in_tu[i, 2] = Int32.Parse(s[2]);
                GV.z_tu[i, 0] = Single.Parse(s[3]);  //и вектор значений параметра
                GV.z_tu[i, 1] = Single.Parse(s[4]);
                GV.z_tu[i, 2] = Single.Parse(s[5]);
                GV.z_tu[i, 3] = Single.Parse(s[6]);
                GV.z_tu[i, 4] = Single.Parse(s[7]);
            }
            for (int i = 1; i <= GV.nou; i++)  //для всех опер. усилителей
            {
                str = fin.ReadLine();
                s = str.Split(sep, 8);  //создание вектора строк из входной строки
                GV.in_ou[i, 1] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_ou[i, 2] = Int32.Parse(s[1]);
                GV.in_ou[i, 3] = Int32.Parse(s[2]);
                GV.in_ou[i, 4] = Int32.Parse(s[3]);
                GV.z_ou[i, 0] = Single.Parse(s[4]);  //и массив значений параметров
                GV.z_ou[i, 1] = Single.Parse(s[5]);
                GV.z_ou[i, 2] = Single.Parse(s[6]);
                GV.z_ou[i, 3] = Single.Parse(s[7]);
            }
            for (int i = 1; i <= GV.ntr; i++)  //для всех трансформаторов
            {
                str = fin.ReadLine();
                s = str.Split(sep, 9);  //создание вектора строк из входной строки
                GV.in_tr[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_tr[i, 1] = Int32.Parse(s[1]);
                GV.in_tr[i, 2] = Int32.Parse(s[2]);
                GV.in_tr[i, 3] = Int32.Parse(s[3]);
                GV.z_tr[i, 0] = Single.Parse(s[4]);  //и вектор значений параметра
                GV.z_tr[i, 1] = Single.Parse(s[5]);  //и вектор значений параметра
                GV.z_tr[i, 2] = Single.Parse(s[6]);  //и вектор значений параметра
                GV.z_tr[i, 3] = Single.Parse(s[7]);  //и вектор значений параметра
                GV.z_tr[i, 4] = Single.Parse(s[8]);  //и вектор значений параметра
            }
            for (int i = 1; i <= GV.noui; i++)  //для всех идеальных опер. усилителей
            {
                str = fin.ReadLine();
                s = str.Split(sep, 4);  //создание вектора строк из входной строки
                GV.in_ou[i, 1] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_ou[i, 2] = Int32.Parse(s[1]);
                GV.in_ou[i, 3] = Int32.Parse(s[2]);
                GV.in_ou[i, 4] = Int32.Parse(s[3]);
            }
            for (int i = 1; i <= GV.ntri; i++)  //для всех ид. трансформаторов
            {
                str = fin.ReadLine();
                s = str.Split(sep, 5);  //создание вектора строк из входной строки
                GV.in_tri[i, 0] = Int32.Parse(s[0]);  //запись элементов вектора в массив включений
                GV.in_tri[i, 1] = Int32.Parse(s[1]);
                GV.in_tri[i, 2] = Int32.Parse(s[2]);
                GV.in_tri[i, 3] = Int32.Parse(s[3]);
                GV.z_tri[i] = Single.Parse(s[4]);  //и вектор значений параметра
            }
            fin.Close();  //закрытие fin

            Response.Redirect("Default.aspx");
        }
    }
}