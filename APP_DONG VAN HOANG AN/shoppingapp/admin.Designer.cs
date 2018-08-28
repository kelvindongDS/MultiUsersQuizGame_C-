namespace quizgame
{
    partial class admin
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
            this.AddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.dv = new System.Windows.Forms.DataGridView();
            this.KillRunningGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditUser = new System.Windows.Forms.Button();
            this.delete_old_game = new System.Windows.Forms.Button();
            this.DelGameID = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(402, 393);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(131, 23);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "ADD USER";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMIN SETTING";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(29, 30);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.CausesValidation = false;
            this.DeleteUser.Location = new System.Drawing.Point(381, 347);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(176, 23);
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Text = "DELETE  USER";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // dv
            // 
            this.dv.AllowUserToAddRows = false;
            this.dv.AllowUserToDeleteRows = false;
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dv.Location = new System.Drawing.Point(29, 79);
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            this.dv.RowTemplate.Height = 24;
            this.dv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dv.Size = new System.Drawing.Size(834, 185);
            this.dv.TabIndex = 4;
            this.dv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellContentClick);
            // 
            // KillRunningGame
            // 
            this.KillRunningGame.CausesValidation = false;
            this.KillRunningGame.Location = new System.Drawing.Point(381, 298);
            this.KillRunningGame.Name = "KillRunningGame";
            this.KillRunningGame.Size = new System.Drawing.Size(176, 23);
            this.KillRunningGame.TabIndex = 7;
            this.KillRunningGame.Text = "KILL RUNNING  GAME";
            this.KillRunningGame.UseVisualStyleBackColor = true;
            this.KillRunningGame.Click += new System.EventHandler(this.KillRunningGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "PLAYER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ONLINE_GAMEID";
            // 
            // EditUser
            // 
            this.EditUser.CausesValidation = false;
            this.EditUser.Location = new System.Drawing.Point(594, 346);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(176, 23);
            this.EditUser.TabIndex = 11;
            this.EditUser.Text = "EDIT  USER";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // delete_old_game
            // 
            this.delete_old_game.Location = new System.Drawing.Point(381, 450);
            this.delete_old_game.Name = "delete_old_game";
            this.delete_old_game.Size = new System.Drawing.Size(176, 23);
            this.delete_old_game.TabIndex = 12;
            this.delete_old_game.Text = "DELETE OLD GAME";
            this.delete_old_game.UseVisualStyleBackColor = true;
            this.delete_old_game.Click += new System.EventHandler(this.delete_old_game_Click);
            // 
            // DelGameID
            // 
            this.DelGameID.AutoSize = true;
            this.DelGameID.Location = new System.Drawing.Point(240, 301);
            this.DelGameID.Name = "DelGameID";
            this.DelGameID.Size = new System.Drawing.Size(111, 17);
            this.DelGameID.TabIndex = 13;
            this.DelGameID.Text = "Select GameID!!!";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(240, 353);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 17);
            this.user.TabIndex = 14;
            this.user.Text = "Select Player!!!";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 502);
            this.Controls.Add(this.user);
            this.Controls.Add(this.DelGameID);
            this.Controls.Add(this.delete_old_game);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KillRunningGame);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUser);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Button KillRunningGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button delete_old_game;
        private System.Windows.Forms.Label DelGameID;
        private System.Windows.Forms.Label user;
    }
}