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
    public partial class admin : Form
    {
        private Timer _admintimer = new Timer();
        private int currentIndex;

        public admin()
        {
            InitializeComponent();
            
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            adduser add = new adduser();
            add.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin sg = new signin();
            sg.Show();
        }



        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (user.Text != "Select Player!!!")
            {
                
                DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int lcResult = Convert.ToInt32(clsDbConnection.DbFunction("deleteplayer", new Dictionary<string, object>

                    { ["prUserName"] = user.Text }));

                   
                    if (lcResult==1)
                    {
                        MessageBox.Show("You deleted this player!!");
                    }
                    else
                    {
                        MessageBox.Show("This Player is playing game or is online");
                    }
                    user.Text = "Select Player!!!";

                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                

            }
            else
            {
                MessageBox.Show("Pls enter User");
            }

        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dv.Rows[e.RowIndex];
                user.Text = row.Cells["PlayerName"].Value.ToString();
                if (row.Cells["OnLine_GAMEID"].Value.ToString() != "N/A")
                { DelGameID.Text = row.Cells["OnLine_GAMEID"].Value.ToString(); }

                currentIndex = dv.CurrentRow.Index;
            }

        }

        private void admin_Load(object sender, EventArgs e)
        {
            
            showallplayer();
           
            _admintimer.Interval = (2 * 1000); // 2secs                
            _admintimer.Tick += new EventHandler(admintimer_Tick);
            _admintimer.Start();
            
        }

        private void admintimer_Tick(object sender, EventArgs e)
        {
            showallplayer();
            this.dv.CurrentCell = this.dv.Rows[currentIndex].Cells[0];



        }

        public void showallplayer()
        {
            DataTable show = clsDbConnection.SProcTable("showallplayer", new Dictionary<string, object>

            { });
            dv.DataSource = show;
        }

       

        private void dgame_TextChanged(object sender, EventArgs e)
        {

        }

        private void KillRunningGame_Click(object sender, EventArgs e)
        {
            if (DelGameID.Text != "Select GameID!!!")
            {
                DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int lcResult = Convert.ToInt32(clsDbConnection.DbFunction("deleteonlinegame", new Dictionary<string, object>

                    { ["prGameID"] = DelGameID.Text }));

                    if (lcResult==1)
                    {
                        MessageBox.Show("You killed running game!!!");

                    }
                    else
                    {
                        MessageBox.Show("Fail!!");
                    }
                    DelGameID.Text = "Select GameID!!!";

                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                

            }
            else
            {
                MessageBox.Show("Pls enter Game ID");
            }

        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (user.Text != "Select Player!!!")
            {
                edituser euser = new edituser(user.Text);
                euser.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Pls enter valid Player Name");
            }



        }

        private void delete_old_game_Click(object sender, EventArgs e)
        {
            this.Hide();
            del_old_game dogame = new del_old_game();
            dogame.Show();

        }
    }
}
