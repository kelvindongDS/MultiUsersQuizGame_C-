namespace quizgame
{
    partial class adduser
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
            this.us = new System.Windows.Forms.TextBox();
            this.ps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // us
            // 
            this.us.Location = new System.Drawing.Point(324, 31);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(100, 22);
            this.us.TabIndex = 1;
            // 
            // ps
            // 
            this.ps.Location = new System.Drawing.Point(324, 90);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(100, 22);
            this.ps.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // sc
            // 
            this.sc.Location = new System.Drawing.Point(324, 162);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(100, 22);
            this.sc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(205, 236);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.us);
            this.Controls.Add(this.label1);
            this.Name = "adduser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox us;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
    }
}

