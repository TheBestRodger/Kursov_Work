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
    public partial class Form6 : Form
    {
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;
        private bool first_type;
        private bool second_type;
        //Mrak
        private bool nagruzka_1_0;
        private bool nagruzka_1_1;
        private bool nagruzka_1_2;
        private bool nagruzka_1_3;
        private bool nagruzka_1_4;
        private bool nagruzka_2_0;
        private bool nagruzka_2_1;
        private bool nagruzka_2_2;
        private bool nagruzka_2_3;
        private bool nagruzka_2_4;
        private bool nagruzka_3_0;
        private bool nagruzka_3_1;
        private bool nagruzka_3_2;
        private bool nagruzka_3_3;
        private bool nagruzka_3_4;
        private bool nagruzka_3_5;
        private bool nagruzka_3_6;
        private bool nagruzka_4_0;
        private bool nagruzka_4_1;
        private bool nagruzka_4_2;
        private bool nagruzka_4_3;
        private bool nagruzka_4_4;
        private bool nagruzka_4_5;
        //Mrak
        public Form6()
        {
            InitializeComponent();
        }

        private void button_Enter_Form6_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            if (DB.clin == true)
            {
                DB.clin = true;
                frm2.Show();
                //DB.clin = false;
            }
            else if (DB.sclin == true)
            {
                frm3.Show();
                //DB.sclin = false;
            }
            else if (DB.pclin == true)
            {
                frm4.Show();
                //DB.pclin = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали тип передачи");
            }
        }

        private void checkBox_I_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_I_CheckedChanged = (CheckBox)sender;
            if (checkBox_I_CheckedChanged.Checked == true)
            {
                first_type = true;
                DB.first_type = first_type;
            }
            else
            {
                first_type = false;
                DB.first_type = first_type;
            }
        }
        private void checkBox_II_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_II_CheckedChanged = (CheckBox)sender;
            if (checkBox_II_CheckedChanged.Checked == true)
            {
                second_type = true;
                DB.second_type = second_type;
            }
            else
            {
                second_type = false;
                DB.second_type = second_type;
            }
        }

        private void checkBox_1_1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_1_1_CheckedChanged = (CheckBox)sender;
            if (checkBox_1_1_CheckedChanged.Checked == true)
            {
                nagruzka_1_0 = true;
                DB.m_nagruzka_1 = nagruzka_1_0;
            }
            else
            {
                nagruzka_1_0 = false;
                DB.m_nagruzka_1 = nagruzka_1_0;
            }
        }
        private void checkBox_1_2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_1_2_CheckedChanged = (CheckBox)sender;
            if (checkBox_1_2_CheckedChanged.Checked == true)
            {
                nagruzka_1_1 = true;
                DB.m_nagruzka_1 = true;
            }
            else
            {
                nagruzka_1_1 = false;
                DB.m_nagruzka_1 = false;
            }
        }
        private void checkBox_1_3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_1_3_CheckedChanged = (CheckBox)sender;
            if (checkBox_1_3_CheckedChanged.Checked == true)
            {
                nagruzka_1_2 = true;
                DB.m_nagruzka_1 = true;
            }
            else
            {
                nagruzka_1_2 = false;
                DB.m_nagruzka_1 = false;
            }
        }
        private void checkBox_1_4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_1_4_CheckedChanged = (CheckBox)sender;
            if (checkBox_1_4_CheckedChanged.Checked == true)
            {
                nagruzka_1_3 = true;
                DB.m_nagruzka_1 = true;
            }
            else
            {
                nagruzka_1_3 = false;
                DB.m_nagruzka_1 = false;
            }
        }
        private void checkBox_1_5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_1_5_CheckedChanged = (CheckBox)sender;
            if (checkBox_1_5_CheckedChanged.Checked == true)
            {
                nagruzka_1_4 = true;
                DB.m_nagruzka_1 = true;
            }
            else
            {
                nagruzka_1_4 = false;
                DB.m_nagruzka_1 = false;
            }
        }

        private void checkBox_2_1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_2_1_CheckedChanged = (CheckBox)sender;
            if (checkBox_2_1_CheckedChanged.Checked == true)
            {
                nagruzka_2_0 = true;
                DB.m_nagruzka_2 = true;
            }
            else
            {
                nagruzka_2_0 = false;
                DB.m_nagruzka_2 = false;
            }
        }
        private void checkBox_2_2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_2_2_CheckedChanged = (CheckBox)sender;
            if (checkBox_2_2_CheckedChanged.Checked == true)
            {
                nagruzka_2_1 = true;
                DB.m_nagruzka_2 = true;
            }
            else
            {
                nagruzka_2_1 = false;
                DB.m_nagruzka_2 = false;
            }
        }
        private void checkBox_2_3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_2_3_CheckedChanged = (CheckBox)sender;
            if (checkBox_2_3_CheckedChanged.Checked == true)
            {
                nagruzka_2_2 = true;
                DB.m_nagruzka_2 = true;
            }
            else
            {
                nagruzka_2_2 = false;
                DB.m_nagruzka_2 = false;
            }
        }
        private void checkBox_2_4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_2_4_CheckedChanged = (CheckBox)sender;
            if (checkBox_2_4_CheckedChanged.Checked == true)
            {
                nagruzka_2_3 = true;
                DB.m_nagruzka_2 = true;
            }
            else
            {
                nagruzka_2_3 = false;
                DB.m_nagruzka_2 = false;
            }
        }
        private void checkBox_2_5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_2_5_CheckedChanged = (CheckBox)sender;
            if (checkBox_2_5_CheckedChanged.Checked == true)
            {
                nagruzka_2_4 = true;
                DB.m_nagruzka_2 = nagruzka_2_4;
            }
            else
            {
                nagruzka_2_4 = false;
                DB.m_nagruzka_2 = nagruzka_2_4;
            }
        }

        private void checkBox_3_1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_1_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_1_CheckedChanged.Checked == true)
            {
                nagruzka_3_0 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_0 = false;
                DB.m_nagruzka_3 = false;
            }
        }
        private void checkBox_3_2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_2_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_2_CheckedChanged.Checked == true)
            {
                nagruzka_3_1 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_1 = false;
                DB.m_nagruzka_3 = false;
            }
        }
        private void checkBox_3_3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_3_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_3_CheckedChanged.Checked == true)
            {
                nagruzka_3_2 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_2 = false;
                DB.m_nagruzka_3 = false;
            }
        }
        private void checkBox_3_4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_4_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_4_CheckedChanged.Checked == true)
            {
                nagruzka_3_3 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_3 = false;
                DB.m_nagruzka_3 = false;
            }
        }
        private void checkBox_3_5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_5_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_5_CheckedChanged.Checked == true)
            {
                nagruzka_3_4 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_4 = false;
                DB.m_nagruzka_3 = false;
            }
        }
        private void checkBox_3_6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_6_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_6_CheckedChanged.Checked == true)
            {
                nagruzka_3_5 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_5 = false;
                DB.m_nagruzka_3 = false;
            }
        }
        private void checkBox_3_7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_3_7_CheckedChanged = (CheckBox)sender;
            if (checkBox_3_7_CheckedChanged.Checked == true)
            {
                nagruzka_3_6 = true;
                DB.m_nagruzka_3 = true;
            }
            else
            {
                nagruzka_3_6 = false;
                DB.m_nagruzka_3 = false;
            }
        }

        private void checkBox_4_1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_4_1_CheckedChanged = (CheckBox)sender;
            if (checkBox_4_1_CheckedChanged.Checked == true)
            {
                nagruzka_4_0 = true;
                DB.m_nagruzka_4 = true;
            }
            else
            {
                nagruzka_4_0 = false;
                DB.m_nagruzka_4 = false;
            }
        }
        private void checkBox_4_2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_4_2_CheckedChanged = (CheckBox)sender;
            if (checkBox_4_2_CheckedChanged.Checked == true)
            {
                nagruzka_4_1 = true;
                DB.m_nagruzka_4 = nagruzka_4_1;
            }
            else
            {
                nagruzka_4_1 = false;
                DB.m_nagruzka_4 = nagruzka_4_1;
            }
        }
        private void checkBox_4_3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_4_3_CheckedChanged = (CheckBox)sender;
            if (checkBox_4_3_CheckedChanged.Checked == true)
            {
                nagruzka_4_2 = true;
                DB.m_nagruzka_4 = true;
            }
            else
            {
                nagruzka_4_2 = false;
                DB.m_nagruzka_4 = false;
            }
        }
        private void checkBox_4_4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_4_4_CheckedChanged = (CheckBox)sender;
            if (checkBox_4_4_CheckedChanged.Checked == true)
            {
                nagruzka_4_0 = true;
                DB.m_nagruzka_4 = true;
            }
            else
            {
                nagruzka_4_0 = false;
                DB.m_nagruzka_4 = false;
            }
        }
        private void checkBox_4_5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_4_5_CheckedChanged = (CheckBox)sender;
            if (checkBox_4_5_CheckedChanged.Checked == true)
            {
                nagruzka_4_4 = true;
                DB.m_nagruzka_4 = true;
            }
            else
            {
                nagruzka_4_4 = false;
                DB.m_nagruzka_4 = false;
            }
        }
        private void checkBox_4_6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_4_6_CheckedChanged = (CheckBox)sender;
            if (checkBox_4_6_CheckedChanged.Checked == true)
            {
                nagruzka_4_5 = true;
                DB.m_nagruzka_4 = true;
            }
            else
            {
                nagruzka_4_5 = false;
                DB.m_nagruzka_4 = false;
            }
        }
    }
}
