
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
            this.K = new System.Windows.Forms.Label();
            this.textK = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textCell9 = new System.Windows.Forms.TextBox();
            this.textCell8 = new System.Windows.Forms.TextBox();
            this.textCell7 = new System.Windows.Forms.TextBox();
            this.textCell6 = new System.Windows.Forms.TextBox();
            this.textCell5 = new System.Windows.Forms.TextBox();
            this.textCell4 = new System.Windows.Forms.TextBox();
            this.textCell3 = new System.Windows.Forms.TextBox();
            this.textCell2 = new System.Windows.Forms.TextBox();
            this.textCell1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.enterCorner = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // but_load
            // 
            this.but_load.Location = new System.Drawing.Point(1153, 17);
            this.but_load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_load.Name = "but_load";
            this.but_load.Size = new System.Drawing.Size(228, 34);
            this.but_load.TabIndex = 1;
            this.but_load.Text = "Load";
            this.but_load.UseVisualStyleBackColor = true;
            this.but_load.Click += new System.EventHandler(this.but_load_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 62);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 671);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(17, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Увеличение в K раз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterNumX
            // 
            this.enterNumX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumX.Location = new System.Drawing.Point(17, 102);
            this.enterNumX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterNumX.Name = "enterNumX";
            this.enterNumX.Size = new System.Drawing.Size(100, 27);
            this.enterNumX.TabIndex = 5;
            this.enterNumX.Text = "2";
            this.enterNumX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNum_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(21, 199);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "билинейная интерполяция";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1174, 465);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // enterNumY
            // 
            this.enterNumY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumY.Location = new System.Drawing.Point(144, 102);
            this.enterNumY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterNumY.Name = "enterNumY";
            this.enterNumY.Size = new System.Drawing.Size(100, 27);
            this.enterNumY.TabIndex = 8;
            this.enterNumY.Text = "2";
            this.enterNumY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ky";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1160, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Разрешение:";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS.Location = new System.Drawing.Point(1195, 534);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(0, 20);
            this.labelS.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1160, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Размер файла:";
            // 
            // labelSIZE
            // 
            this.labelSIZE.AutoSize = true;
            this.labelSIZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSIZE.Location = new System.Drawing.Point(1195, 593);
            this.labelSIZE.Name = "labelSIZE";
            this.labelSIZE.Size = new System.Drawing.Size(0, 20);
            this.labelSIZE.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1155, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(1196, 658);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 20);
            this.labelTime.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1133, 65);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 385);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(255, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.K);
            this.tabPage2.Controls.Add(this.textK);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.enterCorner);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(255, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K.Location = new System.Drawing.Point(33, 116);
            this.K.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(20, 20);
            this.K.TabIndex = 9;
            this.K.Text = "K";
            // 
            // textK
            // 
            this.textK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textK.Location = new System.Drawing.Point(61, 113);
            this.textK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textK.Name = "textK";
            this.textK.Size = new System.Drawing.Size(59, 26);
            this.textK.TabIndex = 8;
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
            this.panel2.Location = new System.Drawing.Point(16, 148);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 99);
            this.panel2.TabIndex = 4;
            // 
            // textCell9
            // 
            this.textCell9.Location = new System.Drawing.Point(153, 68);
            this.textCell9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell9.Name = "textCell9";
            this.textCell9.Size = new System.Drawing.Size(59, 22);
            this.textCell9.TabIndex = 8;
            // 
            // textCell8
            // 
            this.textCell8.Location = new System.Drawing.Point(85, 68);
            this.textCell8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell8.Name = "textCell8";
            this.textCell8.Size = new System.Drawing.Size(59, 22);
            this.textCell8.TabIndex = 7;
            // 
            // textCell7
            // 
            this.textCell7.Location = new System.Drawing.Point(15, 68);
            this.textCell7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell7.Name = "textCell7";
            this.textCell7.Size = new System.Drawing.Size(59, 22);
            this.textCell7.TabIndex = 6;
            // 
            // textCell6
            // 
            this.textCell6.Location = new System.Drawing.Point(153, 36);
            this.textCell6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell6.Name = "textCell6";
            this.textCell6.Size = new System.Drawing.Size(59, 22);
            this.textCell6.TabIndex = 5;
            // 
            // textCell5
            // 
            this.textCell5.Location = new System.Drawing.Point(85, 36);
            this.textCell5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell5.Name = "textCell5";
            this.textCell5.Size = new System.Drawing.Size(59, 22);
            this.textCell5.TabIndex = 4;
            // 
            // textCell4
            // 
            this.textCell4.Location = new System.Drawing.Point(15, 36);
            this.textCell4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell4.Name = "textCell4";
            this.textCell4.Size = new System.Drawing.Size(59, 22);
            this.textCell4.TabIndex = 3;
            // 
            // textCell3
            // 
            this.textCell3.Location = new System.Drawing.Point(153, 4);
            this.textCell3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell3.Name = "textCell3";
            this.textCell3.Size = new System.Drawing.Size(59, 22);
            this.textCell3.TabIndex = 2;
            // 
            // textCell2
            // 
            this.textCell2.Location = new System.Drawing.Point(85, 4);
            this.textCell2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell2.Name = "textCell2";
            this.textCell2.Size = new System.Drawing.Size(59, 22);
            this.textCell2.TabIndex = 1;
            // 
            // textCell1
            // 
            this.textCell1.Location = new System.Drawing.Point(15, 4);
            this.textCell1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCell1.Name = "textCell1";
            this.textCell1.Size = new System.Drawing.Size(59, 22);
            this.textCell1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(135, 112);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "Фильтр";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Введите угол наклона:";
            // 
            // enterCorner
            // 
            this.enterCorner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterCorner.Location = new System.Drawing.Point(39, 37);
            this.enterCorner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterCorner.Name = "enterCorner";
            this.enterCorner.Size = new System.Drawing.Size(153, 27);
            this.enterCorner.TabIndex = 1;
            this.enterCorner.Text = "45";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(61, 70);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 37);
            this.button5.TabIndex = 0;
            this.button5.Text = "Повернуть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(7, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 97);
            this.panel3.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(8, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 43);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "сглаживающий";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(117, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 43);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Контрастоповышающий";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(8, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.Text = "Медианный";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 698);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

