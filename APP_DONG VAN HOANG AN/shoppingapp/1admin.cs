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
        
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            adduser add = new adduser();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            signin sg = new signin();
            sg.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (dus.Text !="")
            {
                DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    
                    DataTable delpl = clsDbConnection.SProcTable("deleteplayer", new Dictionary<string, object>

                    { ["us"] = dus.Text });
                    admin ad = new admin();
                    this.Close();
                    ad.Show();


                }
                else if (dialogResult == DialogResult.No)
                {
                    dus.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Pls enter User");
            }
           
        }

        private void admin_Load(object sender, EventArgs e)
        {
                  

            showallplayer();
        }
        public void showallplayer()
        {
            DataTable show = clsDbConnection.SProcTable("showallplayer", new Dictionary<string, object>

            { });
            dv.DataSource = show;
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dv.Rows[e.RowIndex];
                dus.Text = row.Cells["PlayerName"].Value.ToString();
                if (row.Cells["OnLine_GAMEID"].Value.ToString() != "N/A")
                { DelGameID.Text = row.Cells["OnLine_GAMEID"].Value.ToString(); }

            }
        }

        private void dgame_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DelGameID.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   
                   DataTable delete = clsDbConnection.SProcTable("deleteonlinegame", new Dictionary<string, object>

                    {["gid"]=DelGameID.Text });
                }
                else if (dialogResult == DialogResult.No)
                {
                    dus.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Pls enter Game ID");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dus.Text != "")
            {
                edituser euser = new edituser(dus.Text);
                euser.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Pls enter valid Player Name");
            }
            

            
        }

        private void delete_old_game_Click(object sender, EventArgs e)
        {
            this.Close();
            del_old_game dogame = new del_old_game();
            dogame.Show();

        }
    }
}
