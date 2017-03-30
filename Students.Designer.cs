namespace TeacherStarterKit
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            System.Windows.Forms.Label StudentIDLabel;
            System.Windows.Forms.Label FirstNameLabel;
            System.Windows.Forms.Label LastNameLabel;
            System.Windows.Forms.Label BirthDateLabel;
            System.Windows.Forms.Label PersonalIdentifierLabel;
            System.Windows.Forms.Label OtherLabel;
            System.Windows.Forms.Label ClassificationLabel;
            this.TeachersDataSet = new TeacherStarterKit.TeachersDataSet();
            this.StudentsTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.StudentsTableAdapter();
            this.StudentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PersonalIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.OtherTextBox = new System.Windows.Forms.TextBox();
            this.ClassificationTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            StudentIDLabel = new System.Windows.Forms.Label();
            FirstNameLabel = new System.Windows.Forms.Label();
            LastNameLabel = new System.Windows.Forms.Label();
            BirthDateLabel = new System.Windows.Forms.Label();
            PersonalIdentifierLabel = new System.Windows.Forms.Label();
            OtherLabel = new System.Windows.Forms.Label();
            ClassificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingNavigator)).BeginInit();
            this.StudentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeachersDataSet
            // 
            this.TeachersDataSet.DataSetName = "TeachersDataSet";
            this.TeachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentsTableAdapter
            // 
            this.StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsBindingNavigator
            // 
            this.StudentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.StudentsBindingNavigator.BindingSource = this.StudentsBindingSource;
            this.StudentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.StudentsBindingNavigator.DeleteItem = null;
            this.StudentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
            this.StudentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.StudentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.StudentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.StudentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.StudentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.StudentsBindingNavigator.Name = "StudentsBindingNavigator";
            this.StudentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.StudentsBindingNavigator.Size = new System.Drawing.Size(448, 25);
            this.StudentsBindingNavigator.TabIndex = 4;
            this.StudentsBindingNavigator.Text = "BindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveItem.Text = "Save Data";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // StudentsBindingSource
            // 
            this.StudentsBindingSource.DataMember = "Students";
            this.StudentsBindingSource.DataSource = this.TeachersDataSet;
            this.StudentsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.StudentsBindingSource_ListChanged);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.StudentIDTextBox);
            this.Panel1.Controls.Add(this.FirstNameTextBox);
            this.Panel1.Controls.Add(this.LastNameTextBox);
            this.Panel1.Controls.Add(this.BirthDateDateTimePicker);
            this.Panel1.Controls.Add(this.PersonalIdentifierTextBox);
            this.Panel1.Controls.Add(this.OtherTextBox);
            this.Panel1.Controls.Add(this.ClassificationTextBox);
            this.Panel1.Location = new System.Drawing.Point(134, 46);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(280, 195);
            this.Panel1.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(217, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "(Required)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(217, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "(Required)";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentsBindingSource, "StudentID", true));
            this.StudentIDTextBox.Location = new System.Drawing.Point(14, 6);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.ReadOnly = true;
            this.StudentIDTextBox.Size = new System.Drawing.Size(70, 20);
            this.StudentIDTextBox.TabIndex = 0;
            this.StudentIDTextBox.TabStop = false;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentsBindingSource, "FirstName", true));
            this.FirstNameTextBox.Location = new System.Drawing.Point(14, 33);
            this.FirstNameTextBox.MaxLength = 25;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentsBindingSource, "LastName", true));
            this.LastNameTextBox.Location = new System.Drawing.Point(14, 60);
            this.LastNameTextBox.MaxLength = 50;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // BirthDateDateTimePicker
            // 
            this.BirthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.StudentsBindingSource, "BirthDate", true));
            this.BirthDateDateTimePicker.Location = new System.Drawing.Point(14, 87);
            this.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            this.BirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDateDateTimePicker.TabIndex = 3;
            // 
            // PersonalIdentifierTextBox
            // 
            this.PersonalIdentifierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentsBindingSource, "PersonalIdentifier", true));
            this.PersonalIdentifierTextBox.Location = new System.Drawing.Point(14, 114);
            this.PersonalIdentifierTextBox.MaxLength = 50;
            this.PersonalIdentifierTextBox.Name = "PersonalIdentifierTextBox";
            this.PersonalIdentifierTextBox.Size = new System.Drawing.Size(200, 20);
            this.PersonalIdentifierTextBox.TabIndex = 4;
            // 
            // OtherTextBox
            // 
            this.OtherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentsBindingSource, "Other", true));
            this.OtherTextBox.Location = new System.Drawing.Point(14, 141);
            this.OtherTextBox.MaxLength = 50;
            this.OtherTextBox.Name = "OtherTextBox";
            this.OtherTextBox.Size = new System.Drawing.Size(200, 20);
            this.OtherTextBox.TabIndex = 5;
            // 
            // ClassificationTextBox
            // 
            this.ClassificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StudentsBindingSource, "Classification", true));
            this.ClassificationTextBox.Location = new System.Drawing.Point(14, 168);
            this.ClassificationTextBox.MaxLength = 25;
            this.ClassificationTextBox.Name = "ClassificationTextBox";
            this.ClassificationTextBox.Size = new System.Drawing.Size(200, 20);
            this.ClassificationTextBox.TabIndex = 6;
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.AutoSize = true;
            StudentIDLabel.Location = new System.Drawing.Point(34, 55);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new System.Drawing.Size(61, 13);
            StudentIDLabel.TabIndex = 13;
            StudentIDLabel.Text = "Student ID:";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new System.Drawing.Point(34, 82);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            FirstNameLabel.TabIndex = 14;
            FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new System.Drawing.Point(34, 109);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new System.Drawing.Size(61, 13);
            LastNameLabel.TabIndex = 15;
            LastNameLabel.Text = "Last Name:";
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new System.Drawing.Point(34, 137);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new System.Drawing.Size(57, 13);
            BirthDateLabel.TabIndex = 16;
            BirthDateLabel.Text = "Birth Date:";
            // 
            // PersonalIdentifierLabel
            // 
            PersonalIdentifierLabel.AutoSize = true;
            PersonalIdentifierLabel.Location = new System.Drawing.Point(34, 163);
            PersonalIdentifierLabel.Name = "PersonalIdentifierLabel";
            PersonalIdentifierLabel.Size = new System.Drawing.Size(94, 13);
            PersonalIdentifierLabel.TabIndex = 17;
            PersonalIdentifierLabel.Text = "Personal Identifier:";
            // 
            // OtherLabel
            // 
            OtherLabel.AutoSize = true;
            OtherLabel.Location = new System.Drawing.Point(34, 190);
            OtherLabel.Name = "OtherLabel";
            OtherLabel.Size = new System.Drawing.Size(36, 13);
            OtherLabel.TabIndex = 18;
            OtherLabel.Text = "Other:";
            // 
            // ClassificationLabel
            // 
            ClassificationLabel.AutoSize = true;
            ClassificationLabel.Location = new System.Drawing.Point(34, 217);
            ClassificationLabel.Name = "ClassificationLabel";
            ClassificationLabel.Size = new System.Drawing.Size(71, 13);
            ClassificationLabel.TabIndex = 10;
            ClassificationLabel.Text = "Classification:";
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(171, 247);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(86, 27);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 295);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(StudentIDLabel);
            this.Controls.Add(FirstNameLabel);
            this.Controls.Add(LastNameLabel);
            this.Controls.Add(BirthDateLabel);
            this.Controls.Add(PersonalIdentifierLabel);
            this.Controls.Add(OtherLabel);
            this.Controls.Add(ClassificationLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StudentsBindingNavigator);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingNavigator)).EndInit();
            this.StudentsBindingNavigator.ResumeLayout(false);
            this.StudentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeachersDataSet TeachersDataSet;
        private TeacherStarterKit.TeachersDataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
        internal System.Windows.Forms.BindingNavigator StudentsBindingNavigator;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        internal System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        internal System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        internal System.Windows.Forms.BindingSource StudentsBindingSource;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox StudentIDTextBox;
        internal System.Windows.Forms.TextBox FirstNameTextBox;
        internal System.Windows.Forms.TextBox LastNameTextBox;
        internal System.Windows.Forms.DateTimePicker BirthDateDateTimePicker;
        internal System.Windows.Forms.TextBox PersonalIdentifierTextBox;
        internal System.Windows.Forms.TextBox OtherTextBox;
        internal System.Windows.Forms.TextBox ClassificationTextBox;
        internal System.Windows.Forms.Button CloseButton;
    }
}