
namespace Practice
{
    partial class MainForm
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
            this.tB = new System.Windows.Forms.TextBox();
            this.tA = new System.Windows.Forms.TextBox();
            this.rtbFunc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Answer = new System.Windows.Forms.Button();
            this.tN = new System.Windows.Forms.TextBox();
            this.tEps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(35, 23);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(48, 20);
            this.tB.TabIndex = 0;
            // 
            // tA
            // 
            this.tA.Location = new System.Drawing.Point(35, 125);
            this.tA.Name = "tA";
            this.tA.Size = new System.Drawing.Size(48, 20);
            this.tA.TabIndex = 1;
            // 
            // rtbFunc
            // 
            this.rtbFunc.Location = new System.Drawing.Point(89, 46);
            this.rtbFunc.Name = "rtbFunc";
            this.rtbFunc.Size = new System.Drawing.Size(313, 73);
            this.rtbFunc.TabIndex = 2;
            this.rtbFunc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 73);
            this.label4.TabIndex = 9;
            this.label4.Text = "∫";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(577, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "X всегда указывать с большой буквы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Для правильной работы программы ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Log(X,Y) - Логарифм X по основанию Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pow(X,Y) - Возведение X в степень Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Sqrt(X) - Квадратный корень из X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(577, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sin(X)/Cos(X) - Синус/Косинус X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Abs(X) - Модуль X";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(568, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 182);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Помощь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(408, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 73);
            this.label1.TabIndex = 31;
            this.label1.Text = "dx";
            // 
            // button_Answer
            // 
            this.button_Answer.Location = new System.Drawing.Point(568, 200);
            this.button_Answer.Name = "button_Answer";
            this.button_Answer.Size = new System.Drawing.Size(220, 75);
            this.button_Answer.TabIndex = 32;
            this.button_Answer.Text = "Вычислить";
            this.button_Answer.UseVisualStyleBackColor = true;
            this.button_Answer.Click += new System.EventHandler(this.button_Answer_Click);
            // 
            // tN
            // 
            this.tN.Location = new System.Drawing.Point(35, 169);
            this.tN.Name = "tN";
            this.tN.Size = new System.Drawing.Size(118, 20);
            this.tN.TabIndex = 33;
            // 
            // tEps
            // 
            this.tEps.Location = new System.Drawing.Point(35, 215);
            this.tEps.Name = "tEps";
            this.tEps.Size = new System.Drawing.Size(118, 20);
            this.tEps.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Точность интегралла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Eps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ответ = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Интеграл =";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(172, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 70);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tEps);
            this.Controls.Add(this.tN);
            this.Controls.Add(this.button_Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbFunc);
            this.Controls.Add(this.tA);
            this.Controls.Add(this.tB);
            this.Name = "MainForm";
            this.Text = "Летняя практика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.TextBox tA;
        private System.Windows.Forms.RichTextBox rtbFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Answer;
        private System.Windows.Forms.TextBox tN;
        private System.Windows.Forms.TextBox tEps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

