using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TeacherStarterKit
{
   public partial class SelectStudentsForm : Form
   {
      private const int InvalidCourseID = 0;

      private int m_currentCourseID;    // Currently selected course

      public SelectStudentsForm()
      {
         InitializeComponent();
      }

      /// <summary>
      /// The course we're currently working on
      /// </summary>
      public int CurrentCourseID
      {
         get 
         {
            if (m_currentCourseID == InvalidCourseID)
            {
               throw new InvalidOperationException("Course ID not set");
            }
            return m_currentCourseID; 
         }
         set 
         { 
            m_currentCourseID = value; 
         }
      }
	
      /// <summary>
      /// Query database for students not registered for this course
      /// </summary>
      /// <remarks></remarks>
      private void FillStudentsNotInCourse()
      {
         try
         {
            this.StudentsTableAdapter.FillNotInCourse(this.TeachersDataSet.Students, this.CurrentCourseID);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Select Students", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      private void SelectStudentsForm_Load(object sender, EventArgs e)
      {
        FillStudentsNotInCourse();
        // Call Grid's Sort, so that the sort indicator will appear on the column header
        StudentsDataGridView.Sort(StudentsDataGridView.Columns[0], ListSortDirection.Ascending);
      }

      /// <summary>
      /// Property to pass selected students back to calling form
      /// </summary>
      public TeachersDataSet.StudentsDataTable SelectedStudents
      {
         get
         {
            try
            {
               TeachersDataSet.StudentsDataTable selectedDataTable = new TeachersDataSet.StudentsDataTable();

               TeachersDataSet.StudentsRow studentRow;
               DataRowView rowView;
               foreach (DataGridViewRow selRow in StudentsDataGridView.SelectedRows)
               {
                  // convert generic Current object returned by BindingSource to the typed Student row object
                  rowView = ((DataRowView)(this.StudentsBindingSource[selRow.Index]));
                  studentRow = ((TeachersDataSet.StudentsRow)(rowView.Row));
                  selectedDataTable.ImportRow(studentRow);
               }
               return selectedDataTable;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Select Students", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               //  Return an (empty) initialized object so the caller doesn't have to check for Nothing
               return new TeachersDataSet.StudentsDataTable();
            }
         }
      }

      /// <summary>
      /// Format Birth Date to display only date portion (not time portion)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void StudentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
      {
         //  Although we could have the SQL statement return a formatted date,
         //  this is really a User Interface issue and should be handled here.
         // 
         //  Display only Date part of datetime
         if ((this.StudentsDataGridView.Columns[e.ColumnIndex].Name == this.TeachersDataSet.Students.BirthDateColumn.ColumnName))
         {
            if (!(e.Value == DBNull.Value))
            {
               e.Value = DateTime.Parse((string)e.Value).ToShortDateString();
               e.FormattingApplied = true;
            }
         }
      }

      /// <summary>
      /// Show dialog to add or delete students
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void MangeStudentsButton_Click(object sender, EventArgs e)
      {
         StudentsForm allStudentsForm = new StudentsForm();

         allStudentsForm.ShowDialog();

         // requery for any changes (new students)
         FillStudentsNotInCourse();
      }
   }
}