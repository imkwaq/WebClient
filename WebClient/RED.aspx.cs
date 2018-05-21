using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// <summary>
///исправить нумерацию z1,z2,z3
///и редактирования
///в соответствии с тем, как записываются данные в size
/// </summary>
namespace WebClient
{
    public partial class RED : Page
    {
        public static int k, m;
        string i1, i2, i3, i4, i5, i6, i7, i8, i9, i10; //переменные для вывода текста в элементы "Label"

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_n.Text = "1";
                m_np1.Text = "0";  //оставляем элементы "TextBox" в форме пустыми
                m_nm1.Text = "0";
                m_np2.Text = "0";
                m_nm2.Text = "0";
                m_z1.Text = "0";
                m_z2.Text = "0";
                m_z3.Text = "0";
                m_z4.Text = "0";
                m_z5.Text = "0";
                m_z6.Text = "0";
                m_n.Text = "1";  //номер текущего компонета изначально выставляется равным 1
                i1 = "n+";
                i2 = "n-";
                i3 = "Значение";
                IDC_NP2_STATIC.Text = i1;
                IDC_NM2_STATIC.Text = i2;
                IDC_Z1_STATIC.Text = i3;

                m_np2.Visible = true;
                m_nm2.Visible = true;
                IDC_NP2_STATIC.Visible = true;
                IDC_NM2_STATIC.Visible = true;
                m_z1.Visible = true;
                IDC_Z1_STATIC.Visible = true;


                m_np1.Visible = false;
                m_nm1.Visible = false;
                m_z2.Visible = false;
                m_z3.Visible = false;
                m_z4.Visible = false;
                m_z5.Visible = false;
                m_z6.Visible = false;
                warning.Visible = false;
                warning.Visible = false;

