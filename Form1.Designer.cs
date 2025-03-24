namespace _04
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ravno = new System.Windows.Forms.Button();
            this.otvet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 232);
            this.label1.MaximumSize = new System.Drawing.Size(20, 30);
            this.label1.MinimumSize = new System.Drawing.Size(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "(3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 232);
            this.label2.MaximumSize = new System.Drawing.Size(10, 20);
            this.label2.MinimumSize = new System.Drawing.Size(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 229);
            this.label3.MaximumSize = new System.Drawing.Size(30, 30);
            this.label3.MinimumSize = new System.Drawing.Size(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "12*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 229);
            this.label4.MaximumSize = new System.Drawing.Size(10, 20);
            this.label4.MinimumSize = new System.Drawing.Size(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = ")";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 229);
            this.label5.MaximumSize = new System.Drawing.Size(10, 20);
            this.label5.MinimumSize = new System.Drawing.Size(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 229);
            this.label6.MaximumSize = new System.Drawing.Size(20, 20);
            this.label6.MinimumSize = new System.Drawing.Size(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "/3";
            // 
            // ravno
            // 
            this.ravno.Location = new System.Drawing.Point(527, 229);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(75, 23);
            this.ravno.TabIndex = 8;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = true;
            this.ravno.Click += new System.EventHandler(this.button1_Click);
            // 
            // otvet
            // 
            this.otvet.AutoSize = true;
            this.otvet.Location = new System.Drawing.Point(661, 232);
            this.otvet.Name = "otvet";
            this.otvet.Size = new System.Drawing.Size(0, 13);
            this.otvet.TabIndex = 9;
            this.otvet.Click += new System.EventHandler(this.otvet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.otvet);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.Label otvet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

