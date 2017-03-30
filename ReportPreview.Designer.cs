namespace TeacherStarterKit
{
   partial class ReportPreviewForm
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
          this.ViewGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
          this.TeachersDataSet = new TeacherStarterKit.TeachersDataSet();
          this.ViewGradesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.ViewGradesTableAdapter();
          this.CoursesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.CoursesTableAdapter();
          ((System.ComponentModel.ISupportInitialize)(this.ViewGradesBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).BeginInit();
          this.SuspendLayout();
          // 
          // ViewGradesBindingSource
          // 
          this.ViewGradesBindingSource.DataMember = "ViewGrades";
          this.ViewGradesBindingSource.DataSource = this.TeachersDataSet;
          // 
          // ReportViewer1
          // 
          this.ReportViewer1.AccessibleName = "WinReportServiceViewer";
          this.ReportViewer1.AllowDrop = true;
          this.ReportViewer1.AutoScroll = true;
          this.ReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
          this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
          reportDataSource1.Name = "TeachersDataSet_ViewGrades";
          reportDataSource1.Value = this.ViewGradesBindingSource;
          this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
          this.ReportViewer1.LocalReport.DisplayName = "TeacherStarterKit.GradesByAssessment.rdlc";
          this.ReportViewer1.LocalReport.ReportEmbeddedResource = "TeacherStarterKit.GradesByAssessment.rdlc";
          this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
          this.ReportViewer1.Name = "ReportViewer1";
          this.ReportViewer1.Size = new System.Drawing.Size(488, 266);
          this.ReportViewer1.TabIndex = 1;
          // 
          // TeachersDataSet
          // 
          this.TeachersDataSet.DataSetName = "TeachersDataSet";
          this.TeachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // ViewGradesTableAdapter
          // 
          this.ViewGradesTableAdapter.ClearBeforeFill = true;
          // 
          // CoursesTableAdapter
          // 
          this.CoursesTableAdapter.ClearBeforeFill = true;
          // 
          // ReportPreviewForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(488, 266);
          this.Controls.Add(this.ReportViewer1);
          this.Name = "ReportPreviewForm";
          this.Text = "ReportPreview";
          ((System.ComponentModel.ISupportInitialize)(this.ViewGradesBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).EndInit();
          this.ResumeLayout(false);

      }

      #endregion

      internal Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
      internal System.Windows.Forms.BindingSource ViewGradesBindingSource;
      private TeachersDataSet TeachersDataSet;
      private TeacherStarterKit.TeachersDataSetTableAdapters.ViewGradesTableAdapter ViewGradesTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.CoursesTableAdapter CoursesTableAdapter;

   }
}