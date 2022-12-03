
namespace WindowsFormsApp1
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
            this.ResultBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StrTxb2 = new System.Windows.Forms.TextBox();
            this.StrTxb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StrTxb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultBtn
            // 
            this.ResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBtn.Location = new System.Drawing.Point(42, 227);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(104, 34);
            this.ResultBtn.TabIndex = 0;
            this.ResultBtn.Text = "Рассчитать";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите три стороны вашего треугольника:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ответ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StrTxb2
            // 
            this.StrTxb2.Location = new System.Drawing.Point(38, 142);
            this.StrTxb2.Name = "StrTxb2";
            this.StrTxb2.Size = new System.Drawing.Size(291, 20);
            this.StrTxb2.TabIndex = 4;
            this.StrTxb2.Text = "Сюда вторую сторону";
            this.StrTxb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTxb2.TextChanged += new System.EventHandler(this.StrTxb2_TextChanged);
            this.StrTxb2.Enter += new System.EventHandler(this.StrTxb2_Enter_1);
            this.StrTxb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StrTxb2_KeyPress);
            // 
            // StrTxb3
            // 
            this.StrTxb3.Location = new System.Drawing.Point(38, 180);
            this.StrTxb3.Name = "StrTxb3";
            this.StrTxb3.Size = new System.Drawing.Size(291, 20);
            this.StrTxb3.TabIndex = 5;
            this.StrTxb3.Text = "Ну и как без третьей";
            this.StrTxb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTxb3.TextChanged += new System.EventHandler(this.StrTxb3_TextChanged);
            this.StrTxb3.Enter += new System.EventHandler(this.StrTxb3_Enter_1);
            this.StrTxb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StrTxb3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ваш ответ появится тут";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StrTxb1
            // 
            this.StrTxb1.Location = new System.Drawing.Point(38, 96);
            this.StrTxb1.Name = "StrTxb1";
            this.StrTxb1.Size = new System.Drawing.Size(291, 20);
            this.StrTxb1.TabIndex = 7;
            this.StrTxb1.Text = "Сюда первую сторону";
            this.StrTxb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTxb1.TextChanged += new System.EventHandler(this.StrTxb1_TextChanged);
            this.StrTxb1.Enter += new System.EventHandler(this.StrTxb1_Enter_1);
            this.StrTxb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StrTxb1_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StrTxb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StrTxb3);
            this.Controls.Add(this.StrTxb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultBtn);
            this.Name = "Form1";
            this.Text = "Треугольники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StrTxb2;
        private System.Windows.Forms.TextBox StrTxb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StrTxb1;
    }
}

