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
    public partial class panalgrid : MetroFramework.Forms.MetroForm
    {
        
        private string p;
        public panalgrid()
        {
            InitializeComponent();
        }

        public panalgrid(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //label3.Text = "Welcome(" + nuser + ")";
        }

        private void greenButton1_Click(object sender, EventArgs e)
        {
            Update_Delete up_del = new Update_Delete();
            up_del.Show();
            this.Hide();
        }

        private void grayButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orangeButton1_Click(object sender, EventArgs e)
        {
            Update_Delete up_del = new Update_Delete();
            up_del.Show();
            this.Hide();

        }

        private void purpleButton1_Click(object sender, EventArgs e)
        {
            insert ins = new insert();
            ins.Show();
            this.Hide();
        }

        private void redButton1_Click(object sender, EventArgs e)
        {
            //Attandance_Software attan = new Attandance_Software();
            //attan.Show();
            Attandance_Form att = new Attandance_Form();
            att.Show();
            this.Hide();
        }

        private void blueButton1_Click(object sender, EventArgs e)
        {
            Report rept = new Report();
            rept.Show();
            this.Hide();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Change_Password ch = new Change_Password();
            ch.Show();
            this.Hide();
        }
    }
}
