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
    public partial class Update_Delete : MetroFramework.Forms.MetroForm
    {
        public Update_Delete()
        {
            InitializeComponent();
        }
        DataClasses1DataContext obj = new DataClasses1DataContext();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void blueButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string q = txtsearch.Text.Trim();
                Registration reg = obj.Registrations.Where(a => a.Roll == q).SingleOrDefault();
                txtroll.Text = reg.Roll;
                txtname.Text = reg.Name;
                txtfather.Text = reg.Father;
                combodepartment.Text = reg.Department;
                comboyear.Text = reg.Batch_Year;
                txtcode.Text = reg.Computer_code;

                txtmobile.Text = reg.Mobile;
                txtemail.Text = reg.Email;
                txtaddress.Text = reg.Addresss;
                txtnic.Text = reg.Cnic;
                pictureBox.Load(reg.Picture);
                txtpic.Text = reg.Picture;
                blueButton3.Enabled = true;
                btndelete.Enabled = true;
              
            }
            catch (Exception) {
                MessageBox.Show("Not Found");
            
            }
        }

        private void blueButton3_Click(object sender, EventArgs e)
        {
            string value ="";
            bool ac=male.Checked;
            if(ac)
                value="Male";
            else
                value="Female";
            try
            {
                string src = txtsearch.Text.Trim();
                Registration regis = obj.Registrations.Where(a => a.Roll == src).SingleOrDefault();
                regis.Roll = txtroll.Text.Trim();
                regis.Name = txtname.Text.Trim();
                regis.Father = txtfather.Text.Trim();
                regis.Gender = value.ToString();
                regis.Department = combodepartment.Text;
                regis.Batch_Year = comboyear.Text;
                regis.Cnic = txtnic.Text;
                regis.Mobile = txtmobile.Text;
                regis.Computer_code = txtcode.Text;
                regis.Email = txtemail.Text;
                regis.Picture = txtpic.Text;
                regis.Addresss = txtaddress.Text;

                obj.SubmitChanges();
                
                MessageBox.Show("Successfully Updated");
            }
            catch (Exception) {
                MessageBox.Show("Not Updated Record");
            
            }
            txtroll.Text = "";
            txtsearch.Text = "";
            txtname.Text = "";
            txtfather.Text = "";
            combodepartment.Text = "";
            comboyear.Text = "";
            txtcode.Text = "";

            txtmobile.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
            txtnic.Text ="";
            txtcode.Text = "";
            txtpic.Text = "";
            pictureBox.Visible = false;
        }

        private void blueButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {

                txtpic.Text = openFileDialog1.FileName;
                pictureBox.Load(txtpic.Text);
            
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string src = txtsearch.Text.Trim();
                Registration regis = obj.Registrations.Where(a => a.Roll == src).SingleOrDefault();
                regis.Roll = txtroll.Text.Trim();
                regis.Name = txtname.Text.Trim();
                regis.Father = txtfather.Text.Trim();
                // regis.Gender = value.ToString();
                regis.Department = combodepartment.Text;
                regis.Batch_Year = comboyear.Text;
                regis.Cnic = txtnic.Text;
                regis.Mobile = txtmobile.Text;
                regis.Computer_code = txtcode.Text;
                regis.Email = txtemail.Text;
                regis.Picture = txtpic.Text;
                regis.Addresss = txtaddress.Text;
                obj.Registrations.DeleteOnSubmit(regis);
                obj.SubmitChanges();
                MessageBox.Show("Successfully  Deleted");
            }
            catch (Exception ) {

                MessageBox.Show("Not Delete");
            
            }
            txtroll.Text = "";
            txtsearch.Text = "";
            txtname.Text = "";
            txtfather.Text = "";
            combodepartment.Text = "";
            comboyear.Text = "";
            txtcode.Text = "";

            txtmobile.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
            txtnic.Text = "";
            txtcode.Text = "";
            txtpic.Text = "";
            pictureBox.Visible = false;
        }

        private void grayButton1_Click(object sender, EventArgs e)
        {
            panalgrid panal = new panalgrid();
            panal.Show();
            this.Hide();
        }
    }
}
