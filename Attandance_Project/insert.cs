using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attandance_Project
{
    public partial class insert : MetroFramework.Forms.MetroForm
    {
        public insert()
        {
            InitializeComponent();
        }
        DataClasses1DataContext obj = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
        private bool Validation()
        {
            if (txtroll.Text == "")
            {
                txtroll.BackColor = Color.Purple;
                MessageBox.Show("Enter Roll No!","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtroll.Focus();
                return false;
            }
            else
            {
                int roll;
                if (!int.TryParse(txtroll.Text, out roll))
                {
                    MessageBox.Show("Enter Only Digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtroll.Focus();
                    return false;


                }
                if (txtname.Text == "")
                {
                    MessageBox.Show("Please Enter Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtname.BackColor = Color.Pink;
                    txtname.Focus();
                    return false;

                }
                if (txtfather.Text == "")
                {
                    MessageBox.Show("Please Enter Father Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfather.Focus();
                    return false;


                }
                if (combodepartment.Text == "")
                {
                    MessageBox.Show("Please Select Department", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    combodepartment.Focus();
                    return false;

                }
                if (comboyear.Text == "")
                {
                    MessageBox.Show("Please Select Year", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboyear.Focus();
                    return false;
                }
                if (txtmobile.Text == "")
                {
                    MessageBox.Show("Please Enter Mobile Number ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmobile.Focus();

                    return false;

                }
                if (txtnic.Text == "")
                {
                    MessageBox.Show("Please Enter CNIC", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnic.Focus();
                    return false;
                }
                if (txtpic.Text == "") {
                    MessageBox.Show("Please Browse Picture","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                }
            }



            return true;

        }


        private void btnregistration_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string gender = "";
                bool cheak = male.Checked;
                if (cheak)
                    gender = "Male";
                else
                    gender = "Female";

                try
                {
                    Registration register = new Registration();
                    register.Roll = txtroll.Text;
                    register.Name = txtname.Text;
                    register.Father = txtfather.Text;
                    register.Gender = gender.ToString();
                    register.Department = combodepartment.Text;
                    register.Batch_Year = comboyear.Text;
                    register.Cnic = txtnic.Text;
                    register.Mobile = txtmobile.Text;
                    register.Email = txtemail.Text;
                    register.Addresss = txtaddress.Text;
                    register.Computer_code = txtcode.Text;
                    DateTime dt = DateTime.Now;
                    var localitme = dt.ToLocalTime();
                    register.Date_Time = localitme.ToString();
                    //register.Date_Time = metroDateTime1.Text;
                    register.Picture = txtpic.Text;
                    obj.Registrations.InsertOnSubmit(register);
                    obj.SubmitChanges();

                    MessageBox.Show("Saved Successfully ");
                    txtroll.Text = "";
                    txtname.Text = "";
                    txtfather.Text = "";
                    txtemail.Text = "";
                    txtmobile.Text = "";
                    txtnic.Text = "";
                    txtcode.Text = "";
                    txtaddress.Text = "";
                    txtpic.Text = "";

                }
                catch (Exception)
                {

                    MessageBox.Show("sorry");
                }
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                txtpic.Text = openFileDialog1.FileName;
                pictureBox.Load(txtpic.Text);
            
            
            }
        }

        private void grayButton1_Click(object sender, EventArgs e)
        {
            panalgrid panal = new panalgrid();
            panal.Show();
            this.Hide();
        }
    }
}
