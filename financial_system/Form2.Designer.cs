namespace financial_system
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SumBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryBox
            // 
            this.CategoryBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Продукты",
            "Авто",
            "Спорт",
            "Здоровье",
            "Развлечения",
            "Животные",
            "Подарки",
            "Прочее"});
            this.CategoryBox.Location = new System.Drawing.Point(24, 39);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(223, 28);
            this.CategoryBox.TabIndex = 0;
            this.CategoryBox.Text = "Выберете категорию";
            this.CategoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryBox_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 196);
            this.listBox1.TabIndex = 1;
            // 
            // SumBox
            // 
            this.SumBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumBox.Location = new System.Drawing.Point(24, 90);
            this.SumBox.Multiline = true;
            this.SumBox.Name = "SumBox";
            this.SumBox.Size = new System.Drawing.Size(223, 28);
            this.SumBox.TabIndex = 2;
            this.SumBox.Text = "Введите сумму";
            this.SumBox.Click += new System.EventHandler(this.SumBox_Click);
            this.SumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumBox_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(24, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Вывод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SumBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CategoryBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money_system";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox SumBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}