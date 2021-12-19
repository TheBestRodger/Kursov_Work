
namespace Kursov_Work
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Upper = new System.Windows.Forms.CheckBox();
            this.label_xaracter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_prof = new System.Windows.Forms.Label();
            this.checkBox_down = new System.Windows.Forms.CheckBox();
            this.checkBox_smallcCin = new System.Windows.Forms.CheckBox();
            this.checkBox_clin = new System.Windows.Forms.CheckBox();
            this.checkBox_PolClin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Enter_form1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.SystemColors.Control;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(136, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(409, 40);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Расчет колличества ремней в клиноременной, \r\nузкой и поликлиновой передачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выполнил: Каликин Д.М. ИДБ-19-04";
            // 
            // checkBox_Upper
            // 
            this.checkBox_Upper.AutoSize = true;
            this.checkBox_Upper.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Upper.Location = new System.Drawing.Point(7, 35);
            this.checkBox_Upper.Name = "checkBox_Upper";
            this.checkBox_Upper.Size = new System.Drawing.Size(140, 23);
            this.checkBox_Upper.TabIndex = 2;
            this.checkBox_Upper.Text = "Повыщающаяя";
            this.checkBox_Upper.UseVisualStyleBackColor = true;
            this.checkBox_Upper.CheckedChanged += new System.EventHandler(this.checkBox_Upper_CheckedChanged);
            // 
            // label_xaracter
            // 
            this.label_xaracter.AutoSize = true;
            this.label_xaracter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_xaracter.Location = new System.Drawing.Point(12, 104);
            this.label_xaracter.Name = "label_xaracter";
            this.label_xaracter.Size = new System.Drawing.Size(368, 22);
            this.label_xaracter.TabIndex = 3;
            this.label_xaracter.Text = "Выберите обязательные характеристики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип передачи";
            // 
            // label_prof
            // 
            this.label_prof.AutoSize = true;
            this.label_prof.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_prof.Location = new System.Drawing.Point(3, 2);
            this.label_prof.Name = "label_prof";
            this.label_prof.Size = new System.Drawing.Size(114, 19);
            this.label_prof.TabIndex = 12;
            this.label_prof.Text = "Тип передачи";
            // 
            // checkBox_down
            // 
            this.checkBox_down.AutoSize = true;
            this.checkBox_down.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_down.Location = new System.Drawing.Point(7, 64);
            this.checkBox_down.Name = "checkBox_down";
            this.checkBox_down.Size = new System.Drawing.Size(135, 23);
            this.checkBox_down.TabIndex = 13;
            this.checkBox_down.Text = "Понижающаяя";
            this.checkBox_down.UseVisualStyleBackColor = true;
            this.checkBox_down.CheckedChanged += new System.EventHandler(this.checkBox_down_CheckedChanged);
            // 
            // checkBox_smallcCin
            // 
            this.checkBox_smallcCin.AutoSize = true;
            this.checkBox_smallcCin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_smallcCin.Location = new System.Drawing.Point(7, 64);
            this.checkBox_smallcCin.Name = "checkBox_smallcCin";
            this.checkBox_smallcCin.Size = new System.Drawing.Size(72, 23);
            this.checkBox_smallcCin.TabIndex = 15;
            this.checkBox_smallcCin.Text = "Узкая";
            this.checkBox_smallcCin.UseVisualStyleBackColor = true;
            this.checkBox_smallcCin.CheckedChanged += new System.EventHandler(this.checkBox_smallcCin_CheckedChanged);
            // 
            // checkBox_clin
            // 
            this.checkBox_clin.AutoSize = true;
            this.checkBox_clin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_clin.Location = new System.Drawing.Point(7, 32);
            this.checkBox_clin.Name = "checkBox_clin";
            this.checkBox_clin.Size = new System.Drawing.Size(141, 23);
            this.checkBox_clin.TabIndex = 14;
            this.checkBox_clin.Text = "Клиноременная";
            this.checkBox_clin.UseVisualStyleBackColor = true;
            this.checkBox_clin.CheckedChanged += new System.EventHandler(this.checkBox_clin_CheckedChanged);
            // 
            // checkBox_PolClin
            // 
            this.checkBox_PolClin.AutoSize = true;
            this.checkBox_PolClin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_PolClin.Location = new System.Drawing.Point(7, 93);
            this.checkBox_PolClin.Name = "checkBox_PolClin";
            this.checkBox_PolClin.Size = new System.Drawing.Size(132, 23);
            this.checkBox_PolClin.TabIndex = 16;
            this.checkBox_PolClin.Text = "Поликлиновая";
            this.checkBox_PolClin.UseVisualStyleBackColor = true;
            this.checkBox_PolClin.CheckedChanged += new System.EventHandler(this.checkBox_PolClin_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_clin);
            this.panel1.Controls.Add(this.checkBox_PolClin);
            this.panel1.Controls.Add(this.label_prof);
            this.panel1.Controls.Add(this.checkBox_smallcCin);
            this.panel1.Location = new System.Drawing.Point(207, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBox_Upper);
            this.panel2.Controls.Add(this.checkBox_down);
            this.panel2.Location = new System.Drawing.Point(1, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 117);
            this.panel2.TabIndex = 18;
            // 
            // button_Enter_form1
            // 
            this.button_Enter_form1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Enter_form1.Location = new System.Drawing.Point(468, 174);
            this.button_Enter_form1.Name = "button_Enter_form1";
            this.button_Enter_form1.Size = new System.Drawing.Size(200, 63);
            this.button_Enter_form1.TabIndex = 20;
            this.button_Enter_form1.Text = "Ввести данные";
            this.button_Enter_form1.UseVisualStyleBackColor = true;
            this.button_Enter_form1.Click += new System.EventHandler(this.button_Enter_form1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(696, 316);
            this.Controls.Add(this.button_Enter_form1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_xaracter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Главное окно";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Upper;
        private System.Windows.Forms.Label label_xaracter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_prof;
        private System.Windows.Forms.CheckBox checkBox_down;
        private System.Windows.Forms.CheckBox checkBox_smallcCin;
        private System.Windows.Forms.CheckBox checkBox_clin;
        private System.Windows.Forms.CheckBox checkBox_PolClin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Enter_form1;
    }
}

