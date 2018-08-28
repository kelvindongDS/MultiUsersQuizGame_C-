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
    public partial class adduser : Form
    {

        int n; bool isNumeric;
       // adduser AddUserForm = new adduser();
        public adduser()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {


            if (us.Text == null|| us.Text =="" || ps.Text==null || ps.Text == ""|| sc.Text==null || sc.Text =="")
            {
                MessageBox.Show("Pls enter enough infor!!");
            }
            else

                
                isNumeric = int.TryParse(sc.Text, out n);
                if (isNumeric==true)
                {
                    if (Convert.ToInt32(sc.Text)>0)
                    {
                        int lcaddplayer = Convert.ToInt32(clsDbConnection.DbFunction("addplayer", new Dictionary<string, object>
                        { ["prUserName"] = us.Text, ["prPassWord"] = ps.Text, ["psScore"] = sc.Text }));


                        if (lcaddplayer == 1)
                        {
                            MessageBox.Show("You added this user");
                           

                        }
                        else
                        {
                            MessageBox.Show("This user is existed");

                            
                        
                         }
                        this.Close();
                        adduser ad = new adduser();
                        ad.Show();
                    }
                    else { MessageBox.Show("Pls enter score >0"); }
                }
                else { MessageBox.Show("score is a number"); }
           
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }
    }
}
