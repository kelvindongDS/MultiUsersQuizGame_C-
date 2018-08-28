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
    public partial class signin : Form
    {
       
        public signin()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
          if (wus.Text=="" || wps.Text=="" )
            {
                MessageBox.Show("Pls enter information");

            }
          else
            {
                int lcResult = Convert.ToInt32(clsDbConnection.DbFunction("checksignin", new Dictionary<string, object>

                { ["us"] = wus.Text, ["ps"] = wps.Text }));
                admin ad = new admin();
                signin sg = new signin();
                member mem = new member(wus.Text);
                switch (lcResult)
                {
                    case 0:
                        {
                            MessageBox.Show("You enntered incorrect info"); sg.Show(); this.Hide();
                            int lcattempt = Convert.ToInt32(clsDbConnection.DbFunction("attemptincrease", new Dictionary<string, object>
                            {
                                ["prUserName"] = wus.Text
                            }));
                            break;
                        }
                    case 1:
                        {
                            DataTable dtResetAttempt = clsDbConnection.SProcTable("resetSigninAttempt", new Dictionary<string, object>

                            { ["prUserName"] = wus.Text });
                            MessageBox.Show("You logged in");
                            this.Hide();
                            mem.Show();
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("You registered successfully");

                            mem.Show();

                            this.Hide();
                            break;
                        }
                    case 3:
                        {

                            ad.Show();
                            this.Hide();
                            break;

                        }
                    case 4:
                        {
                            MessageBox.Show("You have failed so many times!!! Contact admin"); sg.Show(); this.Hide();
                            break;
                        }
                    case 5:
                        {
                            MessageBox.Show("You already sign in!!"); sg.Show(); this.Hide();
                            break;
                        }

                }
            }
            
            
           
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }
    }
}
