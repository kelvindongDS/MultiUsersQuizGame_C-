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
    public partial class member : Form
    {
        private Timer _timer = new Timer();
        private game _ga;
        signin sg = new signin();
        private int currentIndex;


        public member(string value)
        {
            InitializeComponent();
            player.Text = value;

            if (_ga == null)
            {
                _ga = new game(player.Text);
                
            }


        }

        public void listcompetitor()
        {
            
           
            DataTable ldlistcompetitor = clsDbConnection.SProcTable("showplayer", new Dictionary<string, object>

            { ["prUsername"] = player.Text });
            listcomp.DataSource = ldlistcompetitor;
            

        }

        private void listcomp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listcomp.Rows[e.RowIndex];
                opponent.Text = row.Cells["PlayerName"].Value.ToString();
                currentIndex = listcomp.CurrentRow.Index;             
                 


            }
        }
        
        public string result = "";
        public int waiting=1;

       



        public void member_Load(object sender, EventArgs e)
        {
            listcompetitor();
                      
            //set timer
            
            if (waiting==1)
            {
                _timer.Interval = (2 * 1000); // 2secs                
                _timer.Tick += new EventHandler(timer_Tick);               
                _timer.Start();
                
            }
           
                       

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            listcompetitor();
            
            this.listcomp.CurrentCell = this.listcomp.Rows[currentIndex].Cells[0];

             playwith();

            if (result != "")
            {
                _timer.Stop();
                waiting = 0;
                               
                MessageBox.Show(result,"You will play with");
                this.Hide();
                _ga.Show();
                
            }

            //check online status to close forms if ppssible
            int lcOnline = Convert.ToInt32(clsDbConnection.DbFunction("OnlineStatus", new Dictionary<string, object>

            { ["prUserName"] = player.Text }));
            if (lcOnline==0)
            {
               
                this.Hide();
                _timer.Stop();
                sg.Show();

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {

            DataTable ldupdate = clsDbConnection.SProcTable("logout", new Dictionary<string, object>

            { ["prUserName"] = player.Text });
            
            this.Hide();
            _timer.Stop();
            sg.Show();
        }
        public void playwith()
        {
            result = Convert.ToString(clsDbConnection.DbFunction("P1InPlayWith", new Dictionary<string, object>

            { ["myname"] = player.Text }));

        }
        public void startgame()
        {
            
            string  result1 = Convert.ToString(clsDbConnection.DbFunction("P1InPlayWith", new Dictionary<string, object>

            { ["myname"] = player.Text }));

           string result2 = Convert.ToString(clsDbConnection.DbFunction("P1InPlayWith", new Dictionary<string, object>

            { ["myname"] = opponent.Text }));
            if (result1 == "" & result2 == "")
            {
                DataTable start = clsDbConnection.SProcTable("startgame", new Dictionary<string, object>

                { ["player1"] = player.Text, ["player2"] = opponent.Text });
                this.Hide();
                _ga.ShowDialog();

            }
            else
            {
                MessageBox.Show("Pls select another player!!!");
            }
                     

            }


        private void Send_Challenge_Click(object sender, EventArgs e)
        {
            if (opponent.Text == "Find someone!!!")
            {
                MessageBox.Show("Pls select your opponent!!!");
            }
            else
            {
                startgame();
            }
           
        }
    }

}
