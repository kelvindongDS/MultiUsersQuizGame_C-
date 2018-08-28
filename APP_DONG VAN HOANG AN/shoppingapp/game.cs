using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizgame
{
    
    public partial class game : Form
        
    {
        private Timer _gametimer = new Timer();
        private string _result;
        private int _gameStatus;
        signin sg = new signin();
        private int count=1;
        
        
       
        public game( string value)
        {
            InitializeComponent();
            player.Text = value;
           
            
            
        }
       public void playname()
        {
            _result = Convert.ToString(clsDbConnection.DbFunction("P1InPlayWith", new Dictionary<string, object>

            { ["myname"] = player.Text }));
            opponent.Text = _result;

        }
        
        private void end()
        {
            _gametimer.Stop();
            MessageBox.Show("Your Game Ended!!!");

            int _winner = Convert.ToInt32(clsDbConnection.DbFunction("endgameinfo", new Dictionary<string, object>

            { ["prUserName"] = player.Text, ["prOpponent"] = opponent.Text }));

            switch (_winner)
            {
                case 0:
                    {
                        MessageBox.Show("EVEN"); break;
                    }

                case 1:
                    {
                        MessageBox.Show(player.Text, "YOU LOSE"); break;
                    }
                case 2:
                    {
                        MessageBox.Show(player.Text, "YOU WON"); break;
                    }


            }
        }

        private void game_Load(object sender, EventArgs e)
        {
            playname();
            nextscreeninfo();


           


            _gametimer.Interval = (1 * 1000); // 2secs
            _gametimer.Tick += new EventHandler(gametimer_Tick);
            _gametimer.Start();
            
            
        }
        private void gametimer_Tick(object sender, EventArgs e)
        {

            
            //RUN NORMAL GAME
            if (_gameStatus == 2)
            {
                count = count+1;
                nextscreeninfo();
                countquestion.Text = Convert.ToString(count);
                Go.Enabled = true;
                
                 DataTable _resetGameStart = clsDbConnection.SProcTable("resetgamestatus", new Dictionary<string, object>

                { ["prUserName"] = player.Text,["prGameStatus"]=0 });
                

             }

           
            {
                _gameStatus = Convert.ToInt32(clsDbConnection.DbFunction("gamestatus", new Dictionary<string, object>

                { ["prUserName"] = player.Text }));
            }

            
            // END GAME
            if (_gameStatus == 3)
            {
                end();
                member mem1 = new member(player.Text);
                this.Hide();
                mem1.Show();


            }
           
            


            // check game status when  TURN NUMBER=> if either of player reach max turn, then set gamestatus to end(3).
            {
                DataTable _exitgame = clsDbConnection.SProcTable("endgame", new Dictionary<string, object>

                { ["prUserName"] = player.Text });

            }

            //check online status to close forms if ONLINE STATUS is OFFLINE
            int lcOnline = Convert.ToInt32(clsDbConnection.DbFunction("OnlineStatus", new Dictionary<string, object>

            { ["prUserName"] = player.Text }));
            if (lcOnline == 0)
            {
                DataTable _setGameEnd = clsDbConnection.SProcTable("resetgamestatus", new Dictionary<string, object>

                { ["prUserName"] = player.Text, ["prGameStatus"] = 3 });

                end();               


                DataTable ldlistcompetitor = clsDbConnection.SProcTable("resetOnlineStatus", new Dictionary<string, object>

                { ["prUsername"] = player.Text });


                member mem1 = new member(player.Text);
                this.Hide();
                mem1.Show();




            }


        }
       

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void Opt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Opt1.SelectedItem != null) { answer.Text = "A"; }
        }

        private void Opt2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Opt2.SelectedItem != null) { answer.Text = "B"; }
        }

        private void Opt3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Opt3.SelectedItem != null) { answer.Text = "C"; }
        }

        private void Opt4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Opt4.SelectedItem != null) { answer.Text = "D"; }
        }

        private void noanswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noanswer.SelectedItem != null) { answer.Text = null; }
        }

        private void nextscreeninfo()
        {
            DataTable info1 = clsDbConnection.SProcTable("nextscreeninfo", new Dictionary<string, object>

            { ["prUserName"] = player.Text });

            DataTable info2 = clsDbConnection.SProcTable("nextscreeninfo", new Dictionary<string, object>

            { ["prUserName"] = opponent.Text });

            DataTable mark = clsDbConnection.SProcTable("nextscreeninfo2", new Dictionary<string, object>

            { ["prUserName"] = player.Text });

           
            turn1.DataSource = null;
            score1.DataSource = null;
            turn2.DataSource = null;
            score2.DataSource = null;
            LiAddmark.DataSource = null;
            LiSubstractMark.DataSource = null;

            turn1.DataSource = (from DataRow lcRow in info1.Rows

                                select lcRow["TurnNumber"]).ToList();

            turn2.DataSource = (from DataRow lcRow in info2.Rows

                                select lcRow["TurnNumber"]).ToList();

            score1.DataSource = (from DataRow lcRow in info1.Rows

                                 select lcRow["Score"]).ToList();

            score2.DataSource = (from DataRow lcRow in info2.Rows

                                 select lcRow["Score"]).ToList();

            LiAddmark.DataSource = (from DataRow lcRow in mark.Rows

                                    select lcRow["AddMark"]).ToList();
            LiSubstractMark.DataSource = (from DataRow lcRow in mark.Rows

                                          select lcRow["SubtractedMark"]).ToList();


            DataTable quesnew = clsDbConnection.SProcTable("nextscreeninfo3", new Dictionary<string, object>

            { ["prUserName"] = player.Text });

            question_list.DataSource = null;
            Opt1.DataSource = null;
            Opt2.DataSource = null;
            Opt3.DataSource = null;
            Opt4.DataSource = null;

            question_list.DataSource = (from DataRow lcRow in quesnew.Rows

                                        select lcRow["QuestionDetail"]).ToList();

            Opt1.DataSource = (from DataRow lcRow in quesnew.Rows

                               select lcRow["Option1"]).ToList();
            Opt2.DataSource = (from DataRow lcRow in quesnew.Rows

                               select lcRow["Option2"]).ToList();
            Opt3.DataSource = (from DataRow lcRow in quesnew.Rows

                               select lcRow["Option3"]).ToList();
            Opt4.DataSource = (from DataRow lcRow in quesnew.Rows

                               select lcRow["Option4"]).ToList();


           

        }
        private void Go_Click(object sender, EventArgs e)
        {
            

            DataTable GonNewinfo1 = clsDbConnection.SProcTable("Gonextscreen", new Dictionary<string, object>

            { ["prUserName"] = player.Text , ["prAnswer"] = answer.Text });

            Go.Enabled = false;  



        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataTable _setGameEnd = clsDbConnection.SProcTable("resetgamestatus", new Dictionary<string, object>

                { ["prUserName"] = player.Text, ["prGameStatus"] = 3 });
                
            }
               
            

        }
    }
        
}
