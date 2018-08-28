namespace quizgame
{
    partial class member
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
            this.listcomp = new System.Windows.Forms.DataGridView();
            this.player = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opponent = new System.Windows.Forms.Label();
            this.Send_Challenge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listcomp)).BeginInit();
            this.SuspendLayout();
            // 
            // listcomp
            // 
            this.listcomp.AllowUserToAddRows = false;
            this.listcomp.AllowUserToDeleteRows = false;
            this.listcomp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listcomp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listcomp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listcomp.Location = new System.Drawing.Point(120, 44);
            this.listcomp.Name = "listcomp";
            this.listcomp.ReadOnly = true;
            this.listcomp.RowHeadersWidth = 80;
            this.listcomp.RowTemplate.Height = 24;
            this.listcomp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listcomp.Size = new System.Drawing.Size(542, 190);
            this.listcomp.TabIndex = 0;
            this.listcomp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listcomp_CellContentClick);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(72, 9);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(16, 17);
            this.player.TabIndex = 1;
            this.player.Text = "a";
            this.player.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(12, 351);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 30);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Opponent:";
            // 
            // opponent
            // 
            this.opponent.AutoSize = true;
            this.opponent.Location = new System.Drawing.Point(313, 271);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(106, 17);
            this.opponent.TabIndex = 6;
            this.opponent.Text = "Find someone!!!";
            // 
            // Send_Challenge
            // 
            this.Send_Challenge.Location = new System.Drawing.Point(462, 264);
            this.Send_Challenge.Name = "Send_Challenge";
            this.Send_Challenge.Size = new System.Drawing.Size(148, 30);
            this.Send_Challenge.TabIndex = 7;
            this.Send_Challenge.Text = "Send A Challenge ";
            this.Send_Challenge.UseVisualStyleBackColor = true;
            this.Send_Challenge.Click += new System.EventHandler(this.Send_Challenge_Click);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Send_Challenge);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.player);
            this.Controls.Add(this.listcomp);
            this.Name = "member";
            this.Text = "member";
            this.Load += new System.EventHandler(this.member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listcomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listcomp;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label opponent;
        private System.Windows.Forms.Button Send_Challenge;
    }
}