                IDC_NP1_STATIC.Visible = false;
                IDC_NM1_STATIC.Visible = false;
                IDC_Z2_STATIC.Visible = false;
                IDC_Z3_STATIC.Visible = false;
                IDC_Z4_STATIC.Visible = false;
                IDC_Z5_STATIC.Visible = false;
                IDC_Z6_STATIC.Visible = false;
                m_n.Focus();
            }
        }
        protected void RadioR_CheckedChanged(object sender, EventArgs e)
        {
            m = 0;
            m_n.Text = "1";  //номер текущего компонета изначально выставляется равным 1
            i1 = "n+";
            i2 = "n-";
            i3 = "Значение";
            IDC_NP2_STATIC.Text = i1;
            IDC_NM2_STATIC.Text = i2;
            IDC_Z1_STATIC.Text = i3;

            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            IDC_Z1_STATIC.Visible = true;

            m_np1.Visible = false;
            m_nm1.Visible = false;
            m_z2.Visible = false;
            m_z3.Visible = false;
            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            warning.Visible = false;

            IDC_NP1_STATIC.Visible = false;
            IDC_NM1_STATIC.Visible = false;
            IDC_Z2_STATIC.Visible = false;
            IDC_Z3_STATIC.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;
            m_n.Focus();
        }
        protected void RadioC_CheckedChanged(object sender, EventArgs e)
        {
            m = 1;
            m_n.Text = "1";  //номер текущего компонета изначально выставляется равным 1
            i1 = "n+";
            i2 = "n-";
            i3 = "Значение";
            IDC_NP2_STATIC.Text = i1;
            IDC_NM2_STATIC.Text = i2;
            IDC_Z1_STATIC.Text = i3;

            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            IDC_Z1_STATIC.Visible = true;

            m_np1.Visible = false;
            m_nm1.Visible = false;
            m_z2.Visible = false;
            m_z3.Visible = false;
            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            warning.Visible = false;

            IDC_NP1_STATIC.Visible = false;
            IDC_NM1_STATIC.Visible = false;
            IDC_Z2_STATIC.Visible = false;
            IDC_Z3_STATIC.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;
            m_n.Focus();
        }

        protected void RadioL_CheckedChanged(object sender, EventArgs e)
        {
            m = 2;
            m_n.Text = "1";  //номер текущего компонета изначально выставляется равным 1
            i1 = "n+";
            i2 = "n-";
            i3 = "Значение";
            IDC_NP2_STATIC.Text = i1;
            IDC_NM2_STATIC.Text = i2;
            IDC_Z1_STATIC.Text = i3;

            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            IDC_Z1_STATIC.Visible = true;

            m_np1.Visible = false;
            m_nm1.Visible = false;
            m_z2.Visible = false;
            m_z3.Visible = false;
            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            warning.Visible = false;

            IDC_NP1_STATIC.Visible = false;
            IDC_NM1_STATIC.Visible = false;
            IDC_Z2_STATIC.Visible = false;
            IDC_Z3_STATIC.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;
            m_n.Focus();
        }
        protected void RadioJU_CheckedChanged(object sender, EventArgs e)
        {
            m = 3;
            m_n.Text = "1";   //номер текущего ИТУН изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "T1";  //и параметров
            i6 = "T2";
            i7 = "y0";
            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;   //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;    //и параметров
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;
            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;

            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента

        }

        protected void RadioEU_CheckedChanged(object sender, EventArgs e)
        {
            m = 4;
            m_n.Text = "1";    //номер текущего ИНУН изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "T1";  //и параметра
            i6 = "T2";
            i7 = "nu";
            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;


            
            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioJI_CheckedChanged(object sender, EventArgs e)
        {
            m = 5;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "T1";  //и параметра
            i6 = "T2";
            i7 = "beta";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;

            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;

            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioEI_CheckedChanged(object sender, EventArgs e)
        {
            m = 6;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "T1";  //и параметра
            i6 = "T2";
            i7 = "zeta";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;

            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;

            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioTB_CheckedChanged(object sender, EventArgs e)
        {
            m = 7;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "Узел ne";  //отображение в элементах "Label" 
            i2 = "Узел nc";  //названий узлов
            i3 = "Узел nb";
            i5 = "Rb";  //и параметра
            i6 = "Re";
            i7 = "Rc";
            i8 = "Ce";
            i9 = "Cc";
            i10 = "beta";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            //IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;
            IDC_Z4_STATIC.Text = i8;  //и параметра
            IDC_Z5_STATIC.Text = i9;
            IDC_Z6_STATIC.Text = i10;


            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;

            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;
            m_z4.Visible = true;
            IDC_Z4_STATIC.Visible = true;
            m_z5.Visible = true;            
            IDC_Z5_STATIC.Visible = true;
            m_z6.Visible = true;
            IDC_Z6_STATIC.Visible = true;

            m_nm2.Visible = false;
            IDC_NM2_STATIC.Visible = false;           
                        
            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioTU_CheckedChanged(object sender, EventArgs e)
        {
            m = 8;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "Узел nz";  //отображение в элементах "Label" 
            i2 = "Узел ns";  //названий узлов
            i3 = "Узел ni";
            i5 = "Rc";  //и параметра
            i6 = "Czi";
            i7 = "Czs";
            i8 = "Csi";
            i9 = "S";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            //IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;
            IDC_Z4_STATIC.Text = i8;  //и параметра
            IDC_Z5_STATIC.Text = i9;


            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;           
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;

            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;
            m_z4.Visible = true;
            IDC_Z4_STATIC.Visible = true;
            m_z5.Visible = true;
            IDC_Z5_STATIC.Visible = true;

            m_nm2.Visible = false;
            IDC_NM2_STATIC.Visible = false;

            m_z6.Visible = false;
            IDC_Z6_STATIC.Visible = false;                       

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioOU_CheckedChanged(object sender, EventArgs e)
        {
            m = 9;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "Ri";
            i6 = "Ro";
            i7 = "m";
            i8 = "ft";


            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;
            IDC_Z4_STATIC.Text = i8;  //и параметра

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;            
            m_z4.Visible = true;
            IDC_Z4_STATIC.Visible = true;

            m_z5.Visible = false;
            m_z6.Visible = false;            
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioTR_CheckedChanged(object sender, EventArgs e)
        {
            m = 10;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "R1";  //и параметра
            i6 = "R2";
            i7 = "L1";
            i8 = "L2";  //и параметра
            i9 = "M";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            IDC_Z2_STATIC.Text = i6;
            IDC_Z3_STATIC.Text = i7;
            IDC_Z4_STATIC.Text = i8;
            IDC_Z5_STATIC.Text = i9;

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            m_z1.Visible = true;
            m_z2.Visible = true;
            m_z3.Visible = true;
            IDC_Z1_STATIC.Visible = true;
            IDC_Z2_STATIC.Visible = true;
            IDC_Z3_STATIC.Visible = true;

            m_z4.Visible = true;
            m_z5.Visible = true;
            IDC_Z4_STATIC.Visible = true;
            IDC_Z5_STATIC.Visible = true;

            
            m_z6.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioOUI_CheckedChanged(object sender, EventArgs e)
        {
            m = 11;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;


            m_z1.Visible = false;
            m_z2.Visible = false;
            m_z3.Visible = false;
            IDC_Z1_STATIC.Visible = false;
            IDC_Z2_STATIC.Visible = false;
            IDC_Z3_STATIC.Visible = false;

            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void RadioTRI_CheckedChanged(object sender, EventArgs e)
        {
            m = 12;
            m_n.Text = "1";    //номер текущего ИТУТ изначально выставляется равным 1
            i1 = "n1+";  //отображение в элементах "Label" 
            i2 = "n1-";  //названий узлов
            i3 = "n2+";
            i4 = "n2-";
            i5 = "n";  //и параметра
            //i6 = "T2";
            //i7 = "n";

            IDC_NP1_STATIC.Text = i1;   //отображение в элементах "TextBox" 
            IDC_NM1_STATIC.Text = i2;  //названий узлов
            IDC_NP2_STATIC.Text = i3;
            IDC_NM2_STATIC.Text = i4;
            IDC_Z1_STATIC.Text = i5;  //и параметра
            //IDC_Z2_STATIC.Text = i6;
            //IDC_Z3_STATIC.Text = i7;

            warning.Visible = false;

            m_np1.Visible = true;
            m_nm1.Visible = true;
            m_np2.Visible = true;
            m_nm2.Visible = true;
            m_z1.Visible = true;
            IDC_NP1_STATIC.Visible = true;
            IDC_NM1_STATIC.Visible = true;
            IDC_NP2_STATIC.Visible = true;
            IDC_NM2_STATIC.Visible = true;
            IDC_Z1_STATIC.Visible = true;

            m_z2.Visible = false;
            m_z3.Visible = false;
            IDC_Z2_STATIC.Visible = false;
            IDC_Z3_STATIC.Visible = false;

            m_z4.Visible = false;
            m_z5.Visible = false;
            m_z6.Visible = false;
            IDC_Z4_STATIC.Visible = false;
            IDC_Z5_STATIC.Visible = false;
            IDC_Z6_STATIC.Visible = false;

            m_n.Focus();  //курсор в TextBox с номером элемента
        }
        protected void Out_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            k = Int32.Parse(m_n.Text);
            switch (m)
            {
                case 0:
                    if (k <= GV.nr)
                    {
                        m_np2.Text = GV.in_r[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm2.Text = GV.in_r[k, 1].ToString();  //элементами массива включений
                        m_z1.Text = GV.z_r[k].ToString();    //и вектора значений параметра
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        k = 0;
                    }
                    break;
                case 1:
                    if (k <= GV.nc)
                    {
                        m_np2.Text = GV.in_c[k, 0].ToString();//заполнение элементов TextBox 
                        m_nm2.Text = GV.in_c[k, 1].ToString();  //элементами массива включений
                        m_z1.Text = GV.z_c[k].ToString();    //и вектора значений параметра
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        k = 0;
                    }
                    break;
                case 2:
                    if (k <= GV.nl)
                    {
                        m_np2.Text = GV.in_l[k, 0].ToString();//заполнение элементов TextBox 
                        m_nm2.Text = GV.in_l[k, 1].ToString();  //элементами массива включений
                        m_z1.Text = GV.z_l[k].ToString();    //и вектора значений параметра
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        k = 0;
                    }
                    break;
                case 3:
                    if (k <= GV.nju)
                    {
                        m_np1.Text = GV.in_ju[k, 0].ToString();//заполнение элементов TextBox 
                        m_nm1.Text = GV.in_ju[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_ju[k, 2].ToString();
                        m_nm2.Text = GV.in_ju[k, 3].ToString();
                        m_z1.Text = GV.z_ju[k, 0].ToString();    //и массива значений параметров
                        m_z2.Text = GV.z_ju[k, 1].ToString();
                        m_z3.Text = GV.z_ju[k, 2].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента�");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        k = 0;
                    }
                    break;
                case 4:
                    if (k <= GV.neu)
                    {
                        m_np1.Text = GV.in_eu[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_eu[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_eu[k, 2].ToString();
                        m_nm2.Text = GV.in_eu[k, 3].ToString();
                        m_z1.Text = GV.z_eu[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_eu[k, 1].ToString();
                        m_z3.Text = GV.z_eu[k, 2].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        k = 0;
                    }                    
                    break;
                case 5:
                    if (k <= GV.nji)
                    {
                        m_np1.Text = GV.in_ji[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_ji[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_ji[k, 2].ToString();
                        m_nm2.Text = GV.in_ji[k, 3].ToString();
                        m_z1.Text = GV.z_ji[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_ji[k, 1].ToString();
                        m_z3.Text = GV.z_ji[k, 2].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        k = 0;
                    }
                    break;
                case 6:
                    if (k <= GV.nei)
                    {
                        m_np1.Text = GV.in_ei[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_ei[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_ei[k, 2].ToString();
                        m_nm2.Text = GV.in_ei[k, 3].ToString();
                        m_z1.Text = GV.z_ei[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_ei[k, 1].ToString();
                        m_z3.Text = GV.z_ei[k, 2].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        k = 0;
                    }
                    break;
                case 7:
                    if (k <= GV.ntb)
                    {
                        m_np1.Text = GV.in_tb[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_tb[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_tb[k, 2].ToString();
                        m_z1.Text = GV.z_tb[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_tb[k, 1].ToString();
                        m_z3.Text = GV.z_tb[k, 2].ToString();
                        m_z4.Text = GV.z_tb[k, 3].ToString();
                        m_z5.Text = GV.z_tb[k, 4].ToString();
                        m_z6.Text = GV.z_tb[k, 5].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        m_z4.Text = "0";
                        m_z5.Text = "0";
                        m_z6.Text = "0";
                        k = 0;
                    }
                    break;
                case 8:
                    if (k <= GV.ntu)
                    {
                        m_np1.Text = GV.in_tu[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_tu[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_tu[k, 2].ToString();
                        m_z1.Text = GV.z_tu[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_tu[k, 1].ToString();
                        m_z3.Text = GV.z_tu[k, 2].ToString();
                        m_z4.Text = GV.z_tu[k, 3].ToString();
                        m_z5.Text = GV.z_tu[k, 4].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        m_z4.Text = "0";
                        m_z5.Text = "0";
                        k = 0;
                    }
                    break;
                case 9:
                    if (k <= GV.nou)
                    {
                        m_np1.Text = GV.in_ou[k, 1].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_ou[k, 2].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_ou[k, 3].ToString();
                        m_nm2.Text = GV.in_ou[k, 4].ToString();
                        m_z1.Text = GV.z_ou[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_ou[k, 1].ToString();
                        m_z3.Text = GV.z_ou[k, 2].ToString();
                        m_z4.Text = GV.z_ou[k, 3].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        m_z4.Text = "0";
                        k = 0;
                    }
                    break;
                case 10:
                    if (k <= GV.ntr)
                    {
                        m_np1.Text = GV.in_tr[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_tr[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_tr[k, 2].ToString();
                        m_nm2.Text = GV.in_tr[k, 3].ToString();
                        m_z1.Text = GV.z_tr[k, 0].ToString();    //и вектора значений параметра
                        m_z2.Text = GV.z_tr[k, 1].ToString();
                        m_z3.Text = GV.z_tr[k, 2].ToString();
                        m_z4.Text = GV.z_tr[k, 3].ToString();
                        m_z5.Text = GV.z_tr[k, 4].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        m_z2.Text = "0";
                        m_z3.Text = "0";
                        m_z4.Text = "0";
                        m_z5.Text = "0";
                        k = 0;
                    }
                    break;
                case 11:
                    if (k <= GV.noui)
                    {
                        m_np1.Text = GV.in_oui[k, 1].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_oui[k, 2].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_oui[k, 3].ToString();
                        m_nm2.Text = GV.in_oui[k, 4].ToString();
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        k = 0;
                    }
                    break;
                case 12:
                    if (k <= GV.ntri)
                    {
                        m_np1.Text = GV.in_tri[k, 0].ToString();  //заполнение элементов TextBox 
                        m_nm1.Text = GV.in_tri[k, 1].ToString();  //элементами массива включений
                        m_np2.Text = GV.in_tri[k, 2].ToString();
                        m_nm2.Text = GV.in_tri[k, 3].ToString();
                        m_z1.Text = GV.z_tri[k].ToString();    //и вектора значений параметра
                    }
                    else
                    {
                        //Response.Write("Ошибка в задании номера компонента");
                        warning.Visible = true;
                        warning.Text = "Ошибка в задании номера компонента";
                        m_n.Text = "0";
                        m_np1.Text = "0";
                        m_nm1.Text = "0";
                        m_np2.Text = "0";
                        m_nm2.Text = "0";
                        m_z1.Text = "0";
                        k = 0;
                    }
                    break;
            }
        }
        protected void In_Click(object sender, EventArgs e)
        {
            k = Int32.Parse(m_n.Text);

            switch (m)
            {
                case 0:
                    GV.in_r[k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_r[k, 1] = Int32.Parse(m_nm2.Text);
                    GV.z_r[k] = Single.Parse(m_z1.Text);
                    break;
                case 1:
                    GV.in_c[k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_c[k, 1] = Int32.Parse(m_nm2.Text);
                    GV.z_c[k] = Single.Parse(m_z1.Text);
                    break;
                case 2:
                    GV.in_l[k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_l[k, 1] = Int32.Parse(m_nm2.Text);
                    GV.z_l[k] = Single.Parse(m_z1.Text);
                    break;
                case 3:
                    GV.in_ju[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_ju[k, 1] = int.Parse(m_nm1.Text);  //ИТУН
                    GV.in_ju[k, 2] = int.Parse(m_np2.Text);
                    GV.in_ju[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_ju[k, 0] = float.Parse(m_z1.Text);  //заполнение массива значений параметров
                    GV.z_ju[k, 1] = float.Parse(m_z2.Text);
                    GV.z_ju[k, 2] = float.Parse(m_z3.Text);
                    break;
                case 4:
                    GV.in_eu[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_eu[k, 1] = int.Parse(m_nm1.Text);  //ИНУН
                    GV.in_eu[k, 2] = int.Parse(m_np2.Text);
                    GV.in_eu[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_eu[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_eu[k, 1] = float.Parse(m_z2.Text);
                    GV.z_eu[k, 2] = float.Parse(m_z3.Text);
                    break;
                case 5:
                    GV.in_ji[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_ji[k, 1] = int.Parse(m_nm1.Text);  //ИТУТ
                    GV.in_ji[k, 2] = int.Parse(m_np2.Text);
                    GV.in_ji[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_ji[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_ji[k, 1] = float.Parse(m_z2.Text);
                    GV.z_ji[k, 2] = float.Parse(m_z3.Text);                    
                    break;
                case 6:
                    GV.in_ei[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_ei[k, 1] = int.Parse(m_nm1.Text);  //ИНУТ
                    GV.in_ei[k, 2] = int.Parse(m_np2.Text);
                    GV.in_ei[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_ei[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_ei[k, 1] = float.Parse(m_z2.Text);
                    GV.z_ei[k, 2] = float.Parse(m_z3.Text);
                    break;
                case 7:
                    GV.in_tb[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_tb[k, 1] = int.Parse(m_nm1.Text);  //б/п транзисторы
                    GV.in_tb[k, 2] = int.Parse(m_np2.Text);
                    GV.in_tb[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_tb[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_tb[k, 1] = float.Parse(m_z2.Text);
                    GV.z_tb[k, 2] = float.Parse(m_z3.Text);
                    GV.z_tb[k, 3] = float.Parse(m_z4.Text);  //заполнение вектора значения параметра
                    GV.z_tb[k, 4] = float.Parse(m_z5.Text);
                    GV.z_tb[k, 5] = float.Parse(m_z6.Text);
                    break;
                case 8:
                    GV.in_tu[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_tu[k, 1] = int.Parse(m_nm1.Text);  //у/п транзисторы
                    GV.in_tu[k, 2] = int.Parse(m_np2.Text);
                    GV.in_tu[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_tu[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_tu[k, 1] = float.Parse(m_z2.Text);
                    GV.z_tu[k, 2] = float.Parse(m_z3.Text);
                    GV.z_tu[k, 3] = float.Parse(m_z4.Text);
                    GV.z_tu[k, 4] = float.Parse(m_z5.Text);
                    break;
                case 9:
                    GV.in_ou[k, 1] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_ou[k, 2] = int.Parse(m_nm1.Text);  //операционных усилителей
                    GV.in_ou[k, 3] = int.Parse(m_np2.Text);
                    GV.in_ou[k, 4] = int.Parse(m_nm2.Text);
                    GV.z_ou[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_ou[k, 1] = float.Parse(m_z2.Text);
                    GV.z_ou[k, 2] = float.Parse(m_z3.Text);
                    GV.z_ou[k, 3] = float.Parse(m_z3.Text);
                    break;
                case 10:
                    GV.in_tr[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_tr[k, 1] = int.Parse(m_nm1.Text);  //трансформаторов
                    GV.in_tr[k, 2] = int.Parse(m_np2.Text);
                    GV.in_tr[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_tr[k, 0] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    GV.z_tr[k, 1] = float.Parse(m_z2.Text);
                    GV.z_tr[k, 2] = float.Parse(m_z3.Text);
                    GV.z_tr[k, 3] = float.Parse(m_z4.Text);
                    GV.z_tr[k, 4] = float.Parse(m_z5.Text);
                    break;
                case 11:
                    GV.in_oui[k, 1] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_oui[k, 2] = int.Parse(m_nm1.Text);  //идеальных операционных усилителей
                    GV.in_oui[k, 3] = int.Parse(m_np2.Text);
                    GV.in_oui[k, 4] = int.Parse(m_nm2.Text);
                    break;
                case 12:
                    GV.in_tri[k, 0] = int.Parse(m_np1.Text);  //заполнение массива включений  
                    GV.in_tri[k, 1] = int.Parse(m_nm1.Text);  //идеальных трансформаторов
                    GV.in_tri[k, 2] = int.Parse(m_np2.Text);
                    GV.in_tri[k, 3] = int.Parse(m_nm2.Text);
                    GV.z_tri[k] = float.Parse(m_z1.Text);  //заполнение вектора значения параметра
                    break;

            }
        }
    }
}