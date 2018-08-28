namespace quizgame
{
    partial class edituser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playername = new System.Windows.Forms.TextBox();
            this.ps = new System.Windows.Forms.TextBox();
            this.Hscore = new System.Windows.Forms.TextBox();
            this.OkClick = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.resetSigninFailure = new System.Windows.Forms.Button();
            this.resetOnline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDIT USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAYER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "HIGHEST SCORE";
            // 
            // playername
            // 
            this.playername.Location = new System.Drawing.Point(166, 76);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(100, 22);
            this.playername.TabIndex = 4;
            this.playername.TextChanged += new System.EventHandler(this.playername_TextChanged);
            // 
            // ps
            // 
            this.ps.Location = new System.Drawing.Point(166, 154);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(100, 22);
            this.ps.TabIndex = 5;
            // 
            // Hscore
            // 
            this.Hscore.Location = new System.Drawing.Point(166, 220);
            this.Hscore.Name = "Hscore";
            this.Hscore.Size = new System.Drawing.Size(100, 22);
            this.Hscore.TabIndex = 6;
            // 
            // OkClick
            // 
            this.OkClick.Location = new System.Drawing.Point(121, 280);
            this.OkClick.Name = "OkClick";
            this.OkClick.Size = new System.Drawing.Size(75, 23);
            this.OkClick.TabIndex = 7;
            this.OkClick.Text = "OK";
            this.OkClick.UseVisualStyleBackColor = true;
            this.OkClick.Click += new System.EventHandler(this.OkClick_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // resetSigninFailure
            // 
            this.resetSigninFailure.Location = new System.Drawing.Point(19, 355);
            this.resetSigninFailure.Name = "resetSigninFailure";
            this.resetSigninFailure.Size = new System.Drawing.Size(295, 23);
            this.resetSigninFailure.TabIndex = 9;
            this.resetSigninFailure.Text = "RESET NUMBERS OF SIGNIN FAILTURE";
            this.resetSigninFailure.UseVisualStyleBackColor = true;
            this.resetSigninFailure.Click += new System.EventHandler(this.resetSigninFailure_Click);
            // 
            // resetOnline
            // 
            this.resetOnline.Location = new System.Drawing.Point(41, 404);
            this.resetOnline.Name = "resetOnline";
            this.resetOnline.Size = new System.Drawing.Size(225, 23);
            this.resetOnline.TabIndex = 10;
            this.resetOnline.Text = "RESET ONLINE STATUS";
            this.resetOnline.UseVisualStyleBackColor = true;
            this.resetOnline.Click += new System.EventHandler(this.resetOnline_Click);
            // 
            // edituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.ControlBox = false;
            this.Controls.Add(this.resetOnline);
            this.Controls.Add(this.resetSigninFailure);
            this.Controls.Add(this.back);
            this.Controls.Add(this.OkClick);
            this.Controls.Add(this.Hscore);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.playername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "edituser";
            this.Text = "edituser";
            this.Load += new System.EventHandler(this.edituser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox playername;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.TextBox Hscore;
        private System.Windows.Forms.Button OkClick;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button resetSigninFailure;
        private System.Windows.Forms.Button resetOnline;
    }
}