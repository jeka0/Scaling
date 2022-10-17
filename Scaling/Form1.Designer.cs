
namespace Scaling
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.enterNumX = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.enterNumY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSIZE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.enterCorner = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textCell1 = new System.Windows.Forms.TextBox();
            this.textCell2 = new System.Windows.Forms.TextBox();
            this.textCell3 = new System.Windows.Forms.TextBox();
            this.textCell6 = new System.Windows.Forms.TextBox();
            this.textCell5 = new System.Windows.Forms.TextBox();
            this.textCell4 = new System.Windows.Forms.TextBox();
            this.textCell9 = new System.Windows.Forms.TextBox();
            this.textCell8 = new System.Windows.Forms.TextBox();
            this.textCell7 = new System.Windows.Forms.TextBox();
            this.textK = new System.Windows.Forms.TextBox();
            this.K = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // but_load
            // 
            this.but_load.Location = new System.Drawing.Point(865, 14);
            this.but_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_load.Name = "but_load";
            this.but_load.Size = new System.Drawing.Size(171, 28);
            this.but_load.TabIndex = 1;
            this.but_load.Text = "Load";
            this.but_load.UseVisualStyleBackColor = true;
            this.but_load.Click += new System.EventHandler(this.but_load_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Метод ближайшего соседа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 546);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(13, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Увеличение в K раз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterNumX
            // 
            this.enterNumX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumX.Location = new System.Drawing.Point(13, 83);
            this.enterNumX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterNumX.Name = "enterNumX";
            this.enterNumX.Size = new System.Drawing.Size(76, 23);
            this.enterNumX.TabIndex = 5;
            this.enterNumX.Text = "2";
            this.enterNumX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNum_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(16, 162);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "билинейная интерполяция";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(883, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 27);
            this.button4.TabIndex = 7;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // enterNumY
            // 
            this.enterNumY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumY.Location = new System.Drawing.Point(108, 83);
            this.enterNumY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterNumY.Name = "enterNumY";
            this.enterNumY.Size = new System.Drawing.Size(76, 23);
            this.enterNumY.TabIndex = 8;
            this.enterNumY.Text = "2";
            this.enterNumY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(113, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ky";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(871, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Разрешение:";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS.Location = new System.Drawing.Point(897, 411);
            this.labelS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(0, 17);
            this.labelS.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(871, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Размер файла:";
            // 
            // labelSIZE
            // 
            this.labelSIZE.AutoSize = true;
            this.labelSIZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSIZE.Location = new System.Drawing.Point(897, 459);
            this.labelSIZE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSIZE.Name = "labelSIZE";
            this.labelSIZE.Size = new System.Drawing.Size(0, 17);
            this.labelSIZE.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(866, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(897, 535);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 17);
            this.labelTime.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(850, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(197, 278);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.enterNumX);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.enterNumY);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(189, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.K);
            this.tabPage2.Controls.Add(this.textK);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.enterCorner);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(189, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Введите угол наклона:";
            // 
            // enterCorner
            // 
            this.enterCorner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterCorner.Location = new System.Drawing.Point(29, 30);
            this.enterCorner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterCorner.Name = "enterCorner";
            this.enterCorner.Size = new System.Drawing.Size(116, 23);
            this.enterCorner.TabIndex = 1;
            this.enterCorner.Text = "45";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(46, 57);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 27);
            this.button5.TabIndex = 0;
            this.button5.Text = "Повернуть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(25, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Фильтр";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textCell9);
            this.panel2.Controls.Add(this.textCell8);
            this.panel2.Controls.Add(this.textCell7);
            this.panel2.Controls.Add(this.textCell6);
            this.panel2.Controls.Add(this.textCell5);
            this.panel2.Controls.Add(this.textCell4);
            this.panel2.Controls.Add(this.textCell3);
            this.panel2.Controls.Add(this.textCell2);
            this.panel2.Controls.Add(this.textCell1);
            this.panel2.Location = new System.Drawing.Point(5, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 97);
            this.panel2.TabIndex = 4;
            // 
            // textCell1
            // 
            this.textCell1.Location = new System.Drawing.Point(10, 14);
            this.textCell1.Name = "textCell1";
            this.textCell1.Size = new System.Drawing.Size(45, 20);
            this.textCell1.TabIndex = 0;
            // 
            // textCell2
            // 
            this.textCell2.Location = new System.Drawing.Point(62, 14);
            this.textCell2.Name = "textCell2";
            this.textCell2.Size = new System.Drawing.Size(45, 20);
            this.textCell2.TabIndex = 1;
            // 
            // textCell3
            // 
            this.textCell3.Location = new System.Drawing.Point(113, 14);
            this.textCell3.Name = "textCell3";
            this.textCell3.Size = new System.Drawing.Size(45, 20);
            this.textCell3.TabIndex = 2;
            // 
            // textCell6
            // 
            this.textCell6.Location = new System.Drawing.Point(113, 40);
            this.textCell6.Name = "textCell6";
            this.textCell6.Size = new System.Drawing.Size(45, 20);
            this.textCell6.TabIndex = 5;
            // 
            // textCell5
            // 
            this.textCell5.Location = new System.Drawing.Point(62, 40);
            this.textCell5.Name = "textCell5";
            this.textCell5.Size = new System.Drawing.Size(45, 20);
            this.textCell5.TabIndex = 4;
            // 
            // textCell4
            // 
            this.textCell4.Location = new System.Drawing.Point(10, 40);
            this.textCell4.Name = "textCell4";
            this.textCell4.Size = new System.Drawing.Size(45, 20);
            this.textCell4.TabIndex = 3;
            // 
            // textCell9
            // 
            this.textCell9.Location = new System.Drawing.Point(113, 66);
            this.textCell9.Name = "textCell9";
            this.textCell9.Size = new System.Drawing.Size(45, 20);
            this.textCell9.TabIndex = 8;
            // 
            // textCell8
            // 
            this.textCell8.Location = new System.Drawing.Point(62, 66);
            this.textCell8.Name = "textCell8";
            this.textCell8.Size = new System.Drawing.Size(45, 20);
            this.textCell8.TabIndex = 7;
            // 
            // textCell7
            // 
            this.textCell7.Location = new System.Drawing.Point(10, 66);
            this.textCell7.Name = "textCell7";
            this.textCell7.Size = new System.Drawing.Size(45, 20);
            this.textCell7.TabIndex = 6;
            // 
            // textK
            // 
            this.textK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textK.Location = new System.Drawing.Point(106, 102);
            this.textK.Name = "textK";
            this.textK.Size = new System.Drawing.Size(45, 22);
            this.textK.TabIndex = 8;
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K.Location = new System.Drawing.Point(118, 86);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(16, 16);
            this.K.TabIndex = 9;
            this.K.Text = "K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSIZE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but_load);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox enterNumX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox enterNumY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSIZE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox enterCorner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.TextBox textK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textCell9;
        private System.Windows.Forms.TextBox textCell8;
        private System.Windows.Forms.TextBox textCell7;
        private System.Windows.Forms.TextBox textCell6;
        private System.Windows.Forms.TextBox textCell5;
        private System.Windows.Forms.TextBox textCell4;
        private System.Windows.Forms.TextBox textCell3;
        private System.Windows.Forms.TextBox textCell2;
        private System.Windows.Forms.TextBox textCell1;
    }
}

