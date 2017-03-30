namespace TeacherStarterKit
{
   partial class Main
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
            System.Windows.Forms.Label CourseCodeLabel;
            System.Windows.Forms.Label MaxGradeLabel;
            System.Windows.Forms.Label AssessNameLabel;
            System.Windows.Forms.Label AssessTypeLabel;
            System.Windows.Forms.Label AssessDescrLabel;
            System.Windows.Forms.Label AssessDateLabel;
            System.Windows.Forms.Label MinGradeLabel;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label Label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeachersDataSet = new TeacherStarterKit.TeachersDataSet();
            this.AssessmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AssessmentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManageStudentsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ManageCoursesButton = new System.Windows.Forms.Button();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.StudentsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FillByLastNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.LastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.LastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FillByLastNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectStudentsButton = new System.Windows.Forms.Button();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.AssessmentsTab = new System.Windows.Forms.TabPage();
            this.AssessmentsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.AssessTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AssessDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AssessNameTextBox = new System.Windows.Forms.TextBox();
            this.AssessDescrTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Label6 = new System.Windows.Forms.Label();
            this.MinGradeTextBox = new System.Windows.Forms.TextBox();
            this.MaxGradeTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.AssessmentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.EnterGradesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MinMaxLabel = new System.Windows.Forms.Label();
            this.AssessComboBox = new System.Windows.Forms.ComboBox();
            this.SaveGradeButton = new System.Windows.Forms.Button();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.ViewGradesTab = new System.Windows.Forms.TabPage();
            this.ViewGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.assessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewReportButton = new System.Windows.Forms.Button();
            this.OrderByGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderByStudentRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderByAssessRadioButton = new System.Windows.Forms.RadioButton();
            this.CourseStudentsTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.CourseStudentsTableAdapter();
            this.AssessmentsTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.AssessmentsTableAdapter();
            this.AssessmentTypesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.AssessmentTypesTableAdapter();
            this.StudentsTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.StudentsTableAdapter();
            this.CoursesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.CoursesTableAdapter();
            this.ViewGradesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.ViewGradesTableAdapter();
            this.GradesTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.GradesTableAdapter();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            CourseCodeLabel = new System.Windows.Forms.Label();
            MaxGradeLabel = new System.Windows.Forms.Label();
            AssessNameLabel = new System.Windows.Forms.Label();
            AssessTypeLabel = new System.Windows.Forms.Label();
            AssessDescrLabel = new System.Windows.Forms.Label();
            AssessDateLabel = new System.Windows.Forms.Label();
            MinGradeLabel = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesBindingSource)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.StudentsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FillByLastNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.AssessmentsTab.SuspendLayout();
            this.AssessmentsPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentsBindingNavigator)).BeginInit();
            this.AssessmentsBindingNavigator.SuspendLayout();
            this.EnterGradesTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.ViewGradesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGradesDataGridView)).BeginInit();
            this.ReportsTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.OrderByGroupBox.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseCodeLabel
            // 
            CourseCodeLabel.AutoSize = true;
            CourseCodeLabel.Location = new System.Drawing.Point(4, 0);
            CourseCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CourseCodeLabel.Name = "CourseCodeLabel";
            CourseCodeLabel.Size = new System.Drawing.Size(57, 15);
            CourseCodeLabel.TabIndex = 5;
            CourseCodeLabel.Text = "Course:";
            // 
            // MaxGradeLabel
            // 
            MaxGradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            MaxGradeLabel.AutoSize = true;
            MaxGradeLabel.Location = new System.Drawing.Point(237, 13);
            MaxGradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MaxGradeLabel.Name = "MaxGradeLabel";
            MaxGradeLabel.Size = new System.Drawing.Size(114, 17);
            MaxGradeLabel.TabIndex = 12;
            MaxGradeLabel.Text = "Maximum Grade:";
            // 
            // AssessNameLabel
            // 
            AssessNameLabel.AutoSize = true;
            AssessNameLabel.Location = new System.Drawing.Point(4, 76);
            AssessNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AssessNameLabel.Name = "AssessNameLabel";
            AssessNameLabel.Size = new System.Drawing.Size(129, 17);
            AssessNameLabel.TabIndex = 4;
            AssessNameLabel.Text = "Assessment Name:";
            // 
            // AssessTypeLabel
            // 
            AssessTypeLabel.AutoSize = true;
            AssessTypeLabel.Location = new System.Drawing.Point(4, 0);
            AssessTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AssessTypeLabel.Name = "AssessTypeLabel";
            AssessTypeLabel.Size = new System.Drawing.Size(124, 17);
            AssessTypeLabel.TabIndex = 0;
            AssessTypeLabel.Text = "Assessment Type:";
            // 
            // AssessDescrLabel
            // 
            AssessDescrLabel.AutoSize = true;
            AssessDescrLabel.Location = new System.Drawing.Point(4, 123);
            AssessDescrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AssessDescrLabel.Name = "AssessDescrLabel";
            AssessDescrLabel.Size = new System.Drawing.Size(163, 17);
            AssessDescrLabel.TabIndex = 7;
            AssessDescrLabel.Text = "Assessment Description:";
            // 
            // AssessDateLabel
            // 
            AssessDateLabel.AutoSize = true;
            AssessDateLabel.Location = new System.Drawing.Point(274, 0);
            AssessDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AssessDateLabel.Name = "AssessDateLabel";
            AssessDateLabel.Size = new System.Drawing.Size(122, 17);
            AssessDateLabel.TabIndex = 2;
            AssessDateLabel.Text = "Assessment Date:";
            // 
            // MinGradeLabel
            // 
            MinGradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            MinGradeLabel.AutoSize = true;
            MinGradeLabel.Location = new System.Drawing.Point(4, 13);
            MinGradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MinGradeLabel.Name = "MinGradeLabel";
            MinGradeLabel.Size = new System.Drawing.Size(111, 17);
            MinGradeLabel.TabIndex = 9;
            MinGradeLabel.Text = "Minimum Grade:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(4, 244);
            Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(52, 17);
            Label3.TabIndex = 4;
            Label3.Text = "&Grade:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(4, 121);
            Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(61, 17);
            Label2.TabIndex = 2;
            Label2.Text = "&Student:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(4, 0);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(88, 17);
            Label1.TabIndex = 0;
            Label1.Text = "&Assessment:";
            // 
            // StudentsBindingSource
            // 
            this.StudentsBindingSource.DataMember = "Students";
            this.StudentsBindingSource.DataSource = this.TeachersDataSet;
            // 
            // TeachersDataSet
            // 
            this.TeachersDataSet.DataSetName = "TeachersDataSet";
            this.TeachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AssessmentsBindingSource
            // 
            this.AssessmentsBindingSource.DataMember = "Assessments";
            this.AssessmentsBindingSource.DataSource = this.TeachersDataSet;
            this.AssessmentsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.AssessmentsBindingSource_ListChanged);
            // 
            // AssessmentTypesBindingSource
            // 
            this.AssessmentTypesBindingSource.DataMember = "AssessmentTypes";
            this.AssessmentTypesBindingSource.DataSource = this.TeachersDataSet;
            // 
            // ViewGradesBindingSource
            // 
            this.ViewGradesBindingSource.DataMember = "ViewGrades";
            this.ViewGradesBindingSource.DataSource = this.TeachersDataSet;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "CHECKMRK.ICO");
            this.ImageList1.Images.SetKeyName(1, "GRAPH15.ICO");
            this.ImageList1.Images.SetKeyName(2, "MISC28.ICO");
            this.ImageList1.Images.SetKeyName(3, "NOTE14.ICO");
            this.ImageList1.Images.SetKeyName(4, "eventlog.ico");
            this.ImageList1.Images.SetKeyName(5, "ShowRulelines.bmp");
            // 
            // GradesBindingSource
            // 
            this.GradesBindingSource.DataMember = "Grades";
            this.GradesBindingSource.DataSource = this.TeachersDataSet;
            // 
            // CoursesBindingSource
            // 
            this.CoursesBindingSource.DataMember = "Courses";
            this.CoursesBindingSource.DataSource = this.TeachersDataSet;
            // 
            // ManageStudentsButton
            // 
            this.ManageStudentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageStudentsButton.Location = new System.Drawing.Point(361, 19);
            this.ManageStudentsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageStudentsButton.Name = "ManageStudentsButton";
            this.ManageStudentsButton.Size = new System.Drawing.Size(183, 30);
            this.ManageStudentsButton.TabIndex = 8;
            this.ManageStudentsButton.Text = "Manage &Students...";
            this.ManageStudentsButton.Click += new System.EventHandler(this.ManageStudentsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutButton.Location = new System.Drawing.Point(867, 19);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(80, 28);
            this.AboutButton.TabIndex = 9;
            this.AboutButton.Text = "About ...";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ManageCoursesButton
            // 
            this.ManageCoursesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageCoursesButton.Location = new System.Drawing.Point(170, 19);
            this.ManageCoursesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageCoursesButton.Name = "ManageCoursesButton";
            this.ManageCoursesButton.Size = new System.Drawing.Size(183, 30);
            this.ManageCoursesButton.TabIndex = 7;
            this.ManageCoursesButton.Text = "Manage &Courses...";
            this.ManageCoursesButton.Click += new System.EventHandler(this.ManageCoursesButton_Click);
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.DisplayMember = "Text";
            this.CourseCodeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Location = new System.Drawing.Point(4, 19);
            this.CourseCodeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(158, 24);
            this.CourseCodeComboBox.Sorted = true;
            this.CourseCodeComboBox.TabIndex = 6;
            this.CourseCodeComboBox.ValueMember = "Value";
            this.CourseCodeComboBox.SelectedValueChanged += new System.EventHandler(this.CourseCodeComboBox_SelectedValueChanged);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabControl.Controls.Add(this.StudentsTab);
            this.MainTabControl.Controls.Add(this.AssessmentsTab);
            this.MainTabControl.Controls.Add(this.EnterGradesTab);
            this.MainTabControl.Controls.Add(this.ViewGradesTab);
            this.MainTabControl.Controls.Add(this.ReportsTab);
            this.MainTabControl.HotTrack = true;
            this.MainTabControl.ImageList = this.ImageList1;
            this.MainTabControl.Location = new System.Drawing.Point(16, 75);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(925, 668);
            this.MainTabControl.TabIndex = 9;
            this.MainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainTabControl_Selected);
            this.MainTabControl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainTabControl_Deselecting);
            this.MainTabControl.Validating += new System.ComponentModel.CancelEventHandler(this.MainTabControl_Validating);
            // 
            // StudentsTab
            // 
            this.StudentsTab.AutoScroll = true;
            this.StudentsTab.Controls.Add(this.tableLayoutPanel1);
            this.StudentsTab.ImageIndex = 2;
            this.StudentsTab.Location = new System.Drawing.Point(4, 28);
            this.StudentsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentsTab.Name = "StudentsTab";
            this.StudentsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentsTab.Size = new System.Drawing.Size(917, 636);
            this.StudentsTab.TabIndex = 0;
            this.StudentsTab.Text = "Assign Students";
            this.StudentsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FillByLastNameToolStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StudentsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.46395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.53605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 628);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FillByLastNameToolStrip
            // 
            this.FillByLastNameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FillByLastNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LastNameToolStripLabel,
            this.LastNameToolStripTextBox,
            this.FillByLastNameToolStripButton,
            this.ClearToolStripButton});
            this.FillByLastNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FillByLastNameToolStrip.Name = "FillByLastNameToolStrip";
            this.FillByLastNameToolStrip.Size = new System.Drawing.Size(909, 27);
            this.FillByLastNameToolStrip.TabIndex = 0;
            this.FillByLastNameToolStrip.Text = "ToolStrip1";
            // 
            // LastNameToolStripLabel
            // 
            this.LastNameToolStripLabel.Name = "LastNameToolStripLabel";
            this.LastNameToolStripLabel.Size = new System.Drawing.Size(137, 24);
            this.LastNameToolStripLabel.Text = "Student Last Name:";
            // 
            // LastNameToolStripTextBox
            // 
            this.LastNameToolStripTextBox.Name = "LastNameToolStripTextBox";
            this.LastNameToolStripTextBox.Size = new System.Drawing.Size(132, 27);
            // 
            // FillByLastNameToolStripButton
            // 
            this.FillByLastNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FillByLastNameToolStripButton.Name = "FillByLastNameToolStripButton";
            this.FillByLastNameToolStripButton.Size = new System.Drawing.Size(41, 24);
            this.FillByLastNameToolStripButton.Text = "Find";
            this.FillByLastNameToolStripButton.Click += new System.EventHandler(this.FillByLastNameToolStripButton_Click);
            // 
            // ClearToolStripButton
            // 
            this.ClearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearToolStripButton.Name = "ClearToolStripButton";
            this.ClearToolStripButton.Size = new System.Drawing.Size(47, 24);
            this.ClearToolStripButton.Text = "Clear";
            this.ClearToolStripButton.Click += new System.EventHandler(this.ClearToolStripButton_Click);
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AllowUserToAddRows = false;
            this.StudentsDataGridView.AllowUserToDeleteRows = false;
            this.StudentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsDataGridView.AutoGenerateColumns = false;
            this.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.personalIdentifierDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn});
            this.StudentsDataGridView.DataSource = this.StudentsBindingSource;
            this.StudentsDataGridView.Location = new System.Drawing.Point(4, 45);
            this.StudentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentsDataGridView.MultiSelect = false;
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.ReadOnly = true;
            this.StudentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsDataGridView.Size = new System.Drawing.Size(901, 446);
            this.StudentsDataGridView.StandardTab = true;
            this.StudentsDataGridView.TabIndex = 1;
            this.StudentsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StudentsDataGridView_CellFormatting);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalIdentifierDataGridViewTextBoxColumn
            // 
            this.personalIdentifierDataGridViewTextBoxColumn.DataPropertyName = "PersonalIdentifier";
            this.personalIdentifierDataGridViewTextBoxColumn.HeaderText = "PersonalIdentifier";
            this.personalIdentifierDataGridViewTextBoxColumn.Name = "personalIdentifierDataGridViewTextBoxColumn";
            this.personalIdentifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            this.classificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SelectStudentsButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemoveStudentButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 499);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // SelectStudentsButton
            // 
            this.SelectStudentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectStudentsButton.Location = new System.Drawing.Point(4, 7);
            this.SelectStudentsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectStudentsButton.Name = "SelectStudentsButton";
            this.SelectStudentsButton.Size = new System.Drawing.Size(179, 33);
            this.SelectStudentsButton.TabIndex = 2;
            this.SelectStudentsButton.Text = "&Select Students...";
            this.SelectStudentsButton.Click += new System.EventHandler(this.SelectStudentsButton_Click);
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveStudentButton.Location = new System.Drawing.Point(194, 7);
            this.RemoveStudentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(179, 33);
            this.RemoveStudentButton.TabIndex = 3;
            this.RemoveStudentButton.Text = "&Remove Student";
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // AssessmentsTab
            // 
            this.AssessmentsTab.Controls.Add(this.AssessmentsPanel);
            this.AssessmentsTab.Controls.Add(this.AssessmentsBindingNavigator);
            this.AssessmentsTab.ImageIndex = 4;
            this.AssessmentsTab.Location = new System.Drawing.Point(4, 28);
            this.AssessmentsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessmentsTab.Name = "AssessmentsTab";
            this.AssessmentsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessmentsTab.Size = new System.Drawing.Size(917, 636);
            this.AssessmentsTab.TabIndex = 1;
            this.AssessmentsTab.Text = "Assessments";
            this.AssessmentsTab.UseVisualStyleBackColor = true;
            // 
            // AssessmentsPanel
            // 
            this.AssessmentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessmentsPanel.Controls.Add(this.tableLayoutPanel5);
            this.AssessmentsPanel.Location = new System.Drawing.Point(31, 38);
            this.AssessmentsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessmentsPanel.MinimumSize = new System.Drawing.Size(0, 336);
            this.AssessmentsPanel.Name = "AssessmentsPanel";
            this.AssessmentsPanel.Size = new System.Drawing.Size(863, 586);
            this.AssessmentsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(AssessNameLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.AssessNameTextBox, 0, 2);
            this.tableLayoutPanel5.Controls.Add(AssessDescrLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.AssessDescrTextBox, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.Label4, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(117, 43);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(644, 487);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(AssessTypeLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.AssessTypeComboBox, 0, 1);
            this.tableLayoutPanel6.Controls.Add(AssessDateLabel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.AssessDateTimePicker, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.09091F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.90909F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(540, 68);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // AssessTypeComboBox
            // 
            this.AssessTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.AssessmentsBindingSource, "AssessTypeID", true));
            this.AssessTypeComboBox.DataSource = this.AssessmentTypesBindingSource;
            this.AssessTypeComboBox.DisplayMember = "AssessTypeDescr";
            this.AssessTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssessTypeComboBox.FormattingEnabled = true;
            this.AssessTypeComboBox.Location = new System.Drawing.Point(4, 23);
            this.AssessTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessTypeComboBox.Name = "AssessTypeComboBox";
            this.AssessTypeComboBox.Size = new System.Drawing.Size(262, 24);
            this.AssessTypeComboBox.TabIndex = 1;
            this.AssessTypeComboBox.ValueMember = "AssessTypeID";
            this.AssessTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AssessTypeComboBox_SelectedIndexChanged);
            // 
            // AssessDateTimePicker
            // 
            this.AssessDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.AssessmentsBindingSource, "AssessDate", true));
            this.AssessDateTimePicker.Location = new System.Drawing.Point(274, 23);
            this.AssessDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessDateTimePicker.Name = "AssessDateTimePicker";
            this.AssessDateTimePicker.Size = new System.Drawing.Size(262, 22);
            this.AssessDateTimePicker.TabIndex = 3;
            // 
            // AssessNameTextBox
            // 
            this.AssessNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AssessmentsBindingSource, "AssessName", true));
            this.AssessNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssessNameTextBox.Location = new System.Drawing.Point(4, 97);
            this.AssessNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessNameTextBox.MaxLength = 30;
            this.AssessNameTextBox.Name = "AssessNameTextBox";
            this.AssessNameTextBox.Size = new System.Drawing.Size(540, 22);
            this.AssessNameTextBox.TabIndex = 5;
            // 
            // AssessDescrTextBox
            // 
            this.AssessDescrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AssessmentsBindingSource, "AssessDescr", true));
            this.AssessDescrTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssessDescrTextBox.Location = new System.Drawing.Point(4, 144);
            this.AssessDescrTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessDescrTextBox.MaxLength = 200;
            this.AssessDescrTextBox.Multiline = true;
            this.AssessDescrTextBox.Name = "AssessDescrTextBox";
            this.AssessDescrTextBox.Size = new System.Drawing.Size(540, 241);
            this.AssessDescrTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel7.Controls.Add(MinGradeLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Label6, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.MinGradeTextBox, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.MaxGradeTextBox, 2, 1);
            this.tableLayoutPanel7.Controls.Add(MaxGradeLabel, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.Label5, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 393);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(636, 81);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label6.Location = new System.Drawing.Point(378, 36);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(254, 17);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "(Required)";
            // 
            // MinGradeTextBox
            // 
            this.MinGradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AssessmentsBindingSource, "MinGrade", true));
            this.MinGradeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinGradeTextBox.Location = new System.Drawing.Point(4, 34);
            this.MinGradeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinGradeTextBox.MaxLength = 5;
            this.MinGradeTextBox.Name = "MinGradeTextBox";
            this.MinGradeTextBox.Size = new System.Drawing.Size(132, 22);
            this.MinGradeTextBox.TabIndex = 10;
            this.MinGradeTextBox.Text = "0";
            this.MinGradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinGradeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MinMaxGradeTextBoxes_Validating);
            // 
            // MaxGradeTextBox
            // 
            this.MaxGradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AssessmentsBindingSource, "MaxGrade", true));
            this.MaxGradeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxGradeTextBox.Location = new System.Drawing.Point(237, 34);
            this.MaxGradeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxGradeTextBox.MaxLength = 5;
            this.MaxGradeTextBox.Name = "MaxGradeTextBox";
            this.MaxGradeTextBox.Size = new System.Drawing.Size(133, 22);
            this.MaxGradeTextBox.TabIndex = 13;
            this.MaxGradeTextBox.Text = "100";
            this.MaxGradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxGradeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MinMaxGradeTextBoxes_Validating);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label5.Location = new System.Drawing.Point(144, 36);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 17);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "(Required)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(552, 99);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 17);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "(Required)";
            // 
            // AssessmentsBindingNavigator
            // 
            this.AssessmentsBindingNavigator.AddNewItem = null;
            this.AssessmentsBindingNavigator.BindingSource = this.AssessmentsBindingSource;
            this.AssessmentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.AssessmentsBindingNavigator.DeleteItem = null;
            this.AssessmentsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AssessmentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.AssessmentsBindingNavigator.Location = new System.Drawing.Point(4, 4);
            this.AssessmentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.AssessmentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.AssessmentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.AssessmentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.AssessmentsBindingNavigator.Name = "AssessmentsBindingNavigator";
            this.AssessmentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.AssessmentsBindingNavigator.Size = new System.Drawing.Size(909, 27);
            this.AssessmentsBindingNavigator.TabIndex = 0;
            this.AssessmentsBindingNavigator.Text = "BindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorSaveItem.Text = "Save Data";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // EnterGradesTab
            // 
            this.EnterGradesTab.Controls.Add(this.tableLayoutPanel4);
            this.EnterGradesTab.ImageIndex = 0;
            this.EnterGradesTab.Location = new System.Drawing.Point(4, 28);
            this.EnterGradesTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterGradesTab.Name = "EnterGradesTab";
            this.EnterGradesTab.Size = new System.Drawing.Size(917, 636);
            this.EnterGradesTab.TabIndex = 2;
            this.EnterGradesTab.Text = "Enter Grades";
            this.EnterGradesTab.UseVisualStyleBackColor = true;
            this.EnterGradesTab.Validating += new System.ComponentModel.CancelEventHandler(this.EnterGradesTab_Validating);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.00961F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.99039F));
            this.tableLayoutPanel4.Controls.Add(Label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.MinMaxLabel, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.AssessComboBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.SaveGradeButton, 0, 7);
            this.tableLayoutPanel4.Controls.Add(Label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.GradeTextBox, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.StudentComboBox, 0, 3);
            this.tableLayoutPanel4.Controls.Add(Label3, 0, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(205, 74);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.081081F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58108F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.72973F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.067567F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.459459F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.783784F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.72973F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(555, 508);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // MinMaxLabel
            // 
            this.MinMaxLabel.AutoSize = true;
            this.MinMaxLabel.Location = new System.Drawing.Point(176, 269);
            this.MinMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinMaxLabel.Name = "MinMaxLabel";
            this.MinMaxLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MinMaxLabel.Size = new System.Drawing.Size(300, 22);
            this.MinMaxLabel.TabIndex = 6;
            this.MinMaxLabel.Text = "No Minimum and/or Maximum grades specified";
            // 
            // AssessComboBox
            // 
            this.AssessComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssessComboBox.FormattingEnabled = true;
            this.AssessComboBox.Location = new System.Drawing.Point(4, 34);
            this.AssessComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssessComboBox.Name = "AssessComboBox";
            this.AssessComboBox.Size = new System.Drawing.Size(164, 24);
            this.AssessComboBox.TabIndex = 1;
            this.AssessComboBox.DropDown += new System.EventHandler(this.AssessStudentsComboBoxes_DropDown);
            this.AssessComboBox.SelectedIndexChanged += new System.EventHandler(this.AssessComboBox_SelectedIndexChanged);
            // 
            // SaveGradeButton
            // 
            this.SaveGradeButton.Location = new System.Drawing.Point(4, 362);
            this.SaveGradeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveGradeButton.Name = "SaveGradeButton";
            this.SaveGradeButton.Size = new System.Drawing.Size(115, 33);
            this.SaveGradeButton.TabIndex = 7;
            this.SaveGradeButton.Text = "Sa&ve";
            this.SaveGradeButton.Click += new System.EventHandler(this.SaveGradeButton_Click);
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradeTextBox.Location = new System.Drawing.Point(4, 273);
            this.GradeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GradeTextBox.MaxLength = 5;
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(164, 22);
            this.GradeTextBox.TabIndex = 5;
            this.GradeTextBox.TextChanged += new System.EventHandler(this.GradeTextBox_TextChanged);
            this.GradeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GradeTextBox_Validating);
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.DisplayMember = "text";
            this.StudentComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(4, 148);
            this.StudentComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(164, 24);
            this.StudentComboBox.Sorted = true;
            this.StudentComboBox.TabIndex = 3;
            this.StudentComboBox.ValueMember = "value";
            this.StudentComboBox.DropDown += new System.EventHandler(this.AssessStudentsComboBoxes_DropDown);
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // ViewGradesTab
            // 
            this.ViewGradesTab.AutoScroll = true;
            this.ViewGradesTab.Controls.Add(this.ViewGradesDataGridView);
            this.ViewGradesTab.ImageIndex = 1;
            this.ViewGradesTab.Location = new System.Drawing.Point(4, 28);
            this.ViewGradesTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewGradesTab.Name = "ViewGradesTab";
            this.ViewGradesTab.Size = new System.Drawing.Size(917, 636);
            this.ViewGradesTab.TabIndex = 3;
            this.ViewGradesTab.Text = "View Grades";
            this.ViewGradesTab.UseVisualStyleBackColor = true;
            // 
            // ViewGradesDataGridView
            // 
            this.ViewGradesDataGridView.AllowUserToAddRows = false;
            this.ViewGradesDataGridView.AllowUserToDeleteRows = false;
            this.ViewGradesDataGridView.AutoGenerateColumns = false;
            this.ViewGradesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewGradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assessNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.studentIDDataGridViewTextBoxColumn1,
            this.gradeDataGridViewTextBoxColumn,
            this.maxGradeDataGridViewTextBoxColumn,
            this.minGradeDataGridViewTextBoxColumn,
            this.assessIDDataGridViewTextBoxColumn});
            this.ViewGradesDataGridView.DataSource = this.ViewGradesBindingSource;
            this.ViewGradesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewGradesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ViewGradesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewGradesDataGridView.MultiSelect = false;
            this.ViewGradesDataGridView.Name = "ViewGradesDataGridView";
            this.ViewGradesDataGridView.ReadOnly = true;
            this.ViewGradesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewGradesDataGridView.Size = new System.Drawing.Size(917, 636);
            this.ViewGradesDataGridView.StandardTab = true;
            this.ViewGradesDataGridView.TabIndex = 0;
            // 
            // assessNameDataGridViewTextBoxColumn
            // 
            this.assessNameDataGridViewTextBoxColumn.DataPropertyName = "AssessName";
            this.assessNameDataGridViewTextBoxColumn.HeaderText = "AssessName";
            this.assessNameDataGridViewTextBoxColumn.Name = "assessNameDataGridViewTextBoxColumn";
            this.assessNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxGradeDataGridViewTextBoxColumn
            // 
            this.maxGradeDataGridViewTextBoxColumn.DataPropertyName = "MaxGrade";
            this.maxGradeDataGridViewTextBoxColumn.HeaderText = "MaxGrade";
            this.maxGradeDataGridViewTextBoxColumn.Name = "maxGradeDataGridViewTextBoxColumn";
            this.maxGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minGradeDataGridViewTextBoxColumn
            // 
            this.minGradeDataGridViewTextBoxColumn.DataPropertyName = "MinGrade";
            this.minGradeDataGridViewTextBoxColumn.HeaderText = "MinGrade";
            this.minGradeDataGridViewTextBoxColumn.Name = "minGradeDataGridViewTextBoxColumn";
            this.minGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assessIDDataGridViewTextBoxColumn
            // 
            this.assessIDDataGridViewTextBoxColumn.DataPropertyName = "AssessID";
            this.assessIDDataGridViewTextBoxColumn.HeaderText = "AssessID";
            this.assessIDDataGridViewTextBoxColumn.Name = "assessIDDataGridViewTextBoxColumn";
            this.assessIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportsTab
            // 
            this.ReportsTab.Controls.Add(this.tableLayoutPanel3);
            this.ReportsTab.ImageIndex = 5;
            this.ReportsTab.Location = new System.Drawing.Point(4, 28);
            this.ReportsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportsTab.Name = "ReportsTab";
            this.ReportsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportsTab.Size = new System.Drawing.Size(917, 636);
            this.ReportsTab.TabIndex = 4;
            this.ReportsTab.Text = "Reports";
            this.ReportsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ViewReportButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.OrderByGroupBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(357, 142);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(184, 200);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ViewReportButton
            // 
            this.ViewReportButton.Location = new System.Drawing.Point(4, 158);
            this.ViewReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewReportButton.Name = "ViewReportButton";
            this.ViewReportButton.Size = new System.Drawing.Size(169, 33);
            this.ViewReportButton.TabIndex = 1;
            this.ViewReportButton.Text = "View &Report ...";
            this.ViewReportButton.Click += new System.EventHandler(this.ViewReportButton_Click);
            // 
            // OrderByGroupBox
            // 
            this.OrderByGroupBox.Controls.Add(this.OrderByStudentRadioButton);
            this.OrderByGroupBox.Controls.Add(this.OrderByAssessRadioButton);
            this.OrderByGroupBox.Location = new System.Drawing.Point(4, 4);
            this.OrderByGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderByGroupBox.Name = "OrderByGroupBox";
            this.OrderByGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderByGroupBox.Size = new System.Drawing.Size(169, 146);
            this.OrderByGroupBox.TabIndex = 0;
            this.OrderByGroupBox.TabStop = false;
            this.OrderByGroupBox.Text = "Order By";
            // 
            // OrderByStudentRadioButton
            // 
            this.OrderByStudentRadioButton.AutoSize = true;
            this.OrderByStudentRadioButton.Location = new System.Drawing.Point(25, 86);
            this.OrderByStudentRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderByStudentRadioButton.Name = "OrderByStudentRadioButton";
            this.OrderByStudentRadioButton.Size = new System.Drawing.Size(78, 21);
            this.OrderByStudentRadioButton.TabIndex = 0;
            this.OrderByStudentRadioButton.Text = "Student";
            // 
            // OrderByAssessRadioButton
            // 
            this.OrderByAssessRadioButton.AutoSize = true;
            this.OrderByAssessRadioButton.Checked = true;
            this.OrderByAssessRadioButton.Location = new System.Drawing.Point(25, 47);
            this.OrderByAssessRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderByAssessRadioButton.Name = "OrderByAssessRadioButton";
            this.OrderByAssessRadioButton.Size = new System.Drawing.Size(105, 21);
            this.OrderByAssessRadioButton.TabIndex = 1;
            this.OrderByAssessRadioButton.TabStop = true;
            this.OrderByAssessRadioButton.Text = "Assessment";
            // 
            // CourseStudentsTableAdapter
            // 
            this.CourseStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // AssessmentsTableAdapter
            // 
            this.AssessmentsTableAdapter.ClearBeforeFill = true;
            // 
            // AssessmentTypesTableAdapter
            // 
            this.AssessmentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsTableAdapter
            // 
            this.StudentsTableAdapter.ClearBeforeFill = true;
            // 
            // CoursesTableAdapter
            // 
            this.CoursesTableAdapter.ClearBeforeFill = true;
            // 
            // ViewGradesTableAdapter
            // 
            this.ViewGradesTableAdapter.ClearBeforeFill = true;
            // 
            // GradesTableAdapter
            // 
            this.GradesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 403F));
            this.tableLayoutPanel8.Controls.Add(this.AboutButton, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.ManageStudentsButton, 2, 1);
            this.tableLayoutPanel8.Controls.Add(CourseCodeLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.CourseCodeComboBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.ManageCoursesButton, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(951, 53);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 1;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Controls.Add(this.Panel1, 0, 1);
            this.topTableLayoutPanel.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 2;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(959, 73);
            this.topTableLayoutPanel.TabIndex = 11;
            this.topTableLayoutPanel.Enter += new System.EventHandler(this.topTableLayoutPanel_Enter);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Location = new System.Drawing.Point(4, 65);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(951, 3);
            this.Panel1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 746);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(847, 580);
            this.Name = "Main";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesBindingSource)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.StudentsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.FillByLastNameToolStrip.ResumeLayout(false);
            this.FillByLastNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.AssessmentsTab.ResumeLayout(false);
            this.AssessmentsTab.PerformLayout();
            this.AssessmentsPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentsBindingNavigator)).EndInit();
            this.AssessmentsBindingNavigator.ResumeLayout(false);
            this.AssessmentsBindingNavigator.PerformLayout();
            this.EnterGradesTab.ResumeLayout(false);
            this.EnterGradesTab.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ViewGradesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGradesDataGridView)).EndInit();
            this.ReportsTab.ResumeLayout(false);
            this.ReportsTab.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.OrderByGroupBox.ResumeLayout(false);
            this.OrderByGroupBox.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.topTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.BindingSource StudentsBindingSource;
      internal System.Windows.Forms.BindingSource AssessmentsBindingSource;
      internal System.Windows.Forms.BindingSource AssessmentTypesBindingSource;
      internal System.Windows.Forms.BindingSource ViewGradesBindingSource;
      internal System.Windows.Forms.ImageList ImageList1;
      internal System.Windows.Forms.BindingSource GradesBindingSource;
      internal System.Windows.Forms.BindingSource CoursesBindingSource;
      internal System.Windows.Forms.Button ManageStudentsButton;
      internal System.Windows.Forms.Button AboutButton;
      internal System.Windows.Forms.Button ManageCoursesButton;
      internal System.Windows.Forms.ComboBox CourseCodeComboBox;
      internal System.Windows.Forms.TabControl MainTabControl;
      internal System.Windows.Forms.TabPage StudentsTab;
      internal System.Windows.Forms.Button RemoveStudentButton;
      internal System.Windows.Forms.ToolStrip FillByLastNameToolStrip;
      internal System.Windows.Forms.ToolStripLabel LastNameToolStripLabel;
      internal System.Windows.Forms.ToolStripTextBox LastNameToolStripTextBox;
      internal System.Windows.Forms.ToolStripButton FillByLastNameToolStripButton;
      internal System.Windows.Forms.ToolStripButton ClearToolStripButton;
      internal System.Windows.Forms.DataGridView StudentsDataGridView;
      internal System.Windows.Forms.Button SelectStudentsButton;
      internal System.Windows.Forms.TabPage AssessmentsTab;
      internal System.Windows.Forms.Panel AssessmentsPanel;
      internal System.Windows.Forms.Label Label6;
      internal System.Windows.Forms.Label Label5;
      internal System.Windows.Forms.Label Label4;
      internal System.Windows.Forms.TextBox MaxGradeTextBox;
      internal System.Windows.Forms.TextBox AssessNameTextBox;
      internal System.Windows.Forms.ComboBox AssessTypeComboBox;
      internal System.Windows.Forms.TextBox AssessDescrTextBox;
      internal System.Windows.Forms.DateTimePicker AssessDateTimePicker;
      internal System.Windows.Forms.TextBox MinGradeTextBox;
      internal System.Windows.Forms.BindingNavigator AssessmentsBindingNavigator;
      internal System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      internal System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      internal System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      internal System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
      internal System.Windows.Forms.TabPage EnterGradesTab;
      internal System.Windows.Forms.Label MinMaxLabel;
      internal System.Windows.Forms.Button SaveGradeButton;
      internal System.Windows.Forms.TextBox GradeTextBox;
      internal System.Windows.Forms.ComboBox StudentComboBox;
      internal System.Windows.Forms.ComboBox AssessComboBox;
      internal System.Windows.Forms.TabPage ViewGradesTab;
      internal System.Windows.Forms.DataGridView ViewGradesDataGridView;
      internal System.Windows.Forms.TabPage ReportsTab;
      internal System.Windows.Forms.Button ViewReportButton;
      internal System.Windows.Forms.GroupBox OrderByGroupBox;
      internal System.Windows.Forms.RadioButton OrderByStudentRadioButton;
      internal System.Windows.Forms.RadioButton OrderByAssessRadioButton;
      private TeachersDataSet TeachersDataSet;
      private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn personalIdentifierDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn assessNameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn maxGradeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn minGradeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn assessIDDataGridViewTextBoxColumn;
      private TeacherStarterKit.TeachersDataSetTableAdapters.CourseStudentsTableAdapter CourseStudentsTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.AssessmentsTableAdapter AssessmentsTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.AssessmentTypesTableAdapter AssessmentTypesTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.CoursesTableAdapter CoursesTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.ViewGradesTableAdapter ViewGradesTableAdapter;
      private TeacherStarterKit.TeachersDataSetTableAdapters.GradesTableAdapter GradesTableAdapter;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
      private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
      internal System.Windows.Forms.Panel Panel1;
   }
}

