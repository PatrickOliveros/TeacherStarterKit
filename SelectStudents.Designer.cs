namespace TeacherStarterKit
{
   partial class SelectStudentsForm
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
         this.TeachersDataSet = new TeacherStarterKit.TeachersDataSet();
         this.StudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.StudentsTableAdapter = new TeacherStarterKit.TeachersDataSetTableAdapters.StudentsTableAdapter();
         this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
         this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.PersonalIdentifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.MangeStudentsButton = new System.Windows.Forms.Button();
         this.CancelFormButton = new System.Windows.Forms.Button();
         this.OKButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // TeachersDataSet
         // 
         this.TeachersDataSet.DataSetName = "TeachersDataSet";
         this.TeachersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // StudentsBindingSource
         // 
         this.StudentsBindingSource.DataMember = "Students";
         this.StudentsBindingSource.DataSource = this.TeachersDataSet;
         // 
         // StudentsTableAdapter
         // 
         this.StudentsTableAdapter.ClearBeforeFill = true;
         // 
         // StudentsDataGridView
         // 
         this.StudentsDataGridView.AllowUserToAddRows = false;
         this.StudentsDataGridView.AllowUserToDeleteRows = false;
         this.StudentsDataGridView.AutoGenerateColumns = false;
         this.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.PersonalIdentifier,
            this.Other,
            this.Classification});
         this.StudentsDataGridView.DataSource = this.StudentsBindingSource;
         this.StudentsDataGridView.Location = new System.Drawing.Point(26, 27);
         this.StudentsDataGridView.Name = "StudentsDataGridView";
         this.StudentsDataGridView.ReadOnly = true;
         this.StudentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.StudentsDataGridView.Size = new System.Drawing.Size(752, 328);
         this.StudentsDataGridView.TabIndex = 1;
         this.StudentsDataGridView.Text = "DataGridView1";
         this.StudentsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StudentsDataGridView_CellFormatting);
         // 
         // StudentID
         // 
         this.StudentID.DataPropertyName = "StudentID";
         this.StudentID.HeaderText = "StudentID";
         this.StudentID.Name = "StudentID";
         this.StudentID.ReadOnly = true;
         // 
         // FirstName
         // 
         this.FirstName.DataPropertyName = "FirstName";
         this.FirstName.HeaderText = "FirstName";
         this.FirstName.Name = "FirstName";
         this.FirstName.ReadOnly = true;
         // 
         // LastName
         // 
         this.LastName.DataPropertyName = "LastName";
         this.LastName.HeaderText = "LastName";
         this.LastName.Name = "LastName";
         this.LastName.ReadOnly = true;
         // 
         // BirthDate
         // 
         this.BirthDate.DataPropertyName = "BirthDate";
         this.BirthDate.HeaderText = "BirthDate";
         this.BirthDate.Name = "BirthDate";
         this.BirthDate.ReadOnly = true;
         // 
         // PersonalIdentifier
         // 
         this.PersonalIdentifier.DataPropertyName = "PersonalIdentifier";
         this.PersonalIdentifier.HeaderText = "PersonalIdentifier";
         this.PersonalIdentifier.Name = "PersonalIdentifier";
         this.PersonalIdentifier.ReadOnly = true;
         // 
         // Other
         // 
         this.Other.DataPropertyName = "Other";
         this.Other.HeaderText = "Other";
         this.Other.Name = "Other";
         this.Other.ReadOnly = true;
         // 
         // Classification
         // 
         this.Classification.DataPropertyName = "Classification";
         this.Classification.HeaderText = "Classification";
         this.Classification.Name = "Classification";
         this.Classification.ReadOnly = true;
         // 
         // MangeStudentsButton
         // 
         this.MangeStudentsButton.Location = new System.Drawing.Point(257, 376);
         this.MangeStudentsButton.Name = "MangeStudentsButton";
         this.MangeStudentsButton.Size = new System.Drawing.Size(120, 27);
         this.MangeStudentsButton.TabIndex = 27;
         this.MangeStudentsButton.Text = "&Manage Students...";
         this.MangeStudentsButton.Click += new System.EventHandler(this.MangeStudentsButton_Click);
         // 
         // CancelFormButton
         // 
         this.CancelFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.CancelFormButton.Location = new System.Drawing.Point(141, 376);
         this.CancelFormButton.Name = "CancelFormButton";
         this.CancelFormButton.Size = new System.Drawing.Size(86, 27);
         this.CancelFormButton.TabIndex = 26;
         this.CancelFormButton.Text = "&Cancel";
         // 
         // OKButton
         // 
         this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.OKButton.Location = new System.Drawing.Point(26, 376);
         this.OKButton.Name = "OKButton";
         this.OKButton.Size = new System.Drawing.Size(86, 27);
         this.OKButton.TabIndex = 25;
         this.OKButton.Text = "&OK";
         // 
         // SelectStudentsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(802, 424);
         this.Controls.Add(this.MangeStudentsButton);
         this.Controls.Add(this.CancelFormButton);
         this.Controls.Add(this.OKButton);
         this.Controls.Add(this.StudentsDataGridView);
         this.Name = "SelectStudentsForm";
         this.Text = "SelectStudents";
         this.Load += new System.EventHandler(this.SelectStudentsForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.TeachersDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StudentsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private TeachersDataSet TeachersDataSet;
      internal System.Windows.Forms.BindingSource StudentsBindingSource;
      private TeacherStarterKit.TeachersDataSetTableAdapters.StudentsTableAdapter StudentsTableAdapter;
      internal System.Windows.Forms.DataGridView StudentsDataGridView;
      internal System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
      internal System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
      internal System.Windows.Forms.DataGridViewTextBoxColumn LastName;
      internal System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
      internal System.Windows.Forms.DataGridViewTextBoxColumn PersonalIdentifier;
      internal System.Windows.Forms.DataGridViewTextBoxColumn Other;
      internal System.Windows.Forms.DataGridViewTextBoxColumn Classification;
      internal System.Windows.Forms.Button MangeStudentsButton;
      internal System.Windows.Forms.Button CancelFormButton;
      internal System.Windows.Forms.Button OKButton;

   }
}