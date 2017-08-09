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
    public partial class Attandance_Software : MetroFramework.Forms.MetroForm
    {
        public Attandance_Software()
        {
            InitializeComponent();
        }
        DataClasses1DataContext obj = new DataClasses1DataContext();
        private void Attandance_Software_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txtdepartment.SelectedItem.ToString())
            {
                case"Business Adminstration":
                          combCS.Visible = false;
                    CombComrc.Visible = false;
                    combBBA.Visible = true;
                    combgeo.Visible = false;
                    combIT.Visible = false;
                    break;
                case "Computer Science":
                    combCS.Visible = true;
                    CombComrc.Visible = false;
                    combBBA.Visible = false;
                    combgeo.Visible = false;
                    combIT.Visible = false;
                    //year
                    IT_1st_Yaer.Visible = false;
                IT_second_year.Visible = false;
                IT_third_year.Visible = false;
                IT_4th_year.Visible = false;
                    //Semester
                     IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;

                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;
       
                    break;
                case "Information Technology":
                    combCS.Visible = false;
                    CombComrc.Visible = false;
                    combBBA.Visible = false;
                    combgeo.Visible = false;
                    combIT.Visible = true;
                    //Year
                    Cs_First_Year.Visible = false;
                Cs_Second_year.Visible = false;
                CS_Third_year.Visible = false;
                Cs_4th_year.Visible = false;
                //Semester

                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = false;
                    break;
                case "Geology":
                       combCS.Visible = false;
                    CombComrc.Visible = false;
                    combBBA.Visible = false;
                    combgeo.Visible = true;
                    combIT.Visible = false;
                    break;
                case "Commerce":
                       combCS.Visible = false;
                    CombComrc.Visible = true;
                    combBBA.Visible = false;
                    combgeo.Visible = false;
                    combIT.Visible = false;
                    break;
                default:
                    MessageBox.Show("Already Exit");
                    break;

            }
        }

        private void combCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCS.Text == "CS-Part-1") {
                Cs_First_Year.Visible = true;
                Cs_Second_year.Visible = false;
                CS_Third_year.Visible = false;
                Cs_4th_year.Visible = false;
                

            
            }
            else if (combCS.Text == "CS-Part-2") {

                Cs_First_Year.Visible = false;
                Cs_Second_year.Visible = true;
                CS_Third_year.Visible = false;
                Cs_4th_year.Visible = false;
            }
            else if (combCS.Text == "CS-Part-3") {
                Cs_First_Year.Visible = false;
                Cs_Second_year.Visible = false;
                CS_Third_year.Visible = true;
                Cs_4th_year.Visible = false;
            
            }
            else if (combCS.Text == "CS-Part-4")
            {

                Cs_First_Year.Visible = false;
                Cs_Second_year.Visible = false;
                CS_Third_year.Visible = false;
                Cs_4th_year.Visible = true;


            }
            else {

                MessageBox.Show("Please Select Year");
            
            }
        }

        private void combgeo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combIT_SelectedIndexChanged(object sender, EventArgs e)
        {

         //   IT-Part-1
//IT-Part-2
//IT-Part-3
//IT-Part-4
            if (combIT.Text == "IT-Part-1") {
                IT_1st_Yaer.Visible = true;
                IT_second_year.Visible = false;
                IT_third_year.Visible = false;
                IT_4th_year.Visible = false;

            
            }
           else if (combIT.Text == "IT-Part-2")
            {
                IT_1st_Yaer.Visible = false;
                IT_second_year.Visible = true;
                IT_third_year.Visible = false;
                IT_4th_year.Visible = false;


            }
           else if (combIT.Text == "IT-Part-3")
            {
                IT_1st_Yaer.Visible = false;
                IT_second_year.Visible = false;
                IT_third_year.Visible = true;
                IT_4th_year.Visible = false;


            }
            else if (combIT.Text == "IT-Part-4")
            {
                IT_1st_Yaer.Visible = false;
                IT_second_year.Visible = false;
                IT_third_year.Visible = false;
                IT_4th_year.Visible = true;


            }
            else {
                MessageBox.Show("Select Item");
            
            }
        }

        private void Cs_Second_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cs_Second_year.Text == "CS-Semester-3")
            {
                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = true;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = false;
            
            }
            else if (Cs_Second_year.Text == "CS-Semester-4")
            {

                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = true;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = false;
            }
        }

        private void Cs_First_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cs_First_Year.Text == "CS-Semester-1") {

                CS_Semester_1.Visible = true;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = false;

                
            
            }
        
	else if(Cs_First_Year.Text=="CS-Semester-2"){

        CS_Semester_1.Visible = false;
        CS_Semester_2.Visible = true;
        CS_Semester_3.Visible = false;
        CS_Semester_4.Visible = false;
        CS_Semester_5.Visible = false;
        CS_Semester_6.Visible = false;
        CS_Semester_7.Visible = false;
        CS_Semester_8.Visible = false;
    
    }

	
        }

        private void CS_Third_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CS_Third_year.Text == "CS-Semester-5") {
                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = true;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = false;
            
            
            }
            else if(CS_Third_year.Text=="CS-Semester-6"){

                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = true;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = false;
            
            }
        }

        private void Cs_4th_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cs_4th_year.Text == "CS-Semester-7") {


                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = true;
                CS_Semester_8.Visible = false;

            }
            else if (Cs_4th_year.Text == "CS-Semester-8") {

                CS_Semester_1.Visible = false;
                CS_Semester_2.Visible = false;
                CS_Semester_3.Visible = false;
                CS_Semester_4.Visible = false;
                CS_Semester_5.Visible = false;
                CS_Semester_6.Visible = false;
                CS_Semester_7.Visible = false;
                CS_Semester_8.Visible = true;

            
            }
        }

        private void IT_1st_Yaer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IT_1st_Yaer.Text == "IT-Semester-1") {
                IT_Semester_1.Visible = true;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;
                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;
            
            
            }
            else if(IT_1st_Yaer.Text=="IT-Semester-2")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = true;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;
                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;
            }
        }

        private void IT_second_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IT_second_year.Text == "IT-Semester-3")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = true;
                IT_Semester_4.Visible = false;
                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;


            }
            else if (IT_second_year.Text == "IT-Semester-4")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = true;

                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;
            }
        }

        private void IT_third_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IT_third_year.Text == "IT-Semester-5")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;
                IT_Semester_5.Visible = true;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;


            }
            else if (IT_third_year.Text == "IT-Semester-6")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;

                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = true;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = false;
            }

        }

        private void IT_4th_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IT_4th_year.Text == "IT-Semester-7")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;
                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = true;
                IT_Semester_8.Visible = false;


            }
            else if (IT_4th_year.Text == "IT-Semester-8")
            {
                IT_Semester_1.Visible = false;
                IT_Semester_2.Visible = false;
                IT_Semester_3.Visible = false;
                IT_Semester_4.Visible = false;

                IT_Semester_5.Visible = false;
                IT_Semester_6.Visible = false;
                IT_Semester_7.Visible = false;
                IT_Semester_8.Visible = true;

            }
        }

        private void IT_Semester_3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Roll_Attandance_Click(object sender, EventArgs e)
        {

        }
        public void ShowSearch()
        {
            string q = txtidsen.Text.Trim();
            Registration reg = obj.Registrations.Where(a => a.Roll == q).SingleOrDefault();
            txtroll.Text = reg.Roll;
            txtname.Text = reg.Name;
            txtyear.Text = reg.Batch_Year;
            txtdept.Text = reg.Department;
            pictureBox1.Load(reg.Picture);
            pictureBox1.Visible = true;
            return;

        }
        public void Combobox() {
            string a = CS_Semester_1.Text;
            string b = CS_Semester_2.Text;
            string c = CS_Semester_3.Text;
            string d = CS_Semester_4.Text;
            string e = CS_Semester_5.Text;
            string f = CS_Semester_6.Text;
            string g = CS_Semester_7.Text;
            string h = CS_Semester_8.Text;
        
        }
        public void Insert()
        {
            try
            {
                DateTime dt = DateTime.Now;
                Attandance_Record ad = new Attandance_Record();
                ad.Roll_No = txtroll.Text;
                ad.Name = txtname.Text;
                ad.Department = txtdepartment.Text;
                ad.Year = txtyear.Text;
                ad.Date_Time = txtdate.Text;

                ad.Present = "Present";
                ad.Date_Time = dt.ToLocalTime().ToString();
                dt = Convert.ToDateTime(txtdate.Text);
                //semester
                ad.Subject_Course = CS_Semester_1.Text;
   

                obj.Attandance_Records.InsertOnSubmit(ad);
                obj.SubmitChanges();
                metroLabel10.Text = "Your attendence is submited successfully!";
                timer1.Enabled = true;
            }
            catch (Exception) {

                MessageBox.Show("Invalid Roll No");
            }


        }
        private void Txt_Roll_Attandance_TextChanged(object sender, EventArgs e)
        {
            if (txtidsen.Text == "20" || txtidsen.Text == "0008557474" || txtidsen.Text == "0008566315" || txtidsen.Text == "0008556543"
                || txtidsen.Text == "0008531062" || txtidsen.Text == "0008563726" || txtidsen.Text == "0008552146" || txtidsen.Text == "0008534093 "|| txtidsen.Text == "0008549033")
            {


                ShowSearch();
                Insert();



            }
            
        }
        private void grayButton1_Click(object sender, EventArgs e)
        {
            panalgrid panal = new panalgrid();
            panal.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            clean();
        }
        private void clean() {
            txtroll.Text = "";
            txtname.Text = "";
            txtdept.Text = "";
            txtyear.Text = "";
            pictureBox1.Visible = false;
            metroLabel10.Text = "";
            txtidsen.Text = "";
  

        
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

        }
    }
}
