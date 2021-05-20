namespace Bankomat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.edCardNumber = new System.Windows.Forms.TextBox();
            this.tbDisplay = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn3 = new System.Windows.Forms.Button();
            this.edtextPincode = new System.Windows.Forms.MaskedTextBox();
            this.edPincode = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblBalance = new System.Windows.Forms.Label();
            this.edtextbox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbDisplay.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.edCardNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карта";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(162, 67);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Ввести";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edCardNumber
            // 
            this.edCardNumber.Location = new System.Drawing.Point(17, 30);
            this.edCardNumber.Name = "edCardNumber";
            this.edCardNumber.Size = new System.Drawing.Size(261, 22);
            this.edCardNumber.TabIndex = 0;
            this.edCardNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbDisplay.Controls.Add(this.tabPage1);
            this.tbDisplay.Controls.Add(this.tabPage2);
            this.tbDisplay.Controls.Add(this.tabPage3);
            this.tbDisplay.Controls.Add(this.tabPage4);
            this.tbDisplay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbDisplay.Location = new System.Drawing.Point(12, 132);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.SelectedIndex = 0;
            this.tbDisplay.Size = new System.Drawing.Size(776, 424);
            this.tbDisplay.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(255, 128);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Приветствие";
            this.lbl1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn3);
            this.tabPage2.Controls.Add(this.edtextPincode);
            this.tabPage2.Controls.Add(this.edPincode);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(393, 178);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(164, 38);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Подтверждение";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // edtextPincode
            // 
            this.edtextPincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edtextPincode.Location = new System.Drawing.Point(207, 178);
            this.edtextPincode.Mask = "0000";
            this.edtextPincode.Name = "edtextPincode";
            this.edtextPincode.Size = new System.Drawing.Size(159, 38);
            this.edtextPincode.TabIndex = 5;
            this.edtextPincode.ValidatingType = typeof(int);
            this.edtextPincode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.edtextPincode_MaskInputRejected);
            // 
            // edPincode
            // 
            this.edPincode.AutoSize = true;
            this.edPincode.Location = new System.Drawing.Point(320, 110);
            this.edPincode.Name = "edPincode";
            this.edPincode.Size = new System.Drawing.Size(118, 17);
            this.edPincode.TabIndex = 3;
            this.edPincode.Text = "Введите пин код";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblBalance);
            this.tabPage3.Controls.Add(this.edtextbox1);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.btn5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(482, 181);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(93, 32);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "label2";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // edtextbox1
            // 
            this.edtextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edtextbox1.Location = new System.Drawing.Point(13, 32);
            this.edtextbox1.Name = "edtextbox1";
            this.edtextbox1.Size = new System.Drawing.Size(739, 38);
            this.edtextbox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(438, 74);
            this.button6.TabIndex = 3;
            this.button6.Text = "Баланс карты";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(13, 85);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(739, 74);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "Выдать  деньги";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(313, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 79);
            this.button4.TabIndex = 1;
            this.button4.Text = "Вернуться к вводу пин кода";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 69);
            this.label4.TabIndex = 3;
            this.label4.Text = "Баланс карты: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернуться в главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(146, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "Деньги выданы! ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(584, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(713, 573);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 53);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(523, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbDisplay.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox edCardNumber;
        private System.Windows.Forms.TabControl tbDisplay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox edtextPincode;
        private System.Windows.Forms.Label edPincode;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox edtextbox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

