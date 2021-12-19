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
    public partial class Form2 : Form
    {
        private bool O;
        private bool A;
        private bool B;
        private bool V;
        private double N;
        private double n_1;
        private double n_2;
        private double slide;
        Form5 frm5;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox_O_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                O = true;
                DB.O = O;
            }
            else
            {
                O = false;
                DB.O = O;
            }
        }

        private void checkBox_A_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                A = true;
                DB.A = A;
            }
            else
            {
                A = false;
                DB.A = A;
            }
        }

        private void checkBox_B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                B = true;
                DB.B = B;
            }
            else
            {
                B = false;
                DB.B = B;
            }
        }

        private void checkBox_V_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                V = true;
                DB.V = V;
            }
            else
            {
                V = false;
                DB.V = V;
            }
        }

        private void button_Enter_form2_Click(object sender, EventArgs e)
        {
            N = Convert.ToDouble(textBox_N.Text);
           // N = 4;
            DB.N = N;
            n_1 = Convert.ToDouble(textBox_n1.Text);
           // n_1 = 700;
            DB.n_1 = n_1;
            n_2 = Convert.ToDouble(textBox_n2.Text);
            //n_2 = 400;
            DB.n_2 = n_2;
            slide = Convert.ToDouble(textBox_skolzenie.Text);
            //slide = 0.001;
            DB.slide = slide;
            frm5 = new Form5();
            frm5.Show();
        }

    }
}
