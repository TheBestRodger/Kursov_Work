using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov_Work
{
    public partial class Form5 : Form
    {
        public double dp_1;
        public double u;
        public double dp_2;
        public double a_min;
        public double L;
        public double a;
        public double cos_alpha;
        public double v;
        public double sigmafClin;
        public double delta_sigmaf0;
        public double sigmafPClin;
        public double Z;
        public double C_1;
        public double C_2;
        public double C_3;
        Form8 frm8;

        public double shaft_dp1()
        {
            dp_1 = 110 * Math.Sqrt((DB.N * 10 * 10 * 10) / DB.n_1);
            dp_1 = Math.Round(dp_1);
            if (dp_1 > 63 && dp_1 > 90 && dp_1 > 125 && dp_1 > 200)
                dp_1 = 200;
            else if (dp_1 > 63 && dp_1 > 90 && dp_1 > 125 && dp_1 < 200)
                dp_1 = 125;
            else if (dp_1 > 63 && dp_1 > 90 && dp_1 < 125 && dp_1 < 200)
                dp_1 = 90;
            else if (dp_1 > 63 && dp_1 < 90 && dp_1 < 125 && dp_1 < 200)
                dp_1 = 63;
            else dp_1 = 63;
                return dp_1;
        }

        public double shaft_dp2()
        {
            //if (DB.upper == true)
            // dp_2 = dp_1 * (1 - DB.slide) * u;
            // else
            u = DB.n_1 / DB.n_2;
            dp_2 = (dp_1 * u) / (1 - DB.slide);
            dp_2 = Math.Round(dp_2);
            return dp_2;
        }

        public double func_L()
        {
            a_min = 1.5 * (dp_1 + dp_2);
            L = 2 * a_min + 3.14 * ((dp_1 + dp_2) / 2) + ((dp_2 - dp_1) * (dp_2 - dp_1) / 4 * a_min);
            L = Math.Round(L);
            L = 10600;
            return L;
        }
        public double func_a()
        {
            
            double limbda;
            double delta;
            double d_cp = (dp_1 + dp_2) / 2;
            limbda = L - 3.14 * d_cp;
            delta = (dp_2 - dp_1) / 2;
            a = (limbda + (limbda * limbda - 8 * delta * delta) * (1 / 2)) / 4;
            return a;
        }
        public double func_cos_alpha()
        {
            cos_alpha = 83;
            if (v <= 70) C_1 = 0.56;
            else if (v >= 70 && v <= 80) C_1 = 0.62;
            else if (v >= 80 && v <= 90) C_1 = 0.68;
            else if (v >= 90 && v <= 100) C_1 = 0.79;
            else if (v >= 100 && v <= 110) C_1 = 0.83;
            else C_1 = 0.9;

            return cos_alpha;
        }
        public double func_v()
        {
            v = (Math.PI * dp_1 * DB.n_1) / (Math.Pow(10, 3) * 60);
            v = Math.Round(v);
            if (v <= 5) C_2 = 1.04;
            else if (v >= 5 && v <= 10) C_2 = 1;
            else if (v >= 10 && v <= 15) C_2 = 0.94;
            else if (v >= 15 && v <= 20) C_2 = 0.94;
            else if (v >= 20 && v <= 25) C_2 = 0.85;
            else C_2 = 0.6;
            return v;
        }
        public double get_C_3()
        {

            if (DB.m_nagruzka_1 == true) C_3 = 1;
            else if (DB.m_nagruzka_2 == true) C_3 = 0.9;
            else if (DB.m_nagruzka_3 == true) C_3 = 0.8;
            else if (DB.m_nagruzka_4 == true) C_3 = 0.7;
            return C_3;
        }
        public double func_sigmafClin()
        {

            sigmafClin = DB.sigmaf0 * C_1 * C_2 * get_C_3();

            return sigmafClin;
        }
        public double func_delta_sigmaf0()
        {

            delta_sigmaf0 = (100 * DB.delta_sigmaf0_u) / DB.dp_1;

            return delta_sigmaf0;
        }

        public double func_Z()
        {
            double f;
            f = 10 * 10 * 10 * DB.N / v;
            Z = f / (DB.S_1 * func_sigmafClin());
            if (Z > 5) Z = 6;
            else Z = 5;
            return Z;
        }
        public Form5()
        {

            InitializeComponent();
            //
            textBox_Dp1.Text = shaft_dp1().ToString();
            textBox_Dp2.Text = shaft_dp2().ToString();
            //
            textBox_L.Text = func_L().ToString();
            textBox_a.Text = func_a().ToString();
            textBox_v.Text = func_v().ToString();
            textBox_cosalp.Text = func_cos_alpha().ToString();
            //
            textBox_sigmaf0.Text = DB.get_sigmf0().ToString();
            textBox_C1.Text = C_1.ToString();
            textBox_C2.Text = C_2.ToString();
            textBox_C3.Text = get_C_3().ToString();
            textBox_Sigma_Clin.Text = func_sigmafClin().ToString();
            textBox_Z.Text = func_Z().ToString();
            textBox_n1.Text = DB.n_1.ToString();
            textBox_n2.Text = DB.n_2.ToString();
            textBox_N.Text = DB.N.ToString();
            textBox_skolzenie.Text = DB.slide.ToString();
            //
        }

        private void button_prevs_Click(object sender, EventArgs e)
        {
            frm8 = new Form8();
            frm8.Show();
        }
    }
}
