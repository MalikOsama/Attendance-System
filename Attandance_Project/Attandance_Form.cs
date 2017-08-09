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
    public partial class Attandance_Form : MetroFramework.Forms.MetroForm
    {
        public Attandance_Form()
        {
            InitializeComponent();
        }
    
        DataClasses1DataContext obj = new DataClasses1DataContext();
     
        private void Attandance_Form_Load(object sender, EventArgs e)
        {


        }

        private void grayButton1_Click(object sender, EventArgs e)
        {
            panalgrid pl = new panalgrid();
            pl.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CS-PART-1");
                comboBox2.Items.Add("CS-PART-2");

                comboBox2.Items.Add("CS-PART-3");
                comboBox2.Items.Add("CS-PART-4");


            }



            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();

                comboBox2.Items.Add("BBA-PART-1");
                comboBox2.Items.Add("BBA-PART-2");

                comboBox2.Items.Add("BBA-PART-3");
                comboBox2.Items.Add("BBA-PART-4");




            }

            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();

                comboBox2.Items.Add("IT-PART-1");
                comboBox2.Items.Add("IT-PART-2");

                comboBox2.Items.Add("IT-PART-3");
                comboBox2.Items.Add("IT-PART-4");




            }

            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();

                comboBox2.Items.Add("GEO-PART-1");
                comboBox2.Items.Add("GEO-PART-2");

                comboBox2.Items.Add("GEO-PART-3");
                comboBox2.Items.Add("GEO-PART-4");




            }

            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Clear();

                comboBox2.Items.Add("COM-PART-1");
                comboBox2.Items.Add("COM-PART-2");

                comboBox2.Items.Add("COM-PART-3");
                comboBox2.Items.Add("COM-PART-4");


            }
            else
            {

                comboBox2.Items.Add("Please Seleted Department");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nd = comboBox2.Text;

            if (nd == "CS-PART-1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1st Semester");
                comboBox3.Items.Add("2nd Semester");


            }
            else if (nd == "CS-PART-2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("3rd semester");
                comboBox3.Items.Add("4th Semester");
            }
            else if (nd == "CS-PART-3")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("5th Semester");
                comboBox3.Items.Add("6th Semester");
            }
            else if (nd == "CS-PART-4")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("7th Semester");
                comboBox3.Items.Add("8th Semester");

            }
            else if (nd == "IT-PART-1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("IT-1st-Semester");
                comboBox3.Items.Add("IT-2nd-Semester");

            }
            else if (nd == "IT-PART-2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("IT-3rd-Semester");
                comboBox3.Items.Add("IT-4th-Semester");

            }
            else if (nd == "IT-PART-3")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("IT-5th-Semester");
                comboBox3.Items.Add("IT-6th-Semester");

            }
            else if (nd == "IT-PART-4")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("IT-7th-Semester ");
                comboBox3.Items.Add("IT-8th-Semester");

            }
            else
            {

                comboBox3.Items.Clear();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ab = comboBox3.Text;

            if (ab == "1st Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("English");
                comboBox4.Items.Add("C language");
                comboBox4.Items.Add("Islamiyat ");
                comboBox4.Items.Add("Basic Electronics");
                comboBox4.Items.Add("Intro-Computer-Science");
                comboBox4.Items.Add("Pak-Study");


            }
            else if (ab == "2nd Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Algorithm");
                comboBox4.Items.Add("Data Structure");
                comboBox4.Items.Add("Electronic Circuit ");
                comboBox4.Items.Add("English-||");
                comboBox4.Items.Add("Maths");

            }
            else if (ab == "3rd semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Java");
                comboBox4.Items.Add("Discrete Mathematics");
                comboBox4.Items.Add("Java Lab");
                comboBox4.Items.Add("Statistic Probality");
                comboBox4.Items.Add("HRM");




            }
            else if (ab == "4th Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Digital Logic Design");
                comboBox4.Items.Add("DataBase");
                comboBox4.Items.Add("Data Communication Networks");
                comboBox4.Items.Add("Human Resources Mangement");
                comboBox4.Items.Add("Assembly Language");
            }

            else if (ab == "5th Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Oracle Fundamentals");
                comboBox4.Items.Add("Computer Graphics");
                comboBox4.Items.Add("Data Mining");
                comboBox4.Items.Add("Accounting");
                comboBox4.Items.Add("Pakistan Study");
            }

            else if (ab == "6th Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Operation Search");
                comboBox4.Items.Add("Software Engineering");
                comboBox4.Items.Add("English");
                comboBox4.Items.Add("Compiler Construction");
                comboBox4.Items.Add("Operating System");
            }
            else if (ab == "IT-1st-Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Operation Search");
                comboBox4.Items.Add("Software Engineering");
                comboBox4.Items.Add("English");
                comboBox4.Items.Add("Compiler Construction");
                comboBox4.Items.Add("Operating System");
            }
            else if (ab == "IT-2nd-Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Digital Logic Design");
                comboBox4.Items.Add("DataBase");
                comboBox4.Items.Add("Data Communication Networks");
                comboBox4.Items.Add("Human Resources Mangement");
                comboBox4.Items.Add("Assembly Language");
            }
            else if (ab == "IT-3rd-Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Java");
                comboBox4.Items.Add("Discrete Mathematics");
                comboBox4.Items.Add("Java Lab");
                comboBox4.Items.Add("Statistic Probality");
                comboBox4.Items.Add("HRM");




            }
            else if (ab == "IT-4th-Semester")
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Java");
                comboBox4.Items.Add("Discrete Mathematics");
                comboBox4.Items.Add("Java Lab");
                comboBox4.Items.Add("Statistic Probality");
                comboBox4.Items.Add("HRM");




            }


        }
        private void Insert()
        {
            try
            {
                
                    DateTime dt = DateTime.Now;
                    Attandance_Record ad = new Attandance_Record();
                    ad.Roll_No = txtroll.Text;
                    ad.Name = txtname.Text;
                    ad.Department = comboBox1.Text;

                    ad.Year = txtyear.Text;
                    ad.Date_Time = txtdate.Text;

                    ad.Present = "Present";
                    ad.Date_Time = dt.ToLocalTime().ToString();
                    dt = Convert.ToDateTime(txtdate.Text);
                    //semester
                    ad.Subject_Course = comboBox4.Text;




                    obj.Attandance_Records.InsertOnSubmit(ad);
                    obj.SubmitChanges();
                    metroLabel10.Text = "Your attendence is submited successfully!";
                    timer1.Enabled = true;
                }
            
            catch (Exception)
            {

                MessageBox.Show("Invalid Roll No");
            }
        }
        private void txtid_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ShowSearch()
        {
            try
            {
                string q = txtid.Text.Trim();
                Registration reg = obj.Registrations.Where(a => a.Roll == q).SingleOrDefault();
                txtroll.Text = reg.Roll;
                txtname.Text = reg.Name;
                txtyear.Text = reg.Batch_Year;
                txtdept.Text = reg.Department;
                //pictureBox1.Load(reg.Picture);
                pictureBox3.Load(reg.Picture);
                pictureBox3.Visible = true;
                //string aaa = Convert.ToString(reg.Department);
             
                return;
            }
            catch(Exception ){
            
            MessageBox.Show("Invalid Roll No");
            }

        }
        private void clean()
        {
            
            txtroll.Text = "";
            txtname.Text = "";
            txtdept.Text = "";
            txtyear.Text = "";
            pictureBox3.Visible = false;
            metroLabel10.Text = "";
            txtid.Text = "";
         
           


        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            clean();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            //int id;
            //if (!int.TryParse(txtid.Text, out id)&&txtid.Text.Length==10)
            //{
            //    MessageBox.Show("Number");
            //    return;

            //}
            if (txtid.Text.Length == 10) {
             ShowSearch();
            }
              
            if (comboBox1.Text == txtdept.Text)
            {
                Insert();
                return;
             
            }
            else if (txtid.Text.Length == 10 && comboBox1.Text != txtdept.Text) {
               
                MessageBox.Show("Department Doesn,t Match ","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clean();
            }
   

        }

        private void grayButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtid_StyleChanged(object sender, EventArgs e)
        {

        }
    }
}
