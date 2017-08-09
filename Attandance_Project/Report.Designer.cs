namespace Attandance_Project
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.RegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Attandance_SystemDataSet = new Attandance_Project.Attandance_SystemDataSet();
            this.Attandance_RecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Attandance_SystemDataSet1 = new Attandance_Project.Attandance_SystemDataSet1();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.grayButton1 = new Metro.GrayButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RegistrationTableAdapter = new Attandance_Project.Attandance_SystemDataSetTableAdapters.RegistrationTableAdapter();
            this.Attandance_RecordTableAdapter = new Attandance_Project.Attandance_SystemDataSet1TableAdapters.Attandance_RecordTableAdapter();
            this.grayButton2 = new Metro.GrayButton();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attandance_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attandance_RecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attandance_SystemDataSet1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationBindingSource
            // 
            this.RegistrationBindingSource.DataMember = "Registration";
            this.RegistrationBindingSource.DataSource = this.Attandance_SystemDataSet;
            // 
            // Attandance_SystemDataSet
            // 
            this.Attandance_SystemDataSet.DataSetName = "Attandance_SystemDataSet";
            this.Attandance_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Attandance_RecordBindingSource
            // 
            this.Attandance_RecordBindingSource.DataMember = "Attandance_Record";
            this.Attandance_RecordBindingSource.DataSource = this.Attandance_SystemDataSet1;
            // 
            // Attandance_SystemDataSet1
            // 
            this.Attandance_SystemDataSet1.DataSetName = "Attandance_SystemDataSet1";
            this.Attandance_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1035, 537);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.reportViewer1);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1027, 495);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Registraion";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RegistrationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attandance_Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1021, 503);
            this.reportViewer1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.grayButton1);
            this.metroTabPage2.Controls.Add(this.reportViewer2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1027, 495);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Attendence";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // grayButton1
            // 
            this.grayButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grayButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grayButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.grayButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.grayButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grayButton1.Location = new System.Drawing.Point(697, 87);
            this.grayButton1.Name = "grayButton1";
            this.grayButton1.Size = new System.Drawing.Size(137, 40);
            this.grayButton1.TabIndex = 3;
            this.grayButton1.Text = "Clear Report";
            this.grayButton1.UseVisualStyleBackColor = false;
            this.grayButton1.Click += new System.EventHandler(this.grayButton1_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Attandance_RecordBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Attandance_Project.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1014, 508);
            this.reportViewer2.TabIndex = 2;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // RegistrationTableAdapter
            // 
            this.RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // Attandance_RecordTableAdapter
            // 
            this.Attandance_RecordTableAdapter.ClearBeforeFill = true;
            // 
            // grayButton2
            // 
            this.grayButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grayButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grayButton2.BackgroundImage")));
            this.grayButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grayButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grayButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.grayButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.grayButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grayButton2.Location = new System.Drawing.Point(19, 11);
            this.grayButton2.Name = "grayButton2";
            this.grayButton2.Size = new System.Drawing.Size(79, 57);
            this.grayButton2.TabIndex = 1;
            this.grayButton2.UseVisualStyleBackColor = false;
            this.grayButton2.Click += new System.EventHandler(this.grayButton2_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 623);
            this.Controls.Add(this.grayButton2);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attandance_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attandance_RecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attandance_SystemDataSet1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.BindingSource RegistrationBindingSource;
        private Attandance_SystemDataSet Attandance_SystemDataSet;
        private Attandance_SystemDataSetTableAdapters.RegistrationTableAdapter RegistrationTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Attandance_RecordBindingSource;
        private Attandance_SystemDataSet1 Attandance_SystemDataSet1;
        private Attandance_SystemDataSet1TableAdapters.Attandance_RecordTableAdapter Attandance_RecordTableAdapter;
        private Metro.GrayButton grayButton1;
        private Metro.GrayButton grayButton2;
    }
}