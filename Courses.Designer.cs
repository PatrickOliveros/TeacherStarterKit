namespace TeacherStarterKit
{
   partial class CoursesForm
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
         System.Windows.Forms.Label CourseIDLabel;
         System.Windows.Forms.Label CourseCodeLabel;
         System.Windows.Forms.Label CourseSectionLabel;
         System.Windows.Forms.Label CourseTitleLabel;
         System.Windows.Forms.Label CourseDescrLabel;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursesForm));
         this.TeachersDataSet = new TeacherStarterKit.TeachersDataSet();
         this.CoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.CoursesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.CoursesTableAdapter();
         this.CourseStudentsTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.CourseStudentsTableAdapter();
         this.CoursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.Panel1 = new System.Windows.Forms.Panel();
         this.Label2 = new System.Windows.Forms.Label();
         this.CourseIDTextBox = new System.Windows.Forms.TextBox();
         this.CourseCodeTextBox = new System.Windows.Forms.TextBox();
         this.CourseSectionTextBox = new System.Windows.Forms.TextBox();
         this.CourseTitleTextBox = new System.Windows.Forms.TextBox();
         this.CourseDescrTextBox = new System.Windows.Forms.TextBox();
         this.CloseButton = new System.Windows.Forms.Button();
         CourseIDLabel = new System.Windows.Forms.Label();
         CourseCodeLabel = new System.Windows.Forms.Label();
         CourseSectionLabel = new System.Windows.Forms.Label();
         CourseTitleLabel = new System.Windows.Forms.Label();
         CourseDescrLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.CoursesBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.CoursesBindingNavigator)).BeginInit();
         this.CoursesBindingNavigator.SuspendLayout();
         this.Panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // CourseIDLabel
         // 
         CourseIDLabel.AutoSize = true;
         CourseIDLabel.Location = new System.Drawing.Point(12, 40);
         CourseIDLabel.Name = "CourseIDLabel";
         CourseIDLabel.Size = new System.Drawing.Size(57, 13);
         CourseIDLabel.TabIndex = 8;
         CourseIDLabel.Text = "Course ID:";
         // 
         // CourseCodeLabel
         // 
         CourseCodeLabel.AutoSize = true;
         CourseCodeLabel.Location = new System.Drawing.Point(12, 67);
         CourseCodeLabel.Name = "CourseCodeLabel";
         CourseCodeLabel.Size = new System.Drawing.Size(71, 13);
         CourseCodeLabel.TabIndex = 9;
         CourseCodeLabel.Text = "Course Code:";
         // 
         // CourseSectionLabel
         // 
         CourseSectionLabel.AutoSize = true;
         CourseSectionLabel.Location = new System.Drawing.Point(12, 94);
         CourseSectionLabel.Name = "CourseSectionLabel";
         CourseSectionLabel.Size = new System.Drawing.Size(82, 13);
         CourseSectionLabel.TabIndex = 11;
         CourseSectionLabel.Text = "Course Section:";
         // 
         // CourseTitleLabel
         // 
         CourseTitleLabel.AutoSize = true;
         CourseTitleLabel.Location = new System.Drawing.Point(12, 121);
         CourseTitleLabel.Name = "CourseTitleLabel";
         CourseTitleLabel.Size = new System.Drawing.Size(66, 13);
         CourseTitleLabel.TabIndex = 12;
         CourseTitleLabel.Text = "Course Title:";
         // 
         // CourseDescrLabel
         // 
         CourseDescrLabel.AutoSize = true;
         CourseDescrLabel.Location = new System.Drawing.Point(12, 148);
         CourseDescrLabel.Name = "CourseDescrLabel";
         CourseDescrLabel.Size = new System.Drawing.Size(99, 13);
         CourseDescrLabel.TabIndex = 13;
         CourseDescrLabel.Text = "Course Description:";
         // 
         // TeachersDataSet
         // 
         this.TeachersDataSet.DataSetName = "TeachersDataSet";
         this.TeachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // CoursesBindingSource
         // 
         this.CoursesBindingSource.DataMember = "Courses";
         this.CoursesBindingSource.DataSource = this.TeachersDataSet;
         this.CoursesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.CoursesBindingSource_ListChanged);
         // 
         // CoursesTableAdapter
         // 
         this.CoursesTableAdapter.ClearBeforeFill = true;
         // 
         // CourseStudentsTableAdapter
         // 
         this.CourseStudentsTableAdapter.ClearBeforeFill = true;
         // 
         // CoursesBindingNavigator
         // 
         this.CoursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.CoursesBindingNavigator.BindingSource = this.CoursesBindingSource;
         this.CoursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.CoursesBindingNavigator.DeleteItem = null;
         this.CoursesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
         this.CoursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
         this.CoursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.CoursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.CoursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.CoursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.CoursesBindingNavigator.Name = "CoursesBindingNavigator";
         this.CoursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.CoursesBindingNavigator.Size = new System.Drawing.Size(432, 25);
         this.CoursesBindingNavigator.TabIndex = 6;
         this.CoursesBindingNavigator.Text = "BindingNavigator";
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
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
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
         // Panel1
         // 
         this.Panel1.Controls.Add(this.Label2);
         this.Panel1.Controls.Add(this.CourseIDTextBox);
         this.Panel1.Controls.Add(this.CourseCodeTextBox);
         this.Panel1.Controls.Add(this.CourseSectionTextBox);
         this.Panel1.Controls.Add(this.CourseTitleTextBox);
         this.Panel1.Controls.Add(this.CourseDescrTextBox);
         this.Panel1.Location = new System.Drawing.Point(112, 30);
         this.Panel1.Name = "Panel1";
         this.Panel1.Size = new System.Drawing.Size(309, 203);
         this.Panel1.TabIndex = 7;
         // 
         // Label2
         // 
         this.Label2.AutoSize = true;
         this.Label2.Location = new System.Drawing.Point(249, 35);
         this.Label2.Name = "Label2";
         this.Label2.Size = new System.Drawing.Size(56, 13);
         this.Label2.TabIndex = 9;
         this.Label2.Text = "(Required)";
         // 
         // CourseIDTextBox
         // 
         this.CourseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CoursesBindingSource, "CourseID", true));
         this.CourseIDTextBox.Location = new System.Drawing.Point(17, 6);
         this.CourseIDTextBox.Name = "CourseIDTextBox";
         this.CourseIDTextBox.ReadOnly = true;
         this.CourseIDTextBox.Size = new System.Drawing.Size(71, 20);
         this.CourseIDTextBox.TabIndex = 0;
         this.CourseIDTextBox.TabStop = false;
         // 
         // CourseCodeTextBox
         // 
         this.CourseCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CoursesBindingSource, "CourseCode", true));
         this.CourseCodeTextBox.Location = new System.Drawing.Point(17, 32);
         this.CourseCodeTextBox.MaxLength = 20;
         this.CourseCodeTextBox.Name = "CourseCodeTextBox";
         this.CourseCodeTextBox.Size = new System.Drawing.Size(226, 20);
         this.CourseCodeTextBox.TabIndex = 0;
         this.CourseCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CourseCodeTextBox_Validating);
         // 
         // CourseSectionTextBox
         // 
         this.CourseSectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CoursesBindingSource, "CourseSection", true));
         this.CourseSectionTextBox.Location = new System.Drawing.Point(17, 61);
         this.CourseSectionTextBox.MaxLength = 20;
         this.CourseSectionTextBox.Name = "CourseSectionTextBox";
         this.CourseSectionTextBox.Size = new System.Drawing.Size(226, 20);
         this.CourseSectionTextBox.TabIndex = 1;
         // 
         // CourseTitleTextBox
         // 
         this.CourseTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CoursesBindingSource, "CourseTitle", true));
         this.CourseTitleTextBox.Location = new System.Drawing.Point(17, 84);
         this.CourseTitleTextBox.MaxLength = 50;
         this.CourseTitleTextBox.Name = "CourseTitleTextBox";
         this.CourseTitleTextBox.Size = new System.Drawing.Size(226, 20);
         this.CourseTitleTextBox.TabIndex = 2;
         // 
         // CourseDescrTextBox
         // 
         this.CourseDescrTextBox.AcceptsReturn = true;
         this.CourseDescrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CoursesBindingSource, "CourseDescr", true));
         this.CourseDescrTextBox.Location = new System.Drawing.Point(17, 115);
         this.CourseDescrTextBox.MaxLength = 500;
         this.CourseDescrTextBox.Multiline = true;
         this.CourseDescrTextBox.Name = "CourseDescrTextBox";
         this.CourseDescrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.CourseDescrTextBox.Size = new System.Drawing.Size(226, 83);
         this.CourseDescrTextBox.TabIndex = 3;
         // 
         // CloseButton
         // 
         this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.CloseButton.Location = new System.Drawing.Point(174, 248);
         this.CloseButton.Name = "CloseButton";
         this.CloseButton.Size = new System.Drawing.Size(86, 27);
         this.CloseButton.TabIndex = 10;
         this.CloseButton.Text = "Close";
         // 
         // CoursesForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(432, 292);
         this.Controls.Add(this.Panel1);
         this.Controls.Add(this.CloseButton);
         this.Controls.Add(CourseIDLabel);
         this.Controls.Add(CourseCodeLabel);
         this.Controls.Add(CourseSectionLabel);
         this.Controls.Add(CourseTitleLabel);
         this.Controls.Add(CourseDescrLabel);
         this.Controls.Add(this.CoursesBindingNavigator);
         this.Name = "CoursesForm";
         this.Text = "Courses";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoursesForm_FormClosing);
         this.Load += new System.EventHandler(this.CoursesForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.CoursesBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.CoursesBindingNavigator)).EndInit();
         this.CoursesBindingNavigator.ResumeLayout(false);
         this.CoursesBindingNavigator.PerformLayout();
         this.Panel1.ResumeLayout(false);
         this.Panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private TeachersDataSet TeachersDataSet;
      internal System.Windows.Forms.BindingSource CoursesBindingSource;
      private TeacherStarterKit.TeachersDataSetTableAdapters.CoursesTableAdapter CoursesTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.CourseStudentsTableAdapter CourseStudentsTableAdapter;
      internal System.Windows.Forms.BindingNavigator CoursesBindingNavigator;
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
      internal System.Windows.Forms.Panel Panel1;
      internal System.Windows.Forms.Label Label2;
      internal System.Windows.Forms.TextBox CourseIDTextBox;
      internal System.Windows.Forms.TextBox CourseCodeTextBox;
      internal System.Windows.Forms.TextBox CourseSectionTextBox;
      internal System.Windows.Forms.TextBox CourseTitleTextBox;
      internal System.Windows.Forms.TextBox CourseDescrTextBox;
      internal System.Windows.Forms.Button CloseButton;
   }
}