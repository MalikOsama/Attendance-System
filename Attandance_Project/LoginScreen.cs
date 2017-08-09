using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.OleDb;
using System.Threading;
namespace Attandance_Project

{
    public partial class LoginScreen : MetroFramework.Forms.MetroForm
    {
        
        DataClasses1DataContext obj = new DataClasses1DataContext();
    
    
        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void blueButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtname.Text.Trim();
                string pass = txtpass.Text.Trim();
                
                login usr = obj.logins.Where(a => a.User == user).FirstOrDefault();
                login password = obj.logins.Where(a => a.Password== pass).FirstOrDefault();

                if (usr.User == txtname.Text && password.Password == txtpass.Text)
                {
                    panalgrid pa = new panalgrid();
                    pa.Show();
                    this.Hide();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private bool Isvalidated()
        {
            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter User Name");

                txtname.Clear();
                txtname.Focus();
                return false;
            }
            if (txtpass.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Please Enter Password ");
                txtpass.Clear();
                txtpass.Focus();

            }

            return true;

        } 

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void blueButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
