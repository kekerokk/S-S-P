namespace S_S_P
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rock_but = new System.Windows.Forms.Button();
            this.scissors_but = new System.Windows.Forms.Button();
            this.paper_but = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Label();
            this.Imposter = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rock_but
            // 
            this.rock_but.Image = ((System.Drawing.Image)(resources.GetObject("rock_but.Image")));
            this.rock_but.Location = new System.Drawing.Point(277, 769);
            this.rock_but.Name = "rock_but";
            this.rock_but.Size = new System.Drawing.Size(203, 183);
            this.rock_but.TabIndex = 0;
            this.rock_but.UseVisualStyleBackColor = true;
            // 
            // scissors_but
            // 
            this.scissors_but.Image = ((System.Drawing.Image)(resources.GetObject("scissors_but.Image")));
            this.scissors_but.Location = new System.Drawing.Point(532, 801);
            this.scissors_but.Name = "scissors_but";
            this.scissors_but.Size = new System.Drawing.Size(201, 118);
            this.scissors_but.TabIndex = 1;
            this.scissors_but.UseVisualStyleBackColor = true;
            // 
            // paper_but
            // 
            this.paper_but.Image = ((System.Drawing.Image)(resources.GetObject("paper_but.Image")));
            this.paper_but.Location = new System.Drawing.Point(786, 759);
            this.paper_but.Name = "paper_but";
            this.paper_but.Size = new System.Drawing.Size(159, 202);
            this.paper_but.TabIndex = 2;
            this.paper_but.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(26, 820);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 789);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ставку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 892);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваши очки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(147, 892);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Раунд 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(163, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Счёт";
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player.Location = new System.Drawing.Point(183, 464);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(32, 37);
            this.Player.TabIndex = 9;
            this.Player.Text = "0";
            // 
            // Imposter
            // 
            this.Imposter.AutoSize = true;
            this.Imposter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Imposter.Location = new System.Drawing.Point(183, 348);
            this.Imposter.Name = "Imposter";
            this.Imposter.Size = new System.Drawing.Size(32, 37);
            this.Imposter.TabIndex = 10;
            this.Imposter.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(610, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "VS";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(786, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 202);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(532, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 118);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(277, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 183);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(198, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Очки противника:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Imposter);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.paper_but);
            this.Controls.Add(this.scissors_but);
            this.Controls.Add(this.rock_but);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Камень-Ножницы-Бумага";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button rock_but;
        private Button scissors_but;
        private Button paper_but;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Player;
        private Label Imposter;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private Label label7;
    }
}