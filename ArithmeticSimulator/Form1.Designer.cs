
namespace ArithmeticSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonChek = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPravOtvety = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNepravOtvety = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountOfAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(868, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(371, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 49);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonChek
            // 
            this.buttonChek.AutoSize = true;
            this.buttonChek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChek.Location = new System.Drawing.Point(371, 468);
            this.buttonChek.Name = "buttonChek";
            this.buttonChek.Size = new System.Drawing.Size(228, 55);
            this.buttonChek.TabIndex = 2;
            this.buttonChek.Text = "Проверить";
            this.buttonChek.UseVisualStyleBackColor = true;
            this.buttonChek.Click += new System.EventHandler(this.buttonChek_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 840);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Правильные ответы:";
            // 
            // labelPravOtvety
            // 
            this.labelPravOtvety.AutoSize = true;
            this.labelPravOtvety.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPravOtvety.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelPravOtvety.Location = new System.Drawing.Point(295, 840);
            this.labelPravOtvety.Name = "labelPravOtvety";
            this.labelPravOtvety.Size = new System.Drawing.Size(76, 25);
            this.labelPravOtvety.TabIndex = 4;
            this.labelPravOtvety.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 840);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Неправильные ответы:";
            // 
            // labelNepravOtvety
            // 
            this.labelNepravOtvety.AutoSize = true;
            this.labelNepravOtvety.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNepravOtvety.ForeColor = System.Drawing.Color.Red;
            this.labelNepravOtvety.Location = new System.Drawing.Point(834, 840);
            this.labelNepravOtvety.Name = "labelNepravOtvety";
            this.labelNepravOtvety.Size = new System.Drawing.Size(76, 25);
            this.labelNepravOtvety.TabIndex = 4;
            this.labelNepravOtvety.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Осталось попыток:";
            // 
            // labelCountOfAnswer
            // 
            this.labelCountOfAnswer.AutoSize = true;
            this.labelCountOfAnswer.Location = new System.Drawing.Point(569, 606);
            this.labelCountOfAnswer.Name = "labelCountOfAnswer";
            this.labelCountOfAnswer.Size = new System.Drawing.Size(70, 25);
            this.labelCountOfAnswer.TabIndex = 6;
            this.labelCountOfAnswer.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 929);
            this.Controls.Add(this.labelCountOfAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNepravOtvety);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPravOtvety);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChek);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonChek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPravOtvety;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNepravOtvety;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCountOfAnswer;
    }
}

