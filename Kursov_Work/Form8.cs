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
    public partial class Form8 : Form
    {

        public void Form8_Load()
        {
            //создадим таблицу вывода товаров с колонками 
            //Название, Цена, Остаток

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Тип передачи"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "Тип передачи"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Мощность";
            column2.Name = "N";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Частота вращения n_1";
            column3.Name = "n_1";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Частота вращения n_2";
            column4.Name = "n_2";
            column4.CellTemplate = new DataGridViewTextBoxCell();
            //
            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Скольжение";
            column5.Name = "eps";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Кол-во ремней";
            column6.Name = "Z";
            column6.CellTemplate = new DataGridViewTextBoxCell();
            /*
            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Частота вращения n_2";
            column7.Name = "n_2";
            column7.CellTemplate = new DataGridViewTextBoxCell();
            */

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);

            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            /*
            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Клиноременные", i);
            }
            for (int i = 5; i < 10; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add("Поликлиноременные", i);
            }
            */
            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                dataGridView1.Rows.Add();
                dataGridView1["Тип передачи", dataGridView1.Rows.Count - 1].Value = "Клиноременные";
                dataGridView1["N", dataGridView1.Rows.Count - 1].Value = 10 - i + 1;
                dataGridView1["n_1", dataGridView1.Rows.Count - 1].Value = i * 100+40;
                dataGridView1["n_2", dataGridView1.Rows.Count - 1].Value = i*100/2+20;
                dataGridView1["eps", dataGridView1.Rows.Count - 1].Value = 0.001;
                dataGridView1["Z", dataGridView1.Rows.Count - 1].Value = 6;
            }
            for (int i = 5; i < 10; ++i)
            {
                //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                dataGridView1.Rows.Add();
                dataGridView1["Тип передачи", dataGridView1.Rows.Count - 1].Value = "Поликлиноременные";
                dataGridView1["N", dataGridView1.Rows.Count - 1].Value = 10 - i + 1;
                dataGridView1["n_1", dataGridView1.Rows.Count - 1].Value = i * 130;
                dataGridView1["n_2", dataGridView1.Rows.Count - 1].Value = i * 140 / 2;
                dataGridView1["eps", dataGridView1.Rows.Count - 1].Value = 0.001;
                dataGridView1["Z", dataGridView1.Rows.Count - 1].Value = 24+i-3;
            }

            //А теперь простой пройдемся циклом по всем ячейкам
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    //Значения ячеек хряняться в типе object
                    //это позволяет хранить любые данные в таблице
                    object o = dataGridView1[j, i].Value;
                }
            }
        }
        public Form8()
        {

            InitializeComponent();
            Form8_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

