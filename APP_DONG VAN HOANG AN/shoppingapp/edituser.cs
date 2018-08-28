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
    public partial class edituser : Form
    {
     

        public edituser( string Value)
        {
            InitializeComponent();

            playername.Text = Value;
            
        }
        

        private void playername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edituser_Load(object sender, EventArgs e)

        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.Show();
            this.Hide();
        }

       

        private void OkClick_Click(object sender, EventArgs e)
        {
            
            
                DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int n,count=0;
                    bool isNumeric = int.TryParse(Hscore.Text, out n);
                // check if value input of highest score  is int data type
                    if ( isNumeric== true)
                        if (Convert.ToInt32(Hscore.Text) >= 0)
                        {
                        DataTable ldUpdateinfo1 = clsDbConnection.SProcTable("updateinfo1", new Dictionary<string, object>

                        { ["prUserName"] = playername.Text, ["scoreNew"] = Hscore.Text });
                        count = count + 1;
                  
                        
                    }
                        else { MessageBox.Show("Pls enter correct Score Info"); }
                     //check if value input is null
                    else if(Hscore.Text=="")
                        {
                            
                        }

                    else  
                     {
                        MessageBox.Show("Pls enter correct Score Info");
                     }
                    //check if pass will be changed
                    if (ps.Text !="")
                    {
                        
                   DataTable ldUpdateinfo2 = clsDbConnection.SProcTable("updateinfo2", new Dictionary<string, object>

                    { ["prUserName"] = playername.Text, ["psNew"] = ps.Text });
                    count = count+1;

                     }
                    //check if any changes to user, then will return admin screen.
                    if (count>0)
                    {
                        MessageBox.Show("You updated player'info");
                        admin ad = new admin();
                        ad.Show();
                        this.Hide();
                    }
                    

                

                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

            
            
        }

        private void resetSigninFailure_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("", "Are You Sure", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataTable dtResetAttempt = clsDbConnection.SProcTable("resetSigninAttempt", new Dictionary<string, object>

                { ["prUserName"] = playername.Text });
                MessageBox.Show("You reseted the number of attempts for this player");
                this.Hide();
                admin ad = new admin();
                ad.Show();
                

            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }

        private void resetOnline_Click(object sender, EventArgs e)
        {
            DataTable ldlistcompetitor = clsDbConnection.SProcTable("resetOnlineStatus", new Dictionary<string, object>

            { ["prUsername"] = playername.Text });
            MessageBox.Show("You reseted the online status for this player");
        }
    }
}
