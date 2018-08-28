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

    public partial class del_old_game : Form
    {
        private Timer _delgametimer = new Timer();
        private int currentIndex;

        public del_old_game()
        {
            InitializeComponent();
        }

        private void del_old_game_Load(object sender, EventArgs e)
        {
            showscreen();

            _delgametimer.Interval = (1 * 1000); // 2secs
            _delgametimer.Tick += new EventHandler(_delgametimer_Tick);
            _delgametimer.Start();


        }
        private void _delgametimer_Tick(object sender, EventArgs e)
        {
            showscreen();
            this.dv.CurrentCell = this.dv.Rows[currentIndex].Cells[0];

        }

        private void showscreen()
        {
            DataTable lcdelgame = clsDbConnection.SProcTable("showoldgame", new Dictionary<string, object>

            { });
            dv.DataSource = lcdelgame;
        }

        private void dv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dv.Rows[e.RowIndex];
                delGameID.Text = row.Cells["GameID"].Value.ToString();
                currentIndex = dv.CurrentRow.Index;


            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
           if (delGameID.Text== "OLD_GAME_ID")
            {
                MessageBox.Show("Pls select Game!!!");

            }
           else
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                   
                    DataTable lcdelgame = clsDbConnection.SProcTable("deletegame", new Dictionary<string, object>

                    { ["prGameID"] = delGameID.Text });

                    delGameID.Text = "OLD_GAME_ID";

                }
                
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.Show();
        }
    }
}
