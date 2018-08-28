namespace quizgame
{
    partial class game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.opponent = new System.Windows.Forms.Label();
            this.question_list = new System.Windows.Forms.ListBox();
            this.Opt1 = new System.Windows.Forms.ListBox();
            this.Opt2 = new System.Windows.Forms.ListBox();
            this.Opt3 = new System.Windows.Forms.ListBox();
            this.Opt4 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.countquestion = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.noanswer = new System.Windows.Forms.ListBox();
            this.Go = new System.Windows.Forms.Button();
            this.turn1 = new System.Windows.Forms.ListBox();
            this.score1 = new System.Windows.Forms.ListBox();
            this.turn2 = new System.Windows.Forms.ListBox();
            this.score2 = new System.Windows.Forms.ListBox();
            this.answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LiAddmark = new System.Windows.Forms.ListBox();
            this.LiSubstractMark = new System.Windows.Forms.ListBox();
            this.ExitGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome:";
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(88, 34);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(70, 17);
            this.player.TabIndex = 3;
            this.player.Text = "Welcome:";
            // 
            // opponent
            // 
            this.opponent.AutoSize = true;
            this.opponent.Location = new System.Drawing.Point(779, 34);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(56, 17);
            this.opponent.TabIndex = 4;
            this.opponent.Text = "Player2";
            // 
            // question_list
            // 
            this.question_list.FormattingEnabled = true;
            this.question_list.ItemHeight = 16;
            this.question_list.Location = new System.Drawing.Point(161, 195);
            this.question_list.Name = "question_list";
            this.question_list.Size = new System.Drawing.Size(591, 68);
            this.question_list.TabIndex = 5;
            // 
            // Opt1
            // 
            this.Opt1.FormattingEnabled = true;
            this.Opt1.ItemHeight = 16;
            this.Opt1.Location = new System.Drawing.Point(161, 279);
            this.Opt1.Name = "Opt1";
            this.Opt1.Size = new System.Drawing.Size(591, 36);
            this.Opt1.TabIndex = 6;
            this.Opt1.SelectedIndexChanged += new System.EventHandler(this.Opt1_SelectedIndexChanged);
            // 
            // Opt2
            // 
            this.Opt2.FormattingEnabled = true;
            this.Opt2.ItemHeight = 16;
            this.Opt2.Location = new System.Drawing.Point(161, 337);
            this.Opt2.Name = "Opt2";
            this.Opt2.Size = new System.Drawing.Size(591, 36);
            this.Opt2.TabIndex = 7;
            this.Opt2.SelectedIndexChanged += new System.EventHandler(this.Opt2_SelectedIndexChanged);
            // 
            // Opt3
            // 
            this.Opt3.FormattingEnabled = true;
            this.Opt3.ItemHeight = 16;
            this.Opt3.Location = new System.Drawing.Point(161, 390);
            this.Opt3.Name = "Opt3";
            this.Opt3.Size = new System.Drawing.Size(591, 36);
            this.Opt3.TabIndex = 8;
            this.Opt3.SelectedIndexChanged += new System.EventHandler(this.Opt3_SelectedIndexChanged);
            // 
            // Opt4
            // 
            this.Opt4.FormattingEnabled = true;
            this.Opt4.ItemHeight = 16;
            this.Opt4.Location = new System.Drawing.Point(161, 452);
            this.Opt4.Name = "Opt4";
            this.Opt4.Size = new System.Drawing.Size(591, 36);
            this.Opt4.TabIndex = 9;
            this.Opt4.SelectedIndexChanged += new System.EventHandler(this.Opt4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max Turn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max Turn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Turn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(779, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Turn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Score";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(779, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Score";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Answer";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(285, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(196, 39);
            this.label20.TabIndex = 30;
            this.label20.Text = "QUESTION";
            // 
            // countquestion
            // 
            this.countquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countquestion.Location = new System.Drawing.Point(487, 58);
            this.countquestion.Name = "countquestion";
            this.countquestion.Size = new System.Drawing.Size(81, 39);
            this.countquestion.TabIndex = 31;
            this.countquestion.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(542, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 39);
            this.label22.TabIndex = 32;
            this.label22.Text = "/10";
            // 
            // noanswer
            // 
            this.noanswer.FormattingEnabled = true;
            this.noanswer.ItemHeight = 16;
            this.noanswer.Items.AddRange(new object[] {
            "I don\'t want to answer this question. Let move on!!!!"});
            this.noanswer.Location = new System.Drawing.Point(161, 509);
            this.noanswer.Name = "noanswer";
            this.noanswer.Size = new System.Drawing.Size(591, 36);
            this.noanswer.TabIndex = 33;
            this.noanswer.SelectedIndexChanged += new System.EventHandler(this.noanswer_SelectedIndexChanged);
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(18, 240);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 34;
            this.Go.Text = "GO";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // turn1
            // 
            this.turn1.FormattingEnabled = true;
            this.turn1.ItemHeight = 16;
            this.turn1.Location = new System.Drawing.Point(94, 112);
            this.turn1.Name = "turn1";
            this.turn1.Size = new System.Drawing.Size(59, 20);
            this.turn1.TabIndex = 36;
            // 
            // score1
            // 
            this.score1.FormattingEnabled = true;
            this.score1.ItemHeight = 16;
            this.score1.Location = new System.Drawing.Point(94, 153);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(59, 20);
            this.score1.TabIndex = 37;
            // 
            // turn2
            // 
            this.turn2.FormattingEnabled = true;
            this.turn2.ItemHeight = 16;
            this.turn2.Location = new System.Drawing.Point(861, 112);
            this.turn2.Name = "turn2";
            this.turn2.Size = new System.Drawing.Size(59, 20);
            this.turn2.TabIndex = 40;
            // 
            // score2
            // 
            this.score2.FormattingEnabled = true;
            this.score2.ItemHeight = 16;
            this.score2.Location = new System.Drawing.Point(861, 156);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(59, 20);
            this.score2.TabIndex = 41;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(91, 195);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(54, 17);
            this.answer.TabIndex = 42;
            this.answer.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "8";
            // 
            // LiAddmark
            // 
            this.LiAddmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiAddmark.FormattingEnabled = true;
            this.LiAddmark.ItemHeight = 48;
            this.LiAddmark.Location = new System.Drawing.Point(333, 134);
            this.LiAddmark.Name = "LiAddmark";
            this.LiAddmark.Size = new System.Drawing.Size(65, 52);
            this.LiAddmark.TabIndex = 47;
            // 
            // LiSubstractMark
            // 
            this.LiSubstractMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiSubstractMark.FormattingEnabled = true;
            this.LiSubstractMark.ItemHeight = 48;
            this.LiSubstractMark.Location = new System.Drawing.Point(574, 134);
            this.LiSubstractMark.Name = "LiSubstractMark";
            this.LiSubstractMark.Size = new System.Drawing.Size(65, 52);
            this.LiSubstractMark.TabIndex = 48;
            // 
            // ExitGame
            // 
            this.ExitGame.Location = new System.Drawing.Point(817, 522);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(75, 23);
            this.ExitGame.TabIndex = 49;
            this.ExitGame.Text = "Exit";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 571);
            this.ControlBox = false;
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.LiSubstractMark);
            this.Controls.Add(this.LiAddmark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.turn2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.turn1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.noanswer);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.countquestion);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Opt4);
            this.Controls.Add(this.Opt3);
            this.Controls.Add(this.Opt2);
            this.Controls.Add(this.Opt1);
            this.Controls.Add(this.question_list);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label opponent;
        private System.Windows.Forms.ListBox question_list;
        private System.Windows.Forms.ListBox Opt1;
        private System.Windows.Forms.ListBox Opt2;
        private System.Windows.Forms.ListBox Opt3;
        private System.Windows.Forms.ListBox Opt4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label countquestion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListBox noanswer;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.ListBox turn1;
        private System.Windows.Forms.ListBox score1;
        private System.Windows.Forms.ListBox turn2;
        private System.Windows.Forms.ListBox score2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LiAddmark;
        private System.Windows.Forms.ListBox LiSubstractMark;
        private System.Windows.Forms.Button ExitGame;
    }
}