namespace S_S_P
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StartWithBot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rules = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, TO THE INTERNATIONAL 2022!!!!!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Таблица результатов";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StartWithBot
            // 
            this.StartWithBot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartWithBot.Location = new System.Drawing.Point(313, 205);
            this.StartWithBot.Name = "StartWithBot";
            this.StartWithBot.Size = new System.Drawing.Size(272, 62);
            this.StartWithBot.TabIndex = 2;
            this.StartWithBot.Text = "Играть с ботом";
            this.StartWithBot.UseVisualStyleBackColor = true;
            this.StartWithBot.Click += new System.EventHandler(this.StartWithBot_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(313, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введити ваш никенаме";
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rules.Location = new System.Drawing.Point(607, 48);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(281, 483);
            this.Rules.TabIndex = 5;
            this.Rules.Text = "САЛАААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА" +
    "ААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААМ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(313, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 62);
            this.button4.TabIndex = 7;
            this.button4.Text = "Играть по сети";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartWithBot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button StartWithBot;
        private TextBox textBox1;
        private Label label2;
        private Label Rules;
        private Button button4;
    }
}