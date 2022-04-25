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
            this.SuspendLayout();
            // 
            // rock_but
            // 
            this.rock_but.Image = ((System.Drawing.Image)(resources.GetObject("rock_but.Image")));
            this.rock_but.Location = new System.Drawing.Point(360, 420);
            this.rock_but.Name = "rock_but";
            this.rock_but.Size = new System.Drawing.Size(203, 183);
            this.rock_but.TabIndex = 0;
            this.rock_but.UseVisualStyleBackColor = true;
            // 
            // scissors_but
            // 
            this.scissors_but.Image = ((System.Drawing.Image)(resources.GetObject("scissors_but.Image")));
            this.scissors_but.Location = new System.Drawing.Point(657, 452);
            this.scissors_but.Name = "scissors_but";
            this.scissors_but.Size = new System.Drawing.Size(201, 118);
            this.scissors_but.TabIndex = 1;
            this.scissors_but.UseVisualStyleBackColor = true;
            // 
            // paper_but
            // 
            this.paper_but.Image = ((System.Drawing.Image)(resources.GetObject("paper_but.Image")));
            this.paper_but.Location = new System.Drawing.Point(946, 410);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 647);
            this.Controls.Add(this.paper_but);
            this.Controls.Add(this.scissors_but);
            this.Controls.Add(this.rock_but);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button rock_but;
        private Button scissors_but;
        private Button paper_but;
        private System.Windows.Forms.Timer timer1;
    }
}