namespace Lab_0
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
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.katet_a = new System.Windows.Forms.Label();
            this.katet_b = new System.Windows.Forms.Label();
            this.thickness = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.Answer_1 = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(76, 215);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(201, 215);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Отчистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // katet_a
            // 
            this.katet_a.AutoSize = true;
            this.katet_a.Location = new System.Drawing.Point(42, 38);
            this.katet_a.Name = "katet_a";
            this.katet_a.Size = new System.Drawing.Size(45, 13);
            this.katet_a.TabIndex = 2;
            this.katet_a.Text = "Катет а";
            this.katet_a.Click += new System.EventHandler(this.katet_a_Click);
            // 
            // katet_b
            // 
            this.katet_b.AutoSize = true;
            this.katet_b.Location = new System.Drawing.Point(42, 74);
            this.katet_b.Name = "katet_b";
            this.katet_b.Size = new System.Drawing.Size(45, 13);
            this.katet_b.TabIndex = 3;
            this.katet_b.Text = "Катет b";
            // 
            // thickness
            // 
            this.thickness.AutoSize = true;
            this.thickness.Location = new System.Drawing.Point(42, 114);
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(62, 13);
            this.thickness.TabIndex = 4;
            this.thickness.Text = "Толщина h";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(42, 148);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(51, 13);
            this.weight.TabIndex = 5;
            this.weight.Text = "Масса m";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(110, 38);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 6;
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(110, 148);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 20);
            this.m.TabIndex = 7;
            this.m.TextChanged += new System.EventHandler(this.m_TextChanged);
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(110, 114);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(100, 20);
            this.h.TabIndex = 8;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(110, 74);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 9;
            // 
            // Answer_1
            // 
            this.Answer_1.Enabled = false;
            this.Answer_1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Answer_1.Location = new System.Drawing.Point(354, 38);
            this.Answer_1.Name = "Answer_1";
            this.Answer_1.Size = new System.Drawing.Size(100, 20);
            this.Answer_1.TabIndex = 10;
            this.Answer_1.TextChanged += new System.EventHandler(this.Answer_1_TextChanged);
            this.Answer_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Answer_1_KeyPress);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(285, 38);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(52, 13);
            this.answer.TabIndex = 11;
            this.answer.Text = "Решение";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.description.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.ForeColor = System.Drawing.SystemColors.WindowText;
            this.description.Location = new System.Drawing.Point(249, 123);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(361, 45);
            this.description.TabIndex = 12;
            this.description.Text = "Какую плотность должен иметь материал, из которого \r\nизготовлена деталь в форме п" +
    "рямоугольного треугольника \r\nс катетами a и b, толщиной h, если масса детали m?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 249);
            this.Controls.Add(this.description);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Answer_1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.h);
            this.Controls.Add(this.m);
            this.Controls.Add(this.a);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.thickness);
            this.Controls.Add(this.katet_b);
            this.Controls.Add(this.katet_a);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Лаб_0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label katet_a;
        private System.Windows.Forms.Label katet_b;
        private System.Windows.Forms.Label thickness;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox Answer_1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label description;
    }
}

