using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TeacherStarterKit
{
   public partial class Main : Form
   {
      public Main()
      {
         InitializeComponent();
      }

      #region Code for Main form

    /// <summary>
    /// Load and initialize the main form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <remarks></remarks>
      private void Main_Load(object sender, EventArgs e)
      {

         try
         {
            //  Call Grids' Sort, so that the sort indicator will appear on the column header
            this.StudentsDataGridView.Sort(this.StudentsDataGridView.Columns[0], ListSortDirection.Ascending);
            this.ViewGradesDataGridView.Sort(this.ViewGradesDataGridView.Columns[0], ListSortDirection.Ascending);
            //  pre-load lookup table
            this.AssessmentTypesTableAdapter.Fill(this.TeachersDataSet.AssessmentTypes);
            LoadCoursesList();
            //  default to first tab
            this.MainTabControl.SelectTab(0);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Assessment Types", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }


      }

    /// <summary>
    /// Check if assessments changed, when click on one of the top buttons 
    /// or the course combobox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <remarks></remarks>
      private void topTableLayoutPanel_Enter(object sender, EventArgs e)
      {
         if (this.IsAssessmentTabValid)
         {
            CheckAssessmentsChanged();
         }
      }

      /// <summary>
      /// Check for changes to update the database when leaving assessments tab 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks>
      /// This needs to be done here because if you delete the last assessment record,
      /// the panel no longer has the focus and that event won't be triggered when switching tabs
      /// </remarks>

      private void MainTabControl_Deselecting(object sender, TabControlCancelEventArgs e)
      {
         if (e.TabPage == AssessmentsTab)
         {
            e.Cancel = !ValidateAssessmentsTab();
            if (this.IsAssessmentTabValid)
            {
               CheckAssessmentsChanged();
            }
         }

      }

      ///  <summary>
      ///  Validate data on assessments tab when leaving tab control
      ///  </summary>
      ///  <param name="sender"></param>
      ///  <param name="e"></param>
      ///  <remarks>
      ///  This needs to be done here because if you delete the last assessment record,
      ///  the panel no longer has the focus and that event won't be triggered when 
      ///  clicking the Course combobox or ManageStudents / ManageCourses buttons
      ///  </remarks>
      private void MainTabControl_Validating(object sender, CancelEventArgs e)
      {
         if (MainTabControl.SelectedTab == AssessmentsTab)
         {
            e.Cancel = !ValidateAssessmentsTab();
         }
      }

      private void MainTabControl_Selected(object sender, TabControlEventArgs e)
      {
         if ((e.TabPage == EnterGradesTab))
         {
            FillEnterGradesTabData();
         }
         else if ((e.TabPage == ViewGradesTab))
         {
            FillViewGrades(GetCurrentCourseID());
         }
         else
         {
            this.AssessmentsBindingSource.RemoveFilter();
         }
      }

      /// <summary>
      /// Read courses from database, format them, and load into combobox
      /// </summary>
      /// <remarks></remarks>
      private void LoadCoursesList() 
      {
         ListItem item;
         string str;
         try 
         {
            //  due to foreign key constraints, must first clear other tables
            this.TeachersDataSet.Grades.Clear();
            this.TeachersDataSet.ViewGrades.Clear();
            this.TeachersDataSet.Assessments.Clear();
            this.CoursesTableAdapter.Fill(this.TeachersDataSet.Courses);
            this.CourseCodeComboBox.Items.Clear();
            this.CourseCodeComboBox.BeginUpdate();
            foreach (TeachersDataSet.CoursesRow row in this.TeachersDataSet.Courses) 
            {
                //  we want to display both the course code and 
                //  the course section as a single item
                if ((row.CourseSection.Length > 0)) 
                {
                    str = (" - " + row.CourseSection);
                }
                else 
                {
                    str = "";
                }
                //  Add item to combobox
                item = new ListItem((row.CourseCode + str), row.CourseID);
                this.CourseCodeComboBox.Items.Add(item);
            }
            this.CourseCodeComboBox.EndUpdate();

            //  default to first course, if one exists
            if ((this.CourseCodeComboBox.Items.Count > 0)) 
            {
                this.CourseCodeComboBox.SelectedIndex = 0;
            }
            else 
            {
                this.CourseCodeComboBox.SelectedIndex = -1;
            }
         }
         catch (Exception ex) 
         {
            MessageBox.Show(ex.Message, "Load courses", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Load all of the data for a given course
      /// </summary>
      /// <remarks>
      /// Normally called when current course is changed
      /// Update DataSet tables so that data is ready when switch to tab
      /// Always make sure that something is selected
      /// Clear tables and then fill in specified order, so that don't cause
      /// referential integrity errors
      ///
      /// Note that the table CourseStudents is never filled -
      /// we just use its TableAdapter for DirectDB operations
      /// </remarks>
      private void FillTeachersDataSet()
      {
         int courseID;
         try
         {
            this.TeachersDataSet.Grades.Clear();
            this.TeachersDataSet.ViewGrades.Clear();
            this.TeachersDataSet.Assessments.Clear();
            this.TeachersDataSet.Students.Clear();
            courseID = GetCurrentCourseID();
            this.AssessmentsTableAdapter.FillByCourseID(this.TeachersDataSet.Assessments, courseID);
            this.StudentsTableAdapter.FillByCourseID(this.TeachersDataSet.Students, courseID);
            this.ViewGradesTableAdapter.FillFullByCourseID(this.TeachersDataSet.ViewGrades, courseID);
            this.GradesTableAdapter.FillByCourseID(this.TeachersDataSet.Grades, courseID);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Fill DataSet", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Requery database to reflect the currently selected course
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void CourseCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
      {
         if ((CourseCodeComboBox.SelectedIndex == -1))
         {
            this.TeachersDataSet.Clear();
         }
         else
         {
            FillTeachersDataSet();
            if ((MainTabControl.SelectedTab == EnterGradesTab))
            {
               FillEnterGradesTabData();
            }
         }

      }

      /// <summary>
      /// Display the form for managing available courses
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void ManageCoursesButton_Click(object sender, EventArgs e)
      {
         CoursesForm allCoursesForm = new CoursesForm();
         allCoursesForm.ShowDialog();
         //  requery for any changes (new/deleted courses)
         LoadCoursesList();
         if ((MainTabControl.SelectedTab == EnterGradesTab))
         {
            FillEnterGradesTabData();
         }
      }

      /// <summary>
      /// Display form for managing students
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void ManageStudentsButton_Click(object sender, EventArgs e)
      {
         StudentsForm allStudentsForm = new StudentsForm();
         allStudentsForm.ShowDialog();
         //  requery for any changes (new/deleted students)
         FillTeachersDataSet();
         if ((MainTabControl.SelectedTab == EnterGradesTab))
         {
            FillEnterGradesTabData();
         }
      }

      /// <summary>
      /// Display About box
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void AboutButton_Click(object sender, EventArgs e)
      {
         AboutBox aboutBox = new AboutBox();
         aboutBox.ShowDialog();
      }

      #endregion

      #region Code for Students Tab


      /// <summary>
      /// Once a course is selected/specified, fetch all relevant data 
      /// i.e. students and grades, from the database
      /// </summary>
      /// <param name="courseID"></param>
      /// <remarks></remarks>
      private void FillStudentsandRelatedTables(int courseID)
      {
         //  First clear related tables and then refill them all
         this.TeachersDataSet.Grades.Clear();
         this.TeachersDataSet.ViewGrades.Clear();
         this.StudentsTableAdapter.FillByCourseID(this.TeachersDataSet.Students, courseID);
         this.GradesTableAdapter.FillByCourseID(this.TeachersDataSet.Grades, courseID);
         this.ViewGradesTableAdapter.FillFullByCourseID(this.TeachersDataSet.ViewGrades, courseID);
      }

      /// <summary>
      /// Add a Student to the current course
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void SelectStudentsButton_Click(object sender, EventArgs e)
      {
         SelectStudentsForm selectForm = new SelectStudentsForm();
         
         int courseID = GetCurrentCourseID();
         selectForm.CurrentCourseID = courseID;
         selectForm.ShowDialog();
         if ((selectForm.DialogResult == DialogResult.OK)) 
         {
             try 
             {
                 //  first update DB, then gridView
                foreach (TeachersDataSet.StudentsRow row in selectForm.SelectedStudents) 
                 {
                     this.CourseStudentsTableAdapter.Insert(courseID, row.StudentID);
                 }
             }
             catch (Exception ex) 
             {
                 MessageBox.Show(ex.Message, "Select Students", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
         }
         //  Re-Fetch data from DB (in case added/removed)
         FillStudentsandRelatedTables(courseID);

      }

      /// <summary>
      /// Remove a Student from a course
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void RemoveStudentButton_Click(object sender, EventArgs e)
      {

         System.Data.SqlClient.SqlTransaction transaction = null;
         System.Nullable<ConnectionState> previousConnectionState = null;

         try
         {
            if ((this.StudentsBindingSource.Count > 0) && 
                !(this.StudentsBindingSource.Current == null))
            {
               // convert generic Current object returned by BindingSource to the typed Student row object
               DataRowView rowView = ((DataRowView)(this.StudentsBindingSource.Current));
               TeachersDataSet.StudentsRow student = (TeachersDataSet.StudentsRow)rowView.Row;
               string msgText = string.Format("Are you sure you want to remove {0} {1} from this course? ", student.FirstName, student.LastName);
               msgText = msgText + "\nDoing so will delete all grades for this student in this course.";
               DialogResult result = MessageBox.Show(msgText, "OK to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               //  remove the current student if the user accepts
               if ((result == DialogResult.Yes))
               {
                  //  Need to first delete all related rows in Grades table
                  //  Wrap all operations within a single transaction, in case
                  //  something fails - still maintain referential integrity
                  //  Need to setup a transaction across the two TableAdapters
                  if ((this.GradesTableAdapter.Connection.State == ConnectionState.Closed))
                  {
                     previousConnectionState = this.GradesTableAdapter.Connection.State;
                     this.GradesTableAdapter.Connection.Open();
                  }
                  //  start a transaction based on the GradesTableAdapter
                  transaction = this.GradesTableAdapter.Connection.BeginTransaction();
                  //  using the new transaction, establish both Adapters in the transaction
                  this.GradesTableAdapter.AdapterTransaction = transaction;
                  this.CourseStudentsTableAdapter.AdapterTransaction = transaction;
                  //  First delete all grades for this student in this course
                  this.GradesTableAdapter.DeleteByCourseIDAndStudentID(GetCurrentCourseID(), student.StudentID);
                  //  now can remove student from course
                  this.CourseStudentsTableAdapter.Delete(GetCurrentCourseID(), student.StudentID);
                  //  If get to here, all is good
                  transaction.Commit();
                  //  Reset dataset, based on new data
                  FillStudentsandRelatedTables(GetCurrentCourseID());
               }
            }
         }
         catch (Exception ex)
         {
            if (!(transaction == null))
            {
               transaction.Rollback();
            }
            MessageBox.Show(ex.Message, "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
         finally
         {
            //  reset the connection based on it's previous state
            if ((!(previousConnectionState == null)
                        && (previousConnectionState == ConnectionState.Closed)))
            {
               this.GradesTableAdapter.Connection.Close();
            }
         }
      }

      /// <summary>
      /// Format Birth Date to display only date portion (not time portion)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
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
      /// Search for a student by last name
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void FillByLastNameToolStripButton_Click(object sender, EventArgs e)
      {
         string text;
         try
         {
            //  replace single quote with 2 single quotes 
            //  strings in SQL Server are enclosed in single quotes and must indicate
            //  that this single quote is part of the string value
            text = LastNameToolStripTextBox.Text.Replace("\'", "\'\'");
            this.StudentsBindingSource.Filter = ("LastName like \'"
                        + (text + "%\'"));
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Find Student");
         }
      }

      /// <summary>
      /// Clear the filter that was set to search for a student by (partial) last name
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void ClearToolStripButton_Click(object sender, EventArgs e)
      {
         //  restore standard table/view
         this.StudentsBindingSource.RemoveFilter();
         LastNameToolStripTextBox.Text = "";
      }
      #endregion

      #region Code for Assessments Tab


      /// <summary>
      /// "Valid flag" for Assessments Tab
      /// </summary>
      /// <remarks>
      /// This is a property since it is accesed from many different
      /// places in the code and is easier to trace/debug
      /// </remarks>
      bool m_IsAssessmentTabValid;
      private bool IsAssessmentTabValid
      {
         get
         {
            return m_IsAssessmentTabValid;
         }
         set
         {
            m_IsAssessmentTabValid = value;
         }
      }

      /// <summary>
      /// Check if any changes have been made and offer
      /// the user the option of saving or discarding them
      /// </summary>
      private void CheckAssessmentsChanged()
      {
         string msgText;
         DialogResult result;
         try
         {
            this.AssessmentsBindingSource.EndEdit();
            //  See if any changes were made, but not saved 
            if (!(this.TeachersDataSet.Assessments.GetChanges() == null))
            {
               msgText = "You have made changes that have not been saved to the database.";
               msgText = (msgText
                           + (Environment.NewLine + "If you have deleted assessments, deleting them from the database will delete all grades for the asses" +
                           "sment."));
               msgText = (msgText
                           + (Environment.NewLine + "Save the changes ?"));
               result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               switch (result)
               {
                  case DialogResult.Yes:
                     UpdateAssessmentsDatabase();
                     break;
                  default:
                     this.TeachersDataSet.Assessments.RejectChanges();
                     //  reset (reposition) BindingSource
                     this.AssessmentsBindingSource.ResetBindings(false);
                     break;
               }
            }
            if ((AssessmentsBindingSource.Count == 0))
            {
               AssessmentsPanel.Enabled = false;
            }
            else
            {
               AssessmentsPanel.Enabled = true;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Check Assessments Changed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      private void AssessTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(AssessNameTextBox.Text.Trim()))
         {
            //  default to type of assessment
            AssessNameTextBox.Text = AssessTypeComboBox.Text;
         }
      }

      /// <summary>
      /// Update changes in Assessments table to the database
      /// </summary>
      private void UpdateAssessmentsDatabase()
      {
         try
         {
            this.AssessmentsTableAdapter.Update(this.TeachersDataSet.Assessments);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Assessments - update database", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Validate input and then update database with changes
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         try
         {
            if (ValidateAssessmentsTab())
            {
               UpdateAssessmentsDatabase();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Assessments", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Event handler for Delete button on Navigator
      /// Need to handle this myself to avoid (low level)validation 
      /// error message when trying to delete
      /// </summary>
      /// <remarks>Be sure to set the Navigator's DeleteItem property
      /// to None, so that the event is handled ONLY by this routine
      /// </remarks>
      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         if (AssessmentsBindingSource.Count > 0)
         {
            this.AssessmentsBindingSource.RemoveCurrent();
         }
      }

      /// <summary>
      /// Event handler for AddNew button on Navigator
      /// Need to handle this myself to avoid validation error message 
      /// when trying to delete
      /// </summary>
      /// <remarks>Be sure to set the Navigator's AddNewItem property
      /// to None, so that the event is handled ONLY by this routine
      /// </remarks>
      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
      {
         if (GetCurrentCourseID() != -1)
         {
            if (ValidateAssessmentsTab())
            {
               this.AssessmentsBindingSource.AddNew();
               
               //  Add current CourseID to new row 
               SetAssessmentCourse();

               //  Set default/initial value
               AssessDateTimePicker.Value = System.DateTime.Today;

               AssessTypeComboBox.Focus();
            }
         }
      }

      /// <summary>
      /// Add current CourseID to assessment row 
      /// </summary>
      /// <remarks></remarks>
      private void SetAssessmentCourse()
      {
         //  Convert RowView from BindingSource to strongly-typed 
         //  AssementsRow and set CourseID from main combobox
         try
         {
            DataRowView rowView;
            rowView = (DataRowView)(this.AssessmentsBindingSource.Current);
            ((TeachersDataSet.AssessmentsRow)(rowView.Row)).CourseID = GetCurrentCourseID();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "SetCurrentCourse", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Disable input fields if not positioned on a record
      /// </summary>
      private void AssessmentsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
      {
         if (AssessmentsBindingSource.Count == 0)
         {
            AssessmentsPanel.Enabled = false;
         }
         else
         {
            AssessmentsPanel.Enabled = true;
         }
      }

      /// <summary>
      /// Validation routine for Assessments Tab
      /// </summary>
      private bool ValidateAssessmentsTab()
      {
         bool valid = true;
         if ((AssessmentsBindingSource.Count > 0))
         {
            if (string.IsNullOrEmpty(AssessNameTextBox.Text.Trim()))
            {
               valid = false;
               MessageBox.Show("Assessment Name cannot be left empty.", "Validate Assessments Tab", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ValidateMinMaxGrades())
            {
               valid = true;
               this.AssessmentsBindingSource.EndEdit();
            }
         }
         this.IsAssessmentTabValid = valid;
         return valid;
      }

      /// <summary>
      /// Validate the values in the Min/Max grade textboxes
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks>
      /// Since these 2 textboxes are bound to a datasource, which does its own validation,
      /// we handle the validating event so that we can display an error message.
      /// We also do additional validation, i.e. MinGrade less than MaxGrade
      /// </remarks>
      private void MinMaxGradeTextBoxes_Validating(object sender, CancelEventArgs e)
      {
         e.Cancel = !(ValidateMinMaxGrades());
      }

      /// <summary>
      /// Validates Minimum and Maximum Grade fields
      /// </summary>
      /// <returns>
      /// Returns True if Minimum and Maximum Grade values are both valid
      /// </returns>
      private bool ValidateMinMaxGrades()
      {
         float minNum;
         float maxNum;
         bool valid;

         if (float.TryParse(MinGradeTextBox.Text, out minNum))
         {
            if (float.TryParse(MaxGradeTextBox.Text, out maxNum))
            {
               if ((minNum < maxNum))
               {
                  valid = true;
               }
               else
               {
                  valid = false;
                  MessageBox.Show("Minimum Grade must be less than Maximum Grade", "Minimum/Maximum grade validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               }
            }
            else
            {
               valid = false;
               MessageBox.Show("Invalid value for Maximum Grade", "Minimum/Maximum grade validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
         }
         else
         {
            valid = false;
            MessageBox.Show("Invalid value for Minimum Grade", "Minimum/Maximum grade validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
         return valid;
      }


      #endregion

      #region Code for Enter Grades Tab
      float m_AssessMinGrade;    // Lowest valid grade for an assessment
      float m_AssessMaxGrade;    // Highest valid grade for an assessment
      int m_AssessID;
      int m_StudentID;           // Currently selected student
      bool m_gradeExists;        // to differentiate between update, insert, and delete
      bool m_GradeChanged;

      /// <summary>
      /// "Dirty flag" for Grade field - returns true if the grade has been changed
      /// </summary>
      /// <remarks>
      /// This is a property since it is accessed from many different
      /// places in the code and is easier to trace/debug
      /// It also sets the Enabled property of the Save button
      /// </remarks>
      private bool GradeChanged
      {
         get
         {
            return m_GradeChanged;
         }
         set
         {
            m_GradeChanged = value;
            SaveGradeButton.Enabled = value;
         }
      }

      /// <summary>
      /// "Exists flag" for Grade field
      /// </summary>
      /// <remarks>
      /// This is a property since it is accesed from many different
      /// places in the code and is easier to trace/debug
      /// </remarks>
      private bool GradeExists
      {
         get
         {
            return m_gradeExists;
         }
         set
         {
            m_gradeExists = value;
         }
      }

      /// <summary>
      /// Update Grade change to database
      /// </summary>
      private void UpdateGrade()
      {
         try
         {
            //  Grade validation was done in Validating event
            if (GradeExists)
            {
               if (string.IsNullOrEmpty(GradeTextBox.Text.Trim()))
               {
                  //  Grade deleted
                  TeachersDataSet.Grades[0].Delete();
                  GradeExists = false;
               }
               else
               {
                  //  Grade updated 
                  TeachersDataSet.Grades[0].Grade = float.Parse(GradeTextBox.Text);
               }
            }
            else if (!string.IsNullOrEmpty(GradeTextBox.Text.Trim()))
            {
               //  Grade inserted
               TeachersDataSet.GradesRow row;
               row = TeachersDataSet.Grades.NewGradesRow();
               row.AssessID = m_AssessID;
               row.StudentID = m_StudentID;
               row.Grade = float.Parse(GradeTextBox.Text);
               TeachersDataSet.Grades.AddGradesRow(row);
               GradeExists = true;
            }
            int rowsUpdated;
            rowsUpdated = GradesTableAdapter.Update(TeachersDataSet.Grades);
            if ((rowsUpdated > 0))
            {
               MessageBox.Show("Grade successfully updated", "Enter Grade");
            }
            GradeChanged = false;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Save Grade", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Check if any changes have been made and offer
      /// the user the option of saving or discarding them
      /// </summary>
      private void CheckGradeChanged()
      {
         string msgText;
         DialogResult result;
         try
         {
            //  See if any changes were made, but not saved 
            if (GradeChanged)
            {
               msgText = "You have made a grade change that has not been saved to the database.";
               msgText += Environment.NewLine + "Save the change ?";
               result = MessageBox.Show(msgText, "Save changed grade?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               switch (result)
               {
                  case DialogResult.Yes:
                     UpdateGrade();
                     break;
                  default:
                     DisplayStudentGrade();
                     break;
               }
               GradeChanged = false;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Enter Grades", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Only load these comboboxes when select this tab, to
      /// ensure that we fill with latest (assessment and student) data
      /// Do not bind the Students comboboxes to the existing StudentsBindingSource, 
      /// so that there is no possible interference between them and the controls 
      /// bound to it on other forms.
      /// </summary>
      private void FillEnterGradesTabData()
      {
         //  Clear Grade textbox  & mark it as unchanged
         GradeTextBox.Text = "";
         GradeChanged = false;
         SaveGradeButton.Enabled = false;
         LoadAssessmentsList();
         LoadStudentsList();
         //  Make sure both an asessment and a student exist,
         //  before enabling the Grade textbox
         if (((AssessComboBox.SelectedIndex == -1)
                     || (StudentComboBox.SelectedIndex == -1)))
         {
            GradeTextBox.Enabled = false;
         }
         else
         {
            GradeTextBox.Enabled = true;
         }
      }

      /// <summary>
      /// Populate a list of assessments.
      /// An assessment must be selected in order to enter grades
      /// </summary>
      /// <remarks>
      /// </remarks>
      private void LoadAssessmentsList() 
      {
         ListItem item;
         try 
         {
            this.AssessComboBox.Items.Clear();
            this.AssessComboBox.BeginUpdate();
            foreach (TeachersDataSet.AssessmentsRow row in TeachersDataSet.Assessments) 
            {
                item = new ListItem(row.AssessName, row.AssessID);
                this.AssessComboBox.Items.Add(item);
            }
            this.AssessComboBox.EndUpdate();
            //  default to first entry, if there is one
            if ((this.AssessComboBox.Items.Count > 0)) 
            {
                this.AssessComboBox.SelectedIndex = 0;
            }
            else 
            {
                this.AssessComboBox.SelectedIndex = -1;
            }
         }
         catch (Exception ex) 
         {
            MessageBox.Show(ex.Message, "Load assessments Listbox", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Populate a list of students.
      /// A student must be selected in order to enter grades
      /// </summary>
      /// <remarks>
      /// </remarks>
      private void LoadStudentsList() 
      {
        ListItem item;
        try 
        {
            this.StudentComboBox.Items.Clear();
            this.StudentComboBox.BeginUpdate();
            foreach (TeachersDataSet.StudentsRow row in TeachersDataSet.Students) 
            {
                //  we want to display first and last name as single item
                item = new ListItem((row.LastName + (", " + row.FirstName)), row.StudentID);
                this.StudentComboBox.Items.Add(item);
            }
            this.StudentComboBox.EndUpdate();
            //  default to first entry, if there is one
            if ((this.StudentComboBox.Items.Count > 0)) 
            {
                this.StudentComboBox.SelectedIndex = 0;
            }
            else 
            {
                this.StudentComboBox.SelectedIndex = -1;
            }
         }
         catch (Exception ex) 
         {
            MessageBox.Show(ex.Message, "Load students Listbox", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Explicitly check for changed grade when the user clicks on
      /// one of these comboboxes, so that CheckGradeChanged() displays its 
      /// message box BEFORE the combobox shows a new selection
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void AssessStudentsComboBoxes_DropDown(object sender, EventArgs e)
      {
         CheckGradeChanged();
      }

      /// <summary>
      /// Saved the curretn grade, if it was modified and 
      /// reset controls for newly selected assessment
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void AssessComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         DataRowView drv;
         try
         {
            CheckGradeChanged();
            GradeTextBox.Text = "";
            GradeChanged = false;
            GradeExists = false;
            StudentComboBox.SelectedIndex = -1;
            if ((AssessComboBox.SelectedIndex != -1))
            {
               //  Set filter to get selected assessment
               int AssessID = ((ListItem)(this.AssessComboBox.SelectedItem)).Value;
               this.AssessmentsBindingSource.Filter = ("AssessId = " + AssessID);
               drv = ((DataRowView)(this.AssessmentsBindingSource[0]));
               m_AssessMinGrade = ((TeachersDataSet.AssessmentsRow)(drv.Row)).MinGrade;
               m_AssessMaxGrade = ((TeachersDataSet.AssessmentsRow)(drv.Row)).MaxGrade;
               this.MinMaxLabel.Text = string.Format("Assessment grade must between {0} and {1}", m_AssessMinGrade, m_AssessMaxGrade);
               //  Need to store this value, so that we know what
               //  the previous value was, when we change it later
               m_AssessID = AssessID;
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Select Assessment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Clear controls/variables and fetch existing grade for newly selected student
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         try
         {
            CheckGradeChanged();
            GradeTextBox.Text = "";
            GradeChanged = false;
            GradeExists = false;
            if ((StudentComboBox.SelectedIndex != -1))
            {
               //  Fetch this student's grade for this assessment
               //  Make sure an assessment exists/is selected
               if ((AssessComboBox.SelectedIndex != -1))
               {
                  GradesTableAdapter.FillByAssessAndStudent(TeachersDataSet.Grades, ((ListItem)(this.AssessComboBox.SelectedItem)).Value, ((ListItem)(this.StudentComboBox.SelectedItem)).Value);
                  //  Need to store this value, so that we know what
                  //  the previous value was, when we change it later
                  m_StudentID = ((ListItem)(this.StudentComboBox.SelectedItem)).Value;
                  DisplayStudentGrade();
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Select Student", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }

      /// <summary>
      /// Display this student's grade, if it exists
      /// </summary>
      private void DisplayStudentGrade()
      {
         if ((TeachersDataSet.Grades.Rows.Count != 0))
         {
            GradeTextBox.Text = TeachersDataSet.Grades[0].Grade.ToString();
            GradeExists = true;
         }
         else
         {
            GradeTextBox.Text = "";
            GradeExists = false;
         }
         GradeChanged = false;
      }

      /// <summary>
      /// Validate input and then update database with changes
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void SaveGradeButton_Click(object sender, EventArgs e)
      {
         string errMsg;
         if ((AssessComboBox.SelectedIndex == -1))
         {
            errMsg = "Please select an assessment before saving";
            MessageBox.Show(errMsg, "Enter Grades", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
         else if ((StudentComboBox.SelectedIndex == -1))
         {
            errMsg = "Please select a student before saving";
            MessageBox.Show(errMsg, "Enter Grades", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
         else if (GradeChanged)
         {
            UpdateGrade();
         }
         else
         {
            //  no changes made - nothing to do
         }

      }

      /// <summary>
      /// Set Grade Changed flag
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void GradeTextBox_TextChanged(object sender, EventArgs e)
      {
         GradeChanged = true;
      }

      /// <summary>
      /// Validation routine for Grade textbox
      /// </summary>
      private void GradeTextBox_Validating(object sender, CancelEventArgs e)
      {
         e.Cancel = !ValidateGrade();
      }

      /// <summary>
      /// Validate and save modified grade, before leaving the Enter Grades tab
      /// </summary>
      private void EnterGradesTab_Validating(object sender, CancelEventArgs e)
      {
         e.Cancel = !ValidateGrade();
         if (!e.Cancel)
         {
            CheckGradeChanged();
         }
      }

      /// <summary>
      /// Validate that a legal grade value has been entered
      /// </summary>
      /// <returns></returns>
      private bool ValidateGrade()
      {
         string errMsg = "";
         if (!(IsValidGrade(GradeTextBox.Text, m_AssessMinGrade, m_AssessMaxGrade, ref errMsg)))
         {
            MessageBox.Show(errMsg, "Invalid assessment grade", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return false;
         }
         else
         {
            return true;
         }
      }


      #endregion

      #region Code for View Grades Tab

      /// <summary>
      /// Retrieve grades for a given courseID from the database
      /// </summary>
      /// <param name="courseID">Parameter to filter what grades are returned</param>
      /// <remarks>
      /// This needs to be filled here, in case a grade was just added on Enter Grades tab
      /// Always make sure that something is selected
      /// </remarks>
      private void FillViewGrades(int courseID)
      {
         try
         {
            this.ViewGradesTableAdapter.FillFullByCourseID(this.TeachersDataSet.ViewGrades, courseID);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Fill ViewGrades", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }



      #endregion

      #region Code for Reports Tab

      /// <summary>
      /// Select and Preview Report
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void ViewReportButton_Click(object sender, EventArgs e)
      {
         ReportPreviewForm previewForm = new ReportPreviewForm();
         string reportName;
         if (OrderByAssessRadioButton.Checked)
         {
            reportName = "GradesByAssessment.rdlc";
         }
         else if (OrderByStudentRadioButton.Checked)
         {
            reportName = "GradesByStudent.rdlc";
         }
         else
         {
            //  We should never get here!
            reportName = "";
            MessageBox.Show("Non-existant report requested", "View Report", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
         if (!string.IsNullOrEmpty(reportName))
         {
            previewForm.ShowReport(reportName, GetCurrentCourseID());
         }
      }

      #endregion

      #region Helper routines

      /// <summary>
      /// Get the Id of the currently selected Course
      /// </summary>
      /// <returns></returns>
      /// <remarks></remarks>
      public int GetCurrentCourseID()
      {
         if ((CourseCodeComboBox.SelectedIndex == -1))
         {
            //  no courses exist!
            return -1;
         }
         else
         {
            return ((int)(((ListItem)(CourseCodeComboBox.SelectedItem)).Value));
         }
      }

      /// <summary>
      /// Check validity of a grade
      /// </summary>
      /// <param name="grade">the grade to be checked</param>
      /// <param name="minGrade">Minimum valid grade</param>
      /// <param name="maxGrade">Maximum valid grade</param>
      /// <param name="errorMessage">Description of error if grade is not valid</param>
      /// <returns>
      /// This routine will return True (Valid) if the supplied grade is blank. 
      /// </returns>
      /// <remarks></remarks>      
      private static bool IsValidGrade(string grade, float minGrade, float maxGrade, ref string errorMessage)
      {
         bool valid = false;
         errorMessage = "";
         float currentGrade;
         bool isNumeric = false;

         if (string.IsNullOrEmpty(grade.Trim()))
         {
            valid = true;
            return valid;
         }

         // First check if we got a number, return error if not.
         // If we have a number test boundaries.
         isNumeric = float.TryParse(grade, out currentGrade);
         if (!(isNumeric))
         {
            errorMessage = "Assessment grade must be Numeric";
         }
         else if (currentGrade < minGrade)
         {
            errorMessage = ("Assessment grade may not be less than " + minGrade.ToString());
         }
         else if ((currentGrade > maxGrade))
         {
            errorMessage = ("Assessment grade may not be greater than " + maxGrade.ToString());
         }
         else
         {
            valid = true;
         }
         return valid;
      }
      #endregion


   }
}