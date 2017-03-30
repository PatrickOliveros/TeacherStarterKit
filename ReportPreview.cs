using System;
using System.Windows.Forms;

namespace TeacherStarterKit
{
   public partial class ReportPreviewForm : Form
   {
      public ReportPreviewForm()
      {
         InitializeComponent();
      }

      public void ShowReport(string reportName, int courseID)
      {
         //  Select Report
         //  Initialize the report viewer
         ReportViewer1.LocalReport.ReportEmbeddedResource = "TeacherStarterKit." + reportName;
         //  Fill data
         try
         {
            //  This is read-only data, so don't need to enforce constraints
            //  As a result, we do not need to load the related tables.
            this.TeachersDataSet.EnforceConstraints = false;
            this.ViewGradesTableAdapter.FillFullByCourseID(this.TeachersDataSet.ViewGrades, courseID);
            this.ReportViewer1.RefreshReport();
            this.ShowDialog();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Report Preview", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }
   }
}