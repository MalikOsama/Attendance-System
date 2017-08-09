using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace Attandance_Project
{
    public partial class Change_Password : MetroFramework.Forms.MetroForm
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void purpleButton1_Click(object sender, EventArgs e)
        {
            if (IsValidated()) {
                try
                {
                    SqlConnection con=new SqlConnection("Data Source=.;Initial Catalog=Attandance_System;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd=con.CreateCommand();
                    cmd.CommandText=@"UPDATE [dbo].[login]
                SET [Password] =  '"+txtrepass.Text+"' WHERE User'"+txtusername.Text+"'";
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Saved");
                    LoginScreen lo = new LoginScreen();
                    lo.Show();
                    this.Hide();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);

                
                
                }
            
            
            }

           
        }

        private void UpdatePassword()
        {
//            string stringcon = ConfigurationManager.ConnectionStrings["Login"].ConnectionString;
//            string strcmd = "UPDATE Login SET [Password]=@Password WHERE User=@User ";

//            using (OleDbConnection con=new OleDbConnection(stringcon))
//{
//    using (OleDbCommand cmd=new OleDbCommand(strcmd,con))
//    {
//        con.Open();
//        cmd.Parameters.AddWithValue("@Password", txtrepass.Text.Trim());
//        cmd.Parameters.AddWithValue("@User", UserSaved.UserName);
        

//        cmd.ExecuteNonQuery();

//    }
                
//            }
        }

        private bool IsValidated()
        {
            if (txtnewpass.Text.Trim() == string.Empty) { 
            MessageBox.Show("Please Enter User Name","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtnewpass.Focus();
                return false;

            
            }
            if (txtnewpass.Text.Trim() == string.Empty) {
                MessageBox.Show("Please Enter New Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnewpass.Focus();
                return false;
            
            }
            if (txtrepass.Text.Trim() == string.Empty) {

                MessageBox.Show("Please Enter RE Enter Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrepass.Focus();
                return false;
            }
            if (txtnewpass.Text.Trim() != txtrepass.Text.Trim()) {

                MessageBox.Show("Password Not Match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrepass.Focus();
                return false;
            }


            return true;

        }

        
        private void grayButton1_Click(object sender, EventArgs e)
        {
            LoginScreen log = new LoginScreen();
            log.Show();
            this.Hide();

        }

        private void purpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
