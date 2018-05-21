using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient
{
    public class GV
    {
        public static int MF = 20;
        public static int nv, nr, nc, nl, nju, nji, nei, neu, ntb, ntu, noui, ntr, ntri, nou, nf, lp, lm, kp, km, k, m_f, n;
        public static int[,] in_r;
        public static int[,] in_c;
        public static int[,] in_l;
        public static int[,] in_ju;     //массив включений ч/з ИТУН
        public static int[,] in_eu;     //массив включений ч/з ИНУН
        public static int[,] in_ji;   //массив включений ч/з ИТУТ
        public static int[,] in_ei;   //массив включений ч/з ИНУТ
        public static int[,] in_oui;    //массив включений идеальных опер. усилителей
        public static int[,] in_tri;    //массив включений идеальных транформаторов
        public static int[,] in_tr;     //массив включений трансформаторов
        public static int[,] in_tb;     //массив включений б/п транзисторов
        public static int[,] in_tu;     //массив включений у/п транзисторов
        public static int[,] in_ou;     //массив включений реальных опер. усилителей

        public static float[] z_r;
        public static float[] z_c;
        public static float[] z_l;
        public static float[,] z_ju;    //массив значений параметров ч/з ИТУН
        public static float[,] z_eu;    //массив значений параметров ч/з ИНУН
        public static float[,] z_ji;   //массив значений параметров ч/з ИТУТ
        public static float[,] z_ei;   //массив значений параметров ч/з ИНУТ
        public static float[] z_tri;    //массив значений идеальных транформаторов
        public static float[,] z_tr;    //массив значений трансформаторов
        public static float[,] z_tb;    //массив значений б/п транзисторов
        public static float[,] z_tu;    //массив значений у/п транзисторов
        public static float[,] z_ou;    //массив значений реальных опер. усилителей
        //public static float[,] z_oui;    //массив значений ид. опер. усилителей

        public static float[] f = new float[MF + 1];
        public static float[] kum = new float[MF + 1];
        public static float[] kua = new float[MF + 1];
        public static float[] rim = new float[MF + 1];
        public static float[] ria = new float[MF + 1];
        public static float[] rom = new float[MF + 1];
        public static float[] roa = new float[MF + 1];
        // public static Complex s;
        //public static Complex[,] w;
        public static String filename;
        public static bool flag = false;
        public static int[] In_r;
        public static int[] In_c;
        public static int[] In_l;
        public static int[] In_ju;
        public static int[] In_eu;
        //public static int[] In_jufi;
        //public static int[] In_eufi;
        public static int[] In_ji;
        public static int[] In_ei;
        public static int[] In_oui;
        public static int[] In_tri;
        //public static int[] In_tr;
        //public static int[] In_tb;
        //public static int[] In_tu;
        public static int[] In_ou;

        //public static float[] Z_r;
        //public static float[] Z_c;
        //public static float[] Z_l;
        public static float[] Z_ju;
        public static float[] Z_eu;
        //public static float[] Z_jufi;
        //public static float[] Z_eufi;
        public static float[] Z_ji;
        public static float[] Z_ei;
        //public static float[] Z_oui;
        //public static float[] Z_tri;
        //public static float[] Z_tr;
        //public static float[] Z_tb;
        //public static float[] Z_tu;
        public static float[] Z_ou;
        public static float[] Out = new float[6 * MF + 1];

        public GV()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}