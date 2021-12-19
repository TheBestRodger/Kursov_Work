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
    public partial class Form1 : Form
    {
        Form6 frm6;

        private bool upper;
        private bool down;
        private bool clin;
        private bool sclin;
        private bool pclin;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox_Upper_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_down_CheckedChanged = (CheckBox)sender;
            if (checkBox_down_CheckedChanged.Checked == true)
            {
                upper = true;
                DB.upper = upper;
            }
            else
            {
                upper = false;
                DB.upper = upper;
            }
        }

        private void checkBox_down_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_down_CheckedChanged = (CheckBox)sender;
            if (checkBox_down_CheckedChanged.Checked == true)
            {
                down = true;
                DB.down = down;
            }
            else
            {
                down = false;
                DB.down = down;
            }
        }
        private void checkBox_clin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_clin_CheckedChanged = (CheckBox)sender;
            if (checkBox_clin_CheckedChanged.Checked == true)
            {
                clin = true;
                DB.clin = clin;
            }
            else
            {
                clin = false;
                DB.clin = clin;
            }
        }

        private void checkBox_smallcCin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_smallcCin_CheckedChanged = (CheckBox)sender;
            if (checkBox_smallcCin_CheckedChanged.Checked == true)
            {
                sclin = true;
                DB.sclin = sclin;
            }
            else
            {
                sclin = false;
                DB.sclin = sclin;
            }
        }

        private void checkBox_PolClin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox_smallcCin_CheckedChanged = (CheckBox)sender;
            if (checkBox_smallcCin_CheckedChanged.Checked == true)
            {
                pclin = true;
                DB.pclin = pclin;
            }
            else
            {
                pclin = false;
                DB.pclin = pclin;
            }
        }

        private void button_Enter_form1_Click(object sender, EventArgs e)
        {
            frm6 = new Form6();
            frm6.Show();
        }
    }
}
