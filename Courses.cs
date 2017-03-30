using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TeacherStarterKit
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update changes in Courses table to database
        /// </summary>
        private void UpdateDatabase()
        {
            try
            {
                this.CoursesTableAdapter.Update(this.TeachersDataSet.Courses);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Courses - update database", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                this.CoursesBindingSource.EndEdit();
                if (this.Validate())
                    UpdateDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Courses", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        /// <summary>
        /// Before closing form, check if any changes have been made and offer
        /// the user the option of saving or discarding them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoursesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.Validate())
                    this.CoursesBindingSource.EndEdit();
                else
                {
                    e.Cancel = true;
                    return;
                }

                // See if any changes were made, but not saved 
                if (this.TeachersDataSet.Courses.GetChanges() != null)
                {
                    var msgText = "You have made changes that have not been saved to the database.";
                    msgText = msgText + Environment.NewLine + "If you have deleted courses, deleting them from the database will delete all assessments and students for the course.";
                    msgText = msgText + Environment.NewLine + "Save the changes ?";

                    var result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "Courses form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }

        }

        /// <summary>
        /// Fill Courses table with data when loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoursesForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.CoursesTableAdapter.Fill(this.TeachersDataSet.Courses);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Courses", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Disable input fields if not positioned on a record
        /// </summary>
        private void CoursesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (CoursesBindingSource.Count == 0)
            {
                Panel1.Enabled = false;
            }
            else
            {
                Panel1.Enabled = true;
                // always set focus to first field that requires
                // validation, to ensure validation gets triggered if try to 
                // move to another record
                CourseCodeTextBox.Focus();
            }

        }

        /// <summary>
        /// Validation routine for Course Code
        /// </summary>
        private void CourseCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CoursesBindingSource.Count > 0 && string.IsNullOrEmpty(CourseCodeTextBox.Text.Trim()))
            {
                MessageBox.Show("Course Code cannot be left empty.", "Course Code validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            if (CoursesBindingSource.Count > 0)
            {
                this.CoursesBindingSource.RemoveCurrent();
            }
        }


    }
}