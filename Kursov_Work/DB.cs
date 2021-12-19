using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursov_Work
{
   static class DB
    {
        //f1
        public static bool upper;
        public static bool down;

        public static bool clin;
        public static bool sclin;
        public static bool pclin;
        //f1
        //f2
        public static bool O;
        public static bool A;
        public static bool B;
        public static bool V;
        public static double N;
        public static double n_1;
        public static double n_2;
        public static double slide;
        public static double dp_1 = 0;
        //f2
        public static double shaft_dp1()
        {
            //dp_1 = 110 * Math.Sqrt((DB.N * 10 * 10 * 10) / DB.n_1);
            dp_1 = N;
            dp_1 = Math.Round(dp_1);
            return dp_1;
        }
        //f6
        public static bool first_type;
        public static bool second_type;
        public static bool m_nagruzka_1;
        public static bool m_nagruzka_2;
        public static bool m_nagruzka_3;
        public static bool m_nagruzka_4;
        //f6
        //f5
        //public static double dp_1 = Brain.shaft_dp1();
        //public static double dp_2 = Brain.shaft_dp2();
        //public static double T = 90;
        //public static double L = Brain.func_L();
        //public static double a = Brain.func_a();
        //public static double cos_alpha = Brain.func_cos_alpha();
       // public static double v = Brain.func_v();
        //public static double sigmafClin = Brain.func_sigmafClin();
        //public static double delta_sigmaf0 = Brain.func_delta_sigmaf0();
       // public static double sigmafPClin = Brain.func_sigmafPClin();
       // public static double Z = Brain.func_Z();
        // public static double n_;
        // public static double slide;
        //f5
        public static double sigmaf0 = 0;
        public static double C_3;
        public static double C_L = -1;
        public static double delta_sigmaf0_u = -888;
        public static double S_1 = 1;
        public static double S_10 = 10;
        public static double get_sigmf0()
        {
            if (O == true && A == false && B == false && V == false) sigmaf0 = 1.5;
            else if (O == true && A == true && B == false && V == false) sigmaf0 = 1.67;
            else if (O == false && A == false && B == true && V == false) sigmaf0 = 1.78;
            else if (O == false && A == false && B == false && V == true) sigmaf0 = 1.96;

            return sigmaf0;
        }
        public static double get_C_3()
        {

            if (m_nagruzka_1 == true) C_3 = 1;
            else if(m_nagruzka_2 ==true) C_3 = 0.9;
            else if (m_nagruzka_3 == true) C_3 = 0.8;
            else if (m_nagruzka_4 == true) C_3 = 0.7;
            return C_3;
        }
        public static double get_C_L()
        {
            C_L = 1;
            return C_L;
        }
        public static double func_delta_sigmaf0_u()
        {


            return delta_sigmaf0_u;
        }
        public static double get_S_1()
        {
            if (O == true && A == false && B == false && V == false) S_1 = 47;
            else if (O == true && A == true && B == false && V == false) S_1 = 81;
            else if (O == false && A == false && B == true && V == false) S_1 = 138;
            else if (O == false && A == false && B == false && V == true) S_1 = 230;
            return S_1;
        }
        public static double get_S_10()
        {

            return S_10;
        }

    }
}
