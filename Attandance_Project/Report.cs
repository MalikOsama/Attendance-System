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
    public partial class Report : MetroFramework.Forms.MetroForm
    {
        DataClasses1DataContext obj = new DataClasses1DataContext();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Attandance_SystemDataSet1.Attandance_Record' table. You can move, or remove it, as needed.
           // this.Attandance_RecordTableAdapter.Fill(this.Attandance_SystemDataSet1.Attandance_Record);
            // TODO: This line of code loads data into the 'Attandance_SystemDataSet.Registration' table. You can move, or remove it, as needed.
            //this.RegistrationTableAdapter.Fill(this.Attandance_SystemDataSet.Registration);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void grayButton1_Click(object sender, EventArgs e)
        {
            var query = from r in obj.Attandance_Records select r;
            obj.Attandance_Records.DeleteAllOnSubmit(query);

            obj.SubmitChanges();
            MessageBox.Show("All Data Clear SuccessFully");
        }

        private void grayButton2_Click(object sender, EventArgs e)
        {
            panalgrid pan = new panalgrid();
            pan.Show();
            this.Hide();
        }
    }
}
