using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TeacherStarterKit
{
   public partial class StudentsForm : Form
   {
      public StudentsForm()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Update changes in Students table to database
      /// </summary>
      private void UpdateDatabase()
      {
         try
         {
            this.StudentsTableAdapter.Update(this.TeachersDataSet.Students);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Students - update database", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            this.StudentsBindingSource.EndEdit();
            if (this.Validate())
            {
               UpdateDatabase();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Save Student", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }
      }


      /// <summary>
      /// Before closing form, check if any changes have been made and offer
      /// the user the option of saving or discarding them
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void StudentsForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         string msgText = null;
         DialogResult result = 0;

         try
         {
            if (this.Validate())
            {
               this.StudentsBindingSource.EndEdit();
            }
            else
            {
               e.Cancel = true;
               return;
            }

            // See if any changes were made, but not saved 
            if (this.TeachersDataSet.Students.GetChanges() != null)
            {
               msgText = "You have made changes that have not been saved to the database.";
               msgText += Environment.NewLine + "If you have deleted students, deleting them from the database will delete all courses and grades for the student.";
               msgText += Environment.NewLine + "Save the changes ?";

               result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
               switch (result)
               {
                  case DialogResult.Yes:
                     UpdateDatabase();

                     break;
                  case DialogResult.No:
                     this.TeachersDataSet.Courses.RejectChanges();

                     break;
                  default:
                     // do nothing and cancel closing of the form
                     e.Cancel = true;

                     break;
               }
            }

         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Students form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            e.Cancel = true;
         }

      }

      /// <summary>
      /// Fill Students table with data when loading the form
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void StudentsForm_Load(object sender, EventArgs e)
      {
         try
         {
            Panel1.Enabled = false;
            this.StudentsTableAdapter.Fill(this.TeachersDataSet.Students);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Student", MessageBoxButtons.OK, MessageBoxIcon.Stop);
         }

      }

      /// <summary>
      /// Disable input fields if not positioned on a record
      /// </summary>
      private void StudentsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
      {
         if (StudentsBindingSource.Count == 0)
         {
            Panel1.Enabled = false;
         }
         else
         {
            Panel1.Enabled = true;
            // always set focus to first field that requires
            // validation, to ensure validation gets triggered if try to 
            // move to another record
            FirstNameTextBox.Focus();
         }

      }

      /// <summary>
      /// Validation routine for First Name
      /// </summary>
      private void FirstNameTextBox_Validating(object sender, CancelEventArgs e)
      {
         if (StudentsBindingSource.Count > 0 && string.IsNullOrEmpty(FirstNameTextBox.Text.Trim()))
         {
            MessageBox.Show("First Name cannot be left empty.", "Student First Name validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            e.Cancel = true;
         }

      }

      /// <summary>
      /// Validation routine for Last Name
      /// </summary>
      private void LastNameTextBox_Validating(object sender, CancelEventArgs e)
      {
         if (StudentsBindingSource.Count > 0 && string.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
         {
            MessageBox.Show("Last Name cannot be left empty.", "Student Last Name validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            e.Cancel = true;
         }
      }

      /// <summary>
      /// Event handler for Delete button on Navigator
      /// Need to handle this myself to avoid validation error message 
      /// when trying to delete
      /// </summary>
      /// <remarks>Be sure to set the Navigator's DeleteItem property
      /// to None, so that the event is handled ONLY by this routine
      /// </remarks>
      private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
      {
         if (StudentsBindingSource.Count > 0)
         {
            this.StudentsBindingSource.RemoveCurrent();
         }
      }

      /// <summary>
      /// Validation routine for Birth Date
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      /// <remarks></remarks>
      private void BirthDateDateTimePicker_Validating(object sender, CancelEventArgs e)
      {
         if (BirthDateDateTimePicker.Value.Date > System.DateTime.Now.Date)
         {
            MessageBox.Show("Birth date cannot be in the future", "Student Birth date", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            e.Cancel = true;
         }
      }
   }
